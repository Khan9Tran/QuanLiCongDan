namespace QuanLiCongDanThanhPho
{
    partial class btnDeleteInformationControl
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
            pnlDelete = new Panel();
            btnDelete = new Button();
            pnlDelete.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDelete
            // 
            pnlDelete.Controls.Add(btnDelete);
            pnlDelete.Dock = DockStyle.Top;
            pnlDelete.Location = new Point(0, 0);
            pnlDelete.Name = "pnlDelete";
            pnlDelete.Size = new Size(61, 61);
            pnlDelete.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlDark;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = Properties.Resources.delete__1_;
            btnDelete.Location = new Point(0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(32, 32);
            btnDelete.TabIndex = 0;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnDeleteInformationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlDelete);
            Name = "btnDeleteInformationControl";
            Size = new Size(61, 98);
            pnlDelete.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDelete;
        private Button btnDelete;
    }
}
