namespace QuanLiCongDanThanhPho
{
    partial class FThemNguoiVaoHo
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
            this.txtMaHo = new System.Windows.Forms.TextBox();
            this.lblMaHo = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaHo
            // 
            this.txtMaHo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaHo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHo.Location = new System.Drawing.Point(546, 180);
            this.txtMaHo.Name = "txtMaHo";
            this.txtMaHo.Size = new System.Drawing.Size(442, 27);
            this.txtMaHo.TabIndex = 22;
            // 
            // lblMaHo
            // 
            this.lblMaHo.AutoSize = true;
            this.lblMaHo.Location = new System.Drawing.Point(409, 179);
            this.lblMaHo.Name = "lblMaHo";
            this.lblMaHo.Size = new System.Drawing.Size(78, 28);
            this.lblMaHo.TabIndex = 21;
            this.lblMaHo.Text = "Mã hộ ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(641, 453);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(197, 50);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm thành viên";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTen.Location = new System.Drawing.Point(546, 270);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(442, 27);
            this.txtTen.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "CCCD";
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCCCD.Location = new System.Drawing.Point(546, 350);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(292, 27);
            this.txtCCCD.TabIndex = 27;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(878, 345);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(110, 39);
            this.btnTim.TabIndex = 28;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // FThemNguoiVaoHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 695);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaHo);
            this.Controls.Add(this.lblMaHo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FThemNguoiVaoHo";
            this.Text = "FThemNguoiVaoHo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMaHo;
        private Label lblMaHo;
        private Button btnThem;
        private Label label1;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtCCCD;
        private Button btnTim;
    }
}