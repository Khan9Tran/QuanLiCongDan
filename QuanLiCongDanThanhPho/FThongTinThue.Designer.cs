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
            lblTittle = new Label();
            pnlThongTinThue = new Panel();
            btnCapNhatThongTinThue = new Button();
            dtpHanNopThue = new DateTimePicker();
            dtpNgayCapMaSoThue = new DateTimePicker();
            txtSoTienDaNop = new TextBox();
            txtSoTienCanNop = new TextBox();
            txtSdt = new TextBox();
            txtDiaChi = new TextBox();
            txtCCCD = new TextBox();
            txtTen = new TextBox();
            txtMaSoThue = new TextBox();
            lblHanNopThue = new Label();
            lblDiaChi = new Label();
            lblNgayCapMaSoThue = new Label();
            lblSoTienDaNop = new Label();
            lblSoTienCanNop = new Label();
            lblSdt = new Label();
            lblCCCD = new Label();
            lblTen = new Label();
            lblMaSoThue = new Label();
            pnlTittleBar.SuspendLayout();
            pnlThongTinThue.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTittleBar
            // 
            pnlTittleBar.BackColor = Color.FromArgb(44, 43, 60);
            pnlTittleBar.Controls.Add(lblTittle);
            pnlTittleBar.Dock = DockStyle.Top;
            pnlTittleBar.Location = new Point(0, 0);
            pnlTittleBar.Name = "pnlTittleBar";
            pnlTittleBar.Size = new Size(927, 81);
            pnlTittleBar.TabIndex = 0;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Transparent;
            lblTittle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTittle.ForeColor = Color.WhiteSmoke;
            lblTittle.Location = new Point(357, 22);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(213, 38);
            lblTittle.TabIndex = 0;
            lblTittle.Text = "Thông tin thuế";
            // 
            // pnlThongTinThue
            // 
            pnlThongTinThue.BackColor = Color.WhiteSmoke;
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
            pnlThongTinThue.Location = new Point(12, 87);
            pnlThongTinThue.Name = "pnlThongTinThue";
            pnlThongTinThue.Size = new Size(915, 566);
            pnlThongTinThue.TabIndex = 2;
            // 
            // btnCapNhatThongTinThue
            // 
            btnCapNhatThongTinThue.BackColor = Color.White;
            btnCapNhatThongTinThue.ForeColor = Color.FromArgb(44, 53, 60);
            btnCapNhatThongTinThue.Location = new Point(673, 458);
            btnCapNhatThongTinThue.Name = "btnCapNhatThongTinThue";
            btnCapNhatThongTinThue.Size = new Size(200, 50);
            btnCapNhatThongTinThue.TabIndex = 18;
            btnCapNhatThongTinThue.Text = "Cập nhật thông tin";
            btnCapNhatThongTinThue.UseVisualStyleBackColor = false;
            // 
            // dtpHanNopThue
            // 
            dtpHanNopThue.CustomFormat = "dd/MM/yyyy";
            dtpHanNopThue.Format = DateTimePickerFormat.Custom;
            dtpHanNopThue.Location = new Point(713, 370);
            dtpHanNopThue.Name = "dtpHanNopThue";
            dtpHanNopThue.Size = new Size(160, 34);
            dtpHanNopThue.TabIndex = 17;
            // 
            // dtpNgayCapMaSoThue
            // 
            dtpNgayCapMaSoThue.CustomFormat = "dd/MM/yyyy";
            dtpNgayCapMaSoThue.Format = DateTimePickerFormat.Custom;
            dtpNgayCapMaSoThue.Location = new Point(250, 370);
            dtpNgayCapMaSoThue.Name = "dtpNgayCapMaSoThue";
            dtpNgayCapMaSoThue.Size = new Size(160, 34);
            dtpNgayCapMaSoThue.TabIndex = 16;
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
            // txtSoTienCanNop
            // 
            txtSoTienCanNop.BackColor = Color.Gainsboro;
            txtSoTienCanNop.BorderStyle = BorderStyle.None;
            txtSoTienCanNop.Location = new Point(250, 270);
            txtSoTienCanNop.Name = "txtSoTienCanNop";
            txtSoTienCanNop.Size = new Size(623, 27);
            txtSoTienCanNop.TabIndex = 14;
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
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.Gainsboro;
            txtDiaChi.BorderStyle = BorderStyle.None;
            txtDiaChi.Location = new Point(250, 220);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(623, 27);
            txtDiaChi.TabIndex = 12;
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
            // txtTen
            // 
            txtTen.BackColor = Color.Gainsboro;
            txtTen.BorderStyle = BorderStyle.None;
            txtTen.Location = new Point(250, 70);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(623, 27);
            txtTen.TabIndex = 10;
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
            // lblHanNopThue
            // 
            lblHanNopThue.AutoSize = true;
            lblHanNopThue.Location = new Point(591, 370);
            lblHanNopThue.Name = "lblHanNopThue";
            lblHanNopThue.Size = new Size(92, 28);
            lblHanNopThue.TabIndex = 8;
            lblHanNopThue.Text = "Hạn nộp";
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
            // lblNgayCapMaSoThue
            // 
            lblNgayCapMaSoThue.AutoSize = true;
            lblNgayCapMaSoThue.Location = new Point(50, 370);
            lblNgayCapMaSoThue.Name = "lblNgayCapMaSoThue";
            lblNgayCapMaSoThue.Size = new Size(101, 28);
            lblNgayCapMaSoThue.TabIndex = 7;
            lblNgayCapMaSoThue.Text = "Ngày cấp";
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
            // lblSoTienCanNop
            // 
            lblSoTienCanNop.AutoSize = true;
            lblSoTienCanNop.Location = new Point(50, 270);
            lblSoTienCanNop.Name = "lblSoTienCanNop";
            lblSoTienCanNop.Size = new Size(159, 28);
            lblSoTienCanNop.TabIndex = 5;
            lblSoTienCanNop.Text = "Số tiền cần nộp";
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
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(50, 120);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(61, 28);
            lblCCCD.TabIndex = 3;
            lblCCCD.Text = "CCCD";
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
            // FThongTinThue
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(927, 652);
            Controls.Add(pnlThongTinThue);
            Controls.Add(pnlTittleBar);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FThongTinThue";
            Text = "FThongTinThue";
            pnlTittleBar.ResumeLayout(false);
            pnlTittleBar.PerformLayout();
            pnlThongTinThue.ResumeLayout(false);
            pnlThongTinThue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTittleBar;
        private Panel pnlThongTinThue;
        private Label lblTittle;
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