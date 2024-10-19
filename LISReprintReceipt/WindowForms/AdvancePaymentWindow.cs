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

namespace LISReprintReceipt.WindowForms
{
    public partial class AdvancePaymentWindow : Form
    {

        DbConnection dbConnection = new DbConnection();


        private static ArrayList ListID = new ArrayList();
        private static ArrayList ListDateAdvancedPayment = new ArrayList();
        private static ArrayList ListSalary = new ArrayList();
        private static ArrayList ListPayment = new ArrayList();
        private static ArrayList ListInterestAmount = new ArrayList();
        private static ArrayList ListChange = new ArrayList();
        private static ArrayList ListStatus = new ArrayList();
        private static ArrayList ListDescription = new ArrayList();
        private static ArrayList ListLoanID = new ArrayList();
        private static ArrayList ListPreviousBalance = new ArrayList();
        private static ArrayList ListNewBalance = new ArrayList();

        public AdvancePaymentWindow()
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
                if (ListID.Count > 0)
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
                int cID = int.Parse(this.headerControl1.txtIDValue);
                DateTime dtFrom_ = new DateTime();



                dtFrom.CustomFormat = "yyyy-MM-dd";
                dtFrom_ = dtFrom.Value;

                dtTo.Format = DateTimePickerFormat.Custom;
                dtTo.CustomFormat = "yyyy-MM-dd";

                string query = $"SELECT * FROM advancedpayments INNER JOIN loans ON advancedpayments.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID} AND (DateAdvPayment BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}')";
                

                MySqlDataReader row;
                row = dbConnection.ExecuteReader(query);
                if (row.HasRows)
                {
                    ListID.Clear();
                    ListDateAdvancedPayment.Clear();
                    ListSalary.Clear();
                    ListPayment.Clear();
                    ListInterestAmount.Clear();
                    ListChange.Clear();
                    ListStatus.Clear();
                    ListDescription.Clear();
                    ListLoanID.Clear();
                    ListPreviousBalance.Clear();
                    ListNewBalance.Clear();
                    while (row.Read())
                    {
                        ListID.Add(row["ID"].ToString());
                        ListDateAdvancedPayment.Add(row["DateAdvPayment"].ToString());
                        ListSalary.Add(row["Salary"].ToString());
                        ListPayment.Add(row["Payment"].ToString());
                        ListInterestAmount.Add(row["InterestAmt"].ToString());
                        ListChange.Add(row["Change"].ToString());
                        ListStatus.Add(row["Status"].ToString());
                        ListDescription.Add(row["Description"].ToString());
                        ListLoanID.Add(row["LoanID"].ToString());
                        ListPreviousBalance.Add(row["PreviousBalance"].ToString());
                        ListNewBalance.Add(row["NewBalance"].ToString());

                    }
                }
                else
                {
                    ListID.Clear();
                    ListDateAdvancedPayment.Clear();
                    ListSalary.Clear();
                    ListPayment.Clear();
                    ListInterestAmount.Clear();
                    ListChange.Clear();
                    ListStatus.Clear();
                    ListDescription.Clear();
                    ListLoanID.Clear();
                    ListPreviousBalance.Clear();
                    ListNewBalance.Clear();
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
            for (int i = 0; i < ListID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = ListID[i];
                newRow.Cells[1].Value = ListDateAdvancedPayment[i];
                newRow.Cells[2].Value = ListSalary[i];
                newRow.Cells[3].Value = ListPayment[i];
                newRow.Cells[4].Value = ListInterestAmount[i];
                newRow.Cells[5].Value = ListChange[i];
                newRow.Cells[6].Value = ListStatus[i];
                newRow.Cells[7].Value = ListDescription[i];
                newRow.Cells[8].Value = ListLoanID[i];
                newRow.Cells[9].Value = ListPreviousBalance[i];
                newRow.Cells[10].Value = ListNewBalance[i];

                dataGridView1.Rows.Add(newRow);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            AdvancePaymentSS advancePaymentRC = new AdvancePaymentSS();


       


            advancePaymentRC.ClientFullName = this.headerControl1.txtClientFullName;
            advancePaymentRC.ClientID =  int.Parse(this.headerControl1.txtIDValue);
            //advancePaymentRC.Categ = dataGridView1.CurrentRow.Cells[]
            advancePaymentRC.ClientSalary = dataGridView1.CurrentRow.Cells[2].Value + string.Empty;
            advancePaymentRC.IntAmount = dataGridView1.CurrentRow.Cells[4].Value + string.Empty;
            advancePaymentRC.ClientAdvPayment = dataGridView1.CurrentRow.Cells[3].Value + string.Empty;
            advancePaymentRC.Change = dataGridView1.CurrentRow.Cells[5].Value + string.Empty;

            txtAmount.Text = dataGridView1.CurrentRow.Cells[2].Value + string.Empty; ;



            AdvancedPaymentReportViewer avdPaymentReportViewer = new AdvancedPaymentReportViewer();
            avdPaymentReportViewer.advancePaymentSS = advancePaymentRC;
            avdPaymentReportViewer.Show();



            //OtherSS othRC = new OtherSS();

            ////othRC.Amount = txtAmount.Text;
            ////othRC.ClientFullName = this.ClientHeader.txtFullName.Text;
            //othRC.ClientFullName = this.headerControl2.txtClientFullName;
            //othRC.Amount = dataGridView1.CurrentRow.Cells[3].Value + string.Empty;
            //othRC.ClientID = this.headerControl2.txtIDValue;
            //othRC.Datee = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value + string.Empty);
            //othRC.Type = dataGridView1.CurrentRow.Cells[7].Value + string.Empty;
            //othRC.Remarks = dataGridView1.CurrentRow.Cells[4].Value + string.Empty;

            //OthersReportViewer frm = new OthersReportViewer();
            //frm.otherss = othRC;
            //frm.Show();


        }
    }
}
