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
using LISReprintReceipt.Report.ReportViewer;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Collections;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace LISReprintReceipt.WindowForms
{
    public partial class CashAdvancedPaymentTransactionsWindow : Form
    {
        DbConnection dbConnection = new DbConnection();

        //private static ArrayList ListOtherID = new ArrayList();
        //private static ArrayList ListLoanID = new ArrayList();
        //private static ArrayList ListDate = new ArrayList();
        //private static ArrayList ListAmount = new ArrayList();
        //private static ArrayList ListDescription = new ArrayList();
        //private static ArrayList ListBalance = new ArrayList();
        //private static ArrayList ListStatus = new ArrayList();
        //private static ArrayList ListType = new ArrayList();

        // Loans
        private static ArrayList ListLoanID = new ArrayList();
        private static ArrayList ListClientID = new ArrayList();
        private static ArrayList ListLoanType = new ArrayList();
        private static ArrayList ListModeOfPayment = new ArrayList();
        private static ArrayList ListAmount = new ArrayList();
        private static ArrayList ListTerms = new ArrayList();
        private static ArrayList ListInterestRate = new ArrayList();
        private static ArrayList ListInterestAmount = new ArrayList();
        private static ArrayList ListPeriodicPayment = new ArrayList();
        private static ArrayList ListStartDate = new ArrayList();
        private static ArrayList ListEndDate = new ArrayList();
        private static ArrayList ListStatus = new ArrayList();
        private static ArrayList ListBalance = new ArrayList();
        private static ArrayList ListCapitalAmount = new ArrayList();


        // Cash Advances
        private static ArrayList CAListCashAdvanceID = new ArrayList();
        private static ArrayList CAListLoanID = new ArrayList();
        private static ArrayList CAListAmount = new ArrayList();
        private static ArrayList CAListTerms = new ArrayList();
        private static ArrayList CAListInterestRate = new ArrayList();
        private static ArrayList CAListInteretAmount = new ArrayList();
        private static ArrayList CAListTotalAmount = new ArrayList();
        private static ArrayList CAListBalance = new ArrayList();
        private static ArrayList CAListDateReceived = new ArrayList();
        private static ArrayList CAListStatus = new ArrayList();
        private static ArrayList CAListNote = new ArrayList();


        public string clientID { get { return this.headerControl1.txtIDValue; } }

        public string loanID;

        public CashAdvancedPaymentTransactionsWindow()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //OthersDS dsOthers = GetData();
            CashAdvancedPaymentsDS cashAdvancedPaymentsDS = GetData();
            if (cashAdvancedPaymentsDS != null)
            {
                //ReportDataSource datasource = new ReportDataSource("Others", dsOthers.Tables[0]);
                //OtherTransactionsReportViewer otherTransactionsReportViewer = new OtherTransactionsReportViewer();

                //otherTransactionsReportViewer.reportViewer1.LocalReport.DataSources.Clear();

                //otherTransactionsReportViewer.reportViewer1.LocalReport.DataSources.Add(datasource);
                //otherTransactionsReportViewer.reportViewer1.RefreshReport();



                //otherTransactionsReportViewer.Show();

                ReportDataSource datasource = new ReportDataSource("CashAdvancedPaymentsDS", cashAdvancedPaymentsDS.Tables[1]);
                CashAdvancedPaymentTransactionsReportViewer cashAdvancedPaymentTransactionsReportViewer = new CashAdvancedPaymentTransactionsReportViewer();

                cashAdvancedPaymentTransactionsReportViewer.reportViewer1.LocalReport.DataSources.Clear();

                cashAdvancedPaymentTransactionsReportViewer.reportViewer1.LocalReport.DataSources.Add(datasource);
                cashAdvancedPaymentTransactionsReportViewer.reportViewer1.RefreshReport();

                cashAdvancedPaymentTransactionsReportViewer.Show();
            }
            else
            {
                headerControl1.txtID.Focus();
            }
        }

        private CashAdvancedPaymentsDS GetData()
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
                    //using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {clientID} AND (Date BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}') ORDER BY other.Date ASC"))
                    using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM cashadvancepayments as caPayments " +
                        $"INNER JOIN cashadvances as ca on caPayments.CashAdvanceID = ca.CashAdvanceID inner join loans as l on ca.LoanID = l.LoanID " +
                        $"INNER JOIN clients as c on l.ClientID = c.ClientID WHERE c.ClientID = {clientID}"))
                    {
                        //using (SqlDataAdapter sda = new SqlDataAdapter())
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            //using (Customers dsCustomers = new Customers())
                            //using (OthersDS dsOthers = new OthersDS())
                            using (CashAdvancedPaymentsDS cashAdvancedPaymentsDS = new CashAdvancedPaymentsDS())
                            {
                                //sda.Fill(dsCustomers, "DataTable1");

                                //DataTable othersDT = new DataTable();
                                DataTable cashAdvancedPaymentsDT = new DataTable();
                                //sda.Fill(othersDT);
                                sda.Fill(cashAdvancedPaymentsDT);
                                //if (othersDT.Rows.Count > 0)
                                if (cashAdvancedPaymentsDT.Rows.Count > 0)
                                {
                                    //sda.Fill(dsOthers, "OthersDT");
                                    sda.Fill(cashAdvancedPaymentsDS, "CashAdvancedPaymentsDT");

                                    //return dsCustomers;
                                    //return dsOthers;
                                    return cashAdvancedPaymentsDS;
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

        private void btnShowLoans_Click(object sender, EventArgs e)
        {
            if (this.headerControl1.txtID.Text != "")
            {
                dgLoans.Rows.Clear();

                dgLoans.DataSource = null;
                GetLaonsData();
                if (ListLoanID.Count > 0)
                {

                    updateLoansDatagrid();
                    btnPrint.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"No Record Found for Client ID: {this.headerControl1.txtID.Text}");
                    btnPrint.Enabled = false;
                }
            }
            else
            {
                this.headerControl1.txtID.Focus();
            }
        }

        private void GetLaonsData()
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
                //string query = $"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID} AND (Date BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}')";
                string query = $"SELECT * FROM loans INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID}";

                //MySqlDataReader row;  
                MySqlDataReader row;
                row = dbConnection.ExecuteReader(query);
                if (row.HasRows)
                {
                    ListLoanID.Clear();
                    ListClientID.Clear();
                    ListLoanType.Clear();
                    ListModeOfPayment.Clear();
                    ListAmount.Clear();
                    ListTerms.Clear();
                    ListInterestRate.Clear();
                    ListInterestAmount.Clear();
                    ListPeriodicPayment.Clear();
                    ListStartDate.Clear();
                    ListEndDate.Clear();
                    ListStatus.Clear();
                    ListBalance.Clear();
                    ListCapitalAmount.Clear();
                    while (row.Read())
                    {
                        //ListOtherID.Add(row["OtherId"].ToString());
                        //ListLoanID.Add(row["LoanID"].ToString());
                        //ListDate.Add(row["Date"].ToString());
                        //ListAmount.Add(row["Amount"].ToString());
                        //ListDescription.Add(row["Description"].ToString());
                        //ListBalance.Add(row["Balance"].ToString());
                        //ListStatus.Add(row["Status"].ToString());
                        //ListType.Add(row["OtherType"].ToString());


                        ListLoanID.Add(row["LoanID"].ToString());
                        ListClientID.Add(row["ClientID"].ToString());
                        ListLoanType.Add(row["LoanType"].ToString());
                        ListModeOfPayment.Add(row["ModeOfPayment"].ToString());
                        ListAmount.Add(row["Amount"].ToString());
                        ListTerms.Add(row["Terms"].ToString());
                        ListInterestRate.Add(row["InterestRate"].ToString());
                        ListInterestAmount.Add(row["InterestAmount"].ToString());
                        ListPeriodicPayment.Add(row["PeriodicPayment"].ToString());
                        ListStartDate.Add(row["StartDate"].ToString());
                        ListEndDate.Add(row["EndDate"].ToString());
                        ListStatus.Add(row["Status"].ToString());
                        ListBalance.Add(row["Balance"].ToString());
                        ListCapitalAmount.Add(row["CapitalAmount"].ToString());

                    }
                }
                else
                {
                    ListLoanID.Clear();
                    ListClientID.Clear();
                    ListLoanType.Clear();
                    ListModeOfPayment.Clear();
                    ListAmount.Clear();
                    ListTerms.Clear();
                    ListInterestRate.Clear();
                    ListInterestAmount.Clear();
                    ListPeriodicPayment.Clear();
                    ListStartDate.Clear();
                    ListEndDate.Clear();
                    ListStatus.Clear();
                    ListBalance.Clear();
                    ListCapitalAmount.Clear();
                    // MessageBox.Show("Data not found");
                }

                dbConnection.CloseConnection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void updateLoansDatagrid()
        {
            dgLoans.Rows.Clear();
            dgLoans.DataSource = null;
            //dataGridView1.Columns.Clear();

            for (int i = 0; i < ListLoanID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgLoans);
                newRow.Cells[0].Value = ListLoanID[i];
                newRow.Cells[1].Value = ListClientID[i];
                //newRow.Cells[2].Value = ListLoanType[i];
                //newRow.Cells[3].Value = ListModeOfPayment[i];
                newRow.Cells[4].Value = ListAmount[i];
                newRow.Cells[5].Value = ListTerms[i];
                newRow.Cells[6].Value = ListInterestRate[i];
                newRow.Cells[7].Value = ListInterestAmount[i];
                newRow.Cells[8].Value = ListPeriodicPayment[i];
                newRow.Cells[9].Value = ListStartDate[i];
                newRow.Cells[10].Value = ListEndDate[i];
                //newRow.Cells[10].Value = ListStatus[i];
                newRow.Cells[12].Value = ListBalance[i];
                newRow.Cells[13].Value = ListCapitalAmount[i];

                int listStatus = Int32.Parse((string)ListStatus[i]);
                switch (listStatus)
                {
                    case 0:
                        ListStatus[i] = "New";
                        break;
                    case 1:
                        ListStatus[i] = "Pending";
                        break;
                    case 2:
                        ListStatus[i] = "Approved";
                        break;
                    case 3:
                        ListStatus[i] = "Partial";
                        break;
                    case 4:
                        ListStatus[i] = "Settled";
                        break;
                    default:
                        ListStatus[i] = "NA";
                        break;
                }
                newRow.Cells[11].Value = ListStatus[i];

                int loanType = Int32.Parse((string)ListLoanType[i]);
                switch (loanType)
                {
                    case 0:
                        ListLoanType[i] = "Fixed";
                        break;
                    case 1:
                        ListLoanType[i] = "Diminishing";
                        break;
                    case 2:
                        ListLoanType[i] = "Fixed Diminising";
                        break;
                    default:
                        ListLoanType[i] = "NA";
                        break;
                }
                newRow.Cells[2].Value = ListLoanType[i];

                int modeOfPay = Int32.Parse((string)ListModeOfPayment[i]);
                switch (modeOfPay)
                {
                    case 0:
                        ListModeOfPayment[i] = "Daily";
                        break;
                    case 1:
                        ListModeOfPayment[i] = "Weekly";
                        break;
                    case 2:
                        ListModeOfPayment[i] = "Semi Monthly";
                        break;
                    case 3:
                        ListModeOfPayment[i] = "Monthly";
                        break;
                    default:
                        ListLoanType[i] = "NA";
                        break;
                }
                newRow.Cells[3].Value = ListLoanType[i];



                dgLoans.Rows.Add(newRow);
            }
        }

        private void GetCAData()
        {
            try
            {
                int cID = int.Parse(clientID);

                loanID = dgLoans.CurrentRow.Cells[0].Value + string.Empty;

                dbConnection.OpenConnection();
                //string query = "select * from other where LoanID = 696";
                //clientID = int.Parse(this.headerControl2.txtIDValue);
                DateTime dtFrom_ = new DateTime();



                dtFrom.CustomFormat = "yyyy-MM-dd";
                dtFrom_ = dtFrom.Value;

                dtTo.Format = DateTimePickerFormat.Custom;
                dtTo.CustomFormat = "yyyy-MM-dd";


                //DateTime dtTo_ = dtTo.Value;
                //string query = $"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID} AND (Date BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}')";
                string query = $"SELECT * FROM cashadvances INNER JOIN loans on cashadvances.LoanID = loans.LoanID WHERE loans.LoanID = {loanID}";

                //MySqlDataReader row;  
                MySqlDataReader row;
                row = dbConnection.ExecuteReader(query);
                if (row.HasRows)
                {
                    CAListCashAdvanceID.Clear();
                    CAListLoanID.Clear();
                    CAListAmount.Clear();
                    CAListTerms.Clear();
                    CAListInterestRate.Clear();
                    CAListInteretAmount.Clear();
                    CAListTotalAmount.Clear();
                    CAListBalance.Clear();
                    CAListDateReceived.Clear();
                    CAListStatus.Clear();
                    CAListNote.Clear();
                    
                    while (row.Read())
                    {
                        //ListOtherID.Add(row["OtherId"].ToString());
                        //ListLoanID.Add(row["LoanID"].ToString());
                        //ListDate.Add(row["Date"].ToString());
                        //ListAmount.Add(row["Amount"].ToString());
                        //ListDescription.Add(row["Description"].ToString());
                        //ListBalance.Add(row["Balance"].ToString());
                        //ListStatus.Add(row["Status"].ToString());
                        //ListType.Add(row["OtherType"].ToString());


                        CAListCashAdvanceID.Add(row["LoanID"].ToString());
                        CAListLoanID.Add(row["CashAdvanceID"].ToString());
                        CAListAmount.Add(row["Amount"].ToString());
                        CAListTerms.Add(row["Terms"].ToString());
                        CAListInterestRate.Add(row["InterestRate"].ToString());
                        CAListInteretAmount.Add(row["InterestAmount"].ToString());
                        CAListTotalAmount.Add(row["TotalAmount"].ToString());
                        CAListBalance.Add(row["Balance"].ToString());
                        CAListDateReceived.Add(row["DateReceived"].ToString());
                        CAListStatus.Add(row["Status"].ToString());
                        CAListNote.Add(row["Note"].ToString());

                    }
                }
                else
                {
                    CAListCashAdvanceID.Clear();
                    CAListLoanID.Clear();
                    CAListAmount.Clear();
                    CAListTerms.Clear();
                    CAListInterestRate.Clear();
                    CAListInteretAmount.Clear();
                    CAListTotalAmount.Clear();
                    CAListBalance.Clear();
                    CAListDateReceived.Clear();
                    CAListStatus.Clear();
                    CAListNote.Clear();
                    // MessageBox.Show("Data not found");
                }

                dbConnection.CloseConnection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void updateCADatagrid()
        {
            dgCashAdvances.Rows.Clear();
            dgCashAdvances.DataSource = null;
            //dataGridView1.Columns.Clear();

            for (int i = 0; i < CAListCashAdvanceID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgCashAdvances);
                newRow.Cells[0].Value = CAListLoanID[i];
                newRow.Cells[1].Value = CAListCashAdvanceID[i];
                newRow.Cells[2].Value = CAListAmount[i];
                newRow.Cells[3].Value = CAListTerms[i];
                newRow.Cells[4].Value = CAListInterestRate[i];
                newRow.Cells[5].Value = CAListInteretAmount[i];
                newRow.Cells[6].Value = CAListTotalAmount[i];
                newRow.Cells[7].Value = CAListBalance[i];
                newRow.Cells[8].Value = CAListDateReceived[i];
                //newRow.Cells[9].Value = CAListStatus[i];
                newRow.Cells[10].Value = CAListNote[i];

                int type = Int32.Parse((string)CAListStatus[i]);

                switch (type)
                {
                    case 0:
                        CAListStatus[i] = "New";
                        break;
                    case 1:
                        CAListStatus[i] = "Partial";
                        break;
                    case 2:
                        CAListStatus[i] = "Paid";
                        break;
                    default:
                        CAListStatus[i] = "NA";
                        break;
                }

                newRow.Cells[9].Value = CAListStatus[i];

                dgCashAdvances.Rows.Add(newRow);
            }
        }

        private void dgLoans_DoubleClick(object sender, EventArgs e)
        {

            


        }

        private void dgLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnShowCA_Click(object sender, EventArgs e)
        {
            if (this.headerControl1.txtID.Text != "")
            {
                dgCashAdvances.Rows.Clear();

                dgCashAdvances.DataSource = null;
                GetCAData();
                if (CAListCashAdvanceID.Count > 0)
                {

                    updateCADatagrid();
                    //btnPrint.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"No CA Found for this loan");
                    //btnPrint.Enabled = false;
                }
            }
            else
            {
                this.headerControl1.txtID.Focus();
            }
        }
    }


}
