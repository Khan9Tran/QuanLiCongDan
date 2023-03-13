namespace QuanLiCongDanThanhPho
{
    partial class FDanhSachCongDan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvDanhSachCongDan = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnTuoiTac = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnNu = new System.Windows.Forms.Button();
            this.flpnlPhanLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDocThan = new System.Windows.Forms.Button();
            this.btnKetHon = new System.Windows.Forms.Button();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCongDan)).BeginInit();
            this.flpnlPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDanhSachCongDan
            // 
            this.gvDanhSachCongDan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDanhSachCongDan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvDanhSachCongDan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDanhSachCongDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDanhSachCongDan.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvDanhSachCongDan.Location = new System.Drawing.Point(12, 208);
            this.gvDanhSachCongDan.Name = "gvDanhSachCongDan";
            this.gvDanhSachCongDan.RowHeadersWidth = 51;
            this.gvDanhSachCongDan.RowTemplate.Height = 29;
            this.gvDanhSachCongDan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDanhSachCongDan.Size = new System.Drawing.Size(1500, 450);
            this.gvDanhSachCongDan.TabIndex = 0;
            this.gvDanhSachCongDan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDanhSachCongDan_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(15, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(600, 31);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTatCa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTatCa.ForeColor = System.Drawing.Color.Black;
            this.btnTatCa.Location = new System.Drawing.Point(3, 3);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(125, 40);
            this.btnTatCa.TabIndex = 4;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnTuoiTac
            // 
            this.btnTuoiTac.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTuoiTac.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTuoiTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuoiTac.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTuoiTac.ForeColor = System.Drawing.Color.Black;
            this.btnTuoiTac.Location = new System.Drawing.Point(134, 3);
            this.btnTuoiTac.Name = "btnTuoiTac";
            this.btnTuoiTac.Size = new System.Drawing.Size(125, 40);
            this.btnTuoiTac.TabIndex = 5;
            this.btnTuoiTac.Text = "Tuổi tác";
            this.btnTuoiTac.UseVisualStyleBackColor = false;
            this.btnTuoiTac.Click += new System.EventHandler(this.btnTuoiTac_Click);
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNam.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNam.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNam.ForeColor = System.Drawing.Color.Black;
            this.btnNam.Location = new System.Drawing.Point(265, 3);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(125, 40);
            this.btnNam.TabIndex = 6;
            this.btnNam.Text = "Nam";
            this.btnNam.UseVisualStyleBackColor = false;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnNu
            // 
            this.btnNu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNu.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNu.ForeColor = System.Drawing.Color.Black;
            this.btnNu.Location = new System.Drawing.Point(396, 3);
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(125, 40);
            this.btnNu.TabIndex = 7;
            this.btnNu.Text = "Nữ";
            this.btnNu.UseVisualStyleBackColor = false;
            this.btnNu.Click += new System.EventHandler(this.btnNu_Click);
            // 
            // flpnlPhanLoai
            // 
            this.flpnlPhanLoai.Controls.Add(this.btnTatCa);
            this.flpnlPhanLoai.Controls.Add(this.btnTuoiTac);
            this.flpnlPhanLoai.Controls.Add(this.btnNam);
            this.flpnlPhanLoai.Controls.Add(this.btnNu);
            this.flpnlPhanLoai.Controls.Add(this.btnDocThan);
            this.flpnlPhanLoai.Controls.Add(this.btnKetHon);
            this.flpnlPhanLoai.Location = new System.Drawing.Point(12, 155);
            this.flpnlPhanLoai.Name = "flpnlPhanLoai";
            this.flpnlPhanLoai.Size = new System.Drawing.Size(799, 47);
            this.flpnlPhanLoai.TabIndex = 8;
            // 
            // btnDocThan
            // 
            this.btnDocThan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDocThan.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDocThan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocThan.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDocThan.ForeColor = System.Drawing.Color.Black;
            this.btnDocThan.Location = new System.Drawing.Point(527, 3);
            this.btnDocThan.Name = "btnDocThan";
            this.btnDocThan.Size = new System.Drawing.Size(125, 40);
            this.btnDocThan.TabIndex = 8;
            this.btnDocThan.Text = "Độc thân";
            this.btnDocThan.UseVisualStyleBackColor = false;
            this.btnDocThan.Click += new System.EventHandler(this.btnDocThan_Click);
            // 
            // btnKetHon
            // 
            this.btnKetHon.BackColor = System.Drawing.Color.Gainsboro;
            this.btnKetHon.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKetHon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetHon.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKetHon.ForeColor = System.Drawing.Color.Black;
            this.btnKetHon.Location = new System.Drawing.Point(658, 3);
            this.btnKetHon.Name = "btnKetHon";
            this.btnKetHon.Size = new System.Drawing.Size(125, 40);
            this.btnKetHon.TabIndex = 9;
            this.btnKetHon.Text = "Kết hôn";
            this.btnKetHon.UseVisualStyleBackColor = false;
            this.btnKetHon.Click += new System.EventHandler(this.btnKetHon_Click);
            // 
            // picTimKiem
            // 
            this.picTimKiem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.search;
            this.picTimKiem.Location = new System.Drawing.Point(627, 12);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(37, 31);
            this.picTimKiem.TabIndex = 56;
            this.picTimKiem.TabStop = false;
            // 
            // FDanhSachCongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.flpnlPhanLoai);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gvDanhSachCongDan);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDanhSachCongDan";
            this.Text = "DanhSachCongDan";
            this.Load += new System.EventHandler(this.FDanhSachCongDan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCongDan)).EndInit();
            this.flpnlPhanLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvDanhSachCongDan;
        private TextBox txtTimKiem;
        private Button btnTatCa;
        private Button btnTuoiTac;
        private Button btnNam;
        private Button btnNu;
        private FlowLayoutPanel flpnlPhanLoai;
        private Button btnDocThan;
        private Button btnKetHon;
        private PictureBox picTimKiem;
    }
}