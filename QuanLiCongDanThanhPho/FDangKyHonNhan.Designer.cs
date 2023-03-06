namespace QuanLiCongDanThanhPho
{
    partial class FDangKyHonNhan
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
            lblTen = new Label();
            txtTenChong = new TextBox();
            txtTenVo = new TextBox();
            lblCCCD = new Label();
            txtCCCDChong = new TextBox();
            txtCCCDVo = new TextBox();
            dtmNgayDangKy = new DateTimePicker();
            lblNgayDangKy = new Label();
            lblChong = new Label();
            lblVo = new Label();
            btnTimChong = new Button();
            btnTimVo = new Button();
            lblNoiDangKy = new Label();
            txtNoiDK = new TextBox();
            btnMaHonNhan = new Button();
            txtMaHonNhan = new TextBox();
            btnReset = new Button();
            btnDangKy = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.ForeColor = Color.FromArgb(44, 43, 60);
            lblTen.Location = new Point(708, 275);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(104, 28);
            lblTen.TabIndex = 1;
            lblTen.Text = "Họ và tên";
            // 
            // txtTenChong
            // 
            txtTenChong.BackColor = Color.Gainsboro;
            txtTenChong.BorderStyle = BorderStyle.None;
            txtTenChong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenChong.Location = new Point(120, 275);
            txtTenChong.Name = "txtTenChong";
            txtTenChong.Size = new Size(479, 27);
            txtTenChong.TabIndex = 11;
            // 
            // txtTenVo
            // 
            txtTenVo.BackColor = Color.Gainsboro;
            txtTenVo.BorderStyle = BorderStyle.None;
            txtTenVo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenVo.Location = new Point(930, 275);
            txtTenVo.Name = "txtTenVo";
            txtTenVo.Size = new Size(490, 27);
            txtTenVo.TabIndex = 13;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.ForeColor = Color.FromArgb(44, 43, 60);
            lblCCCD.Location = new Point(708, 349);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(61, 28);
            lblCCCD.TabIndex = 14;
            lblCCCD.Text = "CCCD";
            // 
            // txtCCCDChong
            // 
            txtCCCDChong.BackColor = Color.Gainsboro;
            txtCCCDChong.BorderStyle = BorderStyle.None;
            txtCCCDChong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCDChong.Location = new Point(120, 361);
            txtCCCDChong.Name = "txtCCCDChong";
            txtCCCDChong.Size = new Size(397, 27);
            txtCCCDChong.TabIndex = 15;
            // 
            // txtCCCDVo
            // 
            txtCCCDVo.BackColor = Color.Gainsboro;
            txtCCCDVo.BorderStyle = BorderStyle.None;
            txtCCCDVo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCDVo.Location = new Point(930, 361);
            txtCCCDVo.Name = "txtCCCDVo";
            txtCCCDVo.Size = new Size(397, 27);
            txtCCCDVo.TabIndex = 17;
            // 
            // dtmNgayDangKy
            // 
            dtmNgayDangKy.CustomFormat = "dd/MM/yyyy";
            dtmNgayDangKy.Format = DateTimePickerFormat.Custom;
            dtmNgayDangKy.Location = new Point(593, 531);
            dtmNgayDangKy.Name = "dtmNgayDangKy";
            dtmNgayDangKy.Size = new Size(250, 34);
            dtmNgayDangKy.TabIndex = 19;
            dtmNgayDangKy.Value = new DateTime(2023, 3, 6, 0, 0, 0, 0);
            // 
            // lblNgayDangKy
            // 
            lblNgayDangKy.AutoSize = true;
            lblNgayDangKy.ForeColor = Color.FromArgb(44, 43, 60);
            lblNgayDangKy.Location = new Point(416, 531);
            lblNgayDangKy.Name = "lblNgayDangKy";
            lblNgayDangKy.Size = new Size(144, 28);
            lblNgayDangKy.TabIndex = 18;
            lblNgayDangKy.Text = "Ngày đăng ký";
            // 
            // lblChong
            // 
            lblChong.AutoSize = true;
            lblChong.ForeColor = Color.FromArgb(44, 43, 60);
            lblChong.Location = new Point(120, 213);
            lblChong.Name = "lblChong";
            lblChong.Size = new Size(72, 28);
            lblChong.TabIndex = 51;
            lblChong.Text = "Chồng";
            // 
            // lblVo
            // 
            lblVo.AutoSize = true;
            lblVo.ForeColor = Color.FromArgb(44, 43, 60);
            lblVo.Location = new Point(930, 213);
            lblVo.Name = "lblVo";
            lblVo.Size = new Size(38, 28);
            lblVo.TabIndex = 52;
            lblVo.Text = "Vợ";
            // 
            // btnTimChong
            // 
            btnTimChong.BackColor = Color.Transparent;
            btnTimChong.FlatStyle = FlatStyle.Flat;
            btnTimChong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimChong.ForeColor = Color.FromArgb(44, 53, 60);
            btnTimChong.Image = Properties.Resources.search;
            btnTimChong.Location = new Point(549, 337);
            btnTimChong.Name = "btnTimChong";
            btnTimChong.Size = new Size(50, 50);
            btnTimChong.TabIndex = 53;
            btnTimChong.UseVisualStyleBackColor = false;
            // 
            // btnTimVo
            // 
            btnTimVo.BackColor = Color.Transparent;
            btnTimVo.FlatStyle = FlatStyle.Flat;
            btnTimVo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimVo.ForeColor = Color.FromArgb(44, 53, 60);
            btnTimVo.Image = Properties.Resources.search;
            btnTimVo.Location = new Point(1370, 338);
            btnTimVo.Name = "btnTimVo";
            btnTimVo.Size = new Size(50, 50);
            btnTimVo.TabIndex = 54;
            btnTimVo.UseVisualStyleBackColor = false;
            // 
            // lblNoiDangKy
            // 
            lblNoiDangKy.AutoSize = true;
            lblNoiDangKy.ForeColor = Color.FromArgb(44, 43, 60);
            lblNoiDangKy.Location = new Point(416, 455);
            lblNoiDangKy.Name = "lblNoiDangKy";
            lblNoiDangKy.Size = new Size(129, 28);
            lblNoiDangKy.TabIndex = 55;
            lblNoiDangKy.Text = "Nơi đăng ký";
            // 
            // txtNoiDK
            // 
            txtNoiDK.BackColor = Color.Gainsboro;
            txtNoiDK.BorderStyle = BorderStyle.None;
            txtNoiDK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoiDK.Location = new Point(593, 455);
            txtNoiDK.Name = "txtNoiDK";
            txtNoiDK.Size = new Size(511, 27);
            txtNoiDK.TabIndex = 56;
            // 
            // btnMaHonNhan
            // 
            btnMaHonNhan.Location = new Point(108, 93);
            btnMaHonNhan.Name = "btnMaHonNhan";
            btnMaHonNhan.Size = new Size(163, 48);
            btnMaHonNhan.TabIndex = 57;
            btnMaHonNhan.Text = "Mã đăng ký";
            btnMaHonNhan.UseVisualStyleBackColor = true;
            // 
            // txtMaHonNhan
            // 
            txtMaHonNhan.BackColor = Color.Gainsboro;
            txtMaHonNhan.BorderStyle = BorderStyle.None;
            txtMaHonNhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHonNhan.Location = new Point(326, 114);
            txtMaHonNhan.Name = "txtMaHonNhan";
            txtMaHonNhan.Size = new Size(244, 27);
            txtMaHonNhan.TabIndex = 58;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.DialogResult = DialogResult.OK;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Image = Properties.Resources.reset;
            btnReset.Location = new Point(1264, 31);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(50, 50);
            btnReset.TabIndex = 59;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Transparent;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Image = Properties.Resources.verify;
            btnDangKy.Location = new Point(1339, 31);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(50, 50);
            btnDangKy.TabIndex = 60;
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = Properties.Resources.delete__1_;
            btnDelete.Location = new Point(1186, 31);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(50, 50);
            btnDelete.TabIndex = 61;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FDangKyHonNhan
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1532, 782);
            Controls.Add(btnDelete);
            Controls.Add(btnDangKy);
            Controls.Add(btnReset);
            Controls.Add(txtMaHonNhan);
            Controls.Add(btnMaHonNhan);
            Controls.Add(txtNoiDK);
            Controls.Add(lblNoiDangKy);
            Controls.Add(btnTimVo);
            Controls.Add(btnTimChong);
            Controls.Add(lblVo);
            Controls.Add(lblChong);
            Controls.Add(dtmNgayDangKy);
            Controls.Add(lblNgayDangKy);
            Controls.Add(txtCCCDVo);
            Controls.Add(txtCCCDChong);
            Controls.Add(lblCCCD);
            Controls.Add(txtTenVo);
            Controls.Add(txtTenChong);
            Controls.Add(lblTen);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDangKyHonNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDangKyKetHon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTen;
        private TextBox txtTenChong;
        private TextBox txtTenVo;
        private Label lblCCCD;
        private TextBox txtCCCDChong;
        private TextBox txtCCCDVo;
        private DateTimePicker dtmNgayDangKy;
        private Label lblNgayDangKy;
        private Label lblChong;
        private Label lblVo;
        private Button btnTimChong;
        private Button btnTimVo;
        private Label lblNoiDangKy;
        private TextBox txtNoiDK;
        private Button btnMaHonNhan;
        private TextBox txtMaHonNhan;
        private Button btnReset;
        private Button btnDangKy;
        private Button btnDelete;
    }
}