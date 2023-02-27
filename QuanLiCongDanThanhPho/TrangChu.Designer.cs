namespace QuanLiCongDanThanhPho
{
    partial class FTrangChu
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
            this.pnKhungTren = new System.Windows.Forms.Panel();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.pnHienThiForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnKhungTren
            // 
            this.pnKhungTren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.pnKhungTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnKhungTren.Location = new System.Drawing.Point(0, 0);
            this.pnKhungTren.Name = "pnKhungTren";
            this.pnKhungTren.Size = new System.Drawing.Size(1782, 71);
            this.pnKhungTren.TabIndex = 0;
            // 
            // pnChucNang
            // 
            this.pnChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.pnChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnChucNang.Location = new System.Drawing.Point(0, 71);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(250, 782);
            this.pnChucNang.TabIndex = 1;
            // 
            // pnHienThiForm
            // 
            this.pnHienThiForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHienThiForm.Location = new System.Drawing.Point(250, 71);
            this.pnHienThiForm.Name = "pnHienThiForm";
            this.pnHienThiForm.Size = new System.Drawing.Size(1532, 782);
            this.pnHienThiForm.TabIndex = 2;
            // 
            // FTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1782, 853);
            this.Controls.Add(this.pnHienThiForm);
            this.Controls.Add(this.pnChucNang);
            this.Controls.Add(this.pnKhungTren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnKhungTren;
        private Panel pnChucNang;
        private Panel pnHienThiForm;
    }
}