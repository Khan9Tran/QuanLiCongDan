namespace QuanLiCongDanThanhPho
{
    partial class FThongKeCongDan
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
            this.lblSoCongDan = new System.Windows.Forms.Label();
            this.gvSoLuongNamNu = new System.Windows.Forms.DataGridView();
            this.lblTiLeNamNu = new System.Windows.Forms.Label();
            this.lblSoLuongDaKetHon = new System.Windows.Forms.Label();
            this.lblSoLuongChuaKetHon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvSoLuongNamNu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoCongDan
            // 
            this.lblSoCongDan.AutoSize = true;
            this.lblSoCongDan.Location = new System.Drawing.Point(41, 40);
            this.lblSoCongDan.Name = "lblSoCongDan";
            this.lblSoCongDan.Size = new System.Drawing.Size(128, 28);
            this.lblSoCongDan.TabIndex = 22;
            this.lblSoCongDan.Text = "Số công dân";
            // 
            // gvSoLuongNamNu
            // 
            this.gvSoLuongNamNu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSoLuongNamNu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvSoLuongNamNu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSoLuongNamNu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSoLuongNamNu.Location = new System.Drawing.Point(41, 130);
            this.gvSoLuongNamNu.Name = "gvSoLuongNamNu";
            this.gvSoLuongNamNu.RowHeadersVisible = false;
            this.gvSoLuongNamNu.RowHeadersWidth = 51;
            this.gvSoLuongNamNu.RowTemplate.Height = 29;
            this.gvSoLuongNamNu.Size = new System.Drawing.Size(315, 134);
            this.gvSoLuongNamNu.TabIndex = 23;
            // 
            // lblTiLeNamNu
            // 
            this.lblTiLeNamNu.AutoSize = true;
            this.lblTiLeNamNu.Location = new System.Drawing.Point(41, 81);
            this.lblTiLeNamNu.Name = "lblTiLeNamNu";
            this.lblTiLeNamNu.Size = new System.Drawing.Size(131, 28);
            this.lblTiLeNamNu.TabIndex = 24;
            this.lblTiLeNamNu.Text = "Tỉ lệ nam nữ";
            // 
            // lblSoLuongDaKetHon
            // 
            this.lblSoLuongDaKetHon.AutoSize = true;
            this.lblSoLuongDaKetHon.Location = new System.Drawing.Point(399, 110);
            this.lblSoLuongDaKetHon.Name = "lblSoLuongDaKetHon";
            this.lblSoLuongDaKetHon.Size = new System.Drawing.Size(116, 28);
            this.lblSoLuongDaKetHon.TabIndex = 26;
            this.lblSoLuongDaKetHon.Text = "Đã kết hôn";
            // 
            // lblSoLuongChuaKetHon
            // 
            this.lblSoLuongChuaKetHon.AutoSize = true;
            this.lblSoLuongChuaKetHon.Location = new System.Drawing.Point(399, 161);
            this.lblSoLuongChuaKetHon.Name = "lblSoLuongChuaKetHon";
            this.lblSoLuongChuaKetHon.Size = new System.Drawing.Size(138, 28);
            this.lblSoLuongChuaKetHon.TabIndex = 27;
            this.lblSoLuongChuaKetHon.Text = "Chưa kết hôn";
            // 
            // FThongKeCongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.lblSoLuongChuaKetHon);
            this.Controls.Add(this.lblSoLuongDaKetHon);
            this.Controls.Add(this.lblTiLeNamNu);
            this.Controls.Add(this.gvSoLuongNamNu);
            this.Controls.Add(this.lblSoCongDan);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FThongKeCongDan";
            this.Text = "FThongKeCongDancs";
            this.Load += new System.EventHandler(this.FThongKeCongDancs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSoLuongNamNu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSoCongDan;
        private DataGridView gvSoLuongNamNu;
        private Label lblTiLeNamNu;
        private Label lblSoLuongDaKetHon;
        private Label lblSoLuongChuaKetHon;
    }
}