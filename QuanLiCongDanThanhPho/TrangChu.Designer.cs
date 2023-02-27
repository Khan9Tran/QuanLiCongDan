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
            this.btnHide = new System.Windows.Forms.Button();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.pnHienThiForm = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnKhungTren.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnKhungTren
            // 
            this.pnKhungTren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.pnKhungTren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnKhungTren.Controls.Add(this.btnExit);
            this.pnKhungTren.Controls.Add(this.btnHide);
            this.pnKhungTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnKhungTren.Location = new System.Drawing.Point(0, 0);
            this.pnKhungTren.Name = "pnKhungTren";
            this.pnKhungTren.Size = new System.Drawing.Size(1782, 71);
            this.pnKhungTren.TabIndex = 0;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHide.Location = new System.Drawing.Point(1720, 10);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(25, 25);
            this.btnHide.TabIndex = 0;
            this.btnHide.Text = "-";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
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
            this.pnHienThiForm.AutoSize = true;
            this.pnHienThiForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHienThiForm.Location = new System.Drawing.Point(250, 71);
            this.pnHienThiForm.Name = "pnHienThiForm";
            this.pnHienThiForm.Size = new System.Drawing.Size(1532, 782);
            this.pnHienThiForm.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(1750, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.pnKhungTren.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnKhungTren;
        private Panel pnChucNang;
        private Panel pnHienThiForm;
        private Button btnHide;
        private Button btnExit;
    }
}