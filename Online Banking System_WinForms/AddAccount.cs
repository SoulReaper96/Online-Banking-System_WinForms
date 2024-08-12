using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Banking_System_WinForms
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void AddAcct_btn_Click(object sender, EventArgs e)
        {
            string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Documents\\OnlineBanking.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string Query = "INSERT INTO AccountTable (AccountName, HolderName, AccountType, Balance) VALUES (@HolderName, @AccountNumber, @AccountType, @Balance)";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@HolderName", AcctName_tb.Text);
                    command.Parameters.AddWithValue("@AccountNumber", AcctNumber_tb.Text);
                    command.Parameters.AddWithValue("@AccountType", AcctType_tb.Text);
                    command.Parameters.AddWithValue("@Balance", AcctBalance_tb.Text);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Account Added Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            OnlineBankingApp onlineBankingApp = new OnlineBankingApp();
            onlineBankingApp.Show();
            this.Hide();
        }
    }
}
