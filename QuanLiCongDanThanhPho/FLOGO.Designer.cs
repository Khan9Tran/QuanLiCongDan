namespace QuanLiCongDanThanhPho
{
    partial class FLOGO
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblNameApp = new System.Windows.Forms.Label();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.lblNameApp);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1632, 870);
            this.pnlLogo.TabIndex = 1;
            // 
            // lblNameApp
            // 
            this.lblNameApp.AutoSize = true;
            this.lblNameApp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNameApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNameApp.Font = new System.Drawing.Font("Segoe UI", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(74)))), ((int)(((byte)(155)))));
            this.lblNameApp.Location = new System.Drawing.Point(418, 387);
            this.lblNameApp.Name = "lblNameApp";
            this.lblNameApp.Size = new System.Drawing.Size(861, 177);
            this.lblNameApp.TabIndex = 1;
            this.lblNameApp.Text = "SMART CITY";
            this.lblNameApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FLOGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1632, 870);
            this.Controls.Add(this.pnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLOGO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLOGO";
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Panel pnlLogo;
        private Label lblNameApp;
    }
}