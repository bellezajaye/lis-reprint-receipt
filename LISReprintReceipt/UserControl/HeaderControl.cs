using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Reflection;
using MySqlX.XDevAPI.Relational;
using MySql.Data.MySqlClient;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace LISReprintReceipt.UserControl
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class HeaderControl : System.Windows.Forms.UserControl
    {

        public string txtIDValue
        {
            get
                {
                return txtID.Text;
            }
        }

        public string txtClientFullName
        {
            get
            {
                return txtLastName.Text + ", " + txtFirstName.Text;
            }
        }

        public string txtLoanStatus
        {
            get
            {
                return txtLoanType.Text;
            }
        }
       



        DbConnection clientsDbConnection = new DbConnection();
        DbConnection loansDbConnection = new DbConnection();

        private static ArrayList ListLoanLoanID = new ArrayList();
        private static ArrayList ListLoanClientID = new ArrayList();
        private static ArrayList ListClientClientID = new ArrayList();
        private static ArrayList ListClientFirstname = new ArrayList();
      

        public HeaderControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            clientsDbConnection.GetDbConnection();
            loansDbConnection.GetDbConnection();


            //string sql = $"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = '{txtID.Text}'";
            string sqlClients = $"SELECT * FROM clients WHERE ClientID = @cID";
            string sqlLoans = $"SELECT * FROM loans INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = @cID and loans.status < 4 Order By loans.StartDate Desc";
            //string sql = $"SELECT * FROM clients WHERE ClientID = '{txtID.Text}'";
            //string sql = "SELECT * FROM clients WHERE ClientID = @cID";
            MySqlCommand cmdClients = new MySqlCommand(sqlClients, clientsDbConnection.GetDbConnection());
            //MySqlCommand cmd = new MySqlCommand(sqlLoans, loansDbConnection.GetDbConnection());
            cmdClients.Parameters.AddWithValue("@cID", txtID.Text);
            //cmd.Parameters.AddWithValue("@cID", txtID.Text);
            clientsDbConnection.OpenConnection();
            //var mdr = cmd.ExecuteReader();
            var mdrClients = cmdClients.ExecuteReader();

            try
            {
                if (mdrClients.Read())
                {
                    //MessageBox.Show("Client Found");
                    txtFirstName.Text = mdrClients.GetString("Firstname");
                    txtLastName.Text = mdrClients.GetString("Lastname");
                    clientsDbConnection.CloseConnection();

                    
                    MySqlCommand cmdLoans = new MySqlCommand(sqlLoans, loansDbConnection.GetDbConnection());
                    cmdLoans.Parameters.AddWithValue("@cID", txtID.Text);
                    loansDbConnection.OpenConnection();
                    var mdr = cmdLoans.ExecuteReader();

                    if (mdr.Read())
                    {
                        //MessageBox.Show("Loan Found");

                        int status = Int32.Parse(mdr.GetString("Status"));

                        switch (status)
                        {
                            case 0:
                                txtStatus.Text = "Active";
                                break;
                            case 1:
                                txtStatus.Text = "Inactive";
                                break;
                            default:
                                txtStatus.Text = "Others";
                                break;
                        }



                        int loanType = Int32.Parse(mdr.GetString("LoanType"));
                        switch (loanType)
                        {
                            case 0:
                                txtLoanType.Text = "New";
                                break;
                            case 1:
                                txtLoanType.Text = "Pending";
                                break;
                            case 2:
                                txtLoanType.Text = "Approved";
                                break;
                            case 3:
                                txtLoanType.Text = "Partial";
                                break;
                            case 4:
                                txtLoanType.Text = "Settled";
                                break;
                            default:
                                txtLoanType.Text = "";
                                break;
                        }
                    }

                    
                }
                //if (mdr.Read())
                //{
                //    txtFirstName.Text = mdr.GetString("Firstname");
                //    txtLastName.Text = mdr.GetString("Lastname");
                //    int status = Int32.Parse(mdr.GetString("Status"));

                //    switch (status) 
                //    {
                //        case 0:
                //            txtStatus.Text = "Active";
                //            break;
                //        case 1:
                //            txtStatus.Text = "Inactive";
                //            break;
                //        default:
                //            txtStatus.Text = "Others";
                //            break;
                //    }



                //    int loanType = Int32.Parse(mdr.GetString("LoanType"));
                //    switch (loanType)
                //    {
                //        case 0:
                //            txtLoanType.Text = "New";
                //            break;
                //        case 1:
                //            txtLoanType.Text = "Pending";
                //            break;
                //        case 2:
                //            txtLoanType.Text = "Approved";
                //            break;
                //        case 3:
                //            txtLoanType.Text = "Partial";
                //            break;
                //        case 4:
                //            txtLoanType.Text = "Settled";
                //            break;
                //        default:
                //            txtLoanType.Text = "";
                //            break;
                //    }
                //}
                else
                {
                    MessageBox.Show("ClientID Not Found or does not have an Active Loan");
                    txtID.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtID.Focus();
                }
            }
            

            //SqlConnection Conn = new SqlConnection(Connection_String);
            //SqlCommand Comm1 = new SqlCommand(sql, Conn);
            //MySqlCommand command = new MySqlCommand(sql, dbConnection.GetDbConnection());
            //dbConnection.OpenConnection();
            //MySqlDataReader dataReader = command.ExecuteReader();
            
            //MySqlCommand cmd = new MySqlCommand(sql, dbConnection.GetDbConnection());

            //MySqlCommand cmd = new MySqlCommand(sql, dbConnection.GetDbConnection());
            //object result = cmd.ExecuteScalar();


            //MySqlDataReader reader;
            //reader = dbConnection.ExecuteReader(sql);

            //          SELECT*
            //FROM table1
            //INNER JOIN table2
            //ON table1.id = table2.id
            //INNER JOIN table3
            //ON table2.id = table3.id;

           
            catch (MySqlException ex )
            {
                MessageBox.Show(ex.ToString());
            }

            clientsDbConnection.CloseConnection();
            loansDbConnection.CloseConnection();

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
