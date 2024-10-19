using LISReprintReceipt.Report.ReportViewer;
using LISReprintReceipt.UserControl;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LISReprintReceipt.DataSet1;
using LISReprintReceipt.Report;
using LISReprintReceipt.Report.ReportEntities;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Reporting.WinForms;

namespace LISReprintReceipt
{
    public partial class OthersWindow : Form
    {

        DbConnection dbConnection = new DbConnection();

        private static ArrayList ListOtherID = new ArrayList();
        private static ArrayList ListLoanID = new ArrayList();
        private static ArrayList ListDate = new ArrayList();
        private static ArrayList ListAmount = new ArrayList();
        private static ArrayList ListDescription = new ArrayList();
        private static ArrayList ListBalance = new ArrayList();
        private static ArrayList ListStatus = new ArrayList();
        private static ArrayList ListType = new ArrayList();

        //public int clientID;

        public string clientID { get { return this.headerControl2.txtIDValue; } }

        public OthersWindow()
        {
            InitializeComponent();
        }

        



        private void OthersWindow_Load(object sender, EventArgs e)
        {
            // +1 to current date to show records for current date
            dtTo.Value = dtTo.Value.AddDays(1);
        }

        private void GetData()
        {
            try
            {
                int cID = int.Parse(clientID);

                dbConnection.OpenConnection();
                //string query = "select * from other where LoanID = 696";
                //clientID = int.Parse(this.headerControl2.txtIDValue);
                DateTime dtFrom_ = new DateTime();



                dtFrom.CustomFormat = "yyyy-MM-dd";
                dtFrom_ = dtFrom.Value;

                dtTo.Format = DateTimePickerFormat.Custom;
                dtTo.CustomFormat = "yyyy-MM-dd";


                //DateTime dtTo_ = dtTo.Value;
                string query = $"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID} AND (Date BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}')";
                //string query = $"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE Date BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}'";

                //MySqlDataReader row;  
                MySqlDataReader row;
                row = dbConnection.ExecuteReader(query);
                if (row.HasRows)
                {
                    ListOtherID.Clear();
                    ListLoanID.Clear();
                    ListDate.Clear();
                    ListAmount.Clear();
                    ListDescription.Clear();
                    ListBalance.Clear();
                    ListStatus.Clear();
                    ListType.Clear();
                    while (row.Read())
                    {
                        ListOtherID.Add(row["OtherId"].ToString());
                        ListLoanID.Add(row["LoanID"].ToString());
                        ListDate.Add(row["Date"].ToString());
                        ListAmount.Add(row["Amount"].ToString());
                        ListDescription.Add(row["Description"].ToString());
                        ListBalance.Add(row["Balance"].ToString());
                        ListStatus.Add(row["Status"].ToString());
                        ListType.Add(row["OtherType"].ToString());
                        
                    }
                }
                else
                {
                    ListOtherID.Clear();
                    ListLoanID.Clear();
                    ListDate.Clear();
                    ListAmount.Clear();
                    ListDescription.Clear();
                    ListBalance.Clear();
                    ListStatus.Clear();
                    ListType.Clear();
                    // MessageBox.Show("Data not found");
                }

                dbConnection.CloseConnection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void updateDatagrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            //dataGridView1.Columns.Clear();
            
            for (int i = 0; i < ListOtherID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = ListOtherID[i];
                newRow.Cells[1].Value = ListLoanID[i];
                newRow.Cells[2].Value = ListDate[i];
                newRow.Cells[3].Value = ListAmount[i];
                newRow.Cells[4].Value = ListDescription[i];
                newRow.Cells[5].Value = ListBalance[i];
                newRow.Cells[6].Value = ListStatus[i];

                int type = Int32.Parse((string)ListType[i]);

                switch (type)
                {
                    case 0:
                        ListType[i] = "Charge";
                        break;
                    case 1:
                        ListType[i] = "Rice";
                        break;
                    case 2:
                        ListType[i] = "Goods";
                        break;
                    default:
                        ListType[i] = "NA";
                        break;
                }

                newRow.Cells[7].Value = ListType[i];
                
                dataGridView1.Rows.Add(newRow);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) // make sure user select at least 1 row 
            {
                //string jobId = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                //string userId = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string userId = dataGridView1.CurrentRow.Cells[3].Value + string.Empty;


                //txtJobId.Text = jobId;
                txtAmount.Text = userId;
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void header1_Load(object sender, EventArgs e)
        {

        }

        private void headerControl2_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            OtherSS othRC = new OtherSS();

            //othRC.Amount = txtAmount.Text;
            //othRC.ClientFullName = this.ClientHeader.txtFullName.Text;
            othRC.ClientFullName = this.headerControl2.txtClientFullName;
            othRC.Amount = dataGridView1.CurrentRow.Cells[3].Value + string.Empty;
            othRC.ClientID = this.headerControl2.txtIDValue;
            othRC.Datee = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value + string.Empty);
            othRC.Type = dataGridView1.CurrentRow.Cells[7].Value + string.Empty;
            othRC.Remarks = dataGridView1.CurrentRow.Cells[4].Value + string.Empty;

            OthersReportViewer frm = new OthersReportViewer();
            frm.otherss = othRC;
            frm.Show();
        }

        private void btnShowRecord_Click(object sender, EventArgs e)
        {
            if (this.headerControl2.txtID.Text != "")
                {
                dataGridView1.Rows.Clear();

                dataGridView1.DataSource = null;
                GetData();
                if (ListOtherID.Count > 0)
                {

                    updateDatagrid();
                    btnPrint.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"No Record Found for Client ID: {this.headerControl2.txtID.Text}");
                    btnPrint.Enabled = false;
                }
            }
            else
            {
                this.headerControl2.txtID.Focus();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OthersReportViewer frm 

            //OthersDS dsOthers = GetData();
            //ReportDataSource datasource = new ReportDataSource("Others", dsOthers.Tables[0]);

            //OtherTransactionsReportViewer otherTransactionsReportViewer = new OtherTransactionsReportViewer(reportViewer);
            //var rViewer = otherTransactionsReportViewer.Controls["reportViewer1"];

            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(datasource);
            //this.reportViewer1.RefreshReport();

            //OtherTransactionsReportViewer frm = new OtherTransactionsReportViewer();
            //frm.Show();

            //OthersDS dsOthers = GetData2();
            //ReportDataSource datasource = new ReportDataSource("Others", dsOthers.Tables[0]);
            //OtherTransactionsReportViewer otherTransactionsReportViewer = new OtherTransactionsReportViewer();

            //otherTransactionsReportViewer.reportViewer1.LocalReport.DataSources.Clear();

            //otherTransactionsReportViewer.reportViewer1.LocalReport.DataSources.Add(datasource);
            //otherTransactionsReportViewer.reportViewer1.RefreshReport();

            

            //otherTransactionsReportViewer.Show();


        }

        //private OthersDS GetData2()
        //{

        //    string constr = @"server=localhost;user=root;password=root;database=lendingdb";
        //    //using (SqlConnection con = new SqlConnection(constr))
        //    using (MySqlConnection con = new MySqlConnection(constr))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {clientID}"))
        //        //using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID} AND (Date BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}')"))
        //        //using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM other WHERE LoanID = 696"))
        //        {
        //            //using (SqlDataAdapter sda = new SqlDataAdapter())
        //            using (MySqlDataAdapter sda = new MySqlDataAdapter())
        //            {
        //                cmd.Connection = con;
        //                sda.SelectCommand = cmd;
        //                //using (Customers dsCustomers = new Customers())
        //                using (OthersDS dsOthers = new OthersDS())
        //                {
        //                    //sda.Fill(dsCustomers, "DataTable1");
        //                    sda.Fill(dsOthers, "DataTable1");
        //                    //return dsCustomers;
        //                    return dsOthers;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
