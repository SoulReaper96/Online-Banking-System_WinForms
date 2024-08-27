using System;
using System.Data.SqlClient;
using System.Drawing;
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

            string? username = Login._username;
            int? userId = GetUserIdByUsername(username);

            if (userId == 0)
            {
                MessageBox.Show("Invalid user.");
                return;
            }

            string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Documents\\OnlineBanking.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string Query = "INSERT INTO AccountTable (UserId, HolderName, AccountNumber, AccountType, Balance) VALUES (@UserId, @HolderName, @AccountNumber, @AccountType, @Balance)";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
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
                        OnlineBankingApp onlineBankingApp = new OnlineBankingApp();
                        onlineBankingApp.Show();
                        this.Hide();
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

        public int GetUserIdByUsername(string username)
        {
            string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Documents\\OnlineBanking.mdf;Integrated Security=True;Connect Timeout=30";
            int userId = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT UserId FROM UserTable WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            userId = Convert.ToInt32(reader["UserId"]);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }

            return userId;
        }

        #region TB KeyDown Events
        private void AcctName_tb_KeyDown(object sender, KeyEventArgs e)
        {
            ClearPlaceholderText(AcctName_tb, "Enter Name of Account Holder");
        }

        private void AcctNumber_tb_KeyDown(object sender, KeyEventArgs e)
        {
            ClearPlaceholderText(AcctNumber_tb, "Enter Account Number");
        }

        private void AcctType_tb_KeyDown(object sender, KeyEventArgs e)
        {
            ClearPlaceholderText(AcctType_tb, "Enter Account Type");
        }

        private void AcctBalance_tb_KeyDown(object sender, KeyEventArgs e)
        {
            ClearPlaceholderText(AcctBalance_tb, "Enter Account Balance");
        }
        #endregion

        #region TB Click Events
        private void AcctName_tb_Click(object sender, EventArgs e)
        {
            ClearPlaceholderText(AcctName_tb, "Enter Name of Account Holder");
            SetPlaceholderText(AcctNumber_tb, "Enter Account Number");
            SetPlaceholderText(AcctType_tb, "Enter Account Type");
            SetPlaceholderText(AcctBalance_tb, "Enter Account Balance");
        }

        private void AcctNumber_tb_Click(object sender, EventArgs e)
        {
            ClearPlaceholderText(AcctNumber_tb, "Enter Account Number");
            SetPlaceholderText(AcctName_tb, "Enter Name of Account Holder");
            SetPlaceholderText(AcctType_tb, "Enter Account Type");
            SetPlaceholderText(AcctBalance_tb, "Enter Account Balance");
        }

        private void AcctType_tb_Click(object sender, EventArgs e)
        {
            ClearPlaceholderText(AcctType_tb, "Enter Account Type");
            SetPlaceholderText(AcctName_tb, "Enter Name of Account Holder");
            SetPlaceholderText(AcctNumber_tb, "Enter Account Number");
            SetPlaceholderText(AcctBalance_tb, "Enter Account Balance");
        }

        private void AcctBalance_tb_Click(object sender, EventArgs e)
        {
            ClearPlaceholderText(AcctBalance_tb, "Enter Account Balance");
            SetPlaceholderText(AcctName_tb, "Enter Name of Account Holder");
            SetPlaceholderText(AcctNumber_tb, "Enter Account Number");
            SetPlaceholderText(AcctType_tb, "Enter Account Type");
        }
        #endregion

        private void ClearPlaceholderText(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Clear();
                textBox.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            if (textBox.Text.Length < 1)
            {
                textBox.ForeColor = Color.DarkGray;
                textBox.Text = placeholder;
            }
        }
    }
}
