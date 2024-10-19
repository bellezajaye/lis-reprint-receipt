using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LISReprintReceipt
{
    public partial class LoginWindow : Form
    {

        DbConnection dbConn = new DbConnection();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dbConn.GetDbConnection();


            //string connectionString = ConfigurationManager.ConnectionStrings["LISReprintReceiptDb"].ConnectionString;
            //MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            dbConn.OpenConnection();

            string pass = PasswordEncrypt.EncryptSHA512Managed(txtPassword.Text);

            string sql = $"SELECT * FROM users WHERE username = '{txtUsername.Text}' and password = '{pass}'";
            MySqlCommand cmd = new MySqlCommand(sql, dbConn.GetDbConnection());
            object result = cmd.ExecuteScalar();

            try 
            {
                if (result != null)
                {
                    
                    //MDIParent1 mdparent = new MDIParent1();
                    //mdparent.Show();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.lblWelcome.Text = "WELCOME! Today is " + (DateTime.Now.ToShortDateString());
                    mainWindow.Show();
                    mainWindow.ShowInTaskbar = true;


                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrect username/password, please try again.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }


            dbConn.CloseConnection();

        }

        private void lblPassword_DoubleClick(object sender, EventArgs e)
        {
            //btnLogin_Click(sender, e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            mainWindow.ShowInTaskbar = true;
        }
    }
}
