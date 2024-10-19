using LISReprintReceipt.Report.ReportEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISReprintReceipt.Report.ReportViewer
{
    public partial class OthersReportViewer : Form
    {

        public OtherSS otherss { get; set; }
        public OthersReportViewer()
        {
            InitializeComponent();
        }

        private void OthersReportViewer_Load(object sender, EventArgs e)
        {
            otherBindingSource.DataSource = otherss;
            this.reportViewer1.RefreshReport();
        }
    }
}
