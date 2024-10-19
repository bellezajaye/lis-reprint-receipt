namespace LISReprintReceipt.WindowForms
{
    partial class OthersTransactionsWindow
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowRecords = new System.Windows.Forms.Button();
            this.dgOthers = new System.Windows.Forms.DataGridView();
            this.headerControl1 = new LISReprintReceipt.UserControl.HeaderControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgOthers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(551, 253);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(121, 42);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print Records";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "yyyy-MM-dd";
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(60, 211);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(112, 22);
            this.dtFrom.TabIndex = 29;
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "yyyy-MM-dd";
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(209, 210);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(112, 22);
            this.dtTo.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "To:";
            // 
            // btnShowRecords
            // 
            this.btnShowRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRecords.Location = new System.Drawing.Point(12, 254);
            this.btnShowRecords.Name = "btnShowRecords";
            this.btnShowRecords.Size = new System.Drawing.Size(121, 41);
            this.btnShowRecords.TabIndex = 33;
            this.btnShowRecords.Text = "Show Records";
            this.btnShowRecords.UseVisualStyleBackColor = true;
            this.btnShowRecords.Click += new System.EventHandler(this.btnShowRecords_Click);
            // 
            // dgOthers
            // 
            this.dgOthers.AllowUserToAddRows = false;
            this.dgOthers.AllowUserToDeleteRows = false;
            this.dgOthers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOthers.Location = new System.Drawing.Point(12, 301);
            this.dgOthers.Name = "dgOthers";
            this.dgOthers.ReadOnly = true;
            this.dgOthers.Size = new System.Drawing.Size(660, 249);
            this.dgOthers.TabIndex = 34;
            // 
            // headerControl1
            // 
            this.headerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerControl1.Location = new System.Drawing.Point(12, 12);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(663, 175);
            this.headerControl1.TabIndex = 1;
            this.headerControl1.Load += new System.EventHandler(this.headerControl1_Load);
            // 
            // OthersTransactionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 722);
            this.Controls.Add(this.dgOthers);
            this.Controls.Add(this.btnShowRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.headerControl1);
            this.Controls.Add(this.btnPrint);
            this.Name = "OthersTransactionsWindow";
            this.ShowIcon = false;
            this.Text = "OTHERS TRANSACTIONS";
            this.Load += new System.EventHandler(this.OthersTransactionsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOthers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private UserControl.HeaderControl headerControl1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowRecords;
        private System.Windows.Forms.DataGridView dgOthers;
    }
}