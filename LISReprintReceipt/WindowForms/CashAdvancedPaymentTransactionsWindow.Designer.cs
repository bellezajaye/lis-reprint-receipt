namespace LISReprintReceipt.WindowForms
{
    partial class CashAdvancedPaymentTransactionsWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShowLoans = new System.Windows.Forms.Button();
            this.dgCashAdvances = new System.Windows.Forms.DataGridView();
            this.dgLoans = new System.Windows.Forms.DataGridView();
            this.btnShowCA = new System.Windows.Forms.Button();
            this.headerControl1 = new LISReprintReceipt.UserControl.HeaderControl();
            this.colCashAdvanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModeOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterestRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodicPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapitalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCashAdvances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "From:";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "yyyy-MM-dd";
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(318, 216);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(112, 22);
            this.dtTo.TabIndex = 36;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "yyyy-MM-dd";
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(169, 217);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(112, 22);
            this.dtFrom.TabIndex = 35;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(445, 214);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnShowLoans
            // 
            this.btnShowLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLoans.Location = new System.Drawing.Point(12, 207);
            this.btnShowLoans.Name = "btnShowLoans";
            this.btnShowLoans.Size = new System.Drawing.Size(103, 40);
            this.btnShowLoans.TabIndex = 40;
            this.btnShowLoans.Text = "Show Loans";
            this.btnShowLoans.UseVisualStyleBackColor = true;
            this.btnShowLoans.Click += new System.EventHandler(this.btnShowLoans_Click);
            // 
            // dgCashAdvances
            // 
            this.dgCashAdvances.AllowUserToAddRows = false;
            this.dgCashAdvances.AllowUserToDeleteRows = false;
            this.dgCashAdvances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCashAdvances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCashAdvances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCashAdvanceID,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgCashAdvances.Location = new System.Drawing.Point(12, 598);
            this.dgCashAdvances.Name = "dgCashAdvances";
            this.dgCashAdvances.ReadOnly = true;
            this.dgCashAdvances.Size = new System.Drawing.Size(662, 254);
            this.dgCashAdvances.TabIndex = 43;
            // 
            // dgLoans
            // 
            this.dgLoans.AllowUserToAddRows = false;
            this.dgLoans.AllowUserToDeleteRows = false;
            this.dgLoans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLoanID,
            this.colClientID,
            this.colLoanType,
            this.colModeOfPayment,
            this.colAmount,
            this.colTerms,
            this.colInterestRate,
            this.colInterestAmount,
            this.colPeriodicPayment,
            this.colStartDate,
            this.colEndDate,
            this.colStatus,
            this.colBalance,
            this.colCapitalAmount});
            this.dgLoans.Location = new System.Drawing.Point(12, 265);
            this.dgLoans.Name = "dgLoans";
            this.dgLoans.ReadOnly = true;
            this.dgLoans.Size = new System.Drawing.Size(660, 256);
            this.dgLoans.TabIndex = 44;
            // 
            // btnShowCA
            // 
            this.btnShowCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCA.Location = new System.Drawing.Point(12, 540);
            this.btnShowCA.Name = "btnShowCA";
            this.btnShowCA.Size = new System.Drawing.Size(103, 40);
            this.btnShowCA.TabIndex = 45;
            this.btnShowCA.Text = "Show CA";
            this.btnShowCA.UseVisualStyleBackColor = true;
            this.btnShowCA.Click += new System.EventHandler(this.btnShowCA_Click);
            // 
            // headerControl1
            // 
            this.headerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerControl1.AutoSize = true;
            this.headerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerControl1.Location = new System.Drawing.Point(12, 12);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(663, 175);
            this.headerControl1.TabIndex = 34;
            // 
            // colCashAdvanceID
            // 
            this.colCashAdvanceID.HeaderText = "CA ID";
            this.colCashAdvanceID.Name = "colCashAdvanceID";
            this.colCashAdvanceID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Loan ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Terms";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Interest Rate";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Interest Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total Amount";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Balance";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Date Received";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Status";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Note";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // colLoanID
            // 
            this.colLoanID.HeaderText = "Loan ID";
            this.colLoanID.Name = "colLoanID";
            this.colLoanID.ReadOnly = true;
            // 
            // colClientID
            // 
            this.colClientID.HeaderText = "Client ID";
            this.colClientID.Name = "colClientID";
            this.colClientID.ReadOnly = true;
            // 
            // colLoanType
            // 
            this.colLoanType.HeaderText = "Loan Type";
            this.colLoanType.Name = "colLoanType";
            this.colLoanType.ReadOnly = true;
            // 
            // colModeOfPayment
            // 
            this.colModeOfPayment.HeaderText = "Mode Of Payment";
            this.colModeOfPayment.Name = "colModeOfPayment";
            this.colModeOfPayment.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colTerms
            // 
            this.colTerms.HeaderText = "Terms";
            this.colTerms.Name = "colTerms";
            this.colTerms.ReadOnly = true;
            // 
            // colInterestRate
            // 
            this.colInterestRate.HeaderText = "Interest Rate";
            this.colInterestRate.Name = "colInterestRate";
            this.colInterestRate.ReadOnly = true;
            // 
            // colInterestAmount
            // 
            this.colInterestAmount.HeaderText = "Interest Amount";
            this.colInterestAmount.Name = "colInterestAmount";
            this.colInterestAmount.ReadOnly = true;
            // 
            // colPeriodicPayment
            // 
            this.colPeriodicPayment.HeaderText = "Periodic Payment";
            this.colPeriodicPayment.Name = "colPeriodicPayment";
            this.colPeriodicPayment.ReadOnly = true;
            // 
            // colStartDate
            // 
            this.colStartDate.HeaderText = "Start Date";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            // 
            // colEndDate
            // 
            this.colEndDate.HeaderText = "End Date";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colBalance
            // 
            this.colBalance.HeaderText = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            // 
            // colCapitalAmount
            // 
            this.colCapitalAmount.HeaderText = "Capital Amount";
            this.colCapitalAmount.Name = "colCapitalAmount";
            this.colCapitalAmount.ReadOnly = true;
            // 
            // CashAdvancedPaymentTransactionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 936);
            this.Controls.Add(this.btnShowCA);
            this.Controls.Add(this.dgLoans);
            this.Controls.Add(this.dgCashAdvances);
            this.Controls.Add(this.btnShowLoans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.headerControl1);
            this.Controls.Add(this.btnPrint);
            this.Name = "CashAdvancedPaymentTransactionsWindow";
            this.Text = "CASH ADVANCED PAYMENT TRANSACTIONS";
            ((System.ComponentModel.ISupportInitialize)(this.dgCashAdvances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private UserControl.HeaderControl headerControl1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShowLoans;
        private System.Windows.Forms.DataGridView dgCashAdvances;
        private System.Windows.Forms.DataGridView dgLoans;
        private System.Windows.Forms.Button btnShowCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCashAdvanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModeOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterestRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodicPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapitalAmount;
    }
}