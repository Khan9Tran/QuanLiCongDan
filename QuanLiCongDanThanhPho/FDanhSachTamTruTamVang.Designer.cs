namespace QuanLiCongDanThanhPho
{
    partial class FDanhSachTamTruTamVang
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
            this.gvTamTru = new System.Windows.Forms.DataGridView();
            this.gvTamVang = new System.Windows.Forms.DataGridView();
            this.lblTamTru = new System.Windows.Forms.Label();
            this.lblTamVang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvTamTru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTamVang)).BeginInit();
            this.SuspendLayout();
            // 
            // gvTamTru
            // 
            this.gvTamTru.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTamTru.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvTamTru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvTamTru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTamTru.Location = new System.Drawing.Point(28, 86);
            this.gvTamTru.Name = "gvTamTru";
            this.gvTamTru.RowHeadersWidth = 51;
            this.gvTamTru.RowTemplate.Height = 29;
            this.gvTamTru.Size = new System.Drawing.Size(1400, 300);
            this.gvTamTru.TabIndex = 0;
            this.gvTamTru.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTamTru_CellContentClick);
            // 
            // gvTamVang
            // 
            this.gvTamVang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTamVang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvTamVang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvTamVang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTamVang.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gvTamVang.Location = new System.Drawing.Point(28, 441);
            this.gvTamVang.Name = "gvTamVang";
            this.gvTamVang.RowHeadersWidth = 51;
            this.gvTamVang.RowTemplate.Height = 29;
            this.gvTamVang.Size = new System.Drawing.Size(1400, 300);
            this.gvTamVang.TabIndex = 1;
            this.gvTamVang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTamVang_CellContentClick);
            // 
            // lblTamTru
            // 
            this.lblTamTru.AutoSize = true;
            this.lblTamTru.Location = new System.Drawing.Point(28, 55);
            this.lblTamTru.Name = "lblTamTru";
            this.lblTamTru.Size = new System.Drawing.Size(87, 28);
            this.lblTamTru.TabIndex = 2;
            this.lblTamTru.Text = "Tạm trú";
            // 
            // lblTamVang
            // 
            this.lblTamVang.AutoSize = true;
            this.lblTamVang.Location = new System.Drawing.Point(28, 404);
            this.lblTamVang.Name = "lblTamVang";
            this.lblTamVang.Size = new System.Drawing.Size(105, 28);
            this.lblTamVang.TabIndex = 3;
            this.lblTamVang.Text = "Tạm vắng";
            // 
            // FDanhSachTamTruTamVang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 782);
            this.Controls.Add(this.lblTamVang);
            this.Controls.Add(this.lblTamTru);
            this.Controls.Add(this.gvTamVang);
            this.Controls.Add(this.gvTamTru);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDanhSachTamTruTamVang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDanhSachTamTruTamVang";
            this.Load += new System.EventHandler(this.FDanhSachTamTruTamVang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTamTru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTamVang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvTamTru;
        private DataGridView gvTamVang;
        private Label lblTamTru;
        private Label lblTamVang;
    }
}