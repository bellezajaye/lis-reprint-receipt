using LISReprintReceipt.Report.ReportEntities;
using LISReprintReceipt.Report.ReportViewer;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISReprintReceipt
{
    public partial class AdditionalLoanWindow : Form
    {

        DbConnection dbConnection = new DbConnection();

        private static ArrayList ListID = new ArrayList();
        private static ArrayList ListLoanID = new ArrayList();
        private static ArrayList ListClientID = new ArrayList();
        private static ArrayList ListAdditionalLoanAmount = new ArrayList();
        private static ArrayList ListCurBalance = new ArrayList();
        private static ArrayList ListNewBalance = new ArrayList();
        private static ArrayList ListPeriodicPayment = new ArrayList();
        private static ArrayList ListAdditionalLoanDate = new ArrayList();
        private static ArrayList ListNextPayment = new ArrayList();
        public AdditionalLoanWindow()
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
                }
                else
                {
                    MessageBox.Show($"No Record Found for Client ID: {this.headerControl1.txtID.Text}");
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
                string query = $"SELECT * FROM additionalloans INNER JOIN loans ON additionalloans.LoandID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID} AND (AdditionalLoanDate BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}')";
                //string query = $"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE Date BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}'";

                //MySqlDataReader row;  
                MySqlDataReader row;
                row = dbConnection.ExecuteReader(query);
                if (row.HasRows)
                {
                    ListID.Clear();
                    ListLoanID.Clear();
                    ListClientID.Clear();
                    ListAdditionalLoanAmount.Clear();
                    ListCurBalance.Clear();
                    ListNewBalance.Clear();
                    ListPeriodicPayment.Clear();
                    ListAdditionalLoanDate.Clear();
                    ListNextPayment.Clear();
                    while (row.Read())
                    {
                        ListID.Add(row["ID"].ToString());
                        ListLoanID.Add(row["LoanID"].ToString());
                        ListClientID.Add(row["ClientID"].ToString());
                        ListAdditionalLoanAmount.Add(row["AdditionalLoanAmt"].ToString());
                        ListCurBalance.Add(row["CurBalance"].ToString());
                        ListNewBalance.Add(row["NewBalance"].ToString());
                        ListPeriodicPayment.Add(row["PeriodicPayment"].ToString());
                        ListAdditionalLoanDate.Add(row["AdditionalLoanDate"].ToString());
                        ListNextPayment.Add(row["NextPayment"].ToString());

                    }
                }
                else
                {
                    ListID.Clear();
                    ListLoanID.Clear();
                    ListClientID.Clear();
                    ListAdditionalLoanAmount.Clear();
                    ListCurBalance.Clear();
                    ListNewBalance.Clear();
                    ListPeriodicPayment.Clear();
                    ListAdditionalLoanDate.Clear();
                    ListNextPayment.Clear();
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
                newRow.Cells[1].Value = ListLoanID[i];
                newRow.Cells[2].Value = ListClientID[i];
                newRow.Cells[3].Value = ListAdditionalLoanAmount[i];
                newRow.Cells[4].Value = ListCurBalance[i];
                newRow.Cells[5].Value = ListNewBalance[i];
                newRow.Cells[6].Value = ListPeriodicPayment[i];
                newRow.Cells[7].Value = ListAdditionalLoanDate[i];
                newRow.Cells[8].Value = ListNextPayment[i];

                dataGridView1.Rows.Add(newRow);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            AdditionalLoanSS additionalLoanRC = new AdditionalLoanSS();

            additionalLoanRC.ClientName = this.headerControl1.txtClientFullName;
            additionalLoanRC.addAmount = decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value + string.Empty);
            additionalLoanRC.ClientID = int.Parse(this.headerControl1.txtIDValue);
            additionalLoanRC.loanCateg = this.headerControl1.txtLoanStatus;
            additionalLoanRC.Balance = decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value + string.Empty);
            additionalLoanRC.newBalance = decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value + string.Empty);
            additionalLoanRC.PayNxtSal = decimal.Parse(dataGridView1.CurrentRow.Cells[8].Value + string.Empty);
            additionalLoanRC.PeriodPayment = decimal.Parse(dataGridView1.CurrentRow.Cells[6].Value + string.Empty);
            additionalLoanRC.addLoanDate = DateTime.Parse(dataGridView1.CurrentRow.Cells[7].Value + string.Empty);
            //additionalLoanSS.Datee = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value + string.Empty);
            //additionalLoanSS.Type = dataGridView1.CurrentRow.Cells[7].Value + string.Empty;
            //additionalLoanSS.Remarks = dataGridView1.CurrentRow.Cells[4].Value + string.Empty;

            AdditionalLoanReportViewer frm = new AdditionalLoanReportViewer();
            frm.additionalLoanSS = additionalLoanRC;
            frm.Show();
        }
    }
}
