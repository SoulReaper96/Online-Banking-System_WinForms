using System.Data;
using System.Data.SqlClient;

namespace Online_Banking_System_WinForms
{
    public partial class OnlineBankingApp : Form
    {
        public OnlineBankingApp()
        {
            InitializeComponent();
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
            TransferFunds transferFunds = new TransferFunds();
            transferFunds.Show();
            this.Hide();
        }

        private void BillsMenu_tool_Click(object sender, EventArgs e)
        {
            PayBills payBills = new PayBills();
            payBills.Show();
            this.Hide();
        }
    }
}
