using System.Data;
using System.Data.SqlClient;

namespace Online_Banking_System_WinForms
{
    public partial class OnlineBankingApp : Form
    {
        public OnlineBankingApp()
        {
            InitializeComponent();
            LoadData();
            UserName_tb.Text = Login._username;
            UserPass_tb.Text = Login._password;
            UserFullName_tb.Text = Register._fullname;
            UserEmail_tb.Text = Register._email;
            UserAddr_tb.Text = Register._address;
            UserPhone_tb.Text = Register._phone;
        }

        private void LoadData()
        {
            // Create a DataTable to hold the data
            DataTable table = new DataTable();
            table.Columns.Add("Select", typeof(bool));
            table.Columns.Add("Item", typeof(string));

            // Add some sample data
            table.Rows.Add(false, "Item 1");
            table.Rows.Add(false, "Item 2");
            table.Rows.Add(false, "Item 3");

            // Bind the DataTable to the DataGridView
            Bills_dgv.DataSource = table;

            // Set the DataGridView properties
            Bills_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Bills_dgv.AllowUserToAddRows = false;
            Bills_dgv.AllowUserToDeleteRows = false;
            Bills_dgv.ReadOnly = false;
        }

        private void HomeMenu_tool_Click(object sender, EventArgs e)
        {
            HomeTab.Visible = true;
            MenuTabs.SelectedTab = HomeTab;
        }

        private void AccountsMenu_tool_Click(object sender, EventArgs e)
        {
            AccountsTab.Visible = true;
            MenuTabs.SelectedTab = AccountsTab;
        }

        private void TransactionsMenu_tool_Click(object sender, EventArgs e)
        {
            TransactionsMenu_tool.Visible = true;
            MenuTabs.SelectedTab = TxnsTab;
        }

        private void LogoutMenu_tool_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void AddAccount_tb_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.Show();
            this.Hide();
        }

        private void FundsMenu_tool_Click(object sender, EventArgs e)
        {
            FundsMenu_tool.Visible = true;
            MenuTabs.SelectedTab = TransferFundsTab;
        }

        private void BillsMenu_tool_Click(object sender, EventArgs e)
        {
            BillsMenu_tool.Visible = true;
            MenuTabs.SelectedTab = PayBillsTab;
        }
    }
}
