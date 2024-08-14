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
            LoadData();
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
