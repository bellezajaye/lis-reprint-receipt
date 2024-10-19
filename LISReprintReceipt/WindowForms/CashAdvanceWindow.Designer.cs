namespace LISReprintReceipt
{
    partial class CashAdvanceWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashAdvanceWindow));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.btnShowRecord = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCashAdvanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterestRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerControl1 = new LISReprintReceipt.UserControl.HeaderControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "From:";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "yyyy-MM-dd";
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(187, 248);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(114, 22);
            this.dtTo.TabIndex = 15;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "yyyy-MM-dd";
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(187, 220);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(114, 22);
            this.dtFrom.TabIndex = 14;
            // 
            // btnShowRecord
            // 
            this.btnShowRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRecord.Location = new System.Drawing.Point(12, 220);
            this.btnShowRecord.Name = "btnShowRecord";
            this.btnShowRecord.Size = new System.Drawing.Size(119, 57);
            this.btnShowRecord.TabIndex = 13;
            this.btnShowRecord.Text = "Show Record";
            this.btnShowRecord.UseVisualStyleBackColor = true;
            this.btnShowRecord.Click += new System.EventHandler(this.btnShowRecord_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(576, 188);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 11;
            this.txtAmount.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(601, 244);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 32);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCashAdvanceID,
            this.colLoanID,
            this.colAmount,
            this.colTerms,
            this.colInterestRate,
            this.colInterestAmount,
            this.colTotalAmount,
            this.colBalance,
            this.colDateReceived,
            this.colStatus,
            this.colNote});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 287);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(692, 290);
            this.dataGridView1.TabIndex = 9;
            // 
            // colCashAdvanceID
            // 
            this.colCashAdvanceID.HeaderText = "CashAdvanceID";
            this.colCashAdvanceID.Name = "colCashAdvanceID";
            this.colCashAdvanceID.ReadOnly = true;
            this.colCashAdvanceID.Visible = false;
            // 
            // colLoanID
            // 
            this.colLoanID.HeaderText = "LoanID";
            this.colLoanID.Name = "colLoanID";
            this.colLoanID.ReadOnly = true;
            this.colLoanID.Visible = false;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colTerms
            // 
            this.colTerms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTerms.HeaderText = "Terms";
            this.colTerms.Name = "colTerms";
            this.colTerms.ReadOnly = true;
            this.colTerms.Width = 71;
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
            this.colInterestAmount.Visible = false;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.HeaderText = "Total Amount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            // 
            // colBalance
            // 
            this.colBalance.HeaderText = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            // 
            // colDateReceived
            // 
            this.colDateReceived.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDateReceived.HeaderText = "Date Received";
            this.colDateReceived.Name = "colDateReceived";
            this.colDateReceived.ReadOnly = true;
            this.colDateReceived.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDateReceived.Width = 113;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Visible = false;
            // 
            // colNote
            // 
            this.colNote.HeaderText = "Note";
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.SystemColors.Control;
            this.headerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerControl1.Location = new System.Drawing.Point(13, 8);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(663, 175);
            this.headerControl1.TabIndex = 12;
            // 
            // CashAdvanceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.btnShowRecord);
            this.Controls.Add(this.headerControl1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashAdvanceWindow";
            this.ShowIcon = false;
            this.Text = "CASH ADVANCED";
            this.Load += new System.EventHandler(this.CashAdvanceWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Button btnShowRecord;
        private UserControl.HeaderControl headerControl1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCashAdvanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterestRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
    }
}