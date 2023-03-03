namespace QuanLiCongDanThanhPho
{
    partial class SideBar
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
            pnlSideBar = new Panel();
            btnBack = new Button();
            btnHome = new Button();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.Controls.Add(btnBack);
            pnlSideBar.Controls.Add(btnHome);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(32, 131);
            pnlSideBar.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Tomato;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(0, 52);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(32, 32);
            btnBack.TabIndex = 1;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ActiveCaption;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(32, 32);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSideBar);
            Name = "SideBar";
            Size = new Size(83, 131);
            pnlSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideBar;
        private Button btnBack;
        private Button btnHome;
    }
}
