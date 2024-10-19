namespace LISReprintReceipt
{
    partial class AdditionalLoanWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalLoanWindow));
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.btnShowRecord = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdditionalLoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNewBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodicPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdditionalLoanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNextPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(601, 244);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 32);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.colID,
            this.colLoanID,
            this.colClientID,
            this.colAdditionalLoanAmount,
            this.colCurBalance,
            this.colNewBalance,
            this.colPeriodicPayment,
            this.colAdditionalLoanDate,
            this.colNextPayment});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 293);
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
            this.dataGridView1.Size = new System.Drawing.Size(687, 290);
            this.dataGridView1.TabIndex = 9;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colLoanID
            // 
            this.colLoanID.HeaderText = "LoanID";
            this.colLoanID.Name = "colLoanID";
            this.colLoanID.ReadOnly = true;
            this.colLoanID.Visible = false;
            // 
            // colClientID
            // 
            this.colClientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colClientID.HeaderText = "ClientID";
            this.colClientID.Name = "colClientID";
            this.colClientID.ReadOnly = true;
            this.colClientID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colClientID.Visible = false;
            // 
            // colAdditionalLoanAmount
            // 
            this.colAdditionalLoanAmount.HeaderText = "Additional Loan Amount";
            this.colAdditionalLoanAmount.Name = "colAdditionalLoanAmount";
            this.colAdditionalLoanAmount.ReadOnly = true;
            // 
            // colCurBalance
            // 
            this.colCurBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCurBalance.HeaderText = "Current Balance";
            this.colCurBalance.Name = "colCurBalance";
            this.colCurBalance.ReadOnly = true;
            this.colCurBalance.Width = 116;
            // 
            // colNewBalance
            // 
            this.colNewBalance.HeaderText = "New Balance";
            this.colNewBalance.Name = "colNewBalance";
            this.colNewBalance.ReadOnly = true;
            // 
            // colPeriodicPayment
            // 
            this.colPeriodicPayment.HeaderText = "Periodic Payment";
            this.colPeriodicPayment.Name = "colPeriodicPayment";
            this.colPeriodicPayment.ReadOnly = true;
            // 
            // colAdditionalLoanDate
            // 
            this.colAdditionalLoanDate.HeaderText = "Date";
            this.colAdditionalLoanDate.Name = "colAdditionalLoanDate";
            this.colAdditionalLoanDate.ReadOnly = true;
            // 
            // colNextPayment
            // 
            this.colNextPayment.HeaderText = "Next Payment";
            this.colNextPayment.Name = "colNextPayment";
            this.colNextPayment.ReadOnly = true;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.SystemColors.Control;
            this.headerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerControl1.Location = new System.Drawing.Point(13, 7);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(663, 175);
            this.headerControl1.TabIndex = 12;
            // 
            // AdditionalLoanWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.btnShowRecord);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.headerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdditionalLoanWindow";
            this.ShowIcon = false;
            this.Text = "ADDITIONAL LOAN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Button btnShowRecord;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UserControl.HeaderControl headerControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdditionalLoanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNewBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodicPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdditionalLoanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNextPayment;
    }
}