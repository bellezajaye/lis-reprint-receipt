namespace LISReprintReceipt.Report.ReportViewer
{
    partial class AdditionalLoanReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.additionalLoanSSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.additionalLoanSSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.additionalLoanSSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalLoanSSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // additionalLoanSSBindingSource
            // 
            this.additionalLoanSSBindingSource.DataSource = typeof(LISReprintReceipt.Report.ReportEntities.AdditionalLoanSS);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "AdditionalLoanDS";
            reportDataSource1.Value = this.additionalLoanSSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LISReprintReceipt.Report.RDLC.AdditionalLoan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(280, 503);
            this.reportViewer1.TabIndex = 0;
            // 
            // additionalLoanSSBindingSource1
            // 
            this.additionalLoanSSBindingSource1.DataSource = typeof(LISReprintReceipt.Report.ReportEntities.AdditionalLoanSS);
            // 
            // AdditionalLoanReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AdditionalLoanReportViewer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Additional Loan Receipt";
            this.Load += new System.EventHandler(this.AdditionalLoanReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.additionalLoanSSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalLoanSSBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource additionalLoanSSBindingSource;
        private System.Windows.Forms.BindingSource additionalLoanSSBindingSource1;
    }
}