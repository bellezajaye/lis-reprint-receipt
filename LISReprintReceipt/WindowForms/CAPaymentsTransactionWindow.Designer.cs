namespace LISReprintReceipt.WindowForms
{
    partial class CAPaymentsTransactionWindow
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
            this.lblClientFullName = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblCashAdvancedId = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtClientFullName = new System.Windows.Forms.TextBox();
            this.txtCashAdvancedID = new System.Windows.Forms.TextBox();
            this.dgCAPayments = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowCAPayments = new System.Windows.Forms.Button();
            this.btnPrintCAPayments = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgCAPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientFullName
            // 
            this.lblClientFullName.AutoSize = true;
            this.lblClientFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientFullName.Location = new System.Drawing.Point(13, 59);
            this.lblClientFullName.Name = "lblClientFullName";
            this.lblClientFullName.Size = new System.Drawing.Size(99, 20);
            this.lblClientFullName.TabIndex = 0;
            this.lblClientFullName.Text = "Client Name:";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(13, 24);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(74, 20);
            this.lblClientID.TabIndex = 1;
            this.lblClientID.Text = "Client ID:";
            // 
            // lblCashAdvancedId
            // 
            this.lblCashAdvancedId.AutoSize = true;
            this.lblCashAdvancedId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashAdvancedId.Location = new System.Drawing.Point(13, 94);
            this.lblCashAdvancedId.Name = "lblCashAdvancedId";
            this.lblCashAdvancedId.Size = new System.Drawing.Size(142, 20);
            this.lblCashAdvancedId.TabIndex = 2;
            this.lblCashAdvancedId.Text = "Cash Advanced ID";
            // 
            // txtClientID
            // 
            this.txtClientID.Enabled = false;
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(161, 18);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(177, 26);
            this.txtClientID.TabIndex = 4;
            // 
            // txtClientFullName
            // 
            this.txtClientFullName.Enabled = false;
            this.txtClientFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientFullName.Location = new System.Drawing.Point(161, 53);
            this.txtClientFullName.Name = "txtClientFullName";
            this.txtClientFullName.Size = new System.Drawing.Size(177, 26);
            this.txtClientFullName.TabIndex = 5;
            // 
            // txtCashAdvancedID
            // 
            this.txtCashAdvancedID.Enabled = false;
            this.txtCashAdvancedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashAdvancedID.Location = new System.Drawing.Point(161, 88);
            this.txtCashAdvancedID.Name = "txtCashAdvancedID";
            this.txtCashAdvancedID.Size = new System.Drawing.Size(177, 26);
            this.txtCashAdvancedID.TabIndex = 6;
            // 
            // dgCAPayments
            // 
            this.dgCAPayments.AllowUserToAddRows = false;
            this.dgCAPayments.AllowUserToDeleteRows = false;
            this.dgCAPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCAPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgCAPayments.Location = new System.Drawing.Point(12, 202);
            this.dgCAPayments.Name = "dgCAPayments";
            this.dgCAPayments.Size = new System.Drawing.Size(884, 340);
            this.dgCAPayments.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cash Advance ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount Paid";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "New Balance";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Received";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Due Date";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Note";
            this.Column8.Name = "Column8";
            // 
            // btnShowCAPayments
            // 
            this.btnShowCAPayments.Location = new System.Drawing.Point(12, 145);
            this.btnShowCAPayments.Name = "btnShowCAPayments";
            this.btnShowCAPayments.Size = new System.Drawing.Size(222, 51);
            this.btnShowCAPayments.TabIndex = 8;
            this.btnShowCAPayments.Text = "Show CA Payments";
            this.btnShowCAPayments.UseVisualStyleBackColor = true;
            this.btnShowCAPayments.Click += new System.EventHandler(this.btnShowCAPayments_Click);
            // 
            // btnPrintCAPayments
            // 
            this.btnPrintCAPayments.Location = new System.Drawing.Point(674, 145);
            this.btnPrintCAPayments.Name = "btnPrintCAPayments";
            this.btnPrintCAPayments.Size = new System.Drawing.Size(222, 51);
            this.btnPrintCAPayments.TabIndex = 9;
            this.btnPrintCAPayments.Text = "Print CA Payments";
            this.btnPrintCAPayments.UseVisualStyleBackColor = true;
            this.btnPrintCAPayments.Click += new System.EventHandler(this.btnPrintCAPayments_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint_1);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // CAPaymentsTransactionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 554);
            this.Controls.Add(this.btnPrintCAPayments);
            this.Controls.Add(this.btnShowCAPayments);
            this.Controls.Add(this.dgCAPayments);
            this.Controls.Add(this.txtCashAdvancedID);
            this.Controls.Add(this.txtClientFullName);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.lblCashAdvancedId);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblClientFullName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CAPaymentsTransactionWindow";
            this.ShowIcon = false;
            this.Text = "CA Payments";
            this.Load += new System.EventHandler(this.CAPaymentsTransactionWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCAPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblClientFullName;
        public System.Windows.Forms.Label lblClientID;
        public System.Windows.Forms.Label lblCashAdvancedId;
        public System.Windows.Forms.TextBox txtClientID;
        public System.Windows.Forms.TextBox txtClientFullName;
        public System.Windows.Forms.TextBox txtCashAdvancedID;
        private System.Windows.Forms.DataGridView dgCAPayments;
        private System.Windows.Forms.Button btnShowCAPayments;
        private System.Windows.Forms.Button btnPrintCAPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}