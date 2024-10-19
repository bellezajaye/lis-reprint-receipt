namespace LISReprintReceipt.Report.ReportViewer
{
    partial class OthersReportViewer
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
            this.otherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new LISReprintReceipt.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.otherTableAdapter = new LISReprintReceipt.DataSet1TableAdapters.otherTableAdapter();
            this.advancePaymentSSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otherSSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.otherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancePaymentSSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherSSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // otherBindingSource
            // 
            this.otherBindingSource.DataMember = "other";
            this.otherBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "OtherDS";
            reportDataSource1.Value = this.otherBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LISReprintReceipt.Report.RDLC.OthersReceipt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(284, 482);
            this.reportViewer1.TabIndex = 0;
            // 
            // otherTableAdapter
            // 
            this.otherTableAdapter.ClearBeforeFill = true;
            // 
            // advancePaymentSSBindingSource
            // 
            this.advancePaymentSSBindingSource.DataSource = typeof(LISReprintReceipt.Report.ReportEntities.AdvancePaymentSS);
            // 
            // otherSSBindingSource
            // 
            this.otherSSBindingSource.DataSource = typeof(LISReprintReceipt.Report.ReportEntities.OtherSS);
            // 
            // otherBindingSource1
            // 
            this.otherBindingSource1.DataMember = "other";
            this.otherBindingSource1.DataSource = this.dataSet1;
            // 
            // OthersReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 499);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OthersReportViewer";
            this.ShowIcon = false;
            this.Text = "Others Receipt";
            this.Load += new System.EventHandler(this.OthersReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancePaymentSSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherSSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        //private System.Windows.Forms.BindingSource OtherSSBindingSource;
        //private System.Windows.Forms.BindingSource otherBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource otherBindingSource;
        private DataSet1TableAdapters.otherTableAdapter otherTableAdapter;
        private System.Windows.Forms.BindingSource advancePaymentSSBindingSource;
        private System.Windows.Forms.BindingSource otherSSBindingSource;
        private System.Windows.Forms.BindingSource otherBindingSource1;
    }
}