namespace QuanLiCongDanThanhPho
{
    partial class FThongKePhanBo
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
            this.gvDanhSachQuan = new System.Windows.Forms.DataGridView();
            this.lblQuan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDanhSachQuan
            // 
            this.gvDanhSachQuan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDanhSachQuan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvDanhSachQuan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvDanhSachQuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDanhSachQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDanhSachQuan.Location = new System.Drawing.Point(12, 172);
            this.gvDanhSachQuan.Name = "gvDanhSachQuan";
            this.gvDanhSachQuan.RowHeadersVisible = false;
            this.gvDanhSachQuan.RowHeadersWidth = 51;
            this.gvDanhSachQuan.RowTemplate.Height = 29;
            this.gvDanhSachQuan.Size = new System.Drawing.Size(315, 327);
            this.gvDanhSachQuan.TabIndex = 24;
            // 
            // lblQuan
            // 
            this.lblQuan.AutoSize = true;
            this.lblQuan.Location = new System.Drawing.Point(12, 124);
            this.lblQuan.Name = "lblQuan";
            this.lblQuan.Size = new System.Drawing.Size(252, 28);
            this.lblQuan.TabIndex = 25;
            this.lblQuan.Text = "Top quận có đông dân cư";
            // 
            // FThongKePhanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.lblQuan);
            this.Controls.Add(this.gvDanhSachQuan);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FThongKePhanBo";
            this.Text = "FThongKePhanBo";
            this.Load += new System.EventHandler(this.FThongKePhanBo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvDanhSachQuan;
        private Label lblQuan;
    }
}