using LISReprintReceipt.UserControl;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class CAPaymentsTransactionWindow : Form
    {

        DbConnection dbConnection = new DbConnection();

        private static ArrayList CAPaymentsListID = new ArrayList();
        private static ArrayList CAPaymentsListCashAdvanceID = new ArrayList();
        private static ArrayList CAPaymentsListAmountPaid = new ArrayList();
        private static ArrayList CAPaymentsListNewBalance = new ArrayList();
        private static ArrayList CAPaymentsListDateReceived = new ArrayList();
        private static ArrayList CAPaymentsListStatus = new ArrayList();
        private static ArrayList CAPaymentsListDueDate = new ArrayList();
        private static ArrayList CAPaymentsListNote = new ArrayList();


        public CAPaymentsTransactionWindow()
        {
            InitializeComponent();
        }

        private void CAPaymentsTransactionWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnShowCAPayments_Click(object sender, EventArgs e)
        {
            if (this.txtClientID.Text != "")
            {
                dgCAPayments.Rows.Clear();

                dgCAPayments.DataSource = null;
                GetCAPaymentsData();
                if (CAPaymentsListID.Count > 0)
                {
                    updateCADataGrid();
                }
                else
                {
                    MessageBox.Show("No Payments found for this CA");
                }
            }
        }

        private void updateCADataGrid()
        {
            dgCAPayments.Rows.Clear();
            dgCAPayments.DataSource = null;
            //dataGridView1.Columns.Clear();

            for (int i = 0; i < CAPaymentsListID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgCAPayments);
                newRow.Cells[0].Value = CAPaymentsListID[i];
                newRow.Cells[1].Value = CAPaymentsListCashAdvanceID[i];
                newRow.Cells[2].Value = CAPaymentsListAmountPaid[i];
                newRow.Cells[3].Value = CAPaymentsListNewBalance[i];
                newRow.Cells[4].Value = CAPaymentsListDateReceived[i];
                


                int cAPaymentsListStatus = Int32.Parse((string)CAPaymentsListStatus[i]);
                switch (cAPaymentsListStatus)
                {
                    case 0:
                        CAPaymentsListStatus[i] = "Temporary";
                        break;
                    case 1:
                        CAPaymentsListStatus[i] = "Partial";
                        break;
                    case 2:
                        CAPaymentsListStatus[i] = "Paid";
                        break;
                    default:
                        CAPaymentsListStatus[i] = "NA";
                        break;
                }

                newRow.Cells[5].Value = CAPaymentsListStatus[i];

                newRow.Cells[6].Value = CAPaymentsListDueDate[i];
                newRow.Cells[7].Value = CAPaymentsListNote[i];

                dgCAPayments.Rows.Add(newRow);

            }

        }

        private void GetCAPaymentsData()
        {
            try
            {
                //int cID = int.Parse(clientID);

                //loanID = dgLoans.CurrentRow.Cells[0].Value + string.Empty;

                dbConnection.OpenConnection();
                


                string query = $"SELECT * FROM cashadvancepayments INNER JOIN cashadvances on cashadvancepayments.CashAdvanceID = cashadvances.CashAdvanceID WHERE cashadvances.CashAdvanceID = {txtCashAdvancedID.Text}";

                //MySqlDataReader row;  
                MySqlDataReader row;
                row = dbConnection.ExecuteReader(query);
                if (row.HasRows)
                {
                    CAPaymentsListID.Clear();
                    CAPaymentsListCashAdvanceID.Clear();
                    CAPaymentsListAmountPaid.Clear();
                    CAPaymentsListNewBalance.Clear();
                    CAPaymentsListDateReceived.Clear();
                    CAPaymentsListStatus.Clear();
                    CAPaymentsListDueDate.Clear();
                    CAPaymentsListNote.Clear();

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


                        CAPaymentsListID.Add(row["ID"].ToString());
                        CAPaymentsListCashAdvanceID.Add(row["CashAdvanceID"].ToString());
                        CAPaymentsListAmountPaid.Add(row["AmountPaid"].ToString());
                        CAPaymentsListNewBalance.Add(row["NewBalance"].ToString());
                        CAPaymentsListDateReceived.Add(row["DateReceived"].ToString());
                        CAPaymentsListStatus.Add(row["Status"].ToString());
                        CAPaymentsListDueDate.Add(row["DueDate"].ToString());
                        CAPaymentsListNote.Add(row["Note"].ToString());

                    }
                }
                else
                {
                    CAPaymentsListID.Clear();
                    CAPaymentsListCashAdvanceID.Clear();
                    CAPaymentsListAmountPaid.Clear();
                    CAPaymentsListNewBalance.Clear();
                    CAPaymentsListDateReceived.Clear();
                    CAPaymentsListStatus.Clear();
                    CAPaymentsListDueDate.Clear();
                    CAPaymentsListNote.Clear();
                    // MessageBox.Show("Data not found");
                }

                dbConnection.CloseConnection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        // Printer
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        Font printFont = new Font("Arial", 7);

        private void btnPrintCAPayments_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = printDocument1;

            objPPdialog.Document.DefaultPageSettings.Landscape = true;
            objPPdialog.Height = 1000;
            objPPdialog.Width = 1000;

            objPPdialog.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void printDocument1_BeginPrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            PrintHelper.printDocuments_BeginPrint(dgCAPayments);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintHelper.printDocuments_PrintPage(dgCAPayments, e, txtClientID.Text, txtClientFullName.Text);
        }
    }
}
