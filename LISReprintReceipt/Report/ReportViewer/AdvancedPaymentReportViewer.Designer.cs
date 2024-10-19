namespace LISReprintReceipt.Report.ReportViewer
{
    partial class AdvancedPaymentReportViewer
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
            this.advancedpaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new LISReprintReceipt.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advancedpaymentsTableAdapter = new LISReprintReceipt.DataSet1TableAdapters.advancedpaymentsTableAdapter();
            this.advancePaymentSSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.advancedpaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancePaymentSSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // advancedpaymentsBindingSource
            // 
            this.advancedpaymentsBindingSource.DataMember = "advancedpayments";
            this.advancedpaymentsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "AdvancedPaymentDS";
            reportDataSource1.Value = this.advancedpaymentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LISReprintReceipt.Report.RDLC.AdvancedPaymentReceipt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(280, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // advancedpaymentsTableAdapter
            // 
            this.advancedpaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // advancePaymentSSBindingSource
            // 
            this.advancePaymentSSBindingSource.DataSource = typeof(LISReprintReceipt.Report.ReportEntities.AdvancePaymentSS);
            // 
            // AdvancedPaymentReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 499);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AdvancedPaymentReportViewer";
            this.ShowIcon = false;
            this.Text = "Advanced Payment Receipt";
            this.Load += new System.EventHandler(this.AdvancedPaymentReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedpaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancePaymentSSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource advancePaymentSSBindingSource;
        private System.Windows.Forms.BindingSource advancedpaymentsBindingSource;
        private DataSet1TableAdapters.advancedpaymentsTableAdapter advancedpaymentsTableAdapter;
    }
}