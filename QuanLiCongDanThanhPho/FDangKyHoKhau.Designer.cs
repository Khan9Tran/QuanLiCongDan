namespace QuanLiCongDanThanhPho
{
    partial class FDangKyHoKhau
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
            btnTachGop = new Button();
            btnThem = new Button();
            pnlLuaChon = new Panel();
            btnReset = new Button();
            pnlBarDuoi = new Panel();
            pnlLuaChon.SuspendLayout();
            pnlBarDuoi.SuspendLayout();
            SuspendLayout();
            // 
            // btnTachGop
            // 
            btnTachGop.BackColor = Color.WhiteSmoke;
            btnTachGop.FlatAppearance.BorderSize = 0;
            btnTachGop.FlatStyle = FlatStyle.Flat;
            btnTachGop.Location = new Point(1172, 17);
            btnTachGop.Name = "btnTachGop";
            btnTachGop.Size = new Size(188, 50);
            btnTachGop.TabIndex = 10;
            btnTachGop.Text = "Tách Gộp Hộ";
            btnTachGop.UseVisualStyleBackColor = false;
            btnTachGop.Click += btnTachGop_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.WhiteSmoke;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Image = Properties.Resources.add_user__1_;
            btnThem.Location = new Point(1381, 17);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(50, 50);
            btnThem.TabIndex = 11;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // pnlLuaChon
            // 
            pnlLuaChon.Controls.Add(btnReset);
            pnlLuaChon.Dock = DockStyle.Top;
            pnlLuaChon.Location = new Point(0, 0);
            pnlLuaChon.Name = "pnlLuaChon";
            pnlLuaChon.Size = new Size(1532, 647);
            pnlLuaChon.TabIndex = 12;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.DialogResult = DialogResult.OK;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Image = Properties.Resources.reset;
            btnReset.Location = new Point(1381, 581);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(50, 50);
            btnReset.TabIndex = 92;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // pnlBarDuoi
            // 
            pnlBarDuoi.BackColor = Color.CadetBlue;
            pnlBarDuoi.Controls.Add(btnThem);
            pnlBarDuoi.Controls.Add(btnTachGop);
            pnlBarDuoi.Dock = DockStyle.Bottom;
            pnlBarDuoi.Location = new Point(0, 646);
            pnlBarDuoi.Name = "pnlBarDuoi";
            pnlBarDuoi.Size = new Size(1532, 106);
            pnlBarDuoi.TabIndex = 13;
            // 
            // FDangKyHoKhau
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1532, 752);
            Controls.Add(pnlBarDuoi);
            Controls.Add(pnlLuaChon);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDangKyHoKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDangKyHoKhau";
            pnlLuaChon.ResumeLayout(false);
            pnlBarDuoi.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnTachGop;
        private Button btnThem;
        private Panel pnlLuaChon;
        private Panel pnlBarDuoi;
        private Button btnReset;
    }
}