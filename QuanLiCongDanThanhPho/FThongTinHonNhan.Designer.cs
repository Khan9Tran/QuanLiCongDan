namespace QuanLiCongDanThanhPho
{
    partial class FThongTinHonNhan
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
            pnlChong = new Panel();
            btnThongTinChong = new Button();
            txtCCCDChong = new TextBox();
            txtNoiDangKy = new TextBox();
            btnSua = new Button();
            txtTenChong = new TextBox();
            lblCCCDChong = new Label();
            lblTenChong = new Label();
            lblNoiDangKy = new Label();
            btnXoa = new Button();
            label7 = new Label();
            pnlVo = new Panel();
            btnThongTinVo = new Button();
            dtpNgayDangKy = new DateTimePicker();
            txtTenVo = new TextBox();
            txtCCCDVo = new TextBox();
            lblCCCDVo = new Label();
            lblTenVo = new Label();
            lblDeMuc2 = new Label();
            panel1 = new Panel();
            pnlChong.SuspendLayout();
            pnlVo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChong
            // 
            pnlChong.BackColor = Color.WhiteSmoke;
            pnlChong.Controls.Add(btnThongTinChong);
            pnlChong.Controls.Add(txtCCCDChong);
            pnlChong.Controls.Add(txtNoiDangKy);
            pnlChong.Controls.Add(txtTenChong);
            pnlChong.Controls.Add(lblCCCDChong);
            pnlChong.Controls.Add(lblTenChong);
            pnlChong.Controls.Add(lblNoiDangKy);
            pnlChong.Location = new Point(0, 89);
            pnlChong.Name = "pnlChong";
            pnlChong.Size = new Size(600, 640);
            pnlChong.TabIndex = 2;
            // 
            // btnThongTinChong
            // 
            btnThongTinChong.BackColor = Color.White;
            btnThongTinChong.ForeColor = Color.FromArgb(44, 53, 60);
            btnThongTinChong.Location = new Point(233, 350);
            btnThongTinChong.Name = "btnThongTinChong";
            btnThongTinChong.Size = new Size(133, 50);
            btnThongTinChong.TabIndex = 8;
            btnThongTinChong.Text = "Chi tiết";
            btnThongTinChong.UseVisualStyleBackColor = false;
            // 
            // txtCCCDChong
            // 
            txtCCCDChong.BackColor = Color.Gainsboro;
            txtCCCDChong.BorderStyle = BorderStyle.None;
            txtCCCDChong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCDChong.Location = new Point(250, 150);
            txtCCCDChong.Name = "txtCCCDChong";
            txtCCCDChong.ReadOnly = true;
            txtCCCDChong.Size = new Size(315, 27);
            txtCCCDChong.TabIndex = 7;
            // 
            // txtNoiDangKy
            // 
            txtNoiDangKy.BackColor = Color.Gainsboro;
            txtNoiDangKy.BorderStyle = BorderStyle.None;
            txtNoiDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoiDangKy.Location = new Point(250, 250);
            txtNoiDangKy.Name = "txtNoiDangKy";
            txtNoiDangKy.ReadOnly = true;
            txtNoiDangKy.Size = new Size(315, 27);
            txtNoiDangKy.TabIndex = 6;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.ForeColor = Color.FromArgb(44, 53, 60);
            btnSua.Location = new Point(389, 550);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 50);
            btnSua.TabIndex = 10;
            btnSua.Text = "Chỉnh sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // txtTenChong
            // 
            txtTenChong.BackColor = Color.Gainsboro;
            txtTenChong.BorderStyle = BorderStyle.None;
            txtTenChong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenChong.Location = new Point(250, 50);
            txtTenChong.Name = "txtTenChong";
            txtTenChong.ReadOnly = true;
            txtTenChong.Size = new Size(315, 27);
            txtTenChong.TabIndex = 5;
            // 
            // lblCCCDChong
            // 
            lblCCCDChong.AutoSize = true;
            lblCCCDChong.Location = new Point(50, 150);
            lblCCCDChong.Name = "lblCCCDChong";
            lblCCCDChong.Size = new Size(61, 28);
            lblCCCDChong.TabIndex = 2;
            lblCCCDChong.Text = "CCCD";
            // 
            // lblTenChong
            // 
            lblTenChong.AutoSize = true;
            lblTenChong.Location = new Point(50, 50);
            lblTenChong.Name = "lblTenChong";
            lblTenChong.Size = new Size(168, 28);
            lblTenChong.TabIndex = 1;
            lblTenChong.Text = "Họ và tên chồng";
            // 
            // lblNoiDangKy
            // 
            lblNoiDangKy.AutoSize = true;
            lblNoiDangKy.Location = new Point(50, 250);
            lblNoiDangKy.Name = "lblNoiDangKy";
            lblNoiDangKy.Size = new Size(129, 28);
            lblNoiDangKy.TabIndex = 0;
            lblNoiDangKy.Text = "Nơi đăng ký";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(427, 649);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 50);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa đăng ký";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 250);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 3;
            label7.Text = "Ngày đăng ký";
            // 
            // pnlVo
            // 
            pnlVo.BackColor = Color.WhiteSmoke;
            pnlVo.Controls.Add(btnXoa);
            pnlVo.Controls.Add(btnThongTinVo);
            pnlVo.Controls.Add(dtpNgayDangKy);
            pnlVo.Controls.Add(btnSua);
            pnlVo.Controls.Add(txtTenVo);
            pnlVo.Controls.Add(txtCCCDVo);
            pnlVo.Controls.Add(lblCCCDVo);
            pnlVo.Controls.Add(label7);
            pnlVo.Controls.Add(lblTenVo);
            pnlVo.Location = new Point(600, 89);
            pnlVo.Name = "pnlVo";
            pnlVo.Size = new Size(600, 640);
            pnlVo.TabIndex = 3;
            // 
            // btnThongTinVo
            // 
            btnThongTinVo.BackColor = Color.White;
            btnThongTinVo.ForeColor = Color.FromArgb(44, 53, 60);
            btnThongTinVo.Location = new Point(233, 350);
            btnThongTinVo.Name = "btnThongTinVo";
            btnThongTinVo.Size = new Size(133, 50);
            btnThongTinVo.TabIndex = 7;
            btnThongTinVo.Text = "Chi tiết";
            btnThongTinVo.UseVisualStyleBackColor = false;
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayDangKy.CalendarMonthBackground = Color.Gainsboro;
            dtpNgayDangKy.CustomFormat = "dd/MM/yyyy";
            dtpNgayDangKy.Format = DateTimePickerFormat.Short;
            dtpNgayDangKy.Location = new Point(241, 244);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(315, 34);
            dtpNgayDangKy.TabIndex = 6;
            dtpNgayDangKy.Value = new DateTime(2023, 2, 28, 0, 0, 0, 0);
            // 
            // txtTenVo
            // 
            txtTenVo.BackColor = Color.Gainsboro;
            txtTenVo.BorderStyle = BorderStyle.None;
            txtTenVo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenVo.Location = new Point(241, 50);
            txtTenVo.Name = "txtTenVo";
            txtTenVo.ReadOnly = true;
            txtTenVo.Size = new Size(315, 27);
            txtTenVo.TabIndex = 5;
            // 
            // txtCCCDVo
            // 
            txtCCCDVo.BackColor = Color.Gainsboro;
            txtCCCDVo.BorderStyle = BorderStyle.None;
            txtCCCDVo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCDVo.Location = new Point(241, 150);
            txtCCCDVo.Name = "txtCCCDVo";
            txtCCCDVo.ReadOnly = true;
            txtCCCDVo.Size = new Size(315, 27);
            txtCCCDVo.TabIndex = 4;
            // 
            // lblCCCDVo
            // 
            lblCCCDVo.AutoSize = true;
            lblCCCDVo.Location = new Point(50, 150);
            lblCCCDVo.Name = "lblCCCDVo";
            lblCCCDVo.Size = new Size(61, 28);
            lblCCCDVo.TabIndex = 3;
            lblCCCDVo.Text = "CCCD";
            // 
            // lblTenVo
            // 
            lblTenVo.AutoSize = true;
            lblTenVo.Location = new Point(50, 50);
            lblTenVo.Name = "lblTenVo";
            lblTenVo.Size = new Size(134, 28);
            lblTenVo.TabIndex = 2;
            lblTenVo.Text = "Họ và tên vợ";
            // 
            // lblDeMuc2
            // 
            lblDeMuc2.AutoSize = true;
            lblDeMuc2.BackColor = Color.Transparent;
            lblDeMuc2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeMuc2.ForeColor = Color.WhiteSmoke;
            lblDeMuc2.Location = new Point(520, 19);
            lblDeMuc2.Name = "lblDeMuc2";
            lblDeMuc2.Size = new Size(168, 37);
            lblDeMuc2.TabIndex = 1;
            lblDeMuc2.Text = "HÔN NHÂN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 43, 60);
            panel1.Controls.Add(lblDeMuc2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 80);
            panel1.TabIndex = 4;
            // 
            // FThongTinHonNhan
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1200, 720);
            Controls.Add(panel1);
            Controls.Add(pnlVo);
            Controls.Add(pnlChong);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FThongTinHonNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            pnlChong.ResumeLayout(false);
            pnlChong.PerformLayout();
            pnlVo.ResumeLayout(false);
            pnlVo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChong;
        private Panel pnlVo;
        private Label label7;
        private Label lblCCCDChong;
        private Label lblTenChong;
        private Label lblNoiDangKy;
        private Label lblCCCDVo;
        private Label lblTenVo;
        private Label lblDeMuc2;
        private TextBox txtCCCDChong;
        private TextBox txtNoiDangKy;
        private TextBox txtTenChong;
        private DateTimePicker dtpNgayDangKy;
        private TextBox txtTenVo;
        private TextBox txtCCCDVo;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThongTinChong;
        private Button btnThongTinVo;
        private Panel panel1;
    }
}