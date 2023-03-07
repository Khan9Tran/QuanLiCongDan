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
            txtTimKiem = new TextBox();
            btnMenuShow = new Button();
            pnlDanhMuc = new Panel();
            lblDanhMuc = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblCongDan = new Label();
            cmnusDangKy = new ContextMenuStrip(components);
            cmnusDangKyItemTamTruTamVang = new ToolStripMenuItem();
            cmnusDangKyItemHonNhan = new ToolStripMenuItem();
            cmnusDangKyItemCCCD = new ToolStripMenuItem();
            cmnusDangKyItemHoKhau = new ToolStripMenuItem();
            cmnusDangKyItemCongDan = new ToolStripMenuItem();
            ItemCongDanChuyenDen = new ToolStripMenuItem();
            ItemCongDanChuyenDi = new ToolStripMenuItem();
            ItemKhaiSinh = new ToolStripMenuItem();
            cmnusDanhMuc = new ContextMenuStrip(components);
            cmnusDanhMucItemCongDan = new ToolStripMenuItem();
            cmnusDanhMucItemHoKhau = new ToolStripMenuItem();
            cmnusDanhMucItemThue = new ToolStripMenuItem();
            cmnusDanhMucItemTamTruTamVang = new ToolStripMenuItem();
            pnlHienThiForm = new Panel();
            pnlTitleBar = new Panel();
            tmrThuNho = new System.Windows.Forms.Timer(components);
            pnlMenu = new Panel();
            pnlThongKe = new Panel();
            lblThongKe = new Label();
            pnlDangKy = new Panel();
            lblDangKy = new Label();
            tmrPhongTo = new System.Windows.Forms.Timer(components);
            titleBar1 = new TitleBar();
            sideBar1 = new SideBar();
            pnlDanhMuc.SuspendLayout();
            cmnusDangKy.SuspendLayout();
            cmnusDanhMuc.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlThongKe.SuspendLayout();
            pnlDangKy.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = Color.Gainsboro;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Enabled = false;
            txtTimKiem.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.ForeColor = Color.MediumBlue;
            txtTimKiem.Location = new Point(394, 20);
            txtTimKiem.Margin = new Padding(20);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(387, 35);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnMenuShow
            // 
            btnMenuShow.BackColor = Color.Transparent;
            btnMenuShow.FlatAppearance.BorderSize = 0;
            btnMenuShow.FlatStyle = FlatStyle.Flat;
            btnMenuShow.Image = Properties.Resources.menu__8_;
            btnMenuShow.Location = new Point(7, 3);
            btnMenuShow.Name = "btnMenuShow";
            btnMenuShow.Size = new Size(65, 65);
            btnMenuShow.TabIndex = 3;
            btnMenuShow.UseVisualStyleBackColor = false;
            btnMenuShow.Click += btnMenuShow_Click;
            // 
            // pnlDanhMuc
            // 
            pnlDanhMuc.BackColor = Color.WhiteSmoke;
            pnlDanhMuc.Controls.Add(lblDanhMuc);
            pnlDanhMuc.Location = new Point(0, 69);
            pnlDanhMuc.Name = "pnlDanhMuc";
            pnlDanhMuc.Size = new Size(290, 80);
            pnlDanhMuc.TabIndex = 0;
            // 
            // lblDanhMuc
            // 
            lblDanhMuc.AutoSize = true;
            lblDanhMuc.BackColor = Color.Transparent;
            lblDanhMuc.FlatStyle = FlatStyle.Flat;
            lblDanhMuc.Font = new Font("Segoe UI Semibold", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDanhMuc.ForeColor = Color.Black;
            lblDanhMuc.Image = Properties.Resources.user_list;
            lblDanhMuc.ImageAlign = ContentAlignment.TopLeft;
            lblDanhMuc.Location = new Point(12, 17);
            lblDanhMuc.Name = "lblDanhMuc";
            lblDanhMuc.Size = new Size(244, 45);
            lblDanhMuc.TabIndex = 0;
            lblDanhMuc.Text = "        Danh mục";
            lblDanhMuc.TextAlign = ContentAlignment.BottomCenter;
            lblDanhMuc.Click += btnDanhMuc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 176);
            label3.Name = "label3";
            label3.Size = new Size(168, 37);
            label3.TabIndex = 3;
            label3.Text = "DANH MỤC";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 123);
            label2.Name = "label2";
            label2.Size = new Size(168, 37);
            label2.TabIndex = 2;
            label2.Text = "DANH MỤC";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 67);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 1;
            label1.Text = "DANH MỤC";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblCongDan
            // 
            lblCongDan.AutoSize = true;
            lblCongDan.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblCongDan.Location = new Point(85, 18);
            lblCongDan.Name = "lblCongDan";
            lblCongDan.Size = new Size(168, 37);
            lblCongDan.TabIndex = 0;
            lblCongDan.Text = "DANH MỤC";
            lblCongDan.TextAlign = ContentAlignment.BottomCenter;
            // 
            // cmnusDangKy
            // 
            cmnusDangKy.BackColor = Color.WhiteSmoke;
            cmnusDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmnusDangKy.ImageScalingSize = new Size(20, 20);
            cmnusDangKy.Items.AddRange(new ToolStripItem[] { cmnusDangKyItemTamTruTamVang, cmnusDangKyItemHonNhan, cmnusDangKyItemCCCD, cmnusDangKyItemHoKhau, cmnusDangKyItemCongDan });
            cmnusDangKy.Name = "cmnusDangKy";
            cmnusDangKy.RenderMode = ToolStripRenderMode.Professional;
            cmnusDangKy.ShowImageMargin = false;
            cmnusDangKy.Size = new Size(245, 164);
            // 
            // cmnusDangKyItemTamTruTamVang
            // 
            cmnusDangKyItemTamTruTamVang.Name = "cmnusDangKyItemTamTruTamVang";
            cmnusDangKyItemTamTruTamVang.Size = new Size(244, 32);
            cmnusDangKyItemTamTruTamVang.Text = "Tạm trú / tạm vắng";
            cmnusDangKyItemTamTruTamVang.Click += cmnusDangKyItemTamTruTamVang_Click;
            // 
            // cmnusDangKyItemHonNhan
            // 
            cmnusDangKyItemHonNhan.Name = "cmnusDangKyItemHonNhan";
            cmnusDangKyItemHonNhan.Size = new Size(244, 32);
            cmnusDangKyItemHonNhan.Text = "Hôn nhân";
            cmnusDangKyItemHonNhan.Click += cmnusitemDangKyHonNhan_Click;
            // 
            // cmnusDangKyItemCCCD
            // 
            cmnusDangKyItemCCCD.Name = "cmnusDangKyItemCCCD";
            cmnusDangKyItemCCCD.Size = new Size(244, 32);
            cmnusDangKyItemCCCD.Text = "CCCD";
            cmnusDangKyItemCCCD.Click += cmnusDangKyItemCCCD_Click;
            // 
            // cmnusDangKyItemHoKhau
            // 
            cmnusDangKyItemHoKhau.Name = "cmnusDangKyItemHoKhau";
            cmnusDangKyItemHoKhau.Size = new Size(244, 32);
            cmnusDangKyItemHoKhau.Text = "Hộ khẩu";
            cmnusDangKyItemHoKhau.Click += cmnusDangKyItemHoKhau_Click;
            // 
            // cmnusDangKyItemCongDan
            // 
            cmnusDangKyItemCongDan.DropDownItems.AddRange(new ToolStripItem[] { ItemCongDanChuyenDen, ItemCongDanChuyenDi, ItemKhaiSinh });
            cmnusDangKyItemCongDan.Name = "cmnusDangKyItemCongDan";
            cmnusDangKyItemCongDan.Size = new Size(244, 32);
            cmnusDangKyItemCongDan.Text = "Công Dân";
            // 
            // ItemCongDanChuyenDen
            // 
            ItemCongDanChuyenDen.Name = "ItemCongDanChuyenDen";
            ItemCongDanChuyenDen.Size = new Size(210, 32);
            ItemCongDanChuyenDen.Text = "Chuyển đến";
            ItemCongDanChuyenDen.Click += cmnusDangKyItemCongDan_Click;
            // 
            // ItemCongDanChuyenDi
            // 
            ItemCongDanChuyenDi.Name = "ItemCongDanChuyenDi";
            ItemCongDanChuyenDi.Size = new Size(210, 32);
            ItemCongDanChuyenDi.Text = "Chuyển đi";
            // 
            // ItemKhaiSinh
            // 
            ItemKhaiSinh.Name = "ItemKhaiSinh";
            ItemKhaiSinh.Size = new Size(210, 32);
            ItemKhaiSinh.Text = "Khai sinh";
            ItemKhaiSinh.Click += cmnusDangKyItemKhaiSinh_Click;
            // 
            // cmnusDanhMuc
            // 
            cmnusDanhMuc.BackColor = Color.WhiteSmoke;
            cmnusDanhMuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmnusDanhMuc.ImageScalingSize = new Size(20, 20);
            cmnusDanhMuc.ImeMode = ImeMode.NoControl;
            cmnusDanhMuc.Items.AddRange(new ToolStripItem[] { cmnusDanhMucItemCongDan, cmnusDanhMucItemHoKhau, cmnusDanhMucItemThue, cmnusDanhMucItemTamTruTamVang });
            cmnusDanhMuc.Name = "contextMenuStrip2";
            cmnusDanhMuc.ShowImageMargin = false;
            cmnusDanhMuc.Size = new Size(243, 132);
            // 
            // cmnusDanhMucItemCongDan
            // 
            cmnusDanhMucItemCongDan.Name = "cmnusDanhMucItemCongDan";
            cmnusDanhMucItemCongDan.Size = new Size(242, 32);
            cmnusDanhMucItemCongDan.Text = "Công Dân";
            cmnusDanhMucItemCongDan.Click += cmnusDanhMucItemCongDan_Click;
            // 
            // cmnusDanhMucItemHoKhau
            // 
            cmnusDanhMucItemHoKhau.Name = "cmnusDanhMucItemHoKhau";
            cmnusDanhMucItemHoKhau.Size = new Size(242, 32);
            cmnusDanhMucItemHoKhau.Text = "Hộ khẩu";
            cmnusDanhMucItemHoKhau.Click += cmnusDanhMucItemHoKhau_Click;
            // 
            // cmnusDanhMucItemThue
            // 
            cmnusDanhMucItemThue.Name = "cmnusDanhMucItemThue";
            cmnusDanhMucItemThue.Size = new Size(242, 32);
            cmnusDanhMucItemThue.Text = "Thuế";
            cmnusDanhMucItemThue.Click += cmnusDanhMucItemThue_Click;
            // 
            // cmnusDanhMucItemTamTruTamVang
            // 
            cmnusDanhMucItemTamTruTamVang.Name = "cmnusDanhMucItemTamTruTamVang";
            cmnusDanhMucItemTamTruTamVang.Size = new Size(242, 32);
            cmnusDanhMucItemTamTruTamVang.Text = "Tạm trú/ Tạm vắng";
            cmnusDanhMucItemTamTruTamVang.Click += cmnusDanhMucItemTamTruTamVang_Click;
            // 
            // pnlHienThiForm
            // 
            pnlHienThiForm.AutoSize = true;
            pnlHienThiForm.BackColor = Color.WhiteSmoke;
            pnlHienThiForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlHienThiForm.Location = new Point(88, 81);
            pnlHienThiForm.Name = "pnlHienThiForm";
            pnlHienThiForm.Size = new Size(1532, 782);
            pnlHienThiForm.TabIndex = 2;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.WhiteSmoke;
            pnlTitleBar.Controls.Add(sideBar1);
            pnlTitleBar.Controls.Add(titleBar1);
            pnlTitleBar.Controls.Add(txtTimKiem);
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1630, 75);
            pnlTitleBar.TabIndex = 3;
            // 
            // tmrThuNho
            // 
            tmrThuNho.Tick += tmrThuNho_Tick;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.WhiteSmoke;
            pnlMenu.Controls.Add(pnlThongKe);
            pnlMenu.Controls.Add(pnlDangKy);
            pnlMenu.Controls.Add(pnlDanhMuc);
            pnlMenu.Controls.Add(btnMenuShow);
            pnlMenu.Location = new Point(0, 81);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(80, 775);
            pnlMenu.TabIndex = 4;
            // 
            // pnlThongKe
            // 
            pnlThongKe.BackColor = Color.WhiteSmoke;
            pnlThongKe.Controls.Add(lblThongKe);
            pnlThongKe.Location = new Point(0, 224);
            pnlThongKe.Name = "pnlThongKe";
            pnlThongKe.Size = new Size(290, 80);
            pnlThongKe.TabIndex = 1;
            // 
            // lblThongKe
            // 
            lblThongKe.AutoSize = true;
            lblThongKe.BackColor = Color.Transparent;
            lblThongKe.FlatStyle = FlatStyle.Flat;
            lblThongKe.Font = new Font("Segoe UI Semibold", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblThongKe.ForeColor = Color.Black;
            lblThongKe.Image = Properties.Resources.file;
            lblThongKe.ImageAlign = ContentAlignment.TopLeft;
            lblThongKe.Location = new Point(12, 16);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(231, 45);
            lblThongKe.TabIndex = 0;
            lblThongKe.Text = "        Thống kê";
            lblThongKe.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pnlDangKy
            // 
            pnlDangKy.BackColor = Color.WhiteSmoke;
            pnlDangKy.Controls.Add(lblDangKy);
            pnlDangKy.Location = new Point(0, 144);
            pnlDangKy.Name = "pnlDangKy";
            pnlDangKy.Size = new Size(290, 80);
            pnlDangKy.TabIndex = 1;
            pnlDangKy.Click += btnDangKy_Click;
            // 
            // lblDangKy
            // 
            lblDangKy.AutoSize = true;
            lblDangKy.BackColor = Color.Transparent;
            lblDangKy.FlatStyle = FlatStyle.Flat;
            lblDangKy.Font = new Font("Segoe UI Semibold", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDangKy.ForeColor = Color.Black;
            lblDangKy.Image = Properties.Resources.edit__2_;
            lblDangKy.ImageAlign = ContentAlignment.TopLeft;
            lblDangKy.Location = new Point(12, 18);
            lblDangKy.Name = "lblDangKy";
            lblDangKy.Size = new Size(215, 45);
            lblDangKy.TabIndex = 0;
            lblDangKy.Text = "        Đăng ký";
            lblDangKy.TextAlign = ContentAlignment.BottomCenter;
            lblDangKy.Click += btnDangKy_Click;
            // 
            // tmrPhongTo
            // 
            tmrPhongTo.Tick += tmrPhongTo_Tick;
            // 
            // titleBar1
            // 
            titleBar1.Location = new Point(1582, 3);
            titleBar1.Name = "titleBar1";
            titleBar1.Size = new Size(48, 45);
            titleBar1.TabIndex = 4;
            // 
            // sideBar1
            // 
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(65, 72);
            sideBar1.TabIndex = 5;
            // 
            // FTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1632, 840);
            Controls.Add(pnlMenu);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlHienThiForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChu";
            pnlDanhMuc.ResumeLayout(false);
            pnlDanhMuc.PerformLayout();
            cmnusDangKy.ResumeLayout(false);
            cmnusDanhMuc.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlThongKe.ResumeLayout(false);
            pnlThongKe.PerformLayout();
            pnlDangKy.ResumeLayout(false);
            pnlDangKy.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTimKiem;
        private Panel pnlHienThiForm;
        private ContextMenuStrip cmnusDangKy;
        private ToolStripMenuItem cmnusDangKyItemTamTruTamVang;
        private ToolStripMenuItem cmnusDangKyItemHonNhan;
        private ToolStripMenuItem cmnusDangKyItemCCCD;
        private ToolStripMenuItem cmnusDangKyItemHoKhau;
        private ContextMenuStrip cmnusDanhMuc;
        private ToolStripMenuItem cmnusDanhMucItemCongDan;
        private ToolStripMenuItem cmnusDanhMucItemHoKhau;
        private ToolStripMenuItem cmnusDanhMucItemThue;
        private ToolStripMenuItem cmnusDanhMucItemTamTruTamVang;
        private ToolStripMenuItem cmnusDangKyItemCongDan;
        private Panel pnlTitleBar;
        private Panel pnlDanhMuc;
        private Label lblDanhMuc;
        private Button btnMenuShow;
        private System.Windows.Forms.Timer tmrThuNho;
        private Label lblCongDan;
        private Panel pnlMenu;
        private Label label2;
        private Label label1;
        private Label label3;
        private System.Windows.Forms.Timer tmrPhongTo;
        private Panel pnlThongKe;
        private Label lblThongKe;
        private Panel pnlDangKy;
        private Label lblDangKy;
        private ToolStripMenuItem ItemCongDanChuyenDen;
        private ToolStripMenuItem ItemCongDanChuyenDi;
        private ToolStripMenuItem ItemKhaiSinh;
        private SideBar sideBar1;
        private TitleBar titleBar1;
    }
}