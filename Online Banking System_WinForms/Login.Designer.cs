namespace Online_Banking_System_WinForms
{
    partial class Login
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
            Login_btn = new Button();
            Register_btn = new Button();
            label1 = new Label();
            Password_tb = new TextBox();
            Username_tb = new TextBox();
            Close_lbl = new Label();
            ShowPass_chk = new CheckBox();
            SuspendLayout();
            // 
            // Login_btn
            // 
            Login_btn.FlatStyle = FlatStyle.Flat;
            Login_btn.ForeColor = Color.White;
            Login_btn.Location = new Point(175, 223);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(100, 25);
            Login_btn.TabIndex = 0;
            Login_btn.Text = "LOGIN";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click;
            // 
            // Register_btn
            // 
            Register_btn.FlatStyle = FlatStyle.Flat;
            Register_btn.ForeColor = Color.White;
            Register_btn.Location = new Point(281, 223);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(100, 25);
            Register_btn.TabIndex = 1;
            Register_btn.Text = "REGISTER";
            Register_btn.UseVisualStyleBackColor = true;
            Register_btn.Click += Register_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // Password_tb
            // 
            Password_tb.BorderStyle = BorderStyle.FixedSingle;
            Password_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_tb.ForeColor = Color.DarkGray;
            Password_tb.Location = new Point(12, 144);
            Password_tb.Name = "Password_tb";
            Password_tb.Size = new Size(503, 39);
            Password_tb.TabIndex = 4;
            Password_tb.Text = "Enter Password";
            Password_tb.Click += Password_tb_Click;
            Password_tb.KeyDown += Password_tb_KeyDown;
            // 
            // Username_tb
            // 
            Username_tb.BorderStyle = BorderStyle.FixedSingle;
            Username_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_tb.ForeColor = Color.DarkGray;
            Username_tb.Location = new Point(12, 77);
            Username_tb.Name = "Username_tb";
            Username_tb.Size = new Size(503, 39);
            Username_tb.TabIndex = 5;
            Username_tb.Text = "Enter Username";
            Username_tb.Click += Username_tb_Click;
            Username_tb.KeyDown += Username_tb_KeyDown;
            // 
            // Close_lbl
            // 
            Close_lbl.AutoSize = true;
            Close_lbl.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_lbl.Location = new Point(492, 9);
            Close_lbl.Name = "Close_lbl";
            Close_lbl.Size = new Size(23, 22);
            Close_lbl.TabIndex = 8;
            Close_lbl.Text = "X";
            Close_lbl.Click += Close_lbl_Click;
            // 
            // ShowPass_chk
            // 
            ShowPass_chk.AutoSize = true;
            ShowPass_chk.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPass_chk.ForeColor = Color.White;
            ShowPass_chk.Location = new Point(381, 189);
            ShowPass_chk.Name = "ShowPass_chk";
            ShowPass_chk.Size = new Size(134, 19);
            ShowPass_chk.TabIndex = 9;
            ShowPass_chk.Text = "SHOW PASSWORD";
            ShowPass_chk.UseVisualStyleBackColor = true;
            ShowPass_chk.CheckedChanged += ShowPass_chk_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 103, 110);
            ClientSize = new Size(527, 260);
            Controls.Add(ShowPass_chk);
            Controls.Add(Close_lbl);
            Controls.Add(Username_tb);
            Controls.Add(Password_tb);
            Controls.Add(label1);
            Controls.Add(Register_btn);
            Controls.Add(Login_btn);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            Click += Login_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_btn;
        private Button Register_btn;
        private Label label1;
        private TextBox Password_tb;
        private TextBox Username_tb;
        private Label Close_lbl;
        private CheckBox ShowPass_chk;
    }
}