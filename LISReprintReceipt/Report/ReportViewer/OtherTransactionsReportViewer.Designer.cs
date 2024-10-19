namespace LISReprintReceipt.Report.ReportViewer
{
    partial class OtherTransactionsReportViewer
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
            this.othersDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.othersDS = new LISReprintReceipt.DataSet.OthersDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.othersDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.othersDS)).BeginInit();
            this.SuspendLayout();
            // 
            // othersDSBindingSource
            // 
            this.othersDSBindingSource.DataSource = this.othersDS;
            this.othersDSBindingSource.Position = 0;
            // 
            // othersDS
            // 
            this.othersDS.DataSetName = "OthersDS";
            this.othersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Others";
            reportDataSource1.Value = this.othersDSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LISReprintReceipt.Report.RDLC.OthersTransactionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 644);
            this.reportViewer1.TabIndex = 0;
            // 
            // OtherTransactionsReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 644);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OtherTransactionsReportViewer";
            this.ShowIcon = false;
            this.Text = "Others Transaction Report";
            this.Load += new System.EventHandler(this.OtherTransactionsReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.othersDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.othersDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource othersDSBindingSource;
        private DataSet.OthersDS othersDS;
    }
}