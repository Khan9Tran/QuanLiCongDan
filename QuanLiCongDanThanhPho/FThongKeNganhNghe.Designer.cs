namespace QuanLiCongDanThanhPho
{
    partial class FThongKeNganhNghe
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
            this.lblNganhNghe = new System.Windows.Forms.Label();
            this.gvDanhSachNganhNghe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachNganhNghe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNganhNghe
            // 
            this.lblNganhNghe.AutoSize = true;
            this.lblNganhNghe.Location = new System.Drawing.Point(12, 154);
            this.lblNganhNghe.Name = "lblNganhNghe";
            this.lblNganhNghe.Size = new System.Drawing.Size(375, 28);
            this.lblNganhNghe.TabIndex = 27;
            this.lblNganhNghe.Text = "Top ngành nghề nhiều người làm nhất";
            // 
            // gvDanhSachNganhNghe
            // 
            this.gvDanhSachNganhNghe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDanhSachNganhNghe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvDanhSachNganhNghe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvDanhSachNganhNghe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDanhSachNganhNghe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDanhSachNganhNghe.Location = new System.Drawing.Point(12, 202);
            this.gvDanhSachNganhNghe.Name = "gvDanhSachNganhNghe";
            this.gvDanhSachNganhNghe.RowHeadersVisible = false;
            this.gvDanhSachNganhNghe.RowHeadersWidth = 51;
            this.gvDanhSachNganhNghe.RowTemplate.Height = 29;
            this.gvDanhSachNganhNghe.Size = new System.Drawing.Size(315, 327);
            this.gvDanhSachNganhNghe.TabIndex = 26;
            // 
            // FThongKeNganhNghe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.lblNganhNghe);
            this.Controls.Add(this.gvDanhSachNganhNghe);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FThongKeNganhNghe";
            this.Text = "FThongKeNganhNghe";
            this.Load += new System.EventHandler(this.FThongKeNganhNghe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachNganhNghe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNganhNghe;
        private DataGridView gvDanhSachNganhNghe;
    }
}