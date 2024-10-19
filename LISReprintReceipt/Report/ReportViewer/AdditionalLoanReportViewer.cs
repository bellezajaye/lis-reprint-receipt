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
    public partial class AdditionalLoanReportViewer : Form
    {
        public AdditionalLoanSS additionalLoanSS { get; set; }
        public AdditionalLoanReportViewer()
        {
            InitializeComponent();
        }

        private void AdditionalLoanReportViewer_Load(object sender, EventArgs e)
        {
            additionalLoanSSBindingSource.DataSource = additionalLoanSS;
            this.reportViewer1.RefreshReport();
        }
    }
}
