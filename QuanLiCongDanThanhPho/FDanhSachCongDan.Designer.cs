namespace QuanLiCongDanThanhPho
{
    partial class FDanhSachCongDan
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
            this.gvDanhSachCongDan = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCongDan)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDanhSachCongDan
            // 
            this.gvDanhSachCongDan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDanhSachCongDan.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvDanhSachCongDan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDanhSachCongDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDanhSachCongDan.Location = new System.Drawing.Point(20, 281);
            this.gvDanhSachCongDan.Name = "gvDanhSachCongDan";
            this.gvDanhSachCongDan.RowHeadersWidth = 51;
            this.gvDanhSachCongDan.RowTemplate.Height = 29;
            this.gvDanhSachCongDan.Size = new System.Drawing.Size(1500, 450);
            this.gvDanhSachCongDan.TabIndex = 0;
            this.gvDanhSachCongDan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDanhSachCongDan_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Location = new System.Drawing.Point(20, 198);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(600, 50);
            this.txtTimKiem.TabIndex = 1;
            // 
            // FDanhSachCongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 782);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gvDanhSachCongDan);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDanhSachCongDan";
            this.Text = "DanhSachCongDan";
            this.Load += new System.EventHandler(this.FDanhSachCongDan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCongDan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvDanhSachCongDan;
        private TextBox txtTimKiem;
    }
}