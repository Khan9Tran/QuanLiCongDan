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
            this.pnlChong = new System.Windows.Forms.Panel();
            this.btnThongTinChong = new System.Windows.Forms.Button();
            this.txtCCCDChong = new System.Windows.Forms.TextBox();
            this.txtNoiDangKy = new System.Windows.Forms.TextBox();
            this.txtTenChong = new System.Windows.Forms.TextBox();
            this.lblCCCDChong = new System.Windows.Forms.Label();
            this.lblTenChong = new System.Windows.Forms.Label();
            this.lblNoiDangKy = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlVo = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThongTinVo = new System.Windows.Forms.Button();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.txtTenVo = new System.Windows.Forms.TextBox();
            this.txtCCCDVo = new System.Windows.Forms.TextBox();
            this.lblCCCDVo = new System.Windows.Forms.Label();
            this.lblTenVo = new System.Windows.Forms.Label();
            this.lblDeMuc2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlChong.SuspendLayout();
            this.pnlVo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChong
            // 
            this.pnlChong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlChong.Controls.Add(this.btnThongTinChong);
            this.pnlChong.Controls.Add(this.txtCCCDChong);
            this.pnlChong.Controls.Add(this.txtNoiDangKy);
            this.pnlChong.Controls.Add(this.txtTenChong);
            this.pnlChong.Controls.Add(this.lblCCCDChong);
            this.pnlChong.Controls.Add(this.lblTenChong);
            this.pnlChong.Controls.Add(this.lblNoiDangKy);
            this.pnlChong.Location = new System.Drawing.Point(0, 89);
            this.pnlChong.Name = "pnlChong";
            this.pnlChong.Size = new System.Drawing.Size(600, 640);
            this.pnlChong.TabIndex = 2;
            // 
            // btnThongTinChong
            // 
            this.btnThongTinChong.BackColor = System.Drawing.Color.Transparent;
            this.btnThongTinChong.FlatAppearance.BorderSize = 0;
            this.btnThongTinChong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinChong.Image = global::QuanLiCongDanThanhPho.Properties.Resources.view;
            this.btnThongTinChong.Location = new System.Drawing.Point(515, 293);
            this.btnThongTinChong.Name = "btnThongTinChong";
            this.btnThongTinChong.Size = new System.Drawing.Size(50, 50);
            this.btnThongTinChong.TabIndex = 95;
            this.btnThongTinChong.UseVisualStyleBackColor = false;
            this.btnThongTinChong.Click += new System.EventHandler(this.btnThongTinChong_Click);
            // 
            // txtCCCDChong
            // 
            this.txtCCCDChong.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCCCDChong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCDChong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCCCDChong.Location = new System.Drawing.Point(250, 150);
            this.txtCCCDChong.Name = "txtCCCDChong";
            this.txtCCCDChong.ReadOnly = true;
            this.txtCCCDChong.Size = new System.Drawing.Size(315, 27);
            this.txtCCCDChong.TabIndex = 7;
            // 
            // txtNoiDangKy
            // 
            this.txtNoiDangKy.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNoiDangKy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoiDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNoiDangKy.Location = new System.Drawing.Point(250, 250);
            this.txtNoiDangKy.Name = "txtNoiDangKy";
            this.txtNoiDangKy.ReadOnly = true;
            this.txtNoiDangKy.Size = new System.Drawing.Size(315, 27);
            this.txtNoiDangKy.TabIndex = 6;
            // 
            // txtTenChong
            // 
            this.txtTenChong.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTenChong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenChong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenChong.Location = new System.Drawing.Point(250, 50);
            this.txtTenChong.Name = "txtTenChong";
            this.txtTenChong.ReadOnly = true;
            this.txtTenChong.Size = new System.Drawing.Size(315, 27);
            this.txtTenChong.TabIndex = 5;
            // 
            // lblCCCDChong
            // 
            this.lblCCCDChong.AutoSize = true;
            this.lblCCCDChong.Location = new System.Drawing.Point(50, 150);
            this.lblCCCDChong.Name = "lblCCCDChong";
            this.lblCCCDChong.Size = new System.Drawing.Size(61, 28);
            this.lblCCCDChong.TabIndex = 2;
            this.lblCCCDChong.Text = "CCCD";
            // 
            // lblTenChong
            // 
            this.lblTenChong.AutoSize = true;
            this.lblTenChong.Location = new System.Drawing.Point(50, 50);
            this.lblTenChong.Name = "lblTenChong";
            this.lblTenChong.Size = new System.Drawing.Size(168, 28);
            this.lblTenChong.TabIndex = 1;
            this.lblTenChong.Text = "Họ và tên chồng";
            // 
            // lblNoiDangKy
            // 
            this.lblNoiDangKy.AutoSize = true;
            this.lblNoiDangKy.Location = new System.Drawing.Point(50, 250);
            this.lblNoiDangKy.Name = "lblNoiDangKy";
            this.lblNoiDangKy.Size = new System.Drawing.Size(129, 28);
            this.lblNoiDangKy.TabIndex = 0;
            this.lblNoiDangKy.Text = "Nơi đăng ký";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(427, 649);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 50);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa đăng ký";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày đăng ký";
            // 
            // pnlVo
            // 
            this.pnlVo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlVo.Controls.Add(this.btnSua);
            this.pnlVo.Controls.Add(this.btnThongTinVo);
            this.pnlVo.Controls.Add(this.btnXoa);
            this.pnlVo.Controls.Add(this.dtpNgayDangKy);
            this.pnlVo.Controls.Add(this.txtTenVo);
            this.pnlVo.Controls.Add(this.txtCCCDVo);
            this.pnlVo.Controls.Add(this.lblCCCDVo);
            this.pnlVo.Controls.Add(this.label7);
            this.pnlVo.Controls.Add(this.lblTenVo);
            this.pnlVo.Location = new System.Drawing.Point(600, 89);
            this.pnlVo.Name = "pnlVo";
            this.pnlVo.Size = new System.Drawing.Size(600, 640);
            this.pnlVo.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Image = global::QuanLiCongDanThanhPho.Properties.Resources.editing__1_;
            this.btnSua.Location = new System.Drawing.Point(506, 541);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(50, 50);
            this.btnSua.TabIndex = 96;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThongTinVo
            // 
            this.btnThongTinVo.BackColor = System.Drawing.Color.Transparent;
            this.btnThongTinVo.FlatAppearance.BorderSize = 0;
            this.btnThongTinVo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinVo.Image = global::QuanLiCongDanThanhPho.Properties.Resources.view;
            this.btnThongTinVo.Location = new System.Drawing.Point(506, 293);
            this.btnThongTinVo.Name = "btnThongTinVo";
            this.btnThongTinVo.Size = new System.Drawing.Size(50, 50);
            this.btnThongTinVo.TabIndex = 95;
            this.btnThongTinVo.UseVisualStyleBackColor = false;
            this.btnThongTinVo.Click += new System.EventHandler(this.btnThongTinVo_Click);
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayDangKy.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtpNgayDangKy.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDangKy.Location = new System.Drawing.Point(241, 244);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(315, 34);
            this.dtpNgayDangKy.TabIndex = 6;
            this.dtpNgayDangKy.Value = new System.DateTime(2023, 2, 28, 0, 0, 0, 0);
            // 
            // txtTenVo
            // 
            this.txtTenVo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTenVo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenVo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenVo.Location = new System.Drawing.Point(241, 50);
            this.txtTenVo.Name = "txtTenVo";
            this.txtTenVo.ReadOnly = true;
            this.txtTenVo.Size = new System.Drawing.Size(315, 27);
            this.txtTenVo.TabIndex = 5;
            // 
            // txtCCCDVo
            // 
            this.txtCCCDVo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCCCDVo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCDVo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCCCDVo.Location = new System.Drawing.Point(241, 150);
            this.txtCCCDVo.Name = "txtCCCDVo";
            this.txtCCCDVo.ReadOnly = true;
            this.txtCCCDVo.Size = new System.Drawing.Size(315, 27);
            this.txtCCCDVo.TabIndex = 4;
            // 
            // lblCCCDVo
            // 
            this.lblCCCDVo.AutoSize = true;
            this.lblCCCDVo.Location = new System.Drawing.Point(50, 150);
            this.lblCCCDVo.Name = "lblCCCDVo";
            this.lblCCCDVo.Size = new System.Drawing.Size(61, 28);
            this.lblCCCDVo.TabIndex = 3;
            this.lblCCCDVo.Text = "CCCD";
            // 
            // lblTenVo
            // 
            this.lblTenVo.AutoSize = true;
            this.lblTenVo.Location = new System.Drawing.Point(50, 50);
            this.lblTenVo.Name = "lblTenVo";
            this.lblTenVo.Size = new System.Drawing.Size(134, 28);
            this.lblTenVo.TabIndex = 2;
            this.lblTenVo.Text = "Họ và tên vợ";
            // 
            // lblDeMuc2
            // 
            this.lblDeMuc2.AutoSize = true;
            this.lblDeMuc2.BackColor = System.Drawing.Color.Transparent;
            this.lblDeMuc2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeMuc2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDeMuc2.Location = new System.Drawing.Point(520, 19);
            this.lblDeMuc2.Name = "lblDeMuc2";
            this.lblDeMuc2.Size = new System.Drawing.Size(168, 37);
            this.lblDeMuc2.TabIndex = 1;
            this.lblDeMuc2.Text = "HÔN NHÂN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.lblDeMuc2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 4;
            // 
            // FThongTinHonNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlVo);
            this.Controls.Add(this.pnlChong);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FThongTinHonNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.pnlChong.ResumeLayout(false);
            this.pnlChong.PerformLayout();
            this.pnlVo.ResumeLayout(false);
            this.pnlVo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private Button btnXoa;
        private Panel panel1;
        private Button btnThongTinChong;
        private Button btnThongTinVo;
        private Button btnSua;
    }
}