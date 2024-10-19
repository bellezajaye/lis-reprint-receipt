namespace LISReprintReceipt.Report.ReportViewer
{
    partial class CashAdvanceReportViewer
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cashAdvanceSSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cashAdvanceSSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "CashAdvanceDS";
            reportDataSource1.Value = this.cashAdvanceSSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LISReprintReceipt.Report.RDLC.CashAdvanceReceipt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(291, 485);
            this.reportViewer1.TabIndex = 0;
            // 
            // cashAdvanceSSBindingSource
            // 
            this.cashAdvanceSSBindingSource.DataSource = typeof(LISReprintReceipt.Report.ReportEntities.CashAdvanceSS);
            // 
            // CashAdvanceReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 499);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CashAdvanceReportViewer";
            this.ShowIcon = false;
            this.Text = "Cash Advance Receipt";
            this.Load += new System.EventHandler(this.CashAdvanceReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashAdvanceSSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cashAdvanceSSBindingSource;
    }
}