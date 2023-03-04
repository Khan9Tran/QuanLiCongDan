namespace QuanLiCongDanThanhPho
{
    partial class FDangKyHoKhau
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
            this.btnTachGop = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlLuaChon = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnTachGop
            // 
            this.btnTachGop.Location = new System.Drawing.Point(12, 720);
            this.btnTachGop.Name = "btnTachGop";
            this.btnTachGop.Size = new System.Drawing.Size(188, 50);
            this.btnTachGop.TabIndex = 10;
            this.btnTachGop.Text = "Tách Gộp Hộ";
            this.btnTachGop.UseVisualStyleBackColor = true;
            this.btnTachGop.Click += new System.EventHandler(this.btnTachGop_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1322, 720);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(198, 50);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm thành viên";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlLuaChon
            // 
            this.pnlLuaChon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLuaChon.Location = new System.Drawing.Point(0, 0);
            this.pnlLuaChon.Name = "pnlLuaChon";
            this.pnlLuaChon.Size = new System.Drawing.Size(1532, 695);
            this.pnlLuaChon.TabIndex = 12;
            // 
            // FDangKyHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 782);
            this.Controls.Add(this.pnlLuaChon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTachGop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDangKyHoKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDangKyHoKhau";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTachGop;
        private Button btnThem;
        private Panel pnlLuaChon;
    }
}