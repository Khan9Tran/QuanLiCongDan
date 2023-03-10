namespace QuanLiCongDanThanhPho
{
    partial class FDanhSachHoKhau
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
            this.gvHoKhau = new System.Windows.Forms.DataGridView();
            this.flpnlPhanLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnSoTV = new System.Windows.Forms.Button();
            this.btnNgayDangKy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoKhau)).BeginInit();
            this.flpnlPhanLoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvHoKhau
            // 
            this.gvHoKhau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHoKhau.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvHoKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvHoKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHoKhau.Location = new System.Drawing.Point(20, 217);
            this.gvHoKhau.Name = "gvHoKhau";
            this.gvHoKhau.RowHeadersWidth = 51;
            this.gvHoKhau.RowTemplate.Height = 29;
            this.gvHoKhau.Size = new System.Drawing.Size(1400, 450);
            this.gvHoKhau.TabIndex = 0;
            this.gvHoKhau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHoKhau_CellClick);
            this.gvHoKhau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHoKhau_CellContentClick);
            // 
            // flpnlPhanLoai
            // 
            this.flpnlPhanLoai.Controls.Add(this.btnTatCa);
            this.flpnlPhanLoai.Controls.Add(this.btnSoTV);
            this.flpnlPhanLoai.Controls.Add(this.btnNgayDangKy);
            this.flpnlPhanLoai.Location = new System.Drawing.Point(20, 164);
            this.flpnlPhanLoai.Name = "flpnlPhanLoai";
            this.flpnlPhanLoai.Size = new System.Drawing.Size(699, 47);
            this.flpnlPhanLoai.TabIndex = 9;
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTatCa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTatCa.ForeColor = System.Drawing.Color.Black;
            this.btnTatCa.Location = new System.Drawing.Point(3, 3);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(125, 40);
            this.btnTatCa.TabIndex = 4;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            // 
            // btnSoTV
            // 
            this.btnSoTV.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSoTV.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSoTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoTV.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSoTV.ForeColor = System.Drawing.Color.Black;
            this.btnSoTV.Location = new System.Drawing.Point(134, 3);
            this.btnSoTV.Name = "btnSoTV";
            this.btnSoTV.Size = new System.Drawing.Size(125, 40);
            this.btnSoTV.TabIndex = 5;
            this.btnSoTV.Text = "Thành viên";
            this.btnSoTV.UseVisualStyleBackColor = false;
            // 
            // btnNgayDangKy
            // 
            this.btnNgayDangKy.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNgayDangKy.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNgayDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgayDangKy.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNgayDangKy.ForeColor = System.Drawing.Color.Black;
            this.btnNgayDangKy.Location = new System.Drawing.Point(265, 3);
            this.btnNgayDangKy.Name = "btnNgayDangKy";
            this.btnNgayDangKy.Size = new System.Drawing.Size(144, 40);
            this.btnNgayDangKy.TabIndex = 6;
            this.btnNgayDangKy.Text = "Ngày đăng ký";
            this.btnNgayDangKy.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(20, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(600, 31);
            this.textBox1.TabIndex = 10;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.btnTimKiem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.search;
            this.btnTimKiem.Location = new System.Drawing.Point(626, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(50, 50);
            this.btnTimKiem.TabIndex = 55;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // FDanhSachHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flpnlPhanLoai);
            this.Controls.Add(this.gvHoKhau);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDanhSachHoKhau";
            this.Text = "FDanhSachHoKhau";
            this.Load += new System.EventHandler(this.FDanhSachHoKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHoKhau)).EndInit();
            this.flpnlPhanLoai.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvHoKhau;
        private FlowLayoutPanel flpnlPhanLoai;
        private Button btnTatCa;
        private Button btnSoTV;
        private Button btnNgayDangKy;
        private TextBox textBox1;
        private Button btnTimKiem;
    }
}