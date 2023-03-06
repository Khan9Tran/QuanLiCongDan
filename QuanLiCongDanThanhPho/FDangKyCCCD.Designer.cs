namespace QuanLiCongDanThanhPho
{
    partial class FDangKyCCCD
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
            txtTen = new TextBox();
            lblTen = new Label();
            txtCCCD = new TextBox();
            lblCCCD = new Label();
            dtpNgayCap = new DateTimePicker();
            lblNgayCap = new Label();
            textBox1 = new TextBox();
            lblDDNhanDang = new Label();
            btnDangKy = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.Gainsboro;
            txtTen.BorderStyle = BorderStyle.None;
            txtTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(525, 128);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(534, 27);
            txtTen.TabIndex = 22;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(311, 127);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(104, 28);
            lblTen.TabIndex = 21;
            lblTen.Text = "Họ và tên";
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = Color.Gainsboro;
            txtCCCD.BorderStyle = BorderStyle.None;
            txtCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCD.Location = new Point(525, 195);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(348, 27);
            txtCCCD.TabIndex = 24;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(311, 194);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(61, 28);
            lblCCCD.TabIndex = 23;
            lblCCCD.Text = "CCCD";
            // 
            // dtpNgayCap
            // 
            dtpNgayCap.CustomFormat = "dd/MM/yyyy";
            dtpNgayCap.Format = DateTimePickerFormat.Custom;
            dtpNgayCap.Location = new Point(525, 337);
            dtpNgayCap.Name = "dtpNgayCap";
            dtpNgayCap.Size = new Size(341, 34);
            dtpNgayCap.TabIndex = 39;
            dtpNgayCap.Value = new DateTime(2023, 3, 2, 0, 0, 0, 0);
            // 
            // lblNgayCap
            // 
            lblNgayCap.AutoSize = true;
            lblNgayCap.Location = new Point(311, 337);
            lblNgayCap.Name = "lblNgayCap";
            lblNgayCap.Size = new Size(101, 28);
            lblNgayCap.TabIndex = 38;
            lblNgayCap.Text = "Ngày cấp";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(525, 269);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(534, 27);
            textBox1.TabIndex = 41;
            // 
            // lblDDNhanDang
            // 
            lblDDNhanDang.AutoSize = true;
            lblDDNhanDang.Location = new Point(311, 268);
            lblDDNhanDang.Name = "lblDDNhanDang";
            lblDDNhanDang.Size = new Size(208, 28);
            lblDDNhanDang.TabIndex = 40;
            lblDDNhanDang.Text = "Đặc điểm nhận dạng";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(44, 43, 69);
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(1380, 720);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(140, 50);
            btnDangKy.TabIndex = 89;
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
            btnReset.Click += btnReset_Click_1;
            // 
            // FDangKyCCCD
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 185, 174);
            ClientSize = new Size(1532, 782);
            Controls.Add(btnReset);
            Controls.Add(btnDangKy);
            Controls.Add(textBox1);
            Controls.Add(lblDDNhanDang);
            Controls.Add(dtpNgayCap);
            Controls.Add(lblNgayCap);
            Controls.Add(txtCCCD);
            Controls.Add(lblCCCD);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDangKyCCCD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDangKyCCCD";
            Load += FDangKyCCCD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTen;
        private Label lblTen;
        private TextBox txtCCCD;
        private Label lblCCCD;
        private DateTimePicker dtpNgayCap;
        private Label lblNgayCap;
        private TextBox textBox1;
        private Label lblDDNhanDang;
        private Button btnDangKy;
        private Button btnReset;
    }
}