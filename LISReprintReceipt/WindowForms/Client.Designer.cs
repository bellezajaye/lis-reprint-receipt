namespace LISReprintReceipt.WindowForms
{
    partial class ClientWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintLoans = new System.Windows.Forms.Button();
            this.btnFilterResults = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgLoans = new System.Windows.Forms.DataGridView();
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
            this.btnShowLoans = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbLoanType = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocumentLoans = new System.Drawing.Printing.PrintDocument();
            this.tabControlTransactions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.btnPaymentsFilterResults = new System.Windows.Forms.Button();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.panelDate = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbPaymentsStatus = new System.Windows.Forms.ComboBox();
            this.btnPrintPayments = new System.Windows.Forms.Button();
            this.btnShowPayments = new System.Windows.Forms.Button();
            this.dgPayments = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrintOthers = new System.Windows.Forms.Button();
            this.btnShowOthers = new System.Windows.Forms.Button();
            this.dgOthers = new System.Windows.Forms.DataGridView();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbCAStatus = new System.Windows.Forms.ComboBox();
            this.panelCADate = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtCATo = new System.Windows.Forms.DateTimePicker();
            this.dtCAFrom = new System.Windows.Forms.DateTimePicker();
            this.chkCADate = new System.Windows.Forms.CheckBox();
            this.chkCAStatus = new System.Windows.Forms.CheckBox();
            this.btnCAFilterResults = new System.Windows.Forms.Button();
            this.btnPrintCA = new System.Windows.Forms.Button();
            this.btnShowCA = new System.Windows.Forms.Button();
            this.dgCashAdvances = new System.Windows.Forms.DataGridView();
            this.colCashAdvanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocumentCashAdvances = new System.Drawing.Printing.PrintDocument();
            this.printDocumentOthers = new System.Drawing.Printing.PrintDocument();
            this.btnOthersFilterResults = new System.Windows.Forms.Button();
            this.panelOthersDate = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtOthersTo = new System.Windows.Forms.DateTimePicker();
            this.dtOthersFrom = new System.Windows.Forms.DateTimePicker();
            this.chkOthersDate = new System.Windows.Forms.CheckBox();
            this.headerControl1 = new LISReprintReceipt.UserControl.HeaderControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoans)).BeginInit();
            this.tabControlTransactions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayments)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOthers)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panelCADate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCashAdvances)).BeginInit();
            this.panelOthersDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnPrintLoans);
            this.groupBox1.Controls.Add(this.btnFilterResults);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgLoans);
            this.groupBox1.Controls.Add(this.btnShowLoans);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbLoanType);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 426);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOANS";
            // 
            // btnPrintLoans
            // 
            this.btnPrintLoans.Enabled = false;
            this.btnPrintLoans.Location = new System.Drawing.Point(13, 81);
            this.btnPrintLoans.Name = "btnPrintLoans";
            this.btnPrintLoans.Size = new System.Drawing.Size(222, 54);
            this.btnPrintLoans.TabIndex = 67;
            this.btnPrintLoans.Text = "Print Loans";
            this.btnPrintLoans.UseVisualStyleBackColor = true;
            this.btnPrintLoans.Click += new System.EventHandler(this.btnPrintLoans_Click);
            // 
            // btnFilterResults
            // 
            this.btnFilterResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterResults.Enabled = false;
            this.btnFilterResults.Location = new System.Drawing.Point(587, 85);
            this.btnFilterResults.Name = "btnFilterResults";
            this.btnFilterResults.Size = new System.Drawing.Size(222, 52);
            this.btnFilterResults.TabIndex = 65;
            this.btnFilterResults.Text = "Filter Results";
            this.btnFilterResults.UseVisualStyleBackColor = true;
            this.btnFilterResults.Click += new System.EventHandler(this.btnFilterResults_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Loan Type";
            // 
            // dgLoans
            // 
            this.dgLoans.AllowUserToAddRows = false;
            this.dgLoans.AllowUserToDeleteRows = false;
            this.dgLoans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dgLoans.Location = new System.Drawing.Point(6, 143);
            this.dgLoans.Name = "dgLoans";
            this.dgLoans.ReadOnly = true;
            this.dgLoans.Size = new System.Drawing.Size(809, 266);
            this.dgLoans.TabIndex = 59;
            this.dgLoans.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLoans_CellContentDoubleClick);
            // 
            // colLoanID
            // 
            this.colLoanID.HeaderText = "Loan ID";
            this.colLoanID.Name = "colLoanID";
            this.colLoanID.ReadOnly = true;
            this.colLoanID.Width = 72;
            // 
            // colClientID
            // 
            this.colClientID.HeaderText = "Client ID";
            this.colClientID.Name = "colClientID";
            this.colClientID.ReadOnly = true;
            this.colClientID.Width = 75;
            // 
            // colLoanType
            // 
            this.colLoanType.HeaderText = "Loan Type";
            this.colLoanType.Name = "colLoanType";
            this.colLoanType.ReadOnly = true;
            this.colLoanType.Width = 89;
            // 
            // colModeOfPayment
            // 
            this.colModeOfPayment.HeaderText = "Mode Of Payment";
            this.colModeOfPayment.Name = "colModeOfPayment";
            this.colModeOfPayment.ReadOnly = true;
            this.colModeOfPayment.Width = 127;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 77;
            // 
            // colTerms
            // 
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
            this.colInterestRate.Width = 98;
            // 
            // colInterestAmount
            // 
            this.colInterestAmount.HeaderText = "Interest Amount";
            this.colInterestAmount.Name = "colInterestAmount";
            this.colInterestAmount.ReadOnly = true;
            this.colInterestAmount.Width = 113;
            // 
            // colPeriodicPayment
            // 
            this.colPeriodicPayment.HeaderText = "Periodic Payment";
            this.colPeriodicPayment.Name = "colPeriodicPayment";
            this.colPeriodicPayment.ReadOnly = true;
            this.colPeriodicPayment.Width = 126;
            // 
            // colStartDate
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.colStartDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colStartDate.HeaderText = "Start Date";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            this.colStartDate.Width = 84;
            // 
            // colEndDate
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colEndDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colEndDate.HeaderText = "End Date";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            this.colEndDate.Width = 81;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 69;
            // 
            // colBalance
            // 
            this.colBalance.HeaderText = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            this.colBalance.Width = 82;
            // 
            // colCapitalAmount
            // 
            this.colCapitalAmount.HeaderText = "Capital Amount";
            this.colCapitalAmount.Name = "colCapitalAmount";
            this.colCapitalAmount.ReadOnly = true;
            this.colCapitalAmount.Width = 112;
            // 
            // btnShowLoans
            // 
            this.btnShowLoans.Location = new System.Drawing.Point(13, 21);
            this.btnShowLoans.Name = "btnShowLoans";
            this.btnShowLoans.Size = new System.Drawing.Size(222, 54);
            this.btnShowLoans.TabIndex = 62;
            this.btnShowLoans.Text = "Show Loans";
            this.btnShowLoans.UseVisualStyleBackColor = true;
            this.btnShowLoans.Click += new System.EventHandler(this.btnShowLoans_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "New",
            "Pending",
            "Approved",
            "Partial",
            "Settled"});
            this.cmbStatus.Location = new System.Drawing.Point(658, 55);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(151, 24);
            this.cmbStatus.TabIndex = 61;
            this.cmbStatus.Text = "New";
            // 
            // cmbLoanType
            // 
            this.cmbLoanType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLoanType.FormattingEnabled = true;
            this.cmbLoanType.Items.AddRange(new object[] {
            "Fixed",
            "Diminishing",
            "Fixed Diminishing"});
            this.cmbLoanType.Location = new System.Drawing.Point(658, 21);
            this.cmbLoanType.Name = "cmbLoanType";
            this.cmbLoanType.Size = new System.Drawing.Size(151, 24);
            this.cmbLoanType.TabIndex = 60;
            this.cmbLoanType.Text = "Fixed";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocumentLoans
            // 
            this.printDocumentLoans.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocumentLoans_BeginPrint);
            this.printDocumentLoans.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentLoans_PrintPage);
            // 
            // tabControlTransactions
            // 
            this.tabControlTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlTransactions.Controls.Add(this.tabPage1);
            this.tabControlTransactions.Controls.Add(this.tabPage2);
            this.tabControlTransactions.Controls.Add(this.tabPage3);
            this.tabControlTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlTransactions.Location = new System.Drawing.Point(11, 642);
            this.tabControlTransactions.Name = "tabControlTransactions";
            this.tabControlTransactions.SelectedIndex = 0;
            this.tabControlTransactions.Size = new System.Drawing.Size(823, 471);
            this.tabControlTransactions.TabIndex = 61;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkStatus);
            this.tabPage1.Controls.Add(this.btnPaymentsFilterResults);
            this.tabPage1.Controls.Add(this.chkDate);
            this.tabPage1.Controls.Add(this.panelDate);
            this.tabPage1.Controls.Add(this.cmbPaymentsStatus);
            this.tabPage1.Controls.Add(this.btnPrintPayments);
            this.tabPage1.Controls.Add(this.btnShowPayments);
            this.tabPage1.Controls.Add(this.dgPayments);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(815, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PAYMENTS";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStatus.AutoSize = true;
            this.chkStatus.Enabled = false;
            this.chkStatus.Location = new System.Drawing.Point(616, 10);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(63, 20);
            this.chkStatus.TabIndex = 89;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // btnPaymentsFilterResults
            // 
            this.btnPaymentsFilterResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaymentsFilterResults.Enabled = false;
            this.btnPaymentsFilterResults.Location = new System.Drawing.Point(584, 139);
            this.btnPaymentsFilterResults.Name = "btnPaymentsFilterResults";
            this.btnPaymentsFilterResults.Size = new System.Drawing.Size(222, 51);
            this.btnPaymentsFilterResults.TabIndex = 88;
            this.btnPaymentsFilterResults.Text = "Filter Results";
            this.btnPaymentsFilterResults.UseVisualStyleBackColor = true;
            this.btnPaymentsFilterResults.Click += new System.EventHandler(this.btnPaymentsFilterResults_Click);
            // 
            // chkDate
            // 
            this.chkDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDate.AutoSize = true;
            this.chkDate.Enabled = false;
            this.chkDate.Location = new System.Drawing.Point(616, 39);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(55, 20);
            this.chkDate.TabIndex = 87;
            this.chkDate.Text = "Date";
            this.chkDate.UseVisualStyleBackColor = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // panelDate
            // 
            this.panelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDate.Controls.Add(this.label4);
            this.panelDate.Controls.Add(this.label3);
            this.panelDate.Controls.Add(this.dtTo);
            this.panelDate.Controls.Add(this.dtFrom);
            this.panelDate.Enabled = false;
            this.panelDate.Location = new System.Drawing.Point(616, 65);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(190, 67);
            this.panelDate.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 82;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "From";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "yyyy-MM-dd";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(47, 38);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(140, 22);
            this.dtTo.TabIndex = 79;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "yyyy-MM-dd";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(47, 9);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(140, 22);
            this.dtFrom.TabIndex = 78;
            // 
            // cmbPaymentsStatus
            // 
            this.cmbPaymentsStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPaymentsStatus.Enabled = false;
            this.cmbPaymentsStatus.FormattingEnabled = true;
            this.cmbPaymentsStatus.Items.AddRange(new object[] {
            "Floating",
            "Paid",
            "Others",
            "Temporary",
            "Converted"});
            this.cmbPaymentsStatus.Location = new System.Drawing.Point(685, 8);
            this.cmbPaymentsStatus.Name = "cmbPaymentsStatus";
            this.cmbPaymentsStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbPaymentsStatus.TabIndex = 85;
            this.cmbPaymentsStatus.Text = "Floating";
            // 
            // btnPrintPayments
            // 
            this.btnPrintPayments.Enabled = false;
            this.btnPrintPayments.Location = new System.Drawing.Point(10, 138);
            this.btnPrintPayments.Name = "btnPrintPayments";
            this.btnPrintPayments.Size = new System.Drawing.Size(222, 51);
            this.btnPrintPayments.TabIndex = 84;
            this.btnPrintPayments.Text = "Print Payments";
            this.btnPrintPayments.UseVisualStyleBackColor = true;
            this.btnPrintPayments.Click += new System.EventHandler(this.btnPrintPayments_Click);
            // 
            // btnShowPayments
            // 
            this.btnShowPayments.Enabled = false;
            this.btnShowPayments.Location = new System.Drawing.Point(10, 81);
            this.btnShowPayments.Name = "btnShowPayments";
            this.btnShowPayments.Size = new System.Drawing.Size(222, 51);
            this.btnShowPayments.TabIndex = 83;
            this.btnShowPayments.Text = "Show Payments";
            this.btnShowPayments.UseVisualStyleBackColor = true;
            this.btnShowPayments.Click += new System.EventHandler(this.btnShowPayments_Click);
            // 
            // dgPayments
            // 
            this.dgPayments.AllowUserToAddRows = false;
            this.dgPayments.AllowUserToDeleteRows = false;
            this.dgPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            this.dgPayments.Location = new System.Drawing.Point(3, 196);
            this.dgPayments.Name = "dgPayments";
            this.dgPayments.ReadOnly = true;
            this.dgPayments.Size = new System.Drawing.Size(806, 237);
            this.dgPayments.TabIndex = 68;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Payment ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Loan ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Salary";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PartialPayment";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Interest Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cash Payment";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total Deduction";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Change";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "New Balance";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Due Date";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Payment Date";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Note";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Status";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Total Payment";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Others Total";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Remark";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelOthersDate);
            this.tabPage2.Controls.Add(this.chkOthersDate);
            this.tabPage2.Controls.Add(this.btnOthersFilterResults);
            this.tabPage2.Controls.Add(this.btnPrintOthers);
            this.tabPage2.Controls.Add(this.btnShowOthers);
            this.tabPage2.Controls.Add(this.dgOthers);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(815, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OTHERS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPrintOthers
            // 
            this.btnPrintOthers.Enabled = false;
            this.btnPrintOthers.Location = new System.Drawing.Point(10, 139);
            this.btnPrintOthers.Name = "btnPrintOthers";
            this.btnPrintOthers.Size = new System.Drawing.Size(222, 51);
            this.btnPrintOthers.TabIndex = 86;
            this.btnPrintOthers.Text = "Print Others";
            this.btnPrintOthers.UseVisualStyleBackColor = true;
            this.btnPrintOthers.Click += new System.EventHandler(this.btnPrintOthers_Click);
            // 
            // btnShowOthers
            // 
            this.btnShowOthers.Enabled = false;
            this.btnShowOthers.Location = new System.Drawing.Point(10, 82);
            this.btnShowOthers.Name = "btnShowOthers";
            this.btnShowOthers.Size = new System.Drawing.Size(222, 51);
            this.btnShowOthers.TabIndex = 85;
            this.btnShowOthers.Text = "Show Others";
            this.btnShowOthers.UseVisualStyleBackColor = true;
            this.btnShowOthers.Click += new System.EventHandler(this.btnShowOthers_Click);
            // 
            // dgOthers
            // 
            this.dgOthers.AllowUserToAddRows = false;
            this.dgOthers.AllowUserToDeleteRows = false;
            this.dgOthers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOthers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOthers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25});
            this.dgOthers.Location = new System.Drawing.Point(3, 199);
            this.dgOthers.Name = "dgOthers";
            this.dgOthers.ReadOnly = true;
            this.dgOthers.Size = new System.Drawing.Size(806, 237);
            this.dgOthers.TabIndex = 69;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Other ID";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Loan ID";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Date";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Amount";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "Description";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "Balance";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "Status";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "Other Type";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbCAStatus);
            this.tabPage3.Controls.Add(this.panelCADate);
            this.tabPage3.Controls.Add(this.chkCADate);
            this.tabPage3.Controls.Add(this.chkCAStatus);
            this.tabPage3.Controls.Add(this.btnCAFilterResults);
            this.tabPage3.Controls.Add(this.btnPrintCA);
            this.tabPage3.Controls.Add(this.btnShowCA);
            this.tabPage3.Controls.Add(this.dgCashAdvances);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(815, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CASH ADVANCES";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbCAStatus
            // 
            this.cmbCAStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCAStatus.Enabled = false;
            this.cmbCAStatus.FormattingEnabled = true;
            this.cmbCAStatus.Items.AddRange(new object[] {
            "New",
            "Partial",
            "Paid",
            "NA"});
            this.cmbCAStatus.Location = new System.Drawing.Point(685, 11);
            this.cmbCAStatus.Name = "cmbCAStatus";
            this.cmbCAStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbCAStatus.TabIndex = 99;
            this.cmbCAStatus.Text = "New";
            // 
            // panelCADate
            // 
            this.panelCADate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCADate.Controls.Add(this.label5);
            this.panelCADate.Controls.Add(this.label6);
            this.panelCADate.Controls.Add(this.dtCATo);
            this.panelCADate.Controls.Add(this.dtCAFrom);
            this.panelCADate.Enabled = false;
            this.panelCADate.Location = new System.Drawing.Point(616, 66);
            this.panelCADate.Name = "panelCADate";
            this.panelCADate.Size = new System.Drawing.Size(190, 67);
            this.panelCADate.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 86;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 85;
            this.label6.Text = "From";
            // 
            // dtCATo
            // 
            this.dtCATo.CustomFormat = "yyyy-MM-dd";
            this.dtCATo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCATo.Location = new System.Drawing.Point(47, 36);
            this.dtCATo.Name = "dtCATo";
            this.dtCATo.Size = new System.Drawing.Size(140, 22);
            this.dtCATo.TabIndex = 84;
            // 
            // dtCAFrom
            // 
            this.dtCAFrom.CustomFormat = "yyyy-MM-dd";
            this.dtCAFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCAFrom.Location = new System.Drawing.Point(47, 8);
            this.dtCAFrom.Name = "dtCAFrom";
            this.dtCAFrom.Size = new System.Drawing.Size(140, 22);
            this.dtCAFrom.TabIndex = 83;
            // 
            // chkCADate
            // 
            this.chkCADate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCADate.AutoSize = true;
            this.chkCADate.Enabled = false;
            this.chkCADate.Location = new System.Drawing.Point(616, 40);
            this.chkCADate.Name = "chkCADate";
            this.chkCADate.Size = new System.Drawing.Size(55, 20);
            this.chkCADate.TabIndex = 96;
            this.chkCADate.Text = "Date";
            this.chkCADate.UseVisualStyleBackColor = true;
            this.chkCADate.CheckedChanged += new System.EventHandler(this.chkCADate_CheckedChanged);
            // 
            // chkCAStatus
            // 
            this.chkCAStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCAStatus.AutoSize = true;
            this.chkCAStatus.Enabled = false;
            this.chkCAStatus.Location = new System.Drawing.Point(616, 11);
            this.chkCAStatus.Name = "chkCAStatus";
            this.chkCAStatus.Size = new System.Drawing.Size(63, 20);
            this.chkCAStatus.TabIndex = 94;
            this.chkCAStatus.Text = "Status";
            this.chkCAStatus.UseVisualStyleBackColor = true;
            this.chkCAStatus.CheckedChanged += new System.EventHandler(this.chkCAStatus_CheckedChanged);
            // 
            // btnCAFilterResults
            // 
            this.btnCAFilterResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCAFilterResults.Enabled = false;
            this.btnCAFilterResults.Location = new System.Drawing.Point(584, 142);
            this.btnCAFilterResults.Name = "btnCAFilterResults";
            this.btnCAFilterResults.Size = new System.Drawing.Size(222, 51);
            this.btnCAFilterResults.TabIndex = 90;
            this.btnCAFilterResults.Text = "Filter Results";
            this.btnCAFilterResults.UseVisualStyleBackColor = true;
            this.btnCAFilterResults.Click += new System.EventHandler(this.btnCAFilterResults_Click);
            // 
            // btnPrintCA
            // 
            this.btnPrintCA.Enabled = false;
            this.btnPrintCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCA.Location = new System.Drawing.Point(10, 139);
            this.btnPrintCA.Name = "btnPrintCA";
            this.btnPrintCA.Size = new System.Drawing.Size(222, 54);
            this.btnPrintCA.TabIndex = 47;
            this.btnPrintCA.Text = "Print CA";
            this.btnPrintCA.UseVisualStyleBackColor = true;
            this.btnPrintCA.Click += new System.EventHandler(this.btnPrintCA_Click);
            // 
            // btnShowCA
            // 
            this.btnShowCA.Enabled = false;
            this.btnShowCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCA.Location = new System.Drawing.Point(10, 79);
            this.btnShowCA.Name = "btnShowCA";
            this.btnShowCA.Size = new System.Drawing.Size(222, 54);
            this.btnShowCA.TabIndex = 46;
            this.btnShowCA.Text = "Show CA";
            this.btnShowCA.UseVisualStyleBackColor = true;
            this.btnShowCA.Click += new System.EventHandler(this.btnShowCA_Click);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column9,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgCashAdvances.Location = new System.Drawing.Point(3, 199);
            this.dgCashAdvances.Name = "dgCashAdvances";
            this.dgCashAdvances.ReadOnly = true;
            this.dgCashAdvances.Size = new System.Drawing.Size(806, 237);
            this.dgCashAdvances.TabIndex = 45;
            this.dgCashAdvances.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCashAdvances_CellContentDoubleClick);
            this.dgCashAdvances.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCashAdvances_CellDoubleClick);
            // 
            // colCashAdvanceID
            // 
            this.colCashAdvanceID.HeaderText = "CA ID";
            this.colCashAdvanceID.Name = "colCashAdvanceID";
            this.colCashAdvanceID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Loan ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Terms";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Interest Rate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Interest Amount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Total Amount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Balance";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Date Received";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Note";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // printDocumentCashAdvances
            // 
            this.printDocumentCashAdvances.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocumentcashAdvances_BeginPrint);
            this.printDocumentCashAdvances.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentCashAdvances_PrintPage);
            // 
            // printDocumentOthers
            // 
            this.printDocumentOthers.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocumentOthers_BeginPrint);
            this.printDocumentOthers.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentOthers_PrintPage);
            // 
            // btnOthersFilterResults
            // 
            this.btnOthersFilterResults.Enabled = false;
            this.btnOthersFilterResults.Location = new System.Drawing.Point(584, 139);
            this.btnOthersFilterResults.Name = "btnOthersFilterResults";
            this.btnOthersFilterResults.Size = new System.Drawing.Size(222, 51);
            this.btnOthersFilterResults.TabIndex = 87;
            this.btnOthersFilterResults.Text = "Filter Results";
            this.btnOthersFilterResults.UseVisualStyleBackColor = true;
            this.btnOthersFilterResults.Click += new System.EventHandler(this.btnOthersFilterResults_Click);
            // 
            // panelOthersDate
            // 
            this.panelOthersDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOthersDate.Controls.Add(this.label7);
            this.panelOthersDate.Controls.Add(this.label8);
            this.panelOthersDate.Controls.Add(this.dtOthersTo);
            this.panelOthersDate.Controls.Add(this.dtOthersFrom);
            this.panelOthersDate.Enabled = false;
            this.panelOthersDate.Location = new System.Drawing.Point(584, 69);
            this.panelOthersDate.Name = "panelOthersDate";
            this.panelOthersDate.Size = new System.Drawing.Size(190, 67);
            this.panelOthersDate.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 86;
            this.label7.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 85;
            this.label8.Text = "From";
            // 
            // dtOthersTo
            // 
            this.dtOthersTo.CustomFormat = "yyyy-MM-dd";
            this.dtOthersTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOthersTo.Location = new System.Drawing.Point(47, 36);
            this.dtOthersTo.Name = "dtOthersTo";
            this.dtOthersTo.Size = new System.Drawing.Size(140, 22);
            this.dtOthersTo.TabIndex = 84;
            // 
            // dtOthersFrom
            // 
            this.dtOthersFrom.CustomFormat = "yyyy-MM-dd";
            this.dtOthersFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOthersFrom.Location = new System.Drawing.Point(47, 8);
            this.dtOthersFrom.Name = "dtOthersFrom";
            this.dtOthersFrom.Size = new System.Drawing.Size(140, 22);
            this.dtOthersFrom.TabIndex = 83;
            // 
            // chkOthersDate
            // 
            this.chkOthersDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOthersDate.AutoSize = true;
            this.chkOthersDate.Enabled = false;
            this.chkOthersDate.Location = new System.Drawing.Point(584, 43);
            this.chkOthersDate.Name = "chkOthersDate";
            this.chkOthersDate.Size = new System.Drawing.Size(55, 20);
            this.chkOthersDate.TabIndex = 99;
            this.chkOthersDate.Text = "Date";
            this.chkOthersDate.UseVisualStyleBackColor = true;
            this.chkOthersDate.CheckedChanged += new System.EventHandler(this.chkOthersDate_CheckedChanged);
            // 
            // headerControl1
            // 
            this.headerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerControl1.Location = new System.Drawing.Point(12, 12);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(822, 175);
            this.headerControl1.TabIndex = 0;
            this.headerControl1.Load += new System.EventHandler(this.headerControl1_Load);
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 1125);
            this.Controls.Add(this.tabControlTransactions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.headerControl1);
            this.Name = "ClientWindow";
            this.ShowIcon = false;
            this.Text = "CLIENTS";
            this.Load += new System.EventHandler(this.ClientWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoans)).EndInit();
            this.tabControlTransactions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayments)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOthers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panelCADate.ResumeLayout(false);
            this.panelCADate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCashAdvances)).EndInit();
            this.panelOthersDate.ResumeLayout(false);
            this.panelOthersDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilterResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowLoans;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbLoanType;
        private System.Windows.Forms.DataGridView dgLoans;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public UserControl.HeaderControl headerControl1;
        private System.Windows.Forms.Button btnPrintLoans;
        private System.Drawing.Printing.PrintDocument printDocumentLoans;
        private System.Windows.Forms.TabControl tabControlTransactions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Button btnPaymentsFilterResults;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.ComboBox cmbPaymentsStatus;
        private System.Windows.Forms.Button btnPrintPayments;
        private System.Windows.Forms.Button btnShowPayments;
        private System.Windows.Forms.DataGridView dgPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgCashAdvances;
        private System.Windows.Forms.Button btnPrintCA;
        private System.Windows.Forms.Button btnShowCA;
        private System.Drawing.Printing.PrintDocument printDocumentCashAdvances;
        private System.Windows.Forms.Button btnCAFilterResults;
        private System.Windows.Forms.ComboBox cmbCAStatus;
        private System.Windows.Forms.Panel panelCADate;
        private System.Windows.Forms.CheckBox chkCADate;
        private System.Windows.Forms.CheckBox chkCAStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtCATo;
        private System.Windows.Forms.DateTimePicker dtCAFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCashAdvanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView dgOthers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.Button btnPrintOthers;
        private System.Windows.Forms.Button btnShowOthers;
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
        private System.Drawing.Printing.PrintDocument printDocumentOthers;
        private System.Windows.Forms.Panel panelOthersDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtOthersTo;
        private System.Windows.Forms.DateTimePicker dtOthersFrom;
        private System.Windows.Forms.CheckBox chkOthersDate;
        private System.Windows.Forms.Button btnOthersFilterResults;
    }
}