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
            // Validate input fields
            if (string.IsNullOrWhiteSpace(AcctName_tb.Text) ||
                string.IsNullOrWhiteSpace(AcctNumber_tb.Text) ||
                string.IsNullOrWhiteSpace(AcctType_tb.Text) ||
                string.IsNullOrWhiteSpace(AcctBalance_tb.Text))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            if (!decimal.TryParse(AcctBalance_tb.Text, out decimal balance))
            {
                MessageBox.Show("Balance must be a valid number.");
                return;
            }

            string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Documents\\OnlineBanking.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string Query = "INSERT INTO AccountTable (HolderName, AccountNumber, AccountType, Balance) VALUES (@HolderName, @AccountNumber, @AccountType, @Balance)";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@HolderName", AcctName_tb.Text);
                    command.Parameters.AddWithValue("@AccountNumber", AcctNumber_tb.Text);
                    command.Parameters.AddWithValue("@AccountType", AcctType_tb.Text);
                    command.Parameters.AddWithValue("@Balance", balance);

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

        #region TB KeyDown Events
        private void AcctName_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (AcctName_tb.Text == "Enter Name of Account Holder")
            {
                AcctName_tb.Clear();
                AcctName_tb.ForeColor = Color.Black;
            }
        }

        private void AcctNumber_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (AcctNumber_tb.Text == "Enter Account Number")
            {
                AcctNumber_tb.Clear();
                AcctNumber_tb.ForeColor = Color.Black;
            }
        }

        private void AcctType_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (AcctType_tb.Text == "Enter Account Type")
            {
                AcctType_tb.Clear();
                AcctType_tb.ForeColor = Color.Black;
            }
        }
        private void AcctBalance_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (AcctBalance_tb.Text == "Enter Account Balance")
            {
                AcctBalance_tb.Clear();
                AcctBalance_tb.ForeColor = Color.Black;
            }
        }
        #endregion

        #region TB Click Events
        private void AcctName_tb_Click(object sender, EventArgs e)
        {
            if (AcctName_tb.Text == "Enter Name of Account Holder")
            {
                AcctName_tb.Clear();
                AcctName_tb.ForeColor = Color.Black;
            }

            if (AcctNumber_tb.Text.Length < 1)
            {
                AcctNumber_tb.ForeColor = Color.DarkGray;
                AcctNumber_tb.Text = "Enter Account Number";
            }

            if (AcctType_tb.Text.Length < 1)
            {
                AcctType_tb.ForeColor = Color.DarkGray;
                AcctType_tb.Text = "Enter Account Type";
            }

            if (AcctBalance_tb.Text.Length < 1)
            {
                AcctBalance_tb.ForeColor = Color.DarkGray;
                AcctBalance_tb.Text = "Enter Account Balance";
            }
        }

        private void AcctNumber_tb_Click(object sender, EventArgs e)
        {
            if (AcctNumber_tb.Text == "Enter Account Number")
            {
                AcctNumber_tb.Clear();
                AcctNumber_tb.ForeColor = Color.Black;
            }

            if (AcctName_tb.Text.Length < 1)
            {
                AcctName_tb.ForeColor = Color.DarkGray;
                AcctName_tb.Text = "Enter Name of Account Holder";
            }

            if (AcctType_tb.Text.Length < 1)
            {
                AcctType_tb.ForeColor = Color.DarkGray;
                AcctType_tb.Text = "Enter Account Type";
            }

            if (AcctBalance_tb.Text.Length < 1)
            {
                AcctBalance_tb.ForeColor = Color.DarkGray;
                AcctBalance_tb.Text = "Enter Account Balance";
            }
        }

        private void AcctType_tb_Click(object sender, EventArgs e)
        {
            if (AcctType_tb.Text == "Enter Account Type")
            {
                AcctType_tb.Clear();
                AcctType_tb.ForeColor = Color.Black;
            }

            if (AcctName_tb.Text.Length < 1)
            {
                AcctName_tb.ForeColor = Color.DarkGray;
                AcctName_tb.Text = "Enter Name of Account Holder";
            }

            if (AcctNumber_tb.Text.Length < 1)
            {
                AcctNumber_tb.ForeColor = Color.DarkGray;
                AcctNumber_tb.Text = "Enter Account Number";
            }

            if (AcctBalance_tb.Text.Length < 1)
            {
                AcctBalance_tb.ForeColor = Color.DarkGray;
                AcctBalance_tb.Text = "Enter Account Balance";
            }
        }

        private void AcctBalance_tb_Click(object sender, EventArgs e)
        {
            if (AcctBalance_tb.Text == "Enter Account Balance")
            {
                AcctBalance_tb.Clear();
                AcctBalance_tb.ForeColor = Color.Black;
            }

            if (AcctName_tb.Text.Length < 1)
            {
                AcctName_tb.ForeColor = Color.DarkGray;
                AcctName_tb.Text = "Enter Name of Account Holder";
            }

            if (AcctNumber_tb.Text.Length < 1)
            {
                AcctNumber_tb.ForeColor = Color.DarkGray;
                AcctNumber_tb.Text = "Enter Account Number";
            }

            if (AcctType_tb.Text.Length < 1)
            {
                AcctType_tb.ForeColor = Color.DarkGray;
                AcctType_tb.Text = "Enter Account Type";
            }
        }
        #endregion
    }
}
