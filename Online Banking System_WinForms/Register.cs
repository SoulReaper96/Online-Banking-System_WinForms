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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Password_tb.UseSystemPasswordChar = true;
            RePassword_tb.UseSystemPasswordChar = true;
        }

        private void Close_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Documents\\OnlineBanking.mdf;Integrated Security=True;Connect Timeout=30";
            string _username = Username_tb.Text;
            string _fullname = FullName_tb.Text;
            string _email = Email_tb.Text;
            string _address = Address_tb.Text;
            string _phone = Phone_tb.Text;
            string _password = Password_tb.Text;
            string _repassword = RePassword_tb.Text;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string Query = "INSERT INTO UserTable (Username, FullName, Email, Address, PhoneNumber, Password) VALUES (@Username, @FullName, @Email, @Address, @PhoneNumber, @Password)";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Username", _username);
                    command.Parameters.AddWithValue("@FullName", _fullname);
                    command.Parameters.AddWithValue("@Email", _email);
                    command.Parameters.AddWithValue("@Address", _address);
                    command.Parameters.AddWithValue("@PhoneNumber", _phone);
                    command.Parameters.AddWithValue("@Password", _password);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Registration Successful");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error has occurred: " + ex.Message);
                    }
                }
            }
        }

        private void ShowPass_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass_chk.Checked)
            {
                Password_tb.UseSystemPasswordChar = false;
                RePassword_tb.UseSystemPasswordChar = false;
            }
            else
            {
                Password_tb.UseSystemPasswordChar = true;
                RePassword_tb.UseSystemPasswordChar = true;
            }
        }

        #region TB KeyDown Events
        private void FullName_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (FullName_tb.Text == "Enter Fullname")
            {
                FullName_tb.Clear();
                FullName_tb.ForeColor = Color.Black;
            }
        }

        private void Username_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (Username_tb.Text == "Enter Username")
            {
                Username_tb.Clear();
                Username_tb.ForeColor = Color.Black;
            }
        }

        private void Email_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (Email_tb.Text == "Enter Email")
            {
                Email_tb.Clear();
                Email_tb.ForeColor = Color.Black;
            }
        }

        private void Address_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (Address_tb.Text == "Enter Address")
            {
                Address_tb.Clear();
                Address_tb.ForeColor = Color.Black;
            }
        }

        private void Phone_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (Phone_tb.Text == "Enter Phone Number")
            {
                Phone_tb.Clear();
                Phone_tb.ForeColor = Color.Black;
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

        private void RePassword_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (RePassword_tb.Text == "Re-Enter Password")
            {
                RePassword_tb.Clear();
                RePassword_tb.ForeColor = Color.Black;
            }
        }
        #endregion

        #region TB Click Events
        private void FullName_tb_Click(object sender, EventArgs e)
        {
            if (FullName_tb.Text == "Enter Fullname")
            {
                FullName_tb.Clear();
                FullName_tb.ForeColor = Color.Black;
            }

            if (Username_tb.Text.Length < 1)
            {
                Username_tb.ForeColor = Color.DarkGray;
                Username_tb.Text = "Enter Username";
            }

            if (Email_tb.Text.Length < 1)
            {
                Email_tb.ForeColor = Color.DarkGray;
                Email_tb.Text = "Enter Email";
            }

            if (Address_tb.Text.Length < 1)
            {
                Address_tb.ForeColor = Color.DarkGray;
                Address_tb.Text = "Enter Address";
            }

            if (Phone_tb.Text.Length < 1)
            {
                Phone_tb.ForeColor = Color.DarkGray;
                Phone_tb.Text = "Enter Phone Number";
            }

            if (Password_tb.Text.Length < 1)
            {
                Password_tb.ForeColor = Color.DarkGray;
                Password_tb.UseSystemPasswordChar = false;
                Password_tb.Text = "Enter Password";
            }

            if (RePassword_tb.Text.Length < 1)
            {
                RePassword_tb.ForeColor = Color.DarkGray;
                RePassword_tb.UseSystemPasswordChar = false;
                RePassword_tb.Text = "Re-Enter Password";
            }
        }

        private void Username_tb_Click(object sender, EventArgs e)
        {
            if (Username_tb.Text == "Enter Username")
            {
                Username_tb.Clear();
                Username_tb.ForeColor = Color.Black;
            }

            if (FullName_tb.Text.Length < 1)
            {
                FullName_tb.ForeColor = Color.DarkGray;
                FullName_tb.Text = "Enter Fullname";
            }

            if (Email_tb.Text.Length < 1)
            {
                Email_tb.ForeColor = Color.DarkGray;
                Email_tb.Text = "Enter Email";
            }

            if (Address_tb.Text.Length < 1)
            {
                Address_tb.ForeColor = Color.DarkGray;
                Address_tb.Text = "Enter Address";
            }

            if (Phone_tb.Text.Length < 1)
            {
                Phone_tb.ForeColor = Color.DarkGray;
                Phone_tb.Text = "Enter Phone Number";
            }

            if (Password_tb.Text.Length < 1)
            {
                Password_tb.ForeColor = Color.DarkGray;
                Password_tb.UseSystemPasswordChar = false;
                Password_tb.Text = "Enter Password";
            }

            if (RePassword_tb.Text.Length < 1)
            {
                RePassword_tb.ForeColor = Color.DarkGray;
                RePassword_tb.UseSystemPasswordChar = false;
                RePassword_tb.Text = "Re-Enter Password";
            }
        }

        private void Email_tb_Click(object sender, EventArgs e)
        {
            if (Email_tb.Text == "Enter Email")
            {
                Email_tb.Clear();
                Email_tb.ForeColor = Color.Black;
            }

            if (Username_tb.Text.Length < 1)
            {
                Username_tb.ForeColor = Color.DarkGray;
                Username_tb.Text = "Enter Username";
            }

            if (FullName_tb.Text.Length < 1)
            {
                FullName_tb.ForeColor = Color.DarkGray;
                FullName_tb.Text = "Enter Fullname";
            }

            if (Address_tb.Text.Length < 1)
            {
                Address_tb.ForeColor = Color.DarkGray;
                Address_tb.Text = "Enter Address";
            }

            if (Phone_tb.Text.Length < 1)
            {
                Phone_tb.ForeColor = Color.DarkGray;
                Phone_tb.Text = "Enter Phone Number";
            }

            if (Password_tb.Text.Length < 1)
            {
                Password_tb.UseSystemPasswordChar = false;
                Password_tb.ForeColor = Color.DarkGray;
                Password_tb.Text = "Enter Password";
            }

            if (RePassword_tb.Text.Length < 1)
            {
                RePassword_tb.ForeColor = Color.DarkGray;
                RePassword_tb.UseSystemPasswordChar = false;
                RePassword_tb.Text = "Re-Enter Password";
            }
        }

        private void Address_tb_Click(object sender, EventArgs e)
        {
            if (Address_tb.Text == "Enter Address")
            {
                Address_tb.Clear();
                Address_tb.ForeColor = Color.Black;
            }

            if (FullName_tb.Text.Length < 1)
            {
                FullName_tb.ForeColor = Color.DarkGray;
                FullName_tb.Text = "Enter Fullname";
            }

            if (Username_tb.Text.Length < 1)
            {
                Username_tb.ForeColor = Color.DarkGray;
                Username_tb.Text = "Enter Username";
            }

            if (Email_tb.Text.Length < 1)
            {
                Email_tb.ForeColor = Color.DarkGray;
                Email_tb.Text = "Enter Email";
            }

            if (Phone_tb.Text.Length < 1)
            {
                Phone_tb.ForeColor = Color.DarkGray;
                Phone_tb.Text = "Enter Phone Number";
            }

            if (Password_tb.Text.Length < 1)
            {
                Password_tb.ForeColor = Color.DarkGray;
                Password_tb.UseSystemPasswordChar = false;
                Password_tb.Text = "Enter Password";
            }

            if (RePassword_tb.Text.Length < 1)
            {
                RePassword_tb.ForeColor = Color.DarkGray;
                RePassword_tb.UseSystemPasswordChar = false;
                RePassword_tb.Text = "Re-Enter Password";
            }
        }

        private void Phone_tb_Click(object sender, EventArgs e)
        {
            if (Phone_tb.Text == "Enter Phone Number")
            {
                Phone_tb.Clear();
                Phone_tb.ForeColor = Color.Black;
            }

            if (FullName_tb.Text.Length < 1)
            {
                FullName_tb.ForeColor = Color.DarkGray;
                FullName_tb.Text = "Enter Fullname";
            }

            if (Username_tb.Text.Length < 1)
            {
                Username_tb.ForeColor = Color.DarkGray;
                Username_tb.Text = "Enter Username";
            }

            if (Email_tb.Text.Length < 1)
            {
                Email_tb.ForeColor = Color.DarkGray;
                Email_tb.Text = "Enter Email";
            }

            if (Address_tb.Text.Length < 1)
            {
                Address_tb.ForeColor = Color.DarkGray;
                Address_tb.Text = "Enter Address";
            }

            if (Password_tb.Text.Length < 1)
            {
                Password_tb.ForeColor = Color.DarkGray;
                Password_tb.UseSystemPasswordChar = false;
                Password_tb.Text = "Enter Password";
            }

            if (RePassword_tb.Text.Length < 1)
            {
                RePassword_tb.ForeColor = Color.DarkGray;
                RePassword_tb.UseSystemPasswordChar = false;
                RePassword_tb.Text = "Re-Enter Password";
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

            if (FullName_tb.Text.Length < 1)
            {
                FullName_tb.ForeColor = Color.DarkGray;
                FullName_tb.Text = "Enter Fullname";
            }

            if (Address_tb.Text.Length < 1)
            {
                Address_tb.ForeColor = Color.DarkGray;
                Address_tb.Text = "Enter Address";
            }

            if (Phone_tb.Text.Length < 1)
            {
                Phone_tb.ForeColor = Color.DarkGray;
                Phone_tb.Text = "Enter Phone Number";
            }

            if (Email_tb.Text.Length < 1)
            {
                Email_tb.ForeColor = Color.DarkGray;
                Email_tb.Text = "Enter Email";
            }

            if (RePassword_tb.Text.Length < 1)
            {
                RePassword_tb.ForeColor = Color.DarkGray;
                RePassword_tb.UseSystemPasswordChar = false;
                RePassword_tb.Text = "Re-Enter Password";
            }
        }

        private void RePassword_tb_Click(object sender, EventArgs e)
        {
            if (RePassword_tb.Text == "Re-Enter Password")
            {
                RePassword_tb.Clear();
                RePassword_tb.ForeColor = Color.Black;
                RePassword_tb.UseSystemPasswordChar = true;
            }

            if (Username_tb.Text.Length < 1)
            {
                Username_tb.ForeColor = Color.DarkGray;
                Username_tb.Text = "Enter Username";
            }

            if (FullName_tb.Text.Length < 1)
            {
                FullName_tb.ForeColor = Color.DarkGray;
                FullName_tb.Text = "Enter Fullname";
            }

            if (Address_tb.Text.Length < 1)
            {
                Address_tb.ForeColor = Color.DarkGray;
                Address_tb.Text = "Enter Address";
            }

            if (Phone_tb.Text.Length < 1)
            {
                Phone_tb.ForeColor = Color.DarkGray;
                Phone_tb.Text = "Enter Phone Number";
            }

            if (Email_tb.Text.Length < 1)
            {
                Email_tb.ForeColor = Color.DarkGray;
                Email_tb.Text = "Enter Email";
            }

            if (Password_tb.Text.Length < 1)
            {
                Password_tb.UseSystemPasswordChar = false;
                Password_tb.ForeColor = Color.DarkGray;
                Password_tb.Text = "Enter Password";
            }
        }
        #endregion
    }
}
