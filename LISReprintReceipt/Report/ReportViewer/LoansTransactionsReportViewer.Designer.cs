namespace LISReprintReceipt.Report.ReportViewer
{
    partial class LoansTransactionsReportViewer
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
            this.loansTransactionsDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loansTransactionsDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loansTransactionsDS = new LISReprintReceipt.DataSet.LoansTransactionsDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.loansTransactionsDSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loansTransactionsDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansTransactionsDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansTransactionsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansTransactionsDSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // loansTransactionsDTBindingSource
            // 
            this.loansTransactionsDTBindingSource.DataMember = "LoansTransactionsDT";
            this.loansTransactionsDTBindingSource.DataSource = this.loansTransactionsDSBindingSource;
            // 
            // loansTransactionsDSBindingSource
            // 
            this.loansTransactionsDSBindingSource.DataSource = this.loansTransactionsDS;
            this.loansTransactionsDSBindingSource.Position = 0;
            // 
            // loansTransactionsDS
            // 
            this.loansTransactionsDS.DataSetName = "LoansTransactionsDS";
            this.loansTransactionsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Loans";
            reportDataSource1.Value = this.loansTransactionsDTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LISReprintReceipt.Report.RDLC.LoansTransactionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // loansTransactionsDSBindingSource1
            // 
            this.loansTransactionsDSBindingSource1.DataSource = this.loansTransactionsDS;
            this.loansTransactionsDSBindingSource1.Position = 0;
            // 
            // LoansTransactionsReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LoansTransactionsReportViewer";
            this.ShowIcon = false;
            this.Text = "Loans Transaction Report";
            this.Load += new System.EventHandler(this.LoansTransactionsReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loansTransactionsDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansTransactionsDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansTransactionsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansTransactionsDSBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource loansTransactionsDSBindingSource;
        private DataSet.LoansTransactionsDS loansTransactionsDS;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource loansTransactionsDTBindingSource;
        private System.Windows.Forms.BindingSource loansTransactionsDSBindingSource1;
    }
}