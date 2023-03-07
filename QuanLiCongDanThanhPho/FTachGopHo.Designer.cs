namespace QuanLiCongDanThanhPho
{
    partial class FTachGopHo
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
            this.lblMaHoTach = new System.Windows.Forms.Label();
            this.lblMaHoGop = new System.Windows.Forms.Label();
            this.gvHoTach = new System.Windows.Forms.DataGridView();
            this.gvHoGop = new System.Windows.Forms.DataGridView();
            this.btnTach = new System.Windows.Forms.Button();
            this.btnGopHo = new System.Windows.Forms.Button();
            this.btnTaoHoMoi = new System.Windows.Forms.Button();
            this.txtMaHoTach = new System.Windows.Forms.TextBox();
            this.txtMaHoGop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoTach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoGop)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaHoTach
            // 
            this.lblMaHoTach.AutoSize = true;
            this.lblMaHoTach.Location = new System.Drawing.Point(84, 24);
            this.lblMaHoTach.Name = "lblMaHoTach";
            this.lblMaHoTach.Size = new System.Drawing.Size(119, 28);
            this.lblMaHoTach.TabIndex = 4;
            this.lblMaHoTach.Text = "Mã hộ tách";
            this.lblMaHoTach.Click += new System.EventHandler(this.lblMaHoTach_Click);
            // 
            // lblMaHoGop
            // 
            this.lblMaHoGop.AutoSize = true;
            this.lblMaHoGop.Location = new System.Drawing.Point(838, 23);
            this.lblMaHoGop.Name = "lblMaHoGop";
            this.lblMaHoGop.Size = new System.Drawing.Size(114, 28);
            this.lblMaHoGop.TabIndex = 5;
            this.lblMaHoGop.Text = "Mã hộ gộp";
            // 
            // gvHoTach
            // 
            this.gvHoTach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHoTach.Location = new System.Drawing.Point(84, 85);
            this.gvHoTach.Name = "gvHoTach";
            this.gvHoTach.RowHeadersWidth = 51;
            this.gvHoTach.RowTemplate.Height = 29;
            this.gvHoTach.Size = new System.Drawing.Size(590, 425);
            this.gvHoTach.TabIndex = 6;
            // 
            // gvHoGop
            // 
            this.gvHoGop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHoGop.Location = new System.Drawing.Point(838, 85);
            this.gvHoGop.Name = "gvHoGop";
            this.gvHoGop.RowHeadersWidth = 51;
            this.gvHoGop.RowTemplate.Height = 29;
            this.gvHoGop.Size = new System.Drawing.Size(590, 425);
            this.gvHoGop.TabIndex = 7;
            // 
            // btnTach
            // 
            this.btnTach.BackColor = System.Drawing.Color.Transparent;
            this.btnTach.FlatAppearance.BorderSize = 0;
            this.btnTach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTach.Image = global::QuanLiCongDanThanhPho.Properties.Resources.split__1_;
            this.btnTach.Location = new System.Drawing.Point(732, 248);
            this.btnTach.Name = "btnTach";
            this.btnTach.Size = new System.Drawing.Size(50, 50);
            this.btnTach.TabIndex = 10;
            this.btnTach.UseVisualStyleBackColor = false;
            this.btnTach.Click += new System.EventHandler(this.btnTach_Click);
            // 
            // btnGopHo
            // 
            this.btnGopHo.BackColor = System.Drawing.Color.Transparent;
            this.btnGopHo.FlatAppearance.BorderSize = 0;
            this.btnGopHo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGopHo.Image = global::QuanLiCongDanThanhPho.Properties.Resources.merge;
            this.btnGopHo.Location = new System.Drawing.Point(732, 348);
            this.btnGopHo.Name = "btnGopHo";
            this.btnGopHo.Size = new System.Drawing.Size(50, 50);
            this.btnGopHo.TabIndex = 11;
            this.btnGopHo.UseVisualStyleBackColor = false;
            this.btnGopHo.Click += new System.EventHandler(this.btnGopHo_Click);
            // 
            // btnTaoHoMoi
            // 
            this.btnTaoHoMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnTaoHoMoi.FlatAppearance.BorderSize = 0;
            this.btnTaoHoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHoMoi.Image = global::QuanLiCongDanThanhPho.Properties.Resources.page;
            this.btnTaoHoMoi.Location = new System.Drawing.Point(732, 157);
            this.btnTaoHoMoi.Name = "btnTaoHoMoi";
            this.btnTaoHoMoi.Size = new System.Drawing.Size(50, 50);
            this.btnTaoHoMoi.TabIndex = 12;
            this.btnTaoHoMoi.UseVisualStyleBackColor = false;
            this.btnTaoHoMoi.Click += new System.EventHandler(this.btnTaoHoMoi_Click);
            // 
            // txtMaHoTach
            // 
            this.txtMaHoTach.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaHoTach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHoTach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHoTach.Location = new System.Drawing.Point(232, 25);
            this.txtMaHoTach.Name = "txtMaHoTach";
            this.txtMaHoTach.Size = new System.Drawing.Size(442, 27);
            this.txtMaHoTach.TabIndex = 20;
            // 
            // txtMaHoGop
            // 
            this.txtMaHoGop.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaHoGop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHoGop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHoGop.Location = new System.Drawing.Point(958, 24);
            this.txtMaHoGop.Name = "txtMaHoGop";
            this.txtMaHoGop.Size = new System.Drawing.Size(470, 27);
            this.txtMaHoGop.TabIndex = 21;
            // 
            // FTachGopHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 695);
            this.Controls.Add(this.txtMaHoGop);
            this.Controls.Add(this.txtMaHoTach);
            this.Controls.Add(this.btnTaoHoMoi);
            this.Controls.Add(this.btnGopHo);
            this.Controls.Add(this.btnTach);
            this.Controls.Add(this.gvHoGop);
            this.Controls.Add(this.gvHoTach);
            this.Controls.Add(this.lblMaHoGop);
            this.Controls.Add(this.lblMaHoTach);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FTachGopHo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTachGopHo";
            ((System.ComponentModel.ISupportInitialize)(this.gvHoTach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoGop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMaHoTach;
        private Label lblMaHoGop;
        private DataGridView gvHoTach;
        private DataGridView gvHoGop;
        private Button btnTach;
        private Button btnGopHo;
        private Button btnTaoHoMoi;
        private TextBox txtMaHoTach;
        private TextBox txtMaHoGop;
    }
}