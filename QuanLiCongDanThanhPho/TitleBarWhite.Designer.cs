﻿namespace QuanLiCongDanThanhPho
{
    partial class TitleBarWhite
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
            btnClose = new Button();
            btnMinimize = new Button();
            pnlTitleBar = new Panel();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Transparent;
            btnClose.Image = Properties.Resources.crossWhite;
            btnClose.Location = new Point(50, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.Transparent;
            btnMinimize.Image = Properties.Resources.minusWhite;
            btnMinimize.Location = new Point(20, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(24, 24);
            btnMinimize.TabIndex = 0;
            btnMinimize.UseVisualStyleBackColor = false;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(105, 33);
            pnlTitleBar.TabIndex = 1;
            // 
            // TitleBarWhite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlTitleBar);
            Name = "TitleBarWhite";
            Size = new Size(105, 48);
            pnlTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private Button btnMinimize;
        private Panel pnlTitleBar;
    }
}