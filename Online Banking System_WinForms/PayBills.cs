using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Banking_System_WinForms
{
    public partial class PayBills : Form
    {
        public PayBills()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            OnlineBankingApp onlineBankingApp = new OnlineBankingApp();
            onlineBankingApp.Show();
            this.Hide();
        }

        private void PayBills_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
