namespace QuanLiCongDanThanhPho
{
    partial class FThongTinThue
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
            pnlTittleBar = new Panel();
            pnlTrai = new Panel();
            pnlThongTinThue = new Panel();
            lblTittleBar = new Label();
            lblMaSoThue = new Label();
            lblTen = new Label();
            lblCCCD = new Label();
            lblSdt = new Label();
            lblDiaChi = new Label();
            lblSoTienCanNop = new Label();
            lblSoTienDaNop = new Label();
            lblNgayCapMaSoThue = new Label();
            lblHanNopThue = new Label();
            txtMaSoThue = new TextBox();
            txtTen = new TextBox();
            txtCCCD = new TextBox();
            txtDiaChi = new TextBox();
            txtSdt = new TextBox();
            txtSoTienCanNop = new TextBox();
            txtSoTienDaNop = new TextBox();
            dtpNgayCapMaSoThue = new DateTimePicker();
            dtpHanNopThue = new DateTimePicker();
            btnCapNhatThongTinThue = new Button();
            btnQuayLai = new Button();
            btnTrangChu = new Button();
            pnlTittleBar.SuspendLayout();
            pnlTrai.SuspendLayout();
            pnlThongTinThue.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTittleBar
            // 
            pnlTittleBar.BackColor = Color.FromArgb(250, 200, 0);
            pnlTittleBar.Controls.Add(lblTittleBar);
            pnlTittleBar.Dock = DockStyle.Top;
            pnlTittleBar.Location = new Point(0, 0);
            pnlTittleBar.Name = "pnlTittleBar";
            pnlTittleBar.Size = new Size(1200, 81);
            pnlTittleBar.TabIndex = 0;
            // 
            // pnlTrai
            // 
            pnlTrai.BackColor = Color.FromArgb(250, 200, 0);
            pnlTrai.Controls.Add(btnTrangChu);
            pnlTrai.Controls.Add(btnQuayLai);
            pnlTrai.Dock = DockStyle.Left;
            pnlTrai.Location = new Point(0, 81);
            pnlTrai.Name = "pnlTrai";
            pnlTrai.Size = new Size(250, 639);
            pnlTrai.TabIndex = 1;
            // 
            // pnlThongTinThue
            // 
            pnlThongTinThue.Controls.Add(btnCapNhatThongTinThue);
            pnlThongTinThue.Controls.Add(dtpHanNopThue);
            pnlThongTinThue.Controls.Add(dtpNgayCapMaSoThue);
            pnlThongTinThue.Controls.Add(txtSoTienDaNop);
            pnlThongTinThue.Controls.Add(txtSoTienCanNop);
            pnlThongTinThue.Controls.Add(txtSdt);
            pnlThongTinThue.Controls.Add(txtDiaChi);
            pnlThongTinThue.Controls.Add(txtCCCD);
            pnlThongTinThue.Controls.Add(txtTen);
            pnlThongTinThue.Controls.Add(txtMaSoThue);
            pnlThongTinThue.Controls.Add(lblHanNopThue);
            pnlThongTinThue.Controls.Add(lblDiaChi);
            pnlThongTinThue.Controls.Add(lblNgayCapMaSoThue);
            pnlThongTinThue.Controls.Add(lblSoTienDaNop);
            pnlThongTinThue.Controls.Add(lblSoTienCanNop);
            pnlThongTinThue.Controls.Add(lblSdt);
            pnlThongTinThue.Controls.Add(lblCCCD);
            pnlThongTinThue.Controls.Add(lblTen);
            pnlThongTinThue.Controls.Add(lblMaSoThue);
            pnlThongTinThue.Dock = DockStyle.Fill;
            pnlThongTinThue.Location = new Point(250, 81);
            pnlThongTinThue.Name = "pnlThongTinThue";
            pnlThongTinThue.Size = new Size(950, 639);
            pnlThongTinThue.TabIndex = 2;
            // 
            // lblTittleBar
            // 
            lblTittleBar.AutoSize = true;
            lblTittleBar.Location = new Point(47, 24);
            lblTittleBar.Name = "lblTittleBar";
            lblTittleBar.Size = new Size(153, 28);
            lblTittleBar.TabIndex = 0;
            lblTittleBar.Text = "Thông tin thuế";
            // 
            // lblMaSoThue
            // 
            lblMaSoThue.AutoSize = true;
            lblMaSoThue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaSoThue.Location = new Point(50, 20);
            lblMaSoThue.Name = "lblMaSoThue";
            lblMaSoThue.Size = new Size(118, 28);
            lblMaSoThue.TabIndex = 1;
            lblMaSoThue.Text = "Mã số thuế";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(50, 70);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(138, 28);
            lblTen.TabIndex = 2;
            lblTen.Text = "Tên công dân";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(50, 120);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(61, 28);
            lblCCCD.TabIndex = 3;
            lblCCCD.Text = "CCCD";
            // 
            // lblSdt
            // 
            lblSdt.AutoSize = true;
            lblSdt.Location = new Point(50, 176);
            lblSdt.Name = "lblSdt";
            lblSdt.Size = new Size(138, 28);
            lblSdt.TabIndex = 4;
            lblSdt.Text = "Số điện thoại";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(50, 220);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(78, 28);
            lblDiaChi.TabIndex = 0;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblSoTienCanNop
            // 
            lblSoTienCanNop.AutoSize = true;
            lblSoTienCanNop.Location = new Point(50, 270);
            lblSoTienCanNop.Name = "lblSoTienCanNop";
            lblSoTienCanNop.Size = new Size(159, 28);
            lblSoTienCanNop.TabIndex = 5;
            lblSoTienCanNop.Text = "Số tiền cần nộp";
            // 
            // lblSoTienDaNop
            // 
            lblSoTienDaNop.AutoSize = true;
            lblSoTienDaNop.Location = new Point(50, 320);
            lblSoTienDaNop.Name = "lblSoTienDaNop";
            lblSoTienDaNop.Size = new Size(150, 28);
            lblSoTienDaNop.TabIndex = 6;
            lblSoTienDaNop.Text = "Số tiền đã nộp";
            // 
            // lblNgayCapMaSoThue
            // 
            lblNgayCapMaSoThue.AutoSize = true;
            lblNgayCapMaSoThue.Location = new Point(50, 370);
            lblNgayCapMaSoThue.Name = "lblNgayCapMaSoThue";
            lblNgayCapMaSoThue.Size = new Size(101, 28);
            lblNgayCapMaSoThue.TabIndex = 7;
            lblNgayCapMaSoThue.Text = "Ngày cấp";
            // 
            // lblHanNopThue
            // 
            lblHanNopThue.AutoSize = true;
            lblHanNopThue.Location = new Point(591, 370);
            lblHanNopThue.Name = "lblHanNopThue";
            lblHanNopThue.Size = new Size(92, 28);
            lblHanNopThue.TabIndex = 8;
            lblHanNopThue.Text = "Hạn nộp";
            // 
            // txtMaSoThue
            // 
            txtMaSoThue.BackColor = Color.Gainsboro;
            txtMaSoThue.BorderStyle = BorderStyle.None;
            txtMaSoThue.Location = new Point(250, 20);
            txtMaSoThue.Name = "txtMaSoThue";
            txtMaSoThue.Size = new Size(623, 27);
            txtMaSoThue.TabIndex = 9;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.Gainsboro;
            txtTen.BorderStyle = BorderStyle.None;
            txtTen.Location = new Point(250, 70);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(623, 27);
            txtTen.TabIndex = 10;
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = Color.Gainsboro;
            txtCCCD.BorderStyle = BorderStyle.None;
            txtCCCD.Location = new Point(250, 120);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(623, 27);
            txtCCCD.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.Gainsboro;
            txtDiaChi.BorderStyle = BorderStyle.None;
            txtDiaChi.Location = new Point(250, 220);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(623, 27);
            txtDiaChi.TabIndex = 12;
            // 
            // txtSdt
            // 
            txtSdt.BackColor = Color.Gainsboro;
            txtSdt.BorderStyle = BorderStyle.None;
            txtSdt.Location = new Point(250, 170);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(623, 27);
            txtSdt.TabIndex = 13;
            // 
            // txtSoTienCanNop
            // 
            txtSoTienCanNop.BackColor = Color.Gainsboro;
            txtSoTienCanNop.BorderStyle = BorderStyle.None;
            txtSoTienCanNop.Location = new Point(250, 270);
            txtSoTienCanNop.Name = "txtSoTienCanNop";
            txtSoTienCanNop.Size = new Size(623, 27);
            txtSoTienCanNop.TabIndex = 14;
            // 
            // txtSoTienDaNop
            // 
            txtSoTienDaNop.BackColor = Color.Gainsboro;
            txtSoTienDaNop.BorderStyle = BorderStyle.None;
            txtSoTienDaNop.Location = new Point(250, 320);
            txtSoTienDaNop.Name = "txtSoTienDaNop";
            txtSoTienDaNop.Size = new Size(623, 27);
            txtSoTienDaNop.TabIndex = 15;
            // 
            // dtpNgayCapMaSoThue
            // 
            dtpNgayCapMaSoThue.Format = DateTimePickerFormat.Custom;
            dtpNgayCapMaSoThue.Location = new Point(250, 370);
            dtpNgayCapMaSoThue.Name = "dtpNgayCapMaSoThue";
            dtpNgayCapMaSoThue.Size = new Size(160, 34);
            dtpNgayCapMaSoThue.TabIndex = 16;
            // 
            // dtpHanNopThue
            // 
            dtpHanNopThue.Format = DateTimePickerFormat.Custom;
            dtpHanNopThue.Location = new Point(713, 370);
            dtpHanNopThue.Name = "dtpHanNopThue";
            dtpHanNopThue.Size = new Size(160, 34);
            dtpHanNopThue.TabIndex = 17;
            // 
            // btnCapNhatThongTinThue
            // 
            btnCapNhatThongTinThue.Location = new Point(673, 549);
            btnCapNhatThongTinThue.Name = "btnCapNhatThongTinThue";
            btnCapNhatThongTinThue.Size = new Size(200, 50);
            btnCapNhatThongTinThue.TabIndex = 18;
            btnCapNhatThongTinThue.Text = "Cập nhật thông tin";
            btnCapNhatThongTinThue.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(0, 549);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(200, 50);
            btnQuayLai.TabIndex = 19;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Location = new Point(0, 454);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(200, 50);
            btnTrangChu.TabIndex = 20;
            btnTrangChu.Text = "Trang chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // FThongTinThue
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 720);
            Controls.Add(pnlThongTinThue);
            Controls.Add(pnlTrai);
            Controls.Add(pnlTittleBar);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FThongTinThue";
            Text = "FThongTinThue";
            pnlTittleBar.ResumeLayout(false);
            pnlTittleBar.PerformLayout();
            pnlTrai.ResumeLayout(false);
            pnlThongTinThue.ResumeLayout(false);
            pnlThongTinThue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTittleBar;
        private Panel pnlTrai;
        private Panel pnlThongTinThue;
        private Label lblTittleBar;
        private Label lblDiaChi;
        private Label lblNgayCapMaSoThue;
        private Label lblSoTienDaNop;
        private Label lblSoTienCanNop;
        private Label lblSdt;
        private Label lblCCCD;
        private Label lblTen;
        private Label lblMaSoThue;
        private TextBox txtMaSoThue;
        private Label lblHanNopThue;
        private Button btnTrangChu;
        private Button btnQuayLai;
        private Button btnCapNhatThongTinThue;
        private DateTimePicker dtpHanNopThue;
        private DateTimePicker dtpNgayCapMaSoThue;
        private TextBox txtSoTienDaNop;
        private TextBox txtSoTienCanNop;
        private TextBox txtSdt;
        private TextBox txtDiaChi;
        private TextBox txtCCCD;
        private TextBox txtTen;
    }
}