namespace Online_Banking_System_WinForms
{
    partial class TransferFunds
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
            Amount_tb = new TextBox();
            Back_lbl = new Label();
            Transfer_btn = new Button();
            label1 = new Label();
            FromAcct_cmb = new ComboBox();
            ToAcct_cmb = new ComboBox();
            SuspendLayout();
            // 
            // Amount_tb
            // 
            Amount_tb.BorderStyle = BorderStyle.FixedSingle;
            Amount_tb.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amount_tb.ForeColor = Color.DarkGray;
            Amount_tb.Location = new Point(12, 154);
            Amount_tb.Name = "Amount_tb";
            Amount_tb.Size = new Size(503, 39);
            Amount_tb.TabIndex = 38;
            Amount_tb.Text = "Enter Amount To Transfer";
            // 
            // Back_lbl
            // 
            Back_lbl.AutoSize = true;
            Back_lbl.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_lbl.Location = new Point(458, 10);
            Back_lbl.Name = "Back_lbl";
            Back_lbl.Size = new Size(57, 22);
            Back_lbl.TabIndex = 35;
            Back_lbl.Text = "Back";
            Back_lbl.Click += Back_lbl_Click;
            // 
            // Transfer_btn
            // 
            Transfer_btn.FlatStyle = FlatStyle.Flat;
            Transfer_btn.ForeColor = Color.White;
            Transfer_btn.Location = new Point(221, 272);
            Transfer_btn.Name = "Transfer_btn";
            Transfer_btn.Size = new Size(100, 25);
            Transfer_btn.TabIndex = 33;
            Transfer_btn.Text = "TRANSFER";
            Transfer_btn.UseVisualStyleBackColor = true;
            Transfer_btn.Click += Transfer_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(267, 32);
            label1.TabIndex = 32;
            label1.Text = "TRANSFER FUNDS";
            // 
            // FromAcct_cmb
            // 
            FromAcct_cmb.Font = new Font("Arial", 20.25F);
            FromAcct_cmb.ForeColor = Color.DarkGray;
            FromAcct_cmb.FormattingEnabled = true;
            FromAcct_cmb.Location = new Point(12, 108);
            FromAcct_cmb.Name = "FromAcct_cmb";
            FromAcct_cmb.Size = new Size(200, 40);
            FromAcct_cmb.TabIndex = 39;
            FromAcct_cmb.Text = "From";
            // 
            // ToAcct_cmb
            // 
            ToAcct_cmb.Font = new Font("Arial", 20.25F);
            ToAcct_cmb.ForeColor = Color.DarkGray;
            ToAcct_cmb.FormattingEnabled = true;
            ToAcct_cmb.Location = new Point(315, 108);
            ToAcct_cmb.Name = "ToAcct_cmb";
            ToAcct_cmb.Size = new Size(200, 40);
            ToAcct_cmb.TabIndex = 40;
            ToAcct_cmb.Text = "To";
            // 
            // TransferFunds
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 113, 110);
            ClientSize = new Size(527, 510);
            Controls.Add(ToAcct_cmb);
            Controls.Add(FromAcct_cmb);
            Controls.Add(Amount_tb);
            Controls.Add(Back_lbl);
            Controls.Add(Transfer_btn);
            Controls.Add(label1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransferFunds";
            Text = "TransferFunds";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AcctBalance_tb;
        private TextBox AcctType_tb;
        private TextBox Amount_tb;
        private TextBox AcctNumber_tb;
        private TextBox BankName_tb;
        private Label Back_lbl;
        private TextBox BranchCode_tb;
        private Button Transfer_btn;
        private Label label1;
        private ComboBox FromAcct_cmb;
        private ComboBox ToAcct_cmb;
    }
}