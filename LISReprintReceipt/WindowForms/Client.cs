using MySqlX.XDevAPI;
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
using MySql.Data.MySqlClient;
using System.Data.Entity.Infrastructure;
using System.Runtime.ConstrainedExecution;
using LISReprintReceipt;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Protobuf.WellKnownTypes;

namespace LISReprintReceipt.WindowForms
{
    public partial class ClientWindow : Form
    {

        DbConnection dbConnection = new DbConnection();

        public string clientID { get { return this.headerControl1.txtIDValue; } }

        public string loanID;
        public string paymentsLoanID;

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


        // Payments
        private static ArrayList PaymentsListPaymentID = new ArrayList();
        private static ArrayList PaymentsListLoanID = new ArrayList();
        private static ArrayList PaymentsListSalary = new ArrayList();
        private static ArrayList PaymentsListPartialPayment = new ArrayList();
        private static ArrayList PaymentsListInterestAmount = new ArrayList();
        private static ArrayList PaymentsListCashPayment = new ArrayList();
        private static ArrayList PaymentsListTotalDeduction = new ArrayList();
        private static ArrayList PaymentsListChange = new ArrayList();
        private static ArrayList PaymentsListNewBalance = new ArrayList();
        private static ArrayList PaymentsListDueDate = new ArrayList();
        private static ArrayList PaymentsListPaymentDate = new ArrayList();
        private static ArrayList PaymentsListNote = new ArrayList();
        private static ArrayList PaymentsListStatus = new ArrayList();
        private static ArrayList PaymentsListTotalPayment = new ArrayList();
        private static ArrayList PaymentsListOthersTotal = new ArrayList();
        private static ArrayList PaymentsListRemark = new ArrayList();

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

        // Others
        private static ArrayList OthersListOtherID = new ArrayList();
        private static ArrayList OthersListLoanID = new ArrayList();
        private static ArrayList OthersListDate = new ArrayList();
        private static ArrayList OthersListAmount = new ArrayList();
        private static ArrayList OthersListDescription = new ArrayList();
        private static ArrayList OthersListBalance = new ArrayList();
        private static ArrayList OthersListStatus = new ArrayList();
        private static ArrayList OthersListOtherType = new ArrayList();



        public ClientWindow()
        {
            InitializeComponent();
        }

        private void btnShowLoans_Click(object sender, EventArgs e)
        {
            if (this.headerControl1.txtID.Text != "")
            {
                dgLoans.Rows.Clear();

                dgLoans.DataSource = null;
                GetAllLoansData();
                if (ListLoanID.Count > 0)
                {

                    updateLoansDatagrid();
                    btnShowLoans.Enabled = true;
                    btnFilterResults.Enabled = true;
                    btnShowPayments.Enabled = true;
                    btnPrintLoans.Enabled = true;

                    btnShowCA.Enabled = true;

                    btnShowOthers.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"No Record Found for Client ID: {this.headerControl1.txtID.Text}");
                    btnShowLoans.Enabled = false;
                    btnFilterResults.Enabled = false;
                    btnShowPayments.Enabled = false;
                    btnPrintLoans.Enabled = false;

                    btnShowCA.Enabled = false;

                    btnShowOthers.Enabled = false;
                }
            }
            else
            {
                this.headerControl1.txtID.Focus();
            }
            dgLoans.Columns[9].DefaultCellStyle.Format = "d";
            dgLoans.Columns[10].DefaultCellStyle.Format = "d";
        } 

        private void ClearListLoan()
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
        }

        private void LoadListLoanAddRow(string qry)
        {

            MySqlDataReader row;
            row = dbConnection.ExecuteReader(qry);
            if (row.HasRows)
            {
                ClearListLoan();
                while (row.Read())
                {

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
                ClearListLoan();
            }
            dgLoans.Columns[9].DefaultCellStyle.Format = "d";

        }

        private void GetAllLoansData()
        {
            try
            {
                int cID = int.Parse(clientID);

                dbConnection.OpenConnection();

                string query;

                query = $"SELECT * FROM loans INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID}";

                LoadListLoanAddRow(query);


                dbConnection.CloseConnection();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void GetFilteredLoansData()
        {
            try
            {
                int cID = int.Parse(clientID);

                dbConnection.OpenConnection();

                string query;

                query = $"SELECT * FROM loans INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID} AND loans.LoanType = {cmbLoanType.SelectedIndex} AND loans.Status = {cmbStatus.SelectedIndex}";

                LoadListLoanAddRow(query);


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
                newRow.Cells[4].Value = ListAmount[i];
                newRow.Cells[5].Value = ListTerms[i];
                newRow.Cells[6].Value = ListInterestRate[i];
                newRow.Cells[7].Value = ListInterestAmount[i];
                newRow.Cells[8].Value = ListPeriodicPayment[i];
                newRow.Cells[9].Value = ListStartDate[i];
                newRow.Cells[10].Value = ListEndDate[i];
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
                newRow.Cells[3].Value = ListModeOfPayment[i];



                dgLoans.Rows.Add(newRow);
            }
            
        }

        private void btnFilterResults_Click(object sender, EventArgs e)
        {
            if (this.headerControl1.txtID.Text != "")
            {
                dgLoans.Rows.Clear();

                dgLoans.DataSource = null;
                GetFilteredLoansData();
                if (ListLoanID.Count > 0)
                {

                    updateLoansDatagrid();
                    btnFilterResults.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"No Record Found for Client ID: {this.headerControl1.txtID.Text}");
                    btnFilterResults.Enabled = false;
                }
            }
            else
            {
                this.headerControl1.txtID.Focus();
            }
        }

        private void dgLoans_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnShowPayments_Click(sender, e);
        }

        private void btnShowPayments_Click(object sender, EventArgs e)
        {
            if (this.headerControl1.txtID.Text != "")
            {
                dgPayments.Rows.Clear();

                dgPayments.DataSource = null;
                GetPaymentsData();
                if (PaymentsListPaymentID.Count > 0)
                {

                    updatePaymentsDatagrid();
                    //btnPrint.Enabled = true;

                    chkDate.Enabled = true;
                    chkStatus.Enabled = true;
                    btnPaymentsFilterResults.Enabled = true;
                    btnPrintPayments.Enabled = true;
                    btnPrintLoans.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"No Payments Found for this loan");
                    //btnPrint.Enabled = false;

                    chkDate.Enabled = false;
                    chkStatus.Enabled = false;
                    btnPaymentsFilterResults.Enabled = false;
                    btnPrintPayments.Enabled = true;
                    btnPrintLoans.Enabled = false;
                }
            }
            else
            {
                this.headerControl1.txtID.Focus();
            }
        }

        private void GetPaymentsData()
        {
            try
            {
                paymentsLoanID = dgLoans.CurrentRow.Cells[0].Value + string.Empty;

                dbConnection.OpenConnection();

                string query;

                query = $"SELECT * FROM payments WHERE LoanId = {paymentsLoanID}";

                LoadListPaymentsAddRow(query);


                dbConnection.CloseConnection();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void LoadListPaymentsAddRow(string qry)
        {

            MySqlDataReader row;
            row = dbConnection.ExecuteReader(qry);
            if (row.HasRows)
            {
                ClearPaymentsListLoan();
                while (row.Read())
                {

                    PaymentsListPaymentID.Add(row["PaymentID"].ToString());
                    PaymentsListLoanID.Add(row["LoanID"].ToString());
                    PaymentsListSalary.Add(row["Salary"].ToString());
                    PaymentsListPartialPayment.Add(row["PartialPayment"].ToString());
                    PaymentsListInterestAmount.Add(row["InterestAmount"].ToString());
                    PaymentsListCashPayment.Add(row["CashPayment"].ToString());
                    PaymentsListTotalDeduction.Add(row["TotalDeduction"].ToString());
                    PaymentsListChange.Add(row["Change"].ToString());
                    PaymentsListNewBalance.Add(row["NewBalance"].ToString());
                    PaymentsListDueDate.Add(row["DueDate"].ToString());
                    PaymentsListPaymentDate.Add(row["PaymentDate"].ToString());
                    PaymentsListNote.Add(row["Note"].ToString());
                    PaymentsListStatus.Add(row["Status"].ToString());
                    PaymentsListTotalPayment.Add(row["TotalPayment"].ToString());
                    PaymentsListOthersTotal.Add(row["OthersTotal"].ToString());
                    PaymentsListRemark.Add(row["Remark"].ToString());

                }
            }
            else
            {
                ClearPaymentsListLoan();
            }
        }

        private void ClearPaymentsListLoan()
        {
            PaymentsListPaymentID.Clear();
            PaymentsListLoanID.Clear();
            PaymentsListSalary.Clear();
            PaymentsListPartialPayment.Clear();
            PaymentsListInterestAmount.Clear();
            PaymentsListCashPayment.Clear();
            PaymentsListTotalDeduction.Clear();
            PaymentsListChange.Clear();
            PaymentsListNewBalance.Clear();
            PaymentsListDueDate.Clear();
            PaymentsListPaymentDate.Clear();
            PaymentsListNote.Clear();
            PaymentsListStatus.Clear();
            PaymentsListTotalPayment.Clear();
            PaymentsListOthersTotal.Clear();
            PaymentsListRemark.Clear();
        }

        private void updatePaymentsDatagrid()
        {
            dgPayments.Rows.Clear();
            dgPayments.DataSource = null;
            //dataGridView1.Columns.Clear();

            for (int i = 0; i < PaymentsListPaymentID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgPayments);
                newRow.Cells[0].Value = PaymentsListPaymentID[i];
                newRow.Cells[1].Value = PaymentsListLoanID[i];
                newRow.Cells[2].Value = PaymentsListSalary[i];
                newRow.Cells[3].Value = PaymentsListPartialPayment[i];
                newRow.Cells[4].Value = PaymentsListInterestAmount[i];
                newRow.Cells[5].Value = PaymentsListCashPayment[i];
                newRow.Cells[6].Value = PaymentsListTotalDeduction[i];
                newRow.Cells[7].Value = PaymentsListChange[i];
                newRow.Cells[8].Value = PaymentsListNewBalance[i];
                newRow.Cells[9].Value = PaymentsListDueDate[i];
                newRow.Cells[10].Value = PaymentsListPaymentDate[i];
                newRow.Cells[11].Value = PaymentsListNote[i];


                int paymentsListPaymentStatus = Int32.Parse((string)PaymentsListStatus[i]);
                switch (paymentsListPaymentStatus)
                {
                    case 0:
                        PaymentsListStatus[i] = "Floating";
                        break;
                    case 1:
                        PaymentsListStatus[i] = "Paid";
                        break;
                    case 2:
                        PaymentsListStatus[i] = "Others";
                        break;
                    case 3:
                        PaymentsListStatus[i] = "Temporary";
                        break;
                    case 4:
                        PaymentsListStatus[i] = "Converted";
                        break;
                    default:
                        PaymentsListStatus[i] = "NA";
                        break;
                }

                newRow.Cells[12].Value = PaymentsListStatus[i];




                newRow.Cells[13].Value = PaymentsListTotalPayment[i];
                newRow.Cells[14].Value = PaymentsListOthersTotal[i];
                newRow.Cells[15].Value = PaymentsListRemark[i];

                dgPayments.Rows.Add(newRow);

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


        private void btnPrintPayments_Click(object sender, EventArgs e)
        {
            ////Open the print dialog
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.Document = printDocument1;
            //printDialog.UseEXDialog = true;


            ////Get the document
            //if (DialogResult.OK == printDialog.ShowDialog())
            //{
            //    printDocument1.DocumentName = "Payments";
            //    printDocument1.Print();
            //}

            //Open the print preview dialog
            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = printDocument1;

            objPPdialog.Document.DefaultPageSettings.Landscape = true;
            objPPdialog.Height = 1000;
            objPPdialog.Width = 1000;

            objPPdialog.ShowDialog();

        }


        private void printDocuments_BeginPrint(DataGridView dg)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dg.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //printDocuments_BeginPrint(dgPayments);
            PrintHelper.printDocuments_BeginPrint(dgPayments);
        }

        private void printDocuments_PrintPage(DataGridView dg, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dg.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                        (double)iTotalWidth * (double)iTotalWidth *
                        ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                        GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dg.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dg.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 20;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString($"Payments \n{clientID} - {headerControl1.txtClientFullName}", new Font(dg.Font, FontStyle.Bold),
                            Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                            e.Graphics.MeasureString("Payments", new Font(dg.Font,
                            FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(dg.Font, FontStyle.Bold),
                            Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                            e.Graphics.MeasureString(strDate, new Font(dg.Font,
                            FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                            e.Graphics.MeasureString("Payments", new Font(new Font(dg.Font,
                            FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dg.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight));

                                //e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                //new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                //new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                //(int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                e.Graphics.DrawString(GridCol.HeaderText, printFont,
                                new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                //e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                //new SolidBrush(Cel.InheritedStyle.ForeColor),
                                //new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                //(int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);

                                e.Graphics.DrawString(Cel.Value.ToString(), printFont,
                                new SolidBrush(Cel.InheritedStyle.ForeColor),
                                new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                            iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //printDocuments_PrintPage(dgPayments, e);

            PrintHelper.printDocuments_PrintPage(dgPayments, e, clientID, headerControl1.txtClientFullName);
        }

        private void btnPrintLoans_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = printDocumentLoans;

            objPPdialog.Document.DefaultPageSettings.Landscape = true;
            objPPdialog.Height = 1000;
            objPPdialog.Width = 1000;

            objPPdialog.ShowDialog();
        }

        private void printDocumentLoans_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //printDocuments_BeginPrint(dgLoans);
            PrintHelper.printDocuments_BeginPrint(dgPayments);
        }

        private void printDocumentLoans_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //printDocuments_PrintPage(dgLoans, e);
            PrintHelper.printDocuments_PrintPage(dgLoans, e, clientID, headerControl1.txtClientFullName);
        }


        private void printDocumentcashAdvances_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //printDocuments_BeginPrint(dgLoans);
            PrintHelper.printDocuments_BeginPrint(dgCashAdvances);
        }
        private void printDocumentCashAdvances_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //printDocuments_PrintPage(dgLoans, e);
            PrintHelper.printDocuments_PrintPage(dgCashAdvances, e, clientID, headerControl1.txtClientFullName);
        }

        private void ClientWindow_Load(object sender, EventArgs e)
        {
            dtTo.Value = dtTo.Value.AddDays(1);
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked == false)
            {
                panelDate.Enabled = false;
            }
            else
            {
                panelDate.Enabled = true;
            }
        }

        private void btnPaymentsFilterResults_Click(object sender, EventArgs e)
        {
            if (this.headerControl1.txtID.Text != "")
            {
                dgPayments.Rows.Clear();

                dgPayments.DataSource = null;
                GetPaymentsData_Filtered();
                if (PaymentsListPaymentID.Count > 0)
                {

                    updatePaymentsDatagrid();
                    //btnPrint.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"No Payments Found for this loan");
                    //btnPrint.Enabled = false;
                }
            }
            else
            {
                this.headerControl1.txtID.Focus();
            }
        }

        private void GetPaymentsData_Filtered()
        {
            try
            {
                paymentsLoanID = dgLoans.CurrentRow.Cells[0].Value + string.Empty;

                dbConnection.OpenConnection();

                DateTime dtFrom_ = new DateTime();
                string query;
                dtFrom.CustomFormat = "yyyy-MM-dd";
                dtFrom_ = dtFrom.Value;

                dtTo.Format = DateTimePickerFormat.Custom;
                dtTo.CustomFormat = "yyyy-MM-dd";

                if (chkDate.Checked == true && chkStatus.Checked == true)
                {
                    //query = $"SELECT * FROM payments WHERE LoanId = {paymentsLoanID} AND (PaymentDate BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}') ";
                    query = $"SELECT * FROM payments WHERE LoanId = {paymentsLoanID} AND (PaymentDate BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}') AND Status = {cmbPaymentsStatus.SelectedIndex}";
                }
                else if (chkDate.Checked == true)
                {
                    query = $"SELECT * FROM payments WHERE LoanId = {paymentsLoanID} AND (PaymentDate BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}') ";
                    //query = $"SELECT * FROM payments WHERE LoanId = {paymentsLoanID} AND (PaymentDate BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}') AND Status = {cmbPaymentsStatus.SelectedIndex}";
                }
                else if (chkStatus.Checked == true)
                {
                    query = $"SELECT * FROM payments WHERE LoanId = {paymentsLoanID} AND Status = {cmbPaymentsStatus.SelectedIndex}";
                }
                else
                {
                    query = $"SELECT * FROM payments WHERE LoanId = {paymentsLoanID}";
                }

                //query = $"SELECT * FROM payments WHERE LoanId = {paymentsLoanID}";

                LoadListPaymentsAddRow(query);


                dbConnection.CloseConnection();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStatus.Checked == true)
            {
                cmbPaymentsStatus.Enabled = true;
            }
            else
            {
                cmbPaymentsStatus.Enabled = false;
            }
        }

        private void headerControl1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
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
                    btnPrintCA.Enabled = true;
                    chkCAStatus.Enabled = true;
                    chkCADate.Enabled = true;
                    btnCAFilterResults.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"No CA Found for this loan");
                    btnPrintCA.Enabled = false;
                    chkCAStatus.Enabled = false;
                    chkCADate.Enabled = false;
                    btnCAFilterResults.Enabled = true;
                }
            }
            else
            {
                this.headerControl1.txtID.Focus();
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
                    ClearListCA();

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
                    ClearListCA();
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

        private void btnPrintCA_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = printDocumentCashAdvances;

            objPPdialog.Document.DefaultPageSettings.Landscape = true;
            objPPdialog.Height = 1000;
            objPPdialog.Width = 1000;

            objPPdialog.ShowDialog();
        }

        private void chkCAStatus_CheckedChanged(object sender, EventArgs e)
        {

            cmbCAStatus.Enabled = chkCAStatus.Checked == true ? true : false;
        }

        private void chkCADate_CheckedChanged(object sender, EventArgs e)
        {


            panelCADate.Enabled = chkCADate.Checked == true ? true : false;
        }

        private void btnCAFilterResults_Click(object sender, EventArgs e)
        {
            if (this.headerControl1.txtID.Text != "")
            {
                dgCashAdvances.Rows.Clear();

                dgCashAdvances.DataSource = null;
                GetCAData_Filtered();
                if (CAListCashAdvanceID.Count > 0)
                {

                    updateCADatagrid();
                    //btnPrint.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"No CA Payments Found for this loan");
                    //btnPrint.Enabled = false;
                }
            }
            else
            {
                this.headerControl1.txtID.Focus();
            }
        }

        private void GetCAData_Filtered()
        {
            try
            {
                loanID = dgLoans.CurrentRow.Cells[0].Value + string.Empty;

                dbConnection.OpenConnection();

                //DateTime dtFrom_ = new DateTime();
                string query;
                dtFrom.CustomFormat = "yyyy-MM-dd";
                //dtFrom_ = dtFrom.Value;

                //dtTo.Format = DateTimePickerFormat.Custom;
                dtTo.CustomFormat = "yyyy-MM-dd";


                //string query = $"SELECT * FROM cashadvances INNER JOIN loans on cashadvances.LoanID = loans.LoanID WHERE loans.LoanID = {loanID}";

                if (chkCADate.Checked == true && chkCAStatus.Checked == true)
                {
                    query = $"SELECT * FROM cashadvances INNER JOIN loans on cashadvances.LoanID = loans.LoanID WHERE loans.LoanID = {loanID} AND (DateReceived BETWEEN '{dtCAFrom.Text}' AND '{dtCATo.Text}') AND cashadvances.Status = {cmbCAStatus.SelectedIndex}";
                    //query = $"SELECT * FROM cashadvances INNER JOIN loans on cashadvances.LoanID = loans.LoanID WHERE loans.LoanID = {loanID} AND (DateReceived BETWEEN '{dtCAFrom.Text}' AND '{dtCATo.Text}')";
                }
                else if (chkCADate.Checked == true)
                {
                    query = $"SELECT * FROM cashadvances INNER JOIN loans on cashadvances.LoanID = loans.LoanID WHERE loans.LoanID = {loanID} AND (DateReceived BETWEEN '{dtCAFrom.Text}' AND '{dtCATo.Text}')";
                    //query = $"SELECT * FROM cashadvances INNER JOIN loans on cashadvances.LoanID = loans.LoanID WHERE loans.LoanID = {loanID} AND (DateReceived BETWEEN '{dtCAFrom.Text}' AND '{dtCATo.Text}') AND cashadvances.Status = {cmbCAStatus.SelectedIndex}";
                }
                else if (chkCAStatus.Checked == true)
                {
                    query = $"SELECT * FROM cashadvances INNER JOIN loans on cashadvances.LoanID = loans.LoanID WHERE loans.LoanID = {loanID} AND cashadvances.Status = {cmbCAStatus.SelectedIndex}";
                }
                else
                {
                    query = $"SELECT * FROM cashadvances INNER JOIN loans on cashadvances.LoanID = loans.LoanID WHERE loans.LoanID = {loanID}";
                }

                //query = $"SELECT * FROM payments WHERE LoanId = {paymentsLoanID}";

                LoadListCAAddRow(query);



                dbConnection.CloseConnection();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void LoadListCAAddRow(string qry)
        {

            MySqlDataReader row;
            row = dbConnection.ExecuteReader(qry);
            if (row.HasRows)
            {
                ClearListCA();
                while (row.Read())
                {

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
                ClearListCA();
            }
        }

        private void ClearListCA()
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
        }



        private void dgCashAdvances_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            
        }

        private void dgCashAdvances_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CAPaymentsTransactionWindow caPaymentsTransactionWindow = new CAPaymentsTransactionWindow();
            caPaymentsTransactionWindow.TopLevel = true;
            caPaymentsTransactionWindow.AutoScroll = true;
            //MainWindow.panel1.Controls.Add(caPaymentsTransactionWindow);

            //ViewClients client = App.Container.Resolve<ViewClients>();
            //client.ClientDTO = SelectedClient;

            //var tab = MainWindow.tabFactory.GetTabItem("ViewClients");
            //client.ScreenMode = ScreenMode.Edit;
            //main.AddTab(tab);
            //tab.Header = "Edit Client - " + SelectedClient.ClientID;
            //tab.Focus();


            caPaymentsTransactionWindow.Text = "CA Payments - " + headerControl1.txtClientFullName + " - " + dgCashAdvances.CurrentRow.Cells[0].Value;
            caPaymentsTransactionWindow.txtClientFullName.Text = headerControl1.txtClientFullName;
            caPaymentsTransactionWindow.txtClientID.Text = headerControl1.txtID.Text;
            caPaymentsTransactionWindow.txtCashAdvancedID.Text = (string)dgCashAdvances.CurrentRow.Cells[0].Value;
            caPaymentsTransactionWindow.Show();
            caPaymentsTransactionWindow.BringToFront();
            caPaymentsTransactionWindow.Focus();

            //MessageBox.Show("Andito");
        }

        private void btnShowOthers_Click(object sender, EventArgs e)
        {
            if (this.headerControl1.txtID.Text != "")
            {
                dgOthers.Rows.Clear();

                dgOthers.DataSource = null;
                GetOthersData();
                if (OthersListOtherID.Count > 0)
                {

                    updateOthersDatagrid();
                    btnPrintOthers.Enabled = true;
                    chkOthersDate.Enabled = true;
                    btnOthersFilterResults.Enabled = true;
                    //chkCAStatus.Enabled = true;
                    //chkCADate.Enabled = true;
                    //btnCAFilterResults.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"No Others Found for this loan");
                    btnPrintOthers.Enabled = false;
                    chkOthersDate.Checked = false;
                    btnOthersFilterResults.Enabled = false;
                    //chkCAStatus.Enabled = false;
                    //chkCADate.Enabled = false;
                    //btnCAFilterResults.Enabled = true;
                }
            }
            else
            {
                this.headerControl1.txtID.Focus();
            }
        }

        private void updateOthersDatagrid()
        {
            dgOthers.Rows.Clear();
            dgOthers.DataSource = null;
            //dataGridView1.Columns.Clear();

            for (int i = 0; i < OthersListOtherID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgOthers);
                newRow.Cells[0].Value = OthersListOtherID[i];
                newRow.Cells[1].Value = OthersListLoanID[i];
                newRow.Cells[2].Value = OthersListDate[i];
                newRow.Cells[3].Value = OthersListAmount[i];
                newRow.Cells[4].Value = OthersListDescription[i];
                newRow.Cells[5].Value = OthersListBalance[i];
                
                
                //newRow.Cells[9].Value = CAListStatus[i];

                int type = Int32.Parse((string)OthersListStatus[i]);

                switch (type)
                {
                    case 0:
                        OthersListStatus[i] = "Paid";
                        break;
                    case 1:
                        OthersListStatus[i] = "Partial";
                        break;
                    case 2:
                        OthersListStatus[i] = "Unpaid";
                        break;
                    default:
                        OthersListStatus[i] = "NA";
                        break;
                }

                newRow.Cells[6].Value = OthersListStatus[i];


                int type1 = Int32.Parse((string)OthersListOtherType[i]);
                switch (type1)
                {
                    case 0:
                        OthersListOtherType[i] = "Charge";
                        break;
                    case 1:
                        OthersListOtherType[i] = "Rice";
                        break;
                    case 2:
                        OthersListOtherType[i] = "Goods";
                        break;
                    default:
                        OthersListStatus[i] = "NA";
                        break;
                }


                newRow.Cells[7].Value = OthersListOtherType[i];

                dgOthers.Rows.Add(newRow);
            }
        }

        private void GetOthersData()
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
                //string query = $"SELECT * FROM cashadvances INNER JOIN loans on cashadvances.LoanID = loans.LoanID WHERE loans.LoanID = {loanID}";
                string query = $"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID WHERE loans.loanId = {loanID}";

                //MySqlDataReader row;  
                MySqlDataReader row;
                row = dbConnection.ExecuteReader(query);
                if (row.HasRows)
                {
                    //ClearListCA();
                    ClearListOthers();

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




                        OthersListOtherID.Add(row["OtherID"].ToString());
                        OthersListLoanID.Add(row["LoanID"].ToString());
                        OthersListDate.Add(row["Date"].ToString());
                        OthersListAmount.Add(row["Amount"].ToString());
                        OthersListDescription.Add(row["Description"].ToString());
                        OthersListBalance.Add(row["Balance"].ToString());
                        OthersListStatus.Add(row["Status"].ToString());
                        OthersListOtherType.Add(row["OtherType"].ToString());

                    }
                }
                else
                {
                    ClearListOthers();
                    // MessageBox.Show("Data not found");
                }

                dbConnection.CloseConnection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void ClearListOthers()
        {
            OthersListOtherID.Clear();
            OthersListLoanID.Clear();
            OthersListDate.Clear();
            OthersListAmount.Clear();
            OthersListDescription.Clear();
            OthersListBalance.Clear();
            OthersListStatus.Clear();
            OthersListOtherType.Clear();
        }

        private void printDocumentOthers_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            PrintHelper.printDocuments_BeginPrint(dgOthers);
        }

        private void printDocumentOthers_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintHelper.printDocuments_PrintPage(dgOthers, e, clientID, headerControl1.txtClientFullName);
        }

        private void btnPrintOthers_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = printDocumentOthers;

            objPPdialog.Document.DefaultPageSettings.Landscape = true;
            objPPdialog.Height = 1000;
            objPPdialog.Width = 1000;

            objPPdialog.ShowDialog();
        }

        private void btnOthersFilterResults_Click(object sender, EventArgs e)
        {
            if (this.headerControl1.txtID.Text != "")
            {
                dgOthers.Rows.Clear();

                dgOthers.DataSource = null;
                GetOthersData_Filtered();
                if (OthersListOtherID.Count > 0)
                {

                    updateOthersDatagrid_Filtered();
                    btnPrintOthers.Enabled = true;
                    //chkCAStatus.Enabled = true;
                    //chkCADate.Enabled = true;
                    //btnCAFilterResults.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"No Others Found for this loan");
                    btnPrintOthers.Enabled = false;
                    //chkCAStatus.Enabled = false;
                    //chkCADate.Enabled = false;
                    //btnCAFilterResults.Enabled = true;
                }
            }
            else
            {
                this.headerControl1.txtID.Focus();
            }
        }

        private void updateOthersDatagrid_Filtered()
        {
            dgOthers.Rows.Clear();
            dgOthers.DataSource = null;
            //dataGridView1.Columns.Clear();

            for (int i = 0; i < OthersListOtherID.Count; i++)
            {

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgOthers);
                 newRow.Cells[0].Value = OthersListOtherID[i];
                newRow.Cells[1].Value = OthersListLoanID[i];
                newRow.Cells[2].Value = OthersListDate[i];
                newRow.Cells[3].Value = OthersListAmount[i];
                newRow.Cells[4].Value = OthersListDescription[i];
                newRow.Cells[5].Value = OthersListBalance[i];
                newRow.Cells[6].Value = OthersListStatus[i];
                newRow.Cells[7].Value = OthersListOtherType[i];
               

                //int type = Int32.Parse((string)CAListStatus[i]);

                //switch (type)
                //{
                //    case 0:
                //        CAListStatus[i] = "New";
                //        break;
                //    case 1:
                //        CAListStatus[i] = "Partial";
                //        break;
                //    case 2:
                //        CAListStatus[i] = "Paid";
                //        break;
                //    default:
                //        CAListStatus[i] = "NA";
                //        break;
                //}

                //newRow.Cells[9].Value = CAListStatus[i];

                dgOthers.Rows.Add(newRow);
            }
        }

        private void GetOthersData_Filtered()
        {
            try
            {
                loanID = dgLoans.CurrentRow.Cells[0].Value + string.Empty;

                dbConnection.OpenConnection();

                //DateTime dtFrom_ = new DateTime();
                string query;
                dtFrom.CustomFormat = "yyyy-MM-dd";
                //dtFrom_ = dtFrom.Value;

                //dtTo.Format = DateTimePickerFormat.Custom;
                dtTo.CustomFormat = "yyyy-MM-dd";


                //string query = $"SELECT * FROM cashadvances INNER JOIN loans on cashadvances.LoanID = loans.LoanID WHERE loans.LoanID = {loanID}";

               if (chkOthersDate.Checked == true)
                {
                    //query = $"SELECT * FROM cashadvances INNER JOIN loans on cashadvances.LoanID = loans.LoanID WHERE loans.LoanID = {loanID} AND (DateReceived BETWEEN '{dtCAFrom.Text}' AND '{dtCATo.Text}')";
                    //query = $"SELECT * FROM cashadvances INNER JOIN loans on cashadvances.LoanID = loans.LoanID WHERE loans.LoanID = {loanID} AND (DateReceived BETWEEN '{dtCAFrom.Text}' AND '{dtCATo.Text}') AND cashadvances.Status = {cmbCAStatus.SelectedIndex}";
                    query = $"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID WHERE loans.loanID = {loanID} and (other.Date BETWEEN '{dtOthersFrom.Text}' AND '{dtOthersTo.Text}')";
                }
                else
                {
                    query = $"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID WHERE loans.loanID = {loanID}";
                }

                //query = $"SELECT * FROM payments WHERE LoanId = {paymentsLoanID}";

                LoadListOtherAddRow(query);



                dbConnection.CloseConnection();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void LoadListOtherAddRow(string qry)
        {
            MySqlDataReader row;
            row = dbConnection.ExecuteReader(qry);
            if (row.HasRows)
            {
                ClearListOthers();
                while (row.Read())
                {

                    OthersListOtherID.Add(row["OtherID"].ToString());
                    OthersListLoanID.Add(row["LoanID"].ToString());
                    OthersListDate.Add(row["Date"].ToString());
                    OthersListAmount.Add(row["Amount"].ToString());
                    OthersListDescription.Add(row["Description"].ToString());
                    OthersListBalance.Add(row["Balance"].ToString());
                    OthersListStatus.Add(row["Status"].ToString());
                    OthersListOtherType.Add(row["OtherType"].ToString());
                }
            }
            else
            {
                ClearListOthers();
            }
        }

        private void chkOthersDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOthersDate.Checked == true)
            {
                panelOthersDate.Enabled = true;
            }
        }
    }
}
