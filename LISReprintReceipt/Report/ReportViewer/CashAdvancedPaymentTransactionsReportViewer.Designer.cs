namespace LISReprintReceipt.Report.ReportViewer
{
    partial class CashAdvancedPaymentTransactionsReportViewer
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
            this.cashAdvancedPaymentsDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashAdvancedPaymentsDS = new LISReprintReceipt.DataSet.CashAdvancedPaymentsDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CashAdvancedPaymentDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cashAdvancedPaymentsDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashAdvancedPaymentsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashAdvancedPaymentDTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cashAdvancedPaymentsDSBindingSource
            // 
            this.cashAdvancedPaymentsDSBindingSource.DataSource = this.cashAdvancedPaymentsDS;
            this.cashAdvancedPaymentsDSBindingSource.Position = 0;
            // 
            // cashAdvancedPaymentsDS
            // 
            this.cashAdvancedPaymentsDS.DataSetName = "CashAdvancedPaymentsDS";
            this.cashAdvancedPaymentsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CashAdvancedPaymentsDS";
            reportDataSource1.Value = this.cashAdvancedPaymentsDSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LISReprintReceipt.Report.RDLC.CashAdvancedPaymentTransactionsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // CashAdvancedPaymentDTBindingSource
            // 
            this.CashAdvancedPaymentDTBindingSource.DataMember = "CashAdvancedPaymentDT";
            this.CashAdvancedPaymentDTBindingSource.DataSource = this.cashAdvancedPaymentsDS;
            // 
            // CashAdvancedPaymentTransactionsReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CashAdvancedPaymentTransactionsReportViewer";
            this.ShowIcon = false;
            this.Text = "Cash Advanced Payment Transaction Report";
            this.Load += new System.EventHandler(this.CashAdvancedPaymentTransactionsReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashAdvancedPaymentsDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashAdvancedPaymentsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashAdvancedPaymentDTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cashAdvancedPaymentsDSBindingSource;
        private DataSet.CashAdvancedPaymentsDS cashAdvancedPaymentsDS;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CashAdvancedPaymentDTBindingSource;
    }
}