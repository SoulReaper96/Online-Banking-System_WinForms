namespace Online_Banking_System_WinForms
{
    partial class OnlineBankingApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            HomeMenu_tool = new ToolStripMenuItem();
            AccountsMenu_tool = new ToolStripMenuItem();
            TransactionsMenu_tool = new ToolStripMenuItem();
            FundsMenu_tool = new ToolStripMenuItem();
            BillsMenu_tool = new ToolStripMenuItem();
            LogoutMenu_tool = new ToolStripMenuItem();
            MenuTabs = new TabControl();
            HomeTab = new TabPage();
            label7 = new Label();
            UserPhone_tb = new TextBox();
            label6 = new Label();
            UserEmail_tb = new TextBox();
            label5 = new Label();
            UserAddr_tb = new TextBox();
            label4 = new Label();
            UserFullName_tb = new TextBox();
            label3 = new Label();
            UserPass_tb = new TextBox();
            label2 = new Label();
            UserName_tb = new TextBox();
            label1 = new Label();
            UserId_tb = new TextBox();
            AccountsTab = new TabPage();
            Accounts_dgv = new DataGridView();
            AddAccount_tb = new Button();
            TxnsTab = new TabPage();
            TxnHistory_dgv = new DataGridView();
            TransferFundsTab = new TabPage();
            TrnsFunds_btn = new Button();
            ToAcct_cmb = new ComboBox();
            FromAcct_cmb = new ComboBox();
            Amount_tb = new TextBox();
            PayBillsTab = new TabPage();
            PayBills_btn = new Button();
            Bills_dgv = new DataGridView();
            menuStrip1.SuspendLayout();
            MenuTabs.SuspendLayout();
            HomeTab.SuspendLayout();
            AccountsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Accounts_dgv).BeginInit();
            TxnsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxnHistory_dgv).BeginInit();
            TransferFundsTab.SuspendLayout();
            PayBillsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Bills_dgv).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { HomeMenu_tool, AccountsMenu_tool, TransactionsMenu_tool, FundsMenu_tool, BillsMenu_tool, LogoutMenu_tool });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(721, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // HomeMenu_tool
            // 
            HomeMenu_tool.Name = "HomeMenu_tool";
            HomeMenu_tool.Size = new Size(53, 20);
            HomeMenu_tool.Text = "Home";
            HomeMenu_tool.Click += HomeMenu_tool_Click;
            // 
            // AccountsMenu_tool
            // 
            AccountsMenu_tool.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountsMenu_tool.Name = "AccountsMenu_tool";
            AccountsMenu_tool.Size = new Size(115, 20);
            AccountsMenu_tool.Text = "Manage Accounts";
            AccountsMenu_tool.Click += AccountsMenu_tool_Click;
            // 
            // TransactionsMenu_tool
            // 
            TransactionsMenu_tool.Name = "TransactionsMenu_tool";
            TransactionsMenu_tool.Size = new Size(120, 20);
            TransactionsMenu_tool.Text = "View Transactions";
            TransactionsMenu_tool.Click += TransactionsMenu_tool_Click;
            // 
            // FundsMenu_tool
            // 
            FundsMenu_tool.Name = "FundsMenu_tool";
            FundsMenu_tool.Size = new Size(103, 20);
            FundsMenu_tool.Text = "Transfer Funds";
            FundsMenu_tool.Click += FundsMenu_tool_Click;
            // 
            // BillsMenu_tool
            // 
            BillsMenu_tool.Name = "BillsMenu_tool";
            BillsMenu_tool.Size = new Size(66, 20);
            BillsMenu_tool.Text = "Pay Bills";
            BillsMenu_tool.Click += BillsMenu_tool_Click;
            // 
            // LogoutMenu_tool
            // 
            LogoutMenu_tool.Name = "LogoutMenu_tool";
            LogoutMenu_tool.Size = new Size(57, 20);
            LogoutMenu_tool.Text = "Logout";
            LogoutMenu_tool.Click += LogoutMenu_tool_Click;
            // 
            // MenuTabs
            // 
            MenuTabs.Controls.Add(HomeTab);
            MenuTabs.Controls.Add(AccountsTab);
            MenuTabs.Controls.Add(TxnsTab);
            MenuTabs.Controls.Add(TransferFundsTab);
            MenuTabs.Controls.Add(PayBillsTab);
            MenuTabs.Dock = DockStyle.Fill;
            MenuTabs.Location = new Point(0, 24);
            MenuTabs.Name = "MenuTabs";
            MenuTabs.SelectedIndex = 0;
            MenuTabs.Size = new Size(721, 629);
            MenuTabs.TabIndex = 1;
            // 
            // HomeTab
            // 
            HomeTab.Controls.Add(label7);
            HomeTab.Controls.Add(UserPhone_tb);
            HomeTab.Controls.Add(label6);
            HomeTab.Controls.Add(UserEmail_tb);
            HomeTab.Controls.Add(label5);
            HomeTab.Controls.Add(UserAddr_tb);
            HomeTab.Controls.Add(label4);
            HomeTab.Controls.Add(UserFullName_tb);
            HomeTab.Controls.Add(label3);
            HomeTab.Controls.Add(UserPass_tb);
            HomeTab.Controls.Add(label2);
            HomeTab.Controls.Add(UserName_tb);
            HomeTab.Controls.Add(label1);
            HomeTab.Controls.Add(UserId_tb);
            HomeTab.Location = new Point(4, 26);
            HomeTab.Name = "HomeTab";
            HomeTab.Padding = new Padding(3);
            HomeTab.Size = new Size(713, 599);
            HomeTab.TabIndex = 0;
            HomeTab.Text = "Home";
            HomeTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 427);
            label7.Name = "label7";
            label7.Size = new Size(110, 17);
            label7.TabIndex = 13;
            label7.Text = "Phone Number:";
            // 
            // UserPhone_tb
            // 
            UserPhone_tb.Location = new Point(88, 447);
            UserPhone_tb.Name = "UserPhone_tb";
            UserPhone_tb.Size = new Size(150, 25);
            UserPhone_tb.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 257);
            label6.Name = "label6";
            label6.Size = new Size(106, 17);
            label6.TabIndex = 11;
            label6.Text = "Email Address:";
            // 
            // UserEmail_tb
            // 
            UserEmail_tb.Location = new Point(88, 277);
            UserEmail_tb.Name = "UserEmail_tb";
            UserEmail_tb.Size = new Size(150, 25);
            UserEmail_tb.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 367);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 9;
            label5.Text = "Address:";
            // 
            // UserAddr_tb
            // 
            UserAddr_tb.Location = new Point(88, 387);
            UserAddr_tb.Name = "UserAddr_tb";
            UserAddr_tb.Size = new Size(150, 25);
            UserAddr_tb.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 313);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 7;
            label4.Text = "Full Name:";
            // 
            // UserFullName_tb
            // 
            UserFullName_tb.Location = new Point(88, 333);
            UserFullName_tb.Name = "UserFullName_tb";
            UserFullName_tb.Size = new Size(150, 25);
            UserFullName_tb.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 199);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // UserPass_tb
            // 
            UserPass_tb.Location = new Point(88, 219);
            UserPass_tb.Name = "UserPass_tb";
            UserPass_tb.Size = new Size(150, 25);
            UserPass_tb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 127);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // UserName_tb
            // 
            UserName_tb.Location = new Point(88, 147);
            UserName_tb.Name = "UserName_tb";
            UserName_tb.Size = new Size(150, 25);
            UserName_tb.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 67);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 1;
            label1.Text = "User ID:";
            // 
            // UserId_tb
            // 
            UserId_tb.Location = new Point(88, 87);
            UserId_tb.Name = "UserId_tb";
            UserId_tb.Size = new Size(150, 25);
            UserId_tb.TabIndex = 0;
            // 
            // AccountsTab
            // 
            AccountsTab.Controls.Add(Accounts_dgv);
            AccountsTab.Controls.Add(AddAccount_tb);
            AccountsTab.Location = new Point(4, 26);
            AccountsTab.Name = "AccountsTab";
            AccountsTab.Padding = new Padding(3);
            AccountsTab.Size = new Size(713, 599);
            AccountsTab.TabIndex = 1;
            AccountsTab.Text = "Manage Accounts";
            AccountsTab.UseVisualStyleBackColor = true;
            // 
            // Accounts_dgv
            // 
            Accounts_dgv.BackgroundColor = Color.Gainsboro;
            Accounts_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Accounts_dgv.Dock = DockStyle.Fill;
            Accounts_dgv.Location = new Point(3, 28);
            Accounts_dgv.Name = "Accounts_dgv";
            Accounts_dgv.Size = new Size(707, 568);
            Accounts_dgv.TabIndex = 0;
            // 
            // AddAccount_tb
            // 
            AddAccount_tb.BackColor = Color.WhiteSmoke;
            AddAccount_tb.Dock = DockStyle.Top;
            AddAccount_tb.FlatStyle = FlatStyle.Flat;
            AddAccount_tb.Location = new Point(3, 3);
            AddAccount_tb.Name = "AddAccount_tb";
            AddAccount_tb.Size = new Size(707, 25);
            AddAccount_tb.TabIndex = 1;
            AddAccount_tb.Text = "ADD ACCOUNT";
            AddAccount_tb.UseVisualStyleBackColor = false;
            AddAccount_tb.Click += AddAccount_tb_Click;
            // 
            // TxnsTab
            // 
            TxnsTab.Controls.Add(TxnHistory_dgv);
            TxnsTab.Location = new Point(4, 24);
            TxnsTab.Name = "TxnsTab";
            TxnsTab.Padding = new Padding(3);
            TxnsTab.Size = new Size(713, 601);
            TxnsTab.TabIndex = 4;
            TxnsTab.Text = "View Transactions";
            TxnsTab.UseVisualStyleBackColor = true;
            // 
            // TxnHistory_dgv
            // 
            TxnHistory_dgv.BackgroundColor = Color.Gainsboro;
            TxnHistory_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TxnHistory_dgv.Dock = DockStyle.Fill;
            TxnHistory_dgv.Location = new Point(3, 3);
            TxnHistory_dgv.Name = "TxnHistory_dgv";
            TxnHistory_dgv.Size = new Size(707, 595);
            TxnHistory_dgv.TabIndex = 3;
            // 
            // TransferFundsTab
            // 
            TransferFundsTab.Controls.Add(TrnsFunds_btn);
            TransferFundsTab.Controls.Add(ToAcct_cmb);
            TransferFundsTab.Controls.Add(FromAcct_cmb);
            TransferFundsTab.Controls.Add(Amount_tb);
            TransferFundsTab.Location = new Point(4, 24);
            TransferFundsTab.Name = "TransferFundsTab";
            TransferFundsTab.Padding = new Padding(3);
            TransferFundsTab.Size = new Size(713, 601);
            TransferFundsTab.TabIndex = 5;
            TransferFundsTab.Text = "Transfer Funds";
            TransferFundsTab.UseVisualStyleBackColor = true;
            // 
            // TrnsFunds_btn
            // 
            TrnsFunds_btn.BackColor = Color.WhiteSmoke;
            TrnsFunds_btn.Dock = DockStyle.Top;
            TrnsFunds_btn.FlatStyle = FlatStyle.Flat;
            TrnsFunds_btn.ForeColor = Color.Black;
            TrnsFunds_btn.Location = new Point(3, 3);
            TrnsFunds_btn.Name = "TrnsFunds_btn";
            TrnsFunds_btn.Size = new Size(707, 25);
            TrnsFunds_btn.TabIndex = 44;
            TrnsFunds_btn.Text = "TRANSFER";
            TrnsFunds_btn.UseVisualStyleBackColor = false;
            // 
            // ToAcct_cmb
            // 
            ToAcct_cmb.Font = new Font("Arial", 20.25F);
            ToAcct_cmb.ForeColor = Color.DarkGray;
            ToAcct_cmb.FormattingEnabled = true;
            ToAcct_cmb.Location = new Point(402, 128);
            ToAcct_cmb.Name = "ToAcct_cmb";
            ToAcct_cmb.Size = new Size(200, 40);
            ToAcct_cmb.TabIndex = 43;
            ToAcct_cmb.Text = "To";
            // 
            // FromAcct_cmb
            // 
            FromAcct_cmb.Font = new Font("Arial", 20.25F);
            FromAcct_cmb.ForeColor = Color.DarkGray;
            FromAcct_cmb.FormattingEnabled = true;
            FromAcct_cmb.Location = new Point(99, 128);
            FromAcct_cmb.Name = "FromAcct_cmb";
            FromAcct_cmb.Size = new Size(200, 40);
            FromAcct_cmb.TabIndex = 42;
            FromAcct_cmb.Text = "From";
            // 
            // Amount_tb
            // 
            Amount_tb.BorderStyle = BorderStyle.FixedSingle;
            Amount_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amount_tb.ForeColor = Color.DarkGray;
            Amount_tb.Location = new Point(99, 174);
            Amount_tb.Name = "Amount_tb";
            Amount_tb.Size = new Size(503, 39);
            Amount_tb.TabIndex = 41;
            Amount_tb.Text = "Enter Amount To Transfer";
            // 
            // PayBillsTab
            // 
            PayBillsTab.Controls.Add(PayBills_btn);
            PayBillsTab.Controls.Add(Bills_dgv);
            PayBillsTab.Location = new Point(4, 24);
            PayBillsTab.Name = "PayBillsTab";
            PayBillsTab.Padding = new Padding(3);
            PayBillsTab.Size = new Size(713, 601);
            PayBillsTab.TabIndex = 6;
            PayBillsTab.Text = "Pay Bills";
            PayBillsTab.UseVisualStyleBackColor = true;
            // 
            // PayBills_btn
            // 
            PayBills_btn.BackColor = Color.WhiteSmoke;
            PayBills_btn.Dock = DockStyle.Top;
            PayBills_btn.FlatStyle = FlatStyle.Flat;
            PayBills_btn.ForeColor = Color.Black;
            PayBills_btn.Location = new Point(3, 3);
            PayBills_btn.Name = "PayBills_btn";
            PayBills_btn.Size = new Size(707, 25);
            PayBills_btn.TabIndex = 40;
            PayBills_btn.Text = "PAY";
            PayBills_btn.UseVisualStyleBackColor = false;
            // 
            // Bills_dgv
            // 
            Bills_dgv.AllowUserToAddRows = false;
            Bills_dgv.AllowUserToDeleteRows = false;
            Bills_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Bills_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Bills_dgv.BackgroundColor = Color.Gainsboro;
            Bills_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Bills_dgv.Dock = DockStyle.Fill;
            Bills_dgv.Location = new Point(3, 3);
            Bills_dgv.Name = "Bills_dgv";
            Bills_dgv.Size = new Size(707, 595);
            Bills_dgv.TabIndex = 41;
            // 
            // OnlineBankingApp
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(721, 653);
            Controls.Add(MenuTabs);
            Controls.Add(menuStrip1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "OnlineBankingApp";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MenuTabs.ResumeLayout(false);
            HomeTab.ResumeLayout(false);
            HomeTab.PerformLayout();
            AccountsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Accounts_dgv).EndInit();
            TxnsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TxnHistory_dgv).EndInit();
            TransferFundsTab.ResumeLayout(false);
            TransferFundsTab.PerformLayout();
            PayBillsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Bills_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem HomeMenu_tool;
        private ToolStripMenuItem AccountsMenu_tool;
        private ToolStripMenuItem FundsMenu_tool;
        private ToolStripMenuItem BillsMenu_tool;
        private ToolStripMenuItem TransactionsMenu_tool;
        private ToolStripMenuItem LogoutMenu_tool;
        private TabControl MenuTabs;
        private TabPage HomeTab;
        private TabPage AccountsTab;
        private TabPage TxnsTab;
        private DataGridView Accounts_dgv;
        private Button AddAccount_tb;
        private Label label1;
        private TextBox UserId_tb;
        private Label label7;
        private TextBox UserPhone_tb;
        private Label label6;
        private TextBox UserEmail_tb;
        private Label label5;
        private TextBox UserAddr_tb;
        private Label label4;
        private TextBox UserFullName_tb;
        private Label label3;
        private TextBox UserPass_tb;
        private Label label2;
        private TextBox UserName_tb;
        private DataGridView TxnHistory_dgv;
        private TabPage TransferFundsTab;
        private TabPage PayBillsTab;
        private ComboBox ToAcct_cmb;
        private ComboBox FromAcct_cmb;
        private TextBox Amount_tb;
        private DataGridView Bills_dgv;
        private Button PayBills_btn;
        private Button TrnsFunds_btn;
    }
}
