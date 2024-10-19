using LISReprintReceipt.UserControl;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISReprintReceipt
{
    public static class PrintHelper
    {
        static StringFormat strFormat; //Used to format the grid rows.
        static ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        static ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        static int iCellHeight = 0; //Used to get/set the datagridview cell height
        static int iTotalWidth = 0; //
        static int iRow = 0;//Used as counter
        static bool bFirstPage = false; //Used to check whether we are printing first page
        static bool bNewPage = false;// Used to check whether we are printing a new page
        static int iHeaderHeight = 0; //Used for the header height
        static Font printFont = new Font("Arial", 7);

        public static void printDocuments_BeginPrint(DataGridView dg)
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


        public static void  printDocuments_PrintPage(DataGridView dg, System.Drawing.Printing.PrintPageEventArgs e, string cID, string cFullName)
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
                            e.Graphics.DrawString($"Payments \n{cID} - {cFullName}", new Font(dg.Font, FontStyle.Bold),
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
    }
}
