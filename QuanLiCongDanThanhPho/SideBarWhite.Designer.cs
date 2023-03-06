namespace QuanLiCongDanThanhPho
{
    partial class SideBarWhite
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            pnlSideBar = new Panel();
            btnHome = new Button();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 43, 60);
            btnBack.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.leftWhite;
            btnBack.Location = new Point(32, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(32, 32);
            btnBack.TabIndex = 1;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // pnlSideBar
            // 
            pnlSideBar.Controls.Add(btnBack);
            pnlSideBar.Controls.Add(btnHome);
            pnlSideBar.Dock = DockStyle.Top;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(83, 32);
            pnlSideBar.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 43, 60);
            btnHome.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Image = Properties.Resources.homeWhite;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(32, 32);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // SideBarWhite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSideBar);
            Name = "SideBarWhite";
            Size = new Size(83, 42);
            pnlSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Panel pnlSideBar;
        private Button btnHome;
    }
}
