using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LISReprintReceipt.DataSet;
using MySql.Data.MySqlClient;
using LISReprintReceipt.WindowForms;
using LISReprintReceipt.Report.ReportViewer;
using Microsoft.Reporting.WinForms;

namespace LISReprintReceipt.WindowForms
{
    public partial class OthersTransactionsWindow : Form
    {
        public string clientID { get { return this.headerControl1.txtIDValue; } }

        DbConnection dbConnection = new DbConnection();

        public OthersTransactionsWindow()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            OthersDS dsOthers = GetData();
            if (dsOthers != null)
            {
                ReportDataSource datasource = new ReportDataSource("Others", dsOthers.Tables[0]);
                OtherTransactionsReportViewer otherTransactionsReportViewer = new OtherTransactionsReportViewer();

                otherTransactionsReportViewer.reportViewer1.LocalReport.DataSources.Clear();

                otherTransactionsReportViewer.reportViewer1.LocalReport.DataSources.Add(datasource);
                otherTransactionsReportViewer.reportViewer1.RefreshReport();



                otherTransactionsReportViewer.Show();
            }
            else
            {
                headerControl1.txtID.Focus();
            }
            
            
        }

        private OthersDS GetData()
        {
            if (clientID != "")
            {
                string constr = @"server=localhost;user=root;password=root;database=lendingdb";
                //using (SqlConnection con = new SqlConnection(constr))
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    dtFrom.CustomFormat = "yyyy-MM-dd";
                    dtTo.CustomFormat = "yyyy-MM-dd";

                    //using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {clientID}"))
                    using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {clientID} AND (Date BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}') ORDER BY other.Date ASC"))
                    //using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM other WHERE LoanID = 696"))
                    {
                        //using (SqlDataAdapter sda = new SqlDataAdapter())
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            //using (Customers dsCustomers = new Customers())
                            using (OthersDS dsOthers = new OthersDS())
                            {

                                //sda.Fill(dsCustomers, "DataTable1");

                                DataTable othersDT = new DataTable();
                                sda.Fill(othersDT);
                                if (othersDT.Rows.Count > 0)
                                {
                                    sda.Fill(dsOthers, "OthersDT");

                                    //return dsCustomers;
                                    return dsOthers;
                                }
                                else
                                {
                                    MessageBox.Show("There are no records for this client");
                                    return null;
                                }

                                
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Client ID");
                return null;
            }
        }

        private void headerControl1_Load(object sender, EventArgs e)
        {

        }

        private void OthersTransactionsWindow_Load(object sender, EventArgs e)
        {
            dtTo.Value = dtTo.Value.AddDays(1);
        }

        private void btnShowRecords_Click(object sender, EventArgs e)
        {
            if (this.headerControl1.txtID.Text != "")
            {
                dgOthers.Rows.Clear();

                dgOthers.DataSource = null;
                GetAllOthersData();
                //if (ListLoanID.Count > 0)
                //{

                //    updateLoansDatagrid();
                //    btnShowLoans.Enabled = true;
                //    btnFilterResults.Enabled = true;
                //    btnShowPayments.Enabled = true;
                //    btnPrintLoans.Enabled = true;
                //}
                //else
                //{
                //    MessageBox.Show($"No Record Found for Client ID: {this.headerControl1.txtID.Text}");
                //    btnShowLoans.Enabled = false;
                //    btnFilterResults.Enabled = false;
                //    btnShowPayments.Enabled = false;
                //    btnPrintLoans.Enabled = false;
                //}
            }
            else
            {
                this.headerControl1.txtID.Focus();
            }
        }

        private void GetAllOthersData()
        {
            try
            {
                int cID = int.Parse(clientID);

                dbConnection.OpenConnection();

                string query;

                query = $"SELECT * FROM loans INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID}";

                //LoadListLoanAddRow(query);


                dbConnection.CloseConnection();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }
    }
}
