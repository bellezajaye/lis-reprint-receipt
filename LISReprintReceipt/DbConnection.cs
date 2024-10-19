using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LISReprintReceipt
{
    class DbConnection
    {
        static MySqlConnection databaseConnection = null;
        public MySqlConnection GetDbConnection()
        {
            if(databaseConnection == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["LISReprintReceiptDb"].ConnectionString;
                databaseConnection = new MySqlConnection(connectionString);
            }
            return databaseConnection;
        }

        public bool OpenConnection()
        {
            try
            {
                databaseConnection.Open();
                //MessageBox.Show("Connected!");
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact Administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again.");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                databaseConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, databaseConnection);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
