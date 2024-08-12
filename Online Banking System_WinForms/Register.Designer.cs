namespace Online_Banking_System_WinForms
{
    partial class Register
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
            label1 = new Label();
            ShowPass_chk = new CheckBox();
            Close_lbl = new Label();
            Username_tb = new TextBox();
            Password_tb = new TextBox();
            Register_btn = new Button();
            Email_tb = new TextBox();
            RePassword_tb = new TextBox();
            FullName_tb = new TextBox();
            Address_tb = new TextBox();
            Phone_tb = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 3;
            label1.Text = "REGISTER";
            // 
            // ShowPass_chk
            // 
            ShowPass_chk.AutoSize = true;
            ShowPass_chk.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPass_chk.ForeColor = Color.White;
            ShowPass_chk.Location = new Point(381, 376);
            ShowPass_chk.Name = "ShowPass_chk";
            ShowPass_chk.Size = new Size(134, 19);
            ShowPass_chk.TabIndex = 14;
            ShowPass_chk.Text = "SHOW PASSWORD";
            ShowPass_chk.UseVisualStyleBackColor = true;
            ShowPass_chk.CheckedChanged += ShowPass_chk_CheckedChanged;
            // 
            // Close_lbl
            // 
            Close_lbl.AutoSize = true;
            Close_lbl.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_lbl.Location = new Point(492, 9);
            Close_lbl.Name = "Close_lbl";
            Close_lbl.Size = new Size(23, 22);
            Close_lbl.TabIndex = 13;
            Close_lbl.Text = "X";
            Close_lbl.Click += Close_lbl_Click;
            // 
            // Username_tb
            // 
            Username_tb.BorderStyle = BorderStyle.FixedSingle;
            Username_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_tb.ForeColor = Color.DarkGray;
            Username_tb.Location = new Point(12, 151);
            Username_tb.Name = "Username_tb";
            Username_tb.Size = new Size(503, 39);
            Username_tb.TabIndex = 12;
            Username_tb.Text = "Enter Username";
            Username_tb.Click += Username_tb_Click;
            Username_tb.KeyDown += Username_tb_KeyDown;
            // 
            // Password_tb
            // 
            Password_tb.BorderStyle = BorderStyle.FixedSingle;
            Password_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_tb.ForeColor = Color.DarkGray;
            Password_tb.Location = new Point(12, 286);
            Password_tb.Name = "Password_tb";
            Password_tb.Size = new Size(503, 39);
            Password_tb.TabIndex = 11;
            Password_tb.Text = "Enter Password";
            Password_tb.Click += Password_tb_Click;
            Password_tb.KeyDown += Password_tb_KeyDown;
            // 
            // Register_btn
            // 
            Register_btn.FlatStyle = FlatStyle.Flat;
            Register_btn.ForeColor = Color.White;
            Register_btn.Location = new Point(210, 396);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(100, 25);
            Register_btn.TabIndex = 10;
            Register_btn.Text = "REGISTER";
            Register_btn.UseVisualStyleBackColor = true;
            Register_btn.Click += Register_btn_Click;
            // 
            // Email_tb
            // 
            Email_tb.BorderStyle = BorderStyle.FixedSingle;
            Email_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email_tb.ForeColor = Color.DarkGray;
            Email_tb.Location = new Point(12, 106);
            Email_tb.Name = "Email_tb";
            Email_tb.Size = new Size(503, 39);
            Email_tb.TabIndex = 16;
            Email_tb.Text = "Enter Email";
            Email_tb.Click += Email_tb_Click;
            Email_tb.KeyDown += Email_tb_KeyDown;
            // 
            // RePassword_tb
            // 
            RePassword_tb.BorderStyle = BorderStyle.FixedSingle;
            RePassword_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RePassword_tb.ForeColor = Color.DarkGray;
            RePassword_tb.Location = new Point(12, 331);
            RePassword_tb.Name = "RePassword_tb";
            RePassword_tb.Size = new Size(503, 39);
            RePassword_tb.TabIndex = 15;
            RePassword_tb.Text = "Re-Enter Password";
            RePassword_tb.Click += RePassword_tb_Click;
            RePassword_tb.KeyDown += RePassword_tb_KeyDown;
            // 
            // FullName_tb
            // 
            FullName_tb.BorderStyle = BorderStyle.FixedSingle;
            FullName_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FullName_tb.ForeColor = Color.DarkGray;
            FullName_tb.Location = new Point(12, 61);
            FullName_tb.Name = "FullName_tb";
            FullName_tb.Size = new Size(503, 39);
            FullName_tb.TabIndex = 17;
            FullName_tb.Text = "Enter Fullname";
            FullName_tb.Click += FullName_tb_Click;
            FullName_tb.KeyDown += FullName_tb_KeyDown;
            // 
            // Address_tb
            // 
            Address_tb.BorderStyle = BorderStyle.FixedSingle;
            Address_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Address_tb.ForeColor = Color.DarkGray;
            Address_tb.Location = new Point(12, 196);
            Address_tb.Name = "Address_tb";
            Address_tb.Size = new Size(503, 39);
            Address_tb.TabIndex = 18;
            Address_tb.Text = "Enter Address";
            Address_tb.Click += Address_tb_Click;
            Address_tb.KeyDown += Address_tb_KeyDown;
            // 
            // Phone_tb
            // 
            Phone_tb.BorderStyle = BorderStyle.FixedSingle;
            Phone_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Phone_tb.ForeColor = Color.DarkGray;
            Phone_tb.Location = new Point(12, 241);
            Phone_tb.Name = "Phone_tb";
            Phone_tb.Size = new Size(503, 39);
            Phone_tb.TabIndex = 19;
            Phone_tb.Text = "Enter Phone Number";
            Phone_tb.Click += Phone_tb_Click;
            Phone_tb.KeyDown += Phone_tb_KeyDown;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 103, 110);
            ClientSize = new Size(527, 450);
            Controls.Add(Phone_tb);
            Controls.Add(Address_tb);
            Controls.Add(FullName_tb);
            Controls.Add(Email_tb);
            Controls.Add(RePassword_tb);
            Controls.Add(ShowPass_chk);
            Controls.Add(Close_lbl);
            Controls.Add(Username_tb);
            Controls.Add(Password_tb);
            Controls.Add(Register_btn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox ShowPass_chk;
        private Label Close_lbl;
        private TextBox Username_tb;
        private TextBox Password_tb;
        private Button Register_btn;
        private TextBox Email_tb;
        private TextBox RePassword_tb;
        private TextBox FullName_tb;
        private TextBox Address_tb;
        private TextBox Phone_tb;
    }
}