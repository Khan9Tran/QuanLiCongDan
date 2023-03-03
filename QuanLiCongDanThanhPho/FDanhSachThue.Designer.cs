namespace QuanLiCongDanThanhPho
{
    partial class FDanhSachThue
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
            this.gvThue = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).BeginInit();
            this.SuspendLayout();
            // 
            // gvThue
            // 
            this.gvThue.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThue.Location = new System.Drawing.Point(39, 281);
            this.gvThue.Name = "gvThue";
            this.gvThue.RowHeadersWidth = 51;
            this.gvThue.RowTemplate.Height = 29;
            this.gvThue.Size = new System.Drawing.Size(1400, 450);
            this.gvThue.TabIndex = 0;
            this.gvThue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvThue_CellContentClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Location = new System.Drawing.Point(39, 209);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(600, 35);
            this.txtTimKiem.TabIndex = 1;
            // 
            // FDanhSachThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 782);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gvThue);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDanhSachThue";
            this.Text = "FDanhSachThue";
            this.Load += new System.EventHandler(this.FDanhSachThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvThue;
        private TextBox txtTimKiem;
    }
}