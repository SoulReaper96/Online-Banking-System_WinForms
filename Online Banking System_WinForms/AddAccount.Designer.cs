namespace Online_Banking_System_WinForms
{
    partial class AddAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AcctName_tb = new TextBox();
            AcctNumber_tb = new TextBox();
            Back_lbl = new Label();
            AddAcct_btn = new Button();
            label1 = new Label();
            AcctType_tb = new TextBox();
            AcctBalance_tb = new TextBox();
            SuspendLayout();
            // 
            // AcctName_tb
            // 
            AcctName_tb.BorderStyle = BorderStyle.FixedSingle;
            AcctName_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AcctName_tb.ForeColor = Color.DarkGray;
            AcctName_tb.Location = new Point(41, 60);
            AcctName_tb.Name = "AcctName_tb";
            AcctName_tb.Size = new Size(503, 39);
            AcctName_tb.TabIndex = 29;
            AcctName_tb.Text = "Enter Name of Account Holder";
            // 
            // AcctNumber_tb
            // 
            AcctNumber_tb.BorderStyle = BorderStyle.FixedSingle;
            AcctNumber_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AcctNumber_tb.ForeColor = Color.DarkGray;
            AcctNumber_tb.Location = new Point(41, 105);
            AcctNumber_tb.Name = "AcctNumber_tb";
            AcctNumber_tb.Size = new Size(503, 39);
            AcctNumber_tb.TabIndex = 28;
            AcctNumber_tb.Text = "Enter Account Number";
            // 
            // Back_lbl
            // 
            Back_lbl.AutoSize = true;
            Back_lbl.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_lbl.Location = new Point(487, 10);
            Back_lbl.Name = "Back_lbl";
            Back_lbl.Size = new Size(57, 22);
            Back_lbl.TabIndex = 24;
            Back_lbl.Text = "Back";
            Back_lbl.Click += Back_lbl_Click;
            // 
            // AddAcct_btn
            // 
            AddAcct_btn.FlatStyle = FlatStyle.Flat;
            AddAcct_btn.ForeColor = Color.White;
            AddAcct_btn.Location = new Point(215, 293);
            AddAcct_btn.Name = "AddAcct_btn";
            AddAcct_btn.Size = new Size(127, 25);
            AddAcct_btn.TabIndex = 21;
            AddAcct_btn.Text = "ADD ACCOUNT";
            AddAcct_btn.UseVisualStyleBackColor = true;
            AddAcct_btn.Click += AddAcct_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 32);
            label1.TabIndex = 20;
            label1.Text = "ADD NEW ACCOUNT";
            // 
            // AcctType_tb
            // 
            AcctType_tb.BorderStyle = BorderStyle.FixedSingle;
            AcctType_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AcctType_tb.ForeColor = Color.DarkGray;
            AcctType_tb.Location = new Point(41, 150);
            AcctType_tb.Name = "AcctType_tb";
            AcctType_tb.Size = new Size(503, 39);
            AcctType_tb.TabIndex = 30;
            AcctType_tb.Text = "Enter Account Type";
            // 
            // AcctBalance_tb
            // 
            AcctBalance_tb.BorderStyle = BorderStyle.FixedSingle;
            AcctBalance_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AcctBalance_tb.ForeColor = Color.DarkGray;
            AcctBalance_tb.Location = new Point(41, 195);
            AcctBalance_tb.Name = "AcctBalance_tb";
            AcctBalance_tb.Size = new Size(503, 39);
            AcctBalance_tb.TabIndex = 31;
            AcctBalance_tb.Text = "Enter Account Balance";
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 113, 110);
            ClientSize = new Size(572, 372);
            Controls.Add(AcctBalance_tb);
            Controls.Add(AcctType_tb);
            Controls.Add(AcctName_tb);
            Controls.Add(AcctNumber_tb);
            Controls.Add(Back_lbl);
            Controls.Add(AddAcct_btn);
            Controls.Add(label1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AcctName_tb;
        private TextBox AcctNumber_tb;
        private Label Back_lbl;
        private Button AddAcct_btn;
        private Label label1;
        private TextBox AcctType_tb;
        private TextBox AcctBalance_tb;
    }
}