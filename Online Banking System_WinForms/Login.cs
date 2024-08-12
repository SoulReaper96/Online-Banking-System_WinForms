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
    public partial class Login : Form
    {
        public static string _username { get; internal set; }
        public static string _password { get; internal set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Password_tb.UseSystemPasswordChar = true;
        }

        private void Close_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPass_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass_chk.Checked)
            {
                Password_tb.UseSystemPasswordChar = false;
            }
            else
            {
                Password_tb.UseSystemPasswordChar = true;
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Documents\\OnlineBanking.mdf;Integrated Security=True;Connect Timeout=30";
            _username = Username_tb.Text;
            _password = Password_tb.Text;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string Query = "SELECT COUNT(*) FROM UserTable WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Username", _username);
                    command.Parameters.AddWithValue("@Password", _password);

                    try
                    {
                        connection.Open();
                        int _count = Convert.ToInt32(command.ExecuteScalar());
                        connection.Close();

                        if (_count == 1)
                        {
                            MessageBox.Show("Login Successful");
                            OnlineBankingApp onlineBankingApp = new OnlineBankingApp();
                            onlineBankingApp.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error has occurred: " + ex.Message);
                    }
                }
            }
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        #region TB KeyDown Events
        private void Username_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (Username_tb.Text == "Enter Username")
            {
                Username_tb.Clear();
                Username_tb.ForeColor = Color.Black;
            }
        }

        private void Password_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (Password_tb.Text == "Enter Password")
            {
                Password_tb.Clear();
                Password_tb.ForeColor = Color.Black;
            }
        }
        #endregion

        #region TB Click Events
        private void Username_tb_Click(object sender, EventArgs e)
        {
            if (Username_tb.Text == "Enter Username")
            {
                Username_tb.Clear();
                Username_tb.ForeColor = Color.Black;
            }

            if (Password_tb.Text.Length < 1)
            {
                Password_tb.ForeColor = Color.DarkGray;
                Password_tb.UseSystemPasswordChar = false;
                Password_tb.Text = "Enter Password";
            }
        }

        private void Password_tb_Click(object sender, EventArgs e)
        {
            if (Password_tb.Text == "Enter Password")
            {
                Password_tb.Clear();
                Password_tb.UseSystemPasswordChar = true;
                Password_tb.ForeColor = Color.Black;
            }

            if (Username_tb.Text.Length < 1)
            {
                Username_tb.ForeColor = Color.DarkGray;
                Username_tb.Text = "Enter Username";
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Password_tb.Text.Length < 1)
            {
                Password_tb.ForeColor = Color.DarkGray;
                Password_tb.UseSystemPasswordChar = false;
                Password_tb.Text = "Enter Password";
            }

            if (Username_tb.Text.Length < 1)
            {
                Username_tb.ForeColor = Color.DarkGray;
                Username_tb.Text = "Enter Username";
            }
        }
        #endregion
    }
}
