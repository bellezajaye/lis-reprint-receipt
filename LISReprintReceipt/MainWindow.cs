using LISReprintReceipt.WindowForms;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace LISReprintReceipt
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            //MainWindow mainWindow = new MainWindow();
            OthersWindow othersWindow = new OthersWindow();
            othersWindow.TopLevel = false;
            othersWindow.AutoScroll = true;
            //mainWindow.panel1.Controls.Add(othersWindow);
            this.panel1.Controls.Add(othersWindow);
            //mdiParent.panel1.Controls.Add(othersWindow);
            //othersWindow.MdiParent = this;
            othersWindow.Show();
        }

        private void MainWindow_Loaded(object sender, EventArgs e)
        {
           



            

            

        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
            //LoginWindow loginWindow = new LoginWindow();
            

            
            //this.ShowInTaskbar = true;
            //this.Visible = false;

            //loginWindow.Show();
        }


        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Shown_1(object sender, EventArgs e)
        {
            
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            
        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void othersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //MainWindow mainWindow = new MainWindow();
            OthersWindow othersWindow = new OthersWindow();
            othersWindow.TopLevel = false;
            othersWindow.AutoScroll = true;
            //mainWindow.panel1.Controls.Add(othersWindow);
            this.panel1.Controls.Add(othersWindow);
            //mdiParent.panel1.Controls.Add(othersWindow);
            //othersWindow.MdiParent = this;
            othersWindow.Show();
            othersWindow.BringToFront();
            othersWindow.Focus();
        }

        private void paydayPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashAdvanceWindow cashAdvanceWindow = new CashAdvanceWindow();
            cashAdvanceWindow.TopLevel = false;
            cashAdvanceWindow.AutoScroll = true;
            this.panel1.Controls.Add(cashAdvanceWindow);
            cashAdvanceWindow.Show();
            cashAdvanceWindow.BringToFront();
            cashAdvanceWindow.Focus();
        }

        private void additionalLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdditionalLoanWindow addLoanWindow = new AdditionalLoanWindow();
            addLoanWindow.TopLevel = false;
            addLoanWindow.AutoScroll = true;
            this.panel1.Controls.Add(addLoanWindow);
            addLoanWindow.Show();
            addLoanWindow.BringToFront();
            addLoanWindow.Focus();
        }

        private void advancePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvancePaymentWindow advPaymentWindow = new AdvancePaymentWindow();
            advPaymentWindow.TopLevel = false;
            advPaymentWindow.AutoScroll = true;
            this.panel1.Controls.Add(advPaymentWindow);
            advPaymentWindow.Show();
            advPaymentWindow.BringToFront();
            advPaymentWindow.Focus();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void othersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OthersTransactionsWindow othersTransactionsWindow = new OthersTransactionsWindow();
            othersTransactionsWindow.TopLevel = false;
            othersTransactionsWindow.AutoScroll = true;
            this.panel1.Controls.Add(othersTransactionsWindow);
            othersTransactionsWindow.Show();
            othersTransactionsWindow.BringToFront();
            othersTransactionsWindow.Focus();
        }

        private void cashAdvancedPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashAdvancedPaymentTransactionsWindow cAPaymentTransactionsWindow = new CashAdvancedPaymentTransactionsWindow();
            cAPaymentTransactionsWindow.TopLevel = false;
            cAPaymentTransactionsWindow.AutoScroll = true;
            this.panel1.Controls.Add(cAPaymentTransactionsWindow);
            cAPaymentTransactionsWindow.Show();
            cAPaymentTransactionsWindow.BringToFront();
            cAPaymentTransactionsWindow.Focus();
        }

        private void loansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoansTransactionsWindow loansTransactionsWindow = new LoansTransactionsWindow();
            loansTransactionsWindow.TopLevel = false;
            loansTransactionsWindow.AutoScroll = true;
            this.panel1.Controls.Add(loansTransactionsWindow);
            loansTransactionsWindow.Show();
            loansTransactionsWindow.BringToFront();
            loansTransactionsWindow.Focus();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.TopLevel = false;
            clientWindow.AutoScroll = true;
            this.panel1.Controls.Add(clientWindow);
            clientWindow.Show();
            clientWindow.BringToFront();
            clientWindow.Focus();
        }
    }
}
