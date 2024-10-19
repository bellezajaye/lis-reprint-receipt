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
    public partial class AdvancedPaymentReportViewer : Form
    {
        public AdvancePaymentSS advancePaymentSS { get; set; }

        public AdvancedPaymentReportViewer()
        {
            InitializeComponent();
        }

        private void AdvancedPaymentReportViewer_Load(object sender, EventArgs e)
        {

            advancedpaymentsBindingSource.DataSource = advancePaymentSS;
            this.reportViewer1.RefreshReport();
        }
    }
}
