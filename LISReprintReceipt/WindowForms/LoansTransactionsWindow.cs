using LISReprintReceipt.DataSet;
using LISReprintReceipt.Report.ReportViewer;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace LISReprintReceipt.WindowForms
{
    public partial class LoansTransactionsWindow : Form
    {

        public string clientID { get { return this.headerControl1.txtIDValue; } }

        public LoansTransactionsWindow()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            LoansTransactionsDS loansTransactionsDS = GetData();
            if (loansTransactionsDS != null)
            {
                ReportDataSource datasource = new ReportDataSource("Loans", loansTransactionsDS.Tables[0]);

                

                LoansTransactionsReportViewer loansTransactionsReportViewer = new LoansTransactionsReportViewer();
                loansTransactionsReportViewer.reportViewer1.LocalReport.DataSources.Clear();

                loansTransactionsReportViewer.reportViewer1.LocalReport.DataSources.Add(datasource);
                loansTransactionsReportViewer.reportViewer1.RefreshReport();



                loansTransactionsReportViewer.Show();

            }
            else
            {
                headerControl1.txtID.Focus();
            }
        }

        private LoansTransactionsDS GetData()
        {
            if (clientID != "")
            {
                string constr = @"server=localhost;user=root;password=root;database=lendingdb";
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    dtFrom.CustomFormat = "yyyy-MM-dd";
                    dtTo.CustomFormat = "yyyy-MM-dd";

                    //using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {clientID} AND (Date BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}') ORDER BY other.Date ASC"))
                    using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM loans INNER JOIN clients on loans.ClientID = clients.ClientID WHERE clients.ClientID = {clientID}"))
                    //using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM loans INNER JOIN clients on loans.ClientID = clients.ClientID WHERE clients.ClientID = 1111"))
                    //using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM loans where loanID = 743"))
                    //using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM other WHERE LoanID = 696"))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (LoansTransactionsDS dsLoansTransactions = new LoansTransactionsDS())
                            {
                                DataTable loansTransactionsDT = new DataTable();
                                sda.Fill(loansTransactionsDT);
                                if (loansTransactionsDT.Rows.Count > 0)
                                {
                                    sda.Fill(dsLoansTransactions, "LoansTransactionsDT");

                                    //return dsCustomers;
                                    return dsLoansTransactions;
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
    }
}
