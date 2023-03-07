namespace QuanLiCongDanThanhPho
{
    partial class FDangNhap
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
            panel1 = new Panel();
            btnDangNhap = new Button();
            panel2 = new Panel();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(btnDangNhap);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(330, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(70, 150);
            panel1.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Transparent;
            btnDangNhap.DialogResult = DialogResult.OK;
            btnDangNhap.Dock = DockStyle.Fill;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Image = Properties.Resources.right;
            btnDangNhap.Location = new Point(0, 0);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(70, 150);
            btnDangNhap.TabIndex = 95;
            btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(25, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 2);
            panel2.TabIndex = 2;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BackColor = Color.WhiteSmoke;
            txtTaiKhoan.BorderStyle = BorderStyle.None;
            txtTaiKhoan.ForeColor = Color.Gray;
            txtTaiKhoan.Location = new Point(25, 35);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(250, 27);
            txtTaiKhoan.TabIndex = 3;
            txtTaiKhoan.Text = "Tài Khoản";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.WhiteSmoke;
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.ForeColor = Color.Gray;
            txtMatKhau.Location = new Point(25, 83);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(250, 27);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.Text = "Mật Khẩu";
            // 
            // FDangNhap
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(400, 150);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDangNhap";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
    }
}