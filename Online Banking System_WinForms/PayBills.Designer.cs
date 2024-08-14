namespace Online_Banking_System_WinForms
{
    partial class PayBills
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
            Back_lbl = new Label();
            PayBills_btn = new Button();
            label1 = new Label();
            Bills_dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Bills_dgv).BeginInit();
            SuspendLayout();
            // 
            // Back_lbl
            // 
            Back_lbl.AutoSize = true;
            Back_lbl.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_lbl.Location = new Point(416, 7);
            Back_lbl.Name = "Back_lbl";
            Back_lbl.Size = new Size(57, 22);
            Back_lbl.TabIndex = 38;
            Back_lbl.Text = "Back";
            Back_lbl.Click += Back_lbl_Click;
            // 
            // PayBills_btn
            // 
            PayBills_btn.FlatStyle = FlatStyle.Flat;
            PayBills_btn.ForeColor = Color.White;
            PayBills_btn.Location = new Point(182, 448);
            PayBills_btn.Name = "PayBills_btn";
            PayBills_btn.Size = new Size(100, 25);
            PayBills_btn.TabIndex = 37;
            PayBills_btn.Text = "PAY";
            PayBills_btn.UseVisualStyleBackColor = true;
            PayBills_btn.Click += PayBills_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 36;
            label1.Text = "PAY BILLS";
            // 
            // Bills_dgv
            // 
            Bills_dgv.AllowUserToAddRows = false;
            Bills_dgv.AllowUserToDeleteRows = false;
            Bills_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Bills_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Bills_dgv.BackgroundColor = Color.Gainsboro;
            Bills_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Bills_dgv.Location = new Point(12, 35);
            Bills_dgv.Name = "Bills_dgv";
            Bills_dgv.Size = new Size(461, 407);
            Bills_dgv.TabIndex = 39;
            // 
            // PayBills
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 113, 110);
            ClientSize = new Size(487, 483);
            Controls.Add(Bills_dgv);
            Controls.Add(Back_lbl);
            Controls.Add(PayBills_btn);
            Controls.Add(label1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PayBills";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayBills";
            ((System.ComponentModel.ISupportInitialize)Bills_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Back_lbl;
        private Button PayBills_btn;
        private Label label1;
        private DataGridView Bills_dgv;
    }
}