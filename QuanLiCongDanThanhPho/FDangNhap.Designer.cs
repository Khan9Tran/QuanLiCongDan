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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongTinMe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnThongTinMe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(330, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 150);
            this.panel1.TabIndex = 1;
            // 
            // btnThongTinMe
            // 
            this.btnThongTinMe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongTinMe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnThongTinMe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThongTinMe.FlatAppearance.BorderSize = 0;
            this.btnThongTinMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinMe.Image = global::QuanLiCongDanThanhPho.Properties.Resources.right;
            this.btnThongTinMe.Location = new System.Drawing.Point(0, 0);
            this.btnThongTinMe.Name = "btnThongTinMe";
            this.btnThongTinMe.Size = new System.Drawing.Size(70, 150);
            this.btnThongTinMe.TabIndex = 95;
            this.btnThongTinMe.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(25, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 2);
            this.panel2.TabIndex = 2;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Gray;
            this.txtTaiKhoan.Location = new System.Drawing.Point(25, 35);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(250, 27);
            this.txtTaiKhoan.TabIndex = 3;
            this.txtTaiKhoan.Text = "Tài Khoản";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.ForeColor = System.Drawing.Color.Gray;
            this.txtMatKhau.Location = new System.Drawing.Point(25, 83);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(250, 27);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Text = "Mật Khẩu";
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDangNhap";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button btnThongTinMe;
    }
}