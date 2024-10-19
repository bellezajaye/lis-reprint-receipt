using LISReprintReceipt.Report.ReportEntities;
using LISReprintReceipt.Report.ReportViewer;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISReprintReceipt
{
    public partial class CashAdvanceWindow : Form
    {

        DbConnection dbConnection = new DbConnection();

        private static ArrayList ListCashAdvanceID = new ArrayList();
        private static ArrayList ListLoanID = new ArrayList();
        private static ArrayList ListAmount = new ArrayList();
        private static ArrayList ListTerms = new ArrayList();
        private static ArrayList ListInterestRate = new ArrayList();
        private static ArrayList ListInterestAmount = new ArrayList();
        private static ArrayList ListTotalAmount = new ArrayList();
        private static ArrayList ListBalance = new ArrayList();
        private static ArrayList ListDateReceived = new ArrayList();      
        private static ArrayList ListStatus = new ArrayList();
        private static ArrayList ListNote = new ArrayList();

        public CashAdvanceWindow()
        {
            InitializeComponent();
        }

        private void btnShowRecord_Click(object sender, EventArgs e)
        {
            if (this.headerControl1.txtID.Text != "")
            {
                dataGridView1.Rows.Clear();

                dataGridView1.DataSource = null;
                GetData();
                if (ListCashAdvanceID.Count > 0)
                {
                    updateDatagrid();
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

        private void GetData()
        {
            try
            {
                dbConnection.OpenConnection();
                //string query = "select * from other where LoanID = 696";
                int cID = int.Parse(this.headerControl1.txtIDValue);
                DateTime dtFrom_ = new DateTime();



                dtFrom.CustomFormat = "yyyy-MM-dd";
                dtFrom_ = dtFrom.Value;

                dtTo.Format = DateTimePickerFormat.Custom;
                dtTo.CustomFormat = "yyyy-MM-dd";


                //DateTime dtTo_ = dtTo.Value;
                string query = $"SELECT * FROM cashadvances INNER JOIN loans ON cashadvances.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID} AND (DateReceived BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}')";
                //string query = $"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE Date BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}'";

                //MySqlDataReader row;  
                MySqlDataReader row;
                row = dbConnection.ExecuteReader(query);
                if (row.HasRows)
                {
                    ListCashAdvanceID.Clear();
                    ListLoanID.Clear();
                    ListAmount.Clear();
                    ListTerms.Clear();
                    ListInterestRate.Clear();
                    ListInterestAmount.Clear();
                    ListTotalAmount.Clear();
                    ListBalance.Clear();
                    ListDateReceived.Clear();
                    ListStatus.Clear();
                    ListNote.Clear();
                    while (row.Read())
                    {
                        ListCashAdvanceID.Add(row["CashAdvanceID"].ToString());
                        ListLoanID.Add(row["LoanID"].ToString());
                        ListAmount.Add(row["Amount"].ToString());
                        ListTerms.Add(row["Terms"].ToString());
                        ListInterestRate.Add(row["InterestRate"].ToString());
                        ListInterestAmount.Add(row["InterestAmount"].ToString());
                        ListTotalAmount.Add(row["TotalAmount"].ToString());
                        ListBalance.Add(row["Balance"].ToString());
                        ListDateReceived.Add(row["DateReceived"].ToString());
                        ListStatus.Add(row["Status"].ToString());
                        ListNote.Add(row["Note"].ToString());

                    }
                }
                else
                {
                    ListCashAdvanceID.Clear();
                    ListLoanID.Clear();
                    ListAmount.Clear();
                    ListTerms.Clear();
                    ListInterestRate.Clear();
                    ListInterestAmount.Clear();
                    ListTotalAmount.Clear();
                    ListBalance.Clear();
                    ListDateReceived.Clear();
                    ListStatus.Clear();
                    ListNote.Clear();
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
            for (int i = 0; i < ListCashAdvanceID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = ListCashAdvanceID[i];
                newRow.Cells[1].Value = ListLoanID[i];
                newRow.Cells[2].Value = ListAmount[i];
                newRow.Cells[3].Value = ListTerms[i];
                newRow.Cells[4].Value = ListInterestRate[i];
                newRow.Cells[5].Value = ListInterestAmount[i];
                newRow.Cells[6].Value = ListTotalAmount[i];
                newRow.Cells[7].Value = ListBalance[i];
                newRow.Cells[8].Value = ListDateReceived[i];
                newRow.Cells[9].Value = ListStatus[i];
                newRow.Cells[10].Value = ListNote[i];

                dataGridView1.Rows.Add(newRow);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {


            //OtherSS othRC = new OtherSS();
            CashAdvanceSS cashAdvanceRC = new CashAdvanceSS();

            //othRC.Amount = txtAmount.Text;
            //othRC.ClientFullName = this.ClientHeader.txtFullName.Text;
            cashAdvanceRC.ClientFullName = this.headerControl1.txtClientFullName;
            cashAdvanceRC.Amount = dataGridView1.CurrentRow.Cells[2].Value + string.Empty;
            cashAdvanceRC.ClientID = this.headerControl1.txtIDValue;
            cashAdvanceRC.DateReceived = DateTime.Parse(dataGridView1.CurrentRow.Cells[8].Value + string.Empty);
            cashAdvanceRC.Terms = dataGridView1.CurrentRow.Cells[3].Value + string.Empty;
            cashAdvanceRC.InterestRate = dataGridView1.CurrentRow.Cells[4].Value + string.Empty;
            cashAdvanceRC.InterestAmount = dataGridView1.CurrentRow.Cells[5].Value + string.Empty;
            cashAdvanceRC.TotalAmount = dataGridView1.CurrentRow.Cells[6].Value + string.Empty;
            cashAdvanceRC.Status = dataGridView1.CurrentRow.Cells[9].Value + string.Empty;
            cashAdvanceRC.Note = dataGridView1.CurrentRow.Cells[10].Value + string.Empty;

            //OthersReportViewer frm = new OthersReportViewer();
            CashAdvanceReportViewer frm = new CashAdvanceReportViewer();
            frm.cashAdvanceSS = cashAdvanceRC;
            frm.Show();

            /* 
             * Status
             * 
             * New
             * Partial
             * Paid
             * */
        }

        private void CashAdvanceWindow_Load(object sender, EventArgs e)
        {
            // +1 to current date to show records for current date
            dtTo.Value = dtTo.Value.AddDays(1);
        }
    }
}
