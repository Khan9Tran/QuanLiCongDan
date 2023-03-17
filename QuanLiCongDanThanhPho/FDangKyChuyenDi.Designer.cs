namespace QuanLiCongDanThanhPho
{
    partial class FDangKyChuyenDi
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
            lblCCCD = new Label();
            lblTen = new Label();
            txtCCCD = new TextBox();
            txtTen = new TextBox();
            fpnlChucNang = new FlowLayoutPanel();
            btnReset = new Button();
            btnDangKy = new Button();
            fpnlChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(380, 230);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(61, 28);
            lblCCCD.TabIndex = 1;
            lblCCCD.Text = "CCCD";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(380, 330);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(106, 28);
            lblTen.TabIndex = 2;
            lblTen.Text = "Họ và Tên";
            // 
            // txtCCCD
            // 
            txtCCCD.BackColor = Color.Gainsboro;
            txtCCCD.BorderStyle = BorderStyle.None;
            txtCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCD.Location = new Point(530, 230);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(534, 27);
            txtCCCD.TabIndex = 21;
            txtCCCD.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.Gainsboro;
            txtTen.BorderStyle = BorderStyle.None;
            txtTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(530, 330);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(534, 27);
            txtTen.TabIndex = 22;
            // 
            // fpnlChucNang
            // 
            fpnlChucNang.Controls.Add(btnReset);
            fpnlChucNang.Controls.Add(btnDangKy);
            fpnlChucNang.Location = new Point(1171, 681);
            fpnlChucNang.Name = "fpnlChucNang";
            fpnlChucNang.Size = new Size(349, 59);
            fpnlChucNang.TabIndex = 99;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.DialogResult = DialogResult.OK;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Image = Properties.Resources.reset;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(3, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 50);
            btnReset.TabIndex = 92;
            btnReset.Text = "Tải lại";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Transparent;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangKy.ForeColor = Color.Black;
            btnDangKy.Image = Properties.Resources.confirm;
            btnDangKy.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangKy.Location = new Point(159, 3);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(150, 50);
            btnDangKy.TabIndex = 89;
            btnDangKy.Text = "      Xác nhận";
            btnDangKy.UseVisualStyleBackColor = false;
            // 
            // FDangKyChuyenDi
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1532, 752);
            Controls.Add(fpnlChucNang);
            Controls.Add(txtTen);
            Controls.Add(txtCCCD);
            Controls.Add(lblTen);
            Controls.Add(lblCCCD);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FDangKyChuyenDi";
            Text = "FDangKyChuyenDi";
            fpnlChucNang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCCCD;
        private Label lblTen;
        private TextBox txtCCCD;
        private TextBox txtTen;
        private FlowLayoutPanel fpnlChucNang;
        private Button btnReset;
        private Button btnDangKy;
    }
}