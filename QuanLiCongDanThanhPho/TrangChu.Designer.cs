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
            this.lblHideApp = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.pnHienThiForm = new System.Windows.Forms.Panel();
            this.pnKhungTren.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnKhungTren
            // 
            this.pnKhungTren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.pnKhungTren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnKhungTren.Controls.Add(this.lblHideApp);
            this.pnKhungTren.Controls.Add(this.lblExit);
            this.pnKhungTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnKhungTren.Location = new System.Drawing.Point(0, 0);
            this.pnKhungTren.Name = "pnKhungTren";
            this.pnKhungTren.Size = new System.Drawing.Size(1782, 71);
            this.pnKhungTren.TabIndex = 0;
            // 
            // lblHideApp
            // 
            this.lblHideApp.AutoSize = true;
            this.lblHideApp.ForeColor = System.Drawing.Color.Transparent;
            this.lblHideApp.Location = new System.Drawing.Point(1725, 6);
            this.lblHideApp.Name = "lblHideApp";
            this.lblHideApp.Size = new System.Drawing.Size(21, 20);
            this.lblHideApp.TabIndex = 1;
            this.lblHideApp.Text = "__";
            this.lblHideApp.Click += new System.EventHandler(this.lblHideApp_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblExit.Location = new System.Drawing.Point(1752, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(18, 20);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
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
            this.pnKhungTren.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnKhungTren;
        private Panel pnChucNang;
        private Panel pnHienThiForm;
        private Label lblExit;
        private Label lblHideApp;
    }
}