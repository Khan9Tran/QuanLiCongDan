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
            lblTittleBar = new Label();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            btnDangNhap = new Button();
            lblTaiKhoan = new Label();
            lblMatKhau = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTittleBar
            // 
            lblTittleBar.AutoSize = true;
            lblTittleBar.BackColor = Color.Transparent;
            lblTittleBar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTittleBar.ForeColor = Color.LightGray;
            lblTittleBar.Location = new Point(61, 71);
            lblTittleBar.Name = "lblTittleBar";
            lblTittleBar.Size = new Size(257, 41);
            lblTittleBar.TabIndex = 2;
            lblTittleBar.Text = "Quản lí công dân";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.Gainsboro;
            txtMatKhau.Location = new Point(125, 280);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(220, 34);
            txtMatKhau.TabIndex = 4;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BackColor = Color.Gainsboro;
            txtTaiKhoan.Location = new Point(125, 230);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(220, 34);
            txtTaiKhoan.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Transparent;
            btnDangNhap.Location = new Point(90, 380);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(200, 50);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.BackColor = Color.Transparent;
            lblTaiKhoan.ForeColor = SystemColors.ButtonHighlight;
            lblTaiKhoan.Location = new Point(20, 230);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(103, 28);
            lblTaiKhoan.TabIndex = 7;
            lblTaiKhoan.Text = "Tài khoản";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.BackColor = Color.Transparent;
            lblMatKhau.ForeColor = SystemColors.ButtonHighlight;
            lblMatKhau.Location = new Point(20, 280);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(102, 28);
            lblMatKhau.TabIndex = 8;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(72, 177, 191);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 40);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(72, 177, 191);
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(347, 7);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(72, 177, 191);
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(315, 7);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 1;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            // 
            // FDangNhap
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 43, 69);
            ClientSize = new Size(380, 550);
            Controls.Add(panel1);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTaiKhoan);
            Controls.Add(btnDangNhap);
            Controls.Add(txtTaiKhoan);
            Controls.Add(txtMatKhau);
            Controls.Add(lblTittleBar);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDangNhap";
            Text = "FDangNhap";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTittleBar;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Button btnDangNhap;
        private Label lblTaiKhoan;
        private Label lblMatKhau;
        private Panel panel1;
        private Button button1;
        private Button button2;
    }
}