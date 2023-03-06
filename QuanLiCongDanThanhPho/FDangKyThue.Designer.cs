namespace QuanLiCongDanThanhPho
{
    partial class FDangKyThue
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
            txtSoTienPhaiNop = new TextBox();
            lblSoTien = new Label();
            txtMaSoThue = new TextBox();
            lblMaThue = new Label();
            txtTenCoQuan = new TextBox();
            lblTenCoQuan = new Label();
            lblNgayCapMa = new Label();
            dtpNgayCapMa = new DateTimePicker();
            dtpHanNop = new DateTimePicker();
            lblHanNop = new Label();
            btnDangKy = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // txtSoTienPhaiNop
            // 
            txtSoTienPhaiNop.BackColor = Color.Gainsboro;
            txtSoTienPhaiNop.BorderStyle = BorderStyle.None;
            txtSoTienPhaiNop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoTienPhaiNop.Location = new Point(643, 265);
            txtSoTienPhaiNop.Name = "txtSoTienPhaiNop";
            txtSoTienPhaiNop.Size = new Size(292, 27);
            txtSoTienPhaiNop.TabIndex = 31;
            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.Location = new Point(424, 265);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(167, 28);
            lblSoTien.TabIndex = 30;
            lblSoTien.Text = "Số tiền phải nộp";
            // 
            // txtMaSoThue
            // 
            txtMaSoThue.BackColor = Color.Gainsboro;
            txtMaSoThue.BorderStyle = BorderStyle.None;
            txtMaSoThue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSoThue.Location = new Point(643, 185);
            txtMaSoThue.Name = "txtMaSoThue";
            txtMaSoThue.Size = new Size(442, 27);
            txtMaSoThue.TabIndex = 29;
            // 
            // lblMaThue
            // 
            lblMaThue.AutoSize = true;
            lblMaThue.Location = new Point(424, 184);
            lblMaThue.Name = "lblMaThue";
            lblMaThue.Size = new Size(91, 28);
            lblMaThue.TabIndex = 28;
            lblMaThue.Text = "Mã thuế";
            // 
            // txtTenCoQuan
            // 
            txtTenCoQuan.BackColor = Color.Gainsboro;
            txtTenCoQuan.BorderStyle = BorderStyle.None;
            txtTenCoQuan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenCoQuan.Location = new Point(643, 344);
            txtTenCoQuan.Name = "txtTenCoQuan";
            txtTenCoQuan.Size = new Size(442, 27);
            txtTenCoQuan.TabIndex = 33;
            // 
            // lblTenCoQuan
            // 
            lblTenCoQuan.AutoSize = true;
            lblTenCoQuan.Location = new Point(424, 343);
            lblTenCoQuan.Name = "lblTenCoQuan";
            lblTenCoQuan.Size = new Size(203, 28);
            lblTenCoQuan.TabIndex = 32;
            lblTenCoQuan.Text = "Tên cơ quan quản lý";
            // 
            // lblNgayCapMa
            // 
            lblNgayCapMa.AutoSize = true;
            lblNgayCapMa.Location = new Point(424, 424);
            lblNgayCapMa.Name = "lblNgayCapMa";
            lblNgayCapMa.Size = new Size(136, 28);
            lblNgayCapMa.TabIndex = 34;
            lblNgayCapMa.Text = "Ngày cấp mã";
            // 
            // dtpNgayCapMa
            // 
            dtpNgayCapMa.CustomFormat = "dd/MM/yyyy";
            dtpNgayCapMa.Format = DateTimePickerFormat.Custom;
            dtpNgayCapMa.Location = new Point(643, 424);
            dtpNgayCapMa.Name = "dtpNgayCapMa";
            dtpNgayCapMa.Size = new Size(341, 34);
            dtpNgayCapMa.TabIndex = 38;
            dtpNgayCapMa.Value = new DateTime(2023, 3, 2, 0, 0, 0, 0);
            // 
            // dtpHanNop
            // 
            dtpHanNop.CustomFormat = "dd/MM/yyyy";
            dtpHanNop.Format = DateTimePickerFormat.Custom;
            dtpHanNop.Location = new Point(643, 499);
            dtpHanNop.Name = "dtpHanNop";
            dtpHanNop.Size = new Size(341, 34);
            dtpHanNop.TabIndex = 40;
            dtpHanNop.Value = new DateTime(2023, 3, 2, 0, 0, 0, 0);
            // 
            // lblHanNop
            // 
            lblHanNop.AutoSize = true;
            lblHanNop.Location = new Point(424, 499);
            lblHanNop.Name = "lblHanNop";
            lblHanNop.Size = new Size(92, 28);
            lblHanNop.TabIndex = 39;
            lblHanNop.Text = "Hạn nộp";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(44, 43, 69);
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(1380, 720);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(140, 50);
            btnDangKy.TabIndex = 88;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.DialogResult = DialogResult.OK;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Image = Properties.Resources.reset;
            btnReset.Location = new Point(1324, 720);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(50, 50);
            btnReset.TabIndex = 92;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // FDangKyThue
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1532, 782);
            Controls.Add(btnReset);
            Controls.Add(btnDangKy);
            Controls.Add(dtpHanNop);
            Controls.Add(lblHanNop);
            Controls.Add(dtpNgayCapMa);
            Controls.Add(lblNgayCapMa);
            Controls.Add(txtTenCoQuan);
            Controls.Add(lblTenCoQuan);
            Controls.Add(txtSoTienPhaiNop);
            Controls.Add(lblSoTien);
            Controls.Add(txtMaSoThue);
            Controls.Add(lblMaThue);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDangKyThue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDangKyThue";
            Load += FDangKyThue_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoTienPhaiNop;
        private Label lblSoTien;
        private TextBox txtMaSoThue;
        private Label lblMaThue;
        private TextBox txtTenCoQuan;
        private Label lblTenCoQuan;
        private Label lblNgayCapMa;
        private DateTimePicker dtpNgayCapMa;
        private DateTimePicker dtpHanNop;
        private Label lblHanNop;
        private Button btnDangKy;
        private Button btnReset;
    }
}