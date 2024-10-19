using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using LISReprintReceipt.WindowForms;
using LISReprintReceipt.UserControl;
using Org.BouncyCastle.Asn1.Crmf;


namespace LISReprintReceipt.Report.ReportViewer
{
    public partial class OtherTransactionsReportViewer : Form
    {

        DbConnection dbConnection = new DbConnection();

        public OtherTransactionsReportViewer()
        {
            InitializeComponent();
        }

        private void OtherTransactionsReportViewer_Load(object sender, EventArgs e)
        {
            //OthersDS dsOthers =  GetData();
            //ReportDataSource datasource = new ReportDataSource("Others", dsOthers.Tables[0]);
            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(datasource);
            //this.reportViewer1.RefreshReport();
        }

        //private OthersDS GetData()
        //{


        //    //OthersWindow oWindow = new OthersWindow();

        //    //int cID = int.Parse(oWindow.headerControl2.txtIDValue);
            
            

        //    //string constr = @"server=localhost;user=root;password=root;database=lendingdb";
        //    ////using (SqlConnection con = new SqlConnection(constr))
        //    //using (MySqlConnection con = new MySqlConnection(constr))
        //    //{
        //    //    //using (SqlCommand cmd = new SqlCommand("SELECT TOP 20 * FROM customers"))
        //    //    using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID}"))
        //    //    //using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM other INNER JOIN loans ON other.LoanID = loans.LoanID INNER JOIN clients ON loans.ClientID = clients.ClientID WHERE clients.ClientID = {cID} AND (Date BETWEEN '{dtFrom.Text}' AND '{dtTo.Text}')"))
        //    //    //using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM other WHERE LoanID = 696"))
        //    //    {
        //    //        //using (SqlDataAdapter sda = new SqlDataAdapter())
        //    //        using (MySqlDataAdapter sda = new MySqlDataAdapter())
        //    //        {
        //    //            cmd.Connection = con;
        //    //            sda.SelectCommand = cmd;
        //    //            //using (Customers dsCustomers = new Customers())
        //    //            using (OthersDS dsOthers = new OthersDS())
        //    //            {
        //    //                //sda.Fill(dsCustomers, "DataTable1");
        //    //                sda.Fill(dsOthers, "DataTable1");
        //    //                //return dsCustomers;
        //    //                return dsOthers;
        //    //            }
        //    //        }
        //    //    }
        //    }
        // }
    }
}
