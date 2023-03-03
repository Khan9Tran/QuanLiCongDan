namespace QuanLiCongDanThanhPho
{
    partial class FTrangChu
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
            components = new System.ComponentModel.Container();
            pnlKhungTren = new Panel();
            txtTimKiem = new TextBox();
            lblHideApp = new Label();
            lblExit = new Label();
            pnlChucNang = new Panel();
            btnSuaDoi = new Button();
            btnThongKe = new Button();
            btnDangKy = new Button();
            cmnusDangKy = new ContextMenuStrip(components);
            cmnusDangKyItemTamTruTamVang = new ToolStripMenuItem();
            cmnusDangKyItemHonNhan = new ToolStripMenuItem();
            cmnusDangKyItemKhaiSinh = new ToolStripMenuItem();
            cnmusDangKyItemCCCD = new ToolStripMenuItem();
            cmnusDangKyItemHoKhau = new ToolStripMenuItem();
            cmnusDangKyItemCongDan = new ToolStripMenuItem();
            btnDanhMuc = new Button();
            cmnusDanhMuc = new ContextMenuStrip(components);
            cmnusDanhMucItemCongDan = new ToolStripMenuItem();
            cmnusDanhMucItemHoKhau = new ToolStripMenuItem();
            cmnusDanhMucItemThue = new ToolStripMenuItem();
            cmnusDanhMucItemTamTruTamVang = new ToolStripMenuItem();
            pnlHienThiForm = new Panel();
            CmnusSuaDoi = new ContextMenuStrip(components);
            congDanToolStripMenuItem = new ToolStripMenuItem();
            hộKhẩuToolStripMenuItem = new ToolStripMenuItem();
            thuếToolStripMenuItem = new ToolStripMenuItem();
            hônNhânToolStripMenuItem = new ToolStripMenuItem();
            cCCDToolStripMenuItem = new ToolStripMenuItem();
            khaiSinhToolStripMenuItem = new ToolStripMenuItem();
            pnlKhungTren.SuspendLayout();
            pnlChucNang.SuspendLayout();
            cmnusDangKy.SuspendLayout();
            cmnusDanhMuc.SuspendLayout();
            CmnusSuaDoi.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKhungTren
            // 
            pnlKhungTren.BackColor = Color.FromArgb(50, 49, 69);
            pnlKhungTren.BackgroundImageLayout = ImageLayout.Center;
            pnlKhungTren.Controls.Add(txtTimKiem);
            pnlKhungTren.Controls.Add(lblHideApp);
            pnlKhungTren.Controls.Add(lblExit);
            pnlKhungTren.Dock = DockStyle.Top;
            pnlKhungTren.Location = new Point(0, 0);
            pnlKhungTren.Name = "pnlKhungTren";
            pnlKhungTren.Size = new Size(1782, 71);
            pnlKhungTren.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = Color.FromArgb(44, 43, 60);
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Enabled = false;
            txtTimKiem.Font = new Font("Segoe UI Light", 14F, FontStyle.Italic, GraphicsUnit.Point);
            txtTimKiem.ForeColor = Color.FromArgb(193, 185, 174);
            txtTimKiem.Location = new Point(631, 20);
            txtTimKiem.Margin = new Padding(20);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(387, 35);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.Text = "tìm kiếm";
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // lblHideApp
            // 
            lblHideApp.AutoSize = true;
            lblHideApp.ForeColor = Color.Transparent;
            lblHideApp.Location = new Point(1725, 6);
            lblHideApp.Name = "lblHideApp";
            lblHideApp.Size = new Size(21, 20);
            lblHideApp.TabIndex = 1;
            lblHideApp.Text = "__";
            lblHideApp.Click += lblHideApp_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.ForeColor = Color.WhiteSmoke;
            lblExit.Location = new Point(1752, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(18, 20);
            lblExit.TabIndex = 0;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // pnlChucNang
            // 
            pnlChucNang.BackColor = Color.FromArgb(50, 49, 69);
            pnlChucNang.Controls.Add(btnSuaDoi);
            pnlChucNang.Controls.Add(btnThongKe);
            pnlChucNang.Controls.Add(btnDangKy);
            pnlChucNang.Controls.Add(btnDanhMuc);
            pnlChucNang.Dock = DockStyle.Left;
            pnlChucNang.Location = new Point(0, 71);
            pnlChucNang.Name = "pnlChucNang";
            pnlChucNang.Size = new Size(250, 782);
            pnlChucNang.TabIndex = 1;
            // 
            // btnSuaDoi
            // 
            btnSuaDoi.BackColor = Color.WhiteSmoke;
            btnSuaDoi.FlatStyle = FlatStyle.Flat;
            btnSuaDoi.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuaDoi.ForeColor = Color.FromArgb(44, 43, 69);
            btnSuaDoi.Location = new Point(-18, 402);
            btnSuaDoi.Name = "btnSuaDoi";
            btnSuaDoi.Size = new Size(200, 82);
            btnSuaDoi.TabIndex = 4;
            btnSuaDoi.Text = "Sửa";
            btnSuaDoi.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.WhiteSmoke;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongKe.ForeColor = Color.FromArgb(44, 43, 69);
            btnThongKe.Location = new Point(-18, 515);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(200, 82);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.WhiteSmoke;
            btnDangKy.ContextMenuStrip = cmnusDangKy;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangKy.ForeColor = Color.FromArgb(44, 43, 69);
            btnDangKy.Location = new Point(-18, 279);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(200, 82);
            btnDangKy.TabIndex = 2;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            // 
            // cmnusDangKy
            // 
            cmnusDangKy.BackColor = Color.LightSteelBlue;
            cmnusDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmnusDangKy.ImageScalingSize = new Size(20, 20);
            cmnusDangKy.Items.AddRange(new ToolStripItem[] { cmnusDangKyItemTamTruTamVang, cmnusDangKyItemHonNhan, cmnusDangKyItemKhaiSinh, cnmusDangKyItemCCCD, cmnusDangKyItemHoKhau, cmnusDangKyItemCongDan });
            cmnusDangKy.Name = "cmnusDangKy";
            cmnusDangKy.Size = new Size(270, 196);
            // 
            // cmnusDangKyItemTamTruTamVang
            // 
            cmnusDangKyItemTamTruTamVang.Name = "cmnusDangKyItemTamTruTamVang";
            cmnusDangKyItemTamTruTamVang.Size = new Size(269, 32);
            cmnusDangKyItemTamTruTamVang.Text = "Tạm trú / tạm vắng";
            cmnusDangKyItemTamTruTamVang.Click += cmnusDangKyItemTamTruTamVang_Click;
            // 
            // cmnusDangKyItemHonNhan
            // 
            cmnusDangKyItemHonNhan.Name = "cmnusDangKyItemHonNhan";
            cmnusDangKyItemHonNhan.Size = new Size(269, 32);
            cmnusDangKyItemHonNhan.Text = "Hôn nhân";
            cmnusDangKyItemHonNhan.Click += cmnusitemDangKyHonNhan_Click;
            // 
            // cmnusDangKyItemKhaiSinh
            // 
            cmnusDangKyItemKhaiSinh.Name = "cmnusDangKyItemKhaiSinh";
            cmnusDangKyItemKhaiSinh.Size = new Size(269, 32);
            cmnusDangKyItemKhaiSinh.Text = "Khai sinh";
            cmnusDangKyItemKhaiSinh.Click += cmnusDangKyItemKhaiSinh_Click;
            // 
            // cnmusDangKyItemCCCD
            // 
            cnmusDangKyItemCCCD.Name = "cnmusDangKyItemCCCD";
            cnmusDangKyItemCCCD.Size = new Size(269, 32);
            cnmusDangKyItemCCCD.Text = "CCCD";
            // 
            // cmnusDangKyItemHoKhau
            // 
            cmnusDangKyItemHoKhau.Name = "cmnusDangKyItemHoKhau";
            cmnusDangKyItemHoKhau.Size = new Size(269, 32);
            cmnusDangKyItemHoKhau.Text = "Hộ khẩu";
            // 
            // cmnusDangKyItemCongDan
            // 
            cmnusDangKyItemCongDan.Name = "cmnusDangKyItemCongDan";
            cmnusDangKyItemCongDan.Size = new Size(269, 32);
            cmnusDangKyItemCongDan.Text = "Công Dân";
            cmnusDangKyItemCongDan.Click += cmnusDangKyItemCongDan_Click;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.BackColor = Color.WhiteSmoke;
            btnDanhMuc.ContextMenuStrip = cmnusDanhMuc;
            btnDanhMuc.FlatStyle = FlatStyle.Flat;
            btnDanhMuc.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDanhMuc.ForeColor = Color.FromArgb(44, 43, 69);
            btnDanhMuc.Location = new Point(-18, 170);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(200, 82);
            btnDanhMuc.TabIndex = 1;
            btnDanhMuc.Text = "Danh mục";
            btnDanhMuc.UseVisualStyleBackColor = false;
            // 
            // cmnusDanhMuc
            // 
            cmnusDanhMuc.BackColor = Color.LightSteelBlue;
            cmnusDanhMuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmnusDanhMuc.ImageScalingSize = new Size(20, 20);
            cmnusDanhMuc.ImeMode = ImeMode.NoControl;
            cmnusDanhMuc.Items.AddRange(new ToolStripItem[] { cmnusDanhMucItemCongDan, cmnusDanhMucItemHoKhau, cmnusDanhMucItemThue, cmnusDanhMucItemTamTruTamVang });
            cmnusDanhMuc.Name = "contextMenuStrip2";
            cmnusDanhMuc.Size = new Size(268, 132);
            // 
            // cmnusDanhMucItemCongDan
            // 
            cmnusDanhMucItemCongDan.Name = "cmnusDanhMucItemCongDan";
            cmnusDanhMucItemCongDan.Size = new Size(267, 32);
            cmnusDanhMucItemCongDan.Text = "Công Dân";
            cmnusDanhMucItemCongDan.Click += cmnusDanhMucItemCongDan_Click;
            // 
            // cmnusDanhMucItemHoKhau
            // 
            cmnusDanhMucItemHoKhau.Name = "cmnusDanhMucItemHoKhau";
            cmnusDanhMucItemHoKhau.Size = new Size(267, 32);
            cmnusDanhMucItemHoKhau.Text = "Hộ khẩu";
            cmnusDanhMucItemHoKhau.Click += cmnusDanhMucItemHoKhau_Click;
            // 
            // cmnusDanhMucItemThue
            // 
            cmnusDanhMucItemThue.Name = "cmnusDanhMucItemThue";
            cmnusDanhMucItemThue.Size = new Size(267, 32);
            cmnusDanhMucItemThue.Text = "Thuế";
            cmnusDanhMucItemThue.Click += cmnusDanhMucItemThue_Click;
            // 
            // cmnusDanhMucItemTamTruTamVang
            // 
            cmnusDanhMucItemTamTruTamVang.Name = "cmnusDanhMucItemTamTruTamVang";
            cmnusDanhMucItemTamTruTamVang.Size = new Size(267, 32);
            cmnusDanhMucItemTamTruTamVang.Text = "Tạm trú/ Tạm vắng";
            cmnusDanhMucItemTamTruTamVang.Click += cmnusDanhMucItemTamTruTamVang_Click;
            // 
            // pnlHienThiForm
            // 
            pnlHienThiForm.AutoSize = true;
            pnlHienThiForm.Dock = DockStyle.Fill;
            pnlHienThiForm.Location = new Point(250, 71);
            pnlHienThiForm.Name = "pnlHienThiForm";
            pnlHienThiForm.Size = new Size(1532, 782);
            pnlHienThiForm.TabIndex = 2;
            // 
            // CmnusSuaDoi
            // 
            CmnusSuaDoi.ImageScalingSize = new Size(20, 20);
            CmnusSuaDoi.Items.AddRange(new ToolStripItem[] { congDanToolStripMenuItem, hộKhẩuToolStripMenuItem, thuếToolStripMenuItem, hônNhânToolStripMenuItem, cCCDToolStripMenuItem, khaiSinhToolStripMenuItem });
            CmnusSuaDoi.Name = "contextMenuStrip3";
            CmnusSuaDoi.Size = new Size(143, 148);
            // 
            // congDanToolStripMenuItem
            // 
            congDanToolStripMenuItem.Name = "congDanToolStripMenuItem";
            congDanToolStripMenuItem.Size = new Size(142, 24);
            congDanToolStripMenuItem.Text = "Công dân";
            // 
            // hộKhẩuToolStripMenuItem
            // 
            hộKhẩuToolStripMenuItem.Name = "hộKhẩuToolStripMenuItem";
            hộKhẩuToolStripMenuItem.Size = new Size(142, 24);
            hộKhẩuToolStripMenuItem.Text = "Hộ khẩu";
            // 
            // thuếToolStripMenuItem
            // 
            thuếToolStripMenuItem.Name = "thuếToolStripMenuItem";
            thuếToolStripMenuItem.Size = new Size(142, 24);
            thuếToolStripMenuItem.Text = "Thuế";
            // 
            // hônNhânToolStripMenuItem
            // 
            hônNhânToolStripMenuItem.Name = "hônNhânToolStripMenuItem";
            hônNhânToolStripMenuItem.Size = new Size(142, 24);
            hônNhânToolStripMenuItem.Text = "Hôn nhân";
            // 
            // cCCDToolStripMenuItem
            // 
            cCCDToolStripMenuItem.Name = "cCCDToolStripMenuItem";
            cCCDToolStripMenuItem.Size = new Size(142, 24);
            cCCDToolStripMenuItem.Text = "CCCD";
            // 
            // khaiSinhToolStripMenuItem
            // 
            khaiSinhToolStripMenuItem.Name = "khaiSinhToolStripMenuItem";
            khaiSinhToolStripMenuItem.Size = new Size(142, 24);
            khaiSinhToolStripMenuItem.Text = "Khai sinh";
            // 
            // FTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 43, 60);
            ClientSize = new Size(1782, 853);
            Controls.Add(pnlHienThiForm);
            Controls.Add(pnlChucNang);
            Controls.Add(pnlKhungTren);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChu";
            pnlKhungTren.ResumeLayout(false);
            pnlKhungTren.PerformLayout();
            pnlChucNang.ResumeLayout(false);
            cmnusDangKy.ResumeLayout(false);
            cmnusDanhMuc.ResumeLayout(false);
            CmnusSuaDoi.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlKhungTren;
        private Panel pnlChucNang;
        private Label lblExit;
        private Label lblHideApp;
        private TextBox txtTimKiem;
        private Button btnThongKe;
        private Button btnDangKy;
        private Button btnDanhMuc;
        private Button btnSuaDoi;
        private Panel pnlHienThiForm;
        private ContextMenuStrip cmnusDangKy;
        private ToolStripMenuItem cmnusDangKyItemTamTruTamVang;
        private ToolStripMenuItem cmnusDangKyItemHonNhan;
        private ToolStripMenuItem cmnusDangKyItemKhaiSinh;
        private ToolStripMenuItem cnmusDangKyItemCCCD;
        private ToolStripMenuItem cmnusDangKyItemHoKhau;
        private ContextMenuStrip cmnusDanhMuc;
        private ContextMenuStrip CmnusSuaDoi;
        private ToolStripMenuItem cmnusDanhMucItemCongDan;
        private ToolStripMenuItem cmnusDanhMucItemHoKhau;
        private ToolStripMenuItem cmnusDanhMucItemThue;
        private ToolStripMenuItem cmnusDanhMucItemTamTruTamVang;
        private ToolStripMenuItem cmnusDangKyItemCongDan;
        private ToolStripMenuItem congDanToolStripMenuItem;
        private ToolStripMenuItem hộKhẩuToolStripMenuItem;
        private ToolStripMenuItem thuếToolStripMenuItem;
        private ToolStripMenuItem hônNhânToolStripMenuItem;
        private ToolStripMenuItem cCCDToolStripMenuItem;
        private ToolStripMenuItem khaiSinhToolStripMenuItem;
    }
}