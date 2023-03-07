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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gvDanhSachCongDan = new DataGridView();
            txtTimKiem = new TextBox();
            btnTatCa = new Button();
            btnTuoiTac = new Button();
            btnNam = new Button();
            btnNu = new Button();
            flpnlPhanLoai = new FlowLayoutPanel();
            btnDocThan = new Button();
            btnKetHon = new Button();
            ((System.ComponentModel.ISupportInitialize)gvDanhSachCongDan).BeginInit();
            flpnlPhanLoai.SuspendLayout();
            SuspendLayout();
            // 
            // gvDanhSachCongDan
            // 
            gvDanhSachCongDan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvDanhSachCongDan.BackgroundColor = Color.Gainsboro;
            gvDanhSachCongDan.BorderStyle = BorderStyle.None;
            gvDanhSachCongDan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gvDanhSachCongDan.DefaultCellStyle = dataGridViewCellStyle1;
            gvDanhSachCongDan.Location = new Point(20, 281);
            gvDanhSachCongDan.Name = "gvDanhSachCongDan";
            gvDanhSachCongDan.RowHeadersWidth = 51;
            gvDanhSachCongDan.RowTemplate.Height = 29;
            gvDanhSachCongDan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvDanhSachCongDan.Size = new Size(1500, 450);
            gvDanhSachCongDan.TabIndex = 0;
            gvDanhSachCongDan.CellClick += gvDanhSachCongDan_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = Color.Gainsboro;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Location = new Point(30, 61);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(600, 50);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTatCa
            // 
            btnTatCa.BackColor = Color.Gainsboro;
            btnTatCa.FlatAppearance.BorderColor = Color.Gray;
            btnTatCa.FlatStyle = FlatStyle.Flat;
            btnTatCa.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTatCa.ForeColor = Color.Black;
            btnTatCa.Location = new Point(3, 3);
            btnTatCa.Name = "btnTatCa";
            btnTatCa.Size = new Size(125, 40);
            btnTatCa.TabIndex = 4;
            btnTatCa.Text = "Tất cả";
            btnTatCa.UseVisualStyleBackColor = false;
            // 
            // btnTuoiTac
            // 
            btnTuoiTac.BackColor = Color.Gainsboro;
            btnTuoiTac.FlatAppearance.BorderColor = Color.Gray;
            btnTuoiTac.FlatStyle = FlatStyle.Flat;
            btnTuoiTac.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTuoiTac.ForeColor = Color.Black;
            btnTuoiTac.Location = new Point(134, 3);
            btnTuoiTac.Name = "btnTuoiTac";
            btnTuoiTac.Size = new Size(125, 40);
            btnTuoiTac.TabIndex = 5;
            btnTuoiTac.Text = "Tuổi tác";
            btnTuoiTac.UseVisualStyleBackColor = false;
            // 
            // btnNam
            // 
            btnNam.BackColor = Color.Gainsboro;
            btnNam.FlatAppearance.BorderColor = Color.Gray;
            btnNam.FlatStyle = FlatStyle.Flat;
            btnNam.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNam.ForeColor = Color.Black;
            btnNam.Location = new Point(265, 3);
            btnNam.Name = "btnNam";
            btnNam.Size = new Size(125, 40);
            btnNam.TabIndex = 6;
            btnNam.Text = "Nam";
            btnNam.UseVisualStyleBackColor = false;
            // 
            // btnNu
            // 
            btnNu.BackColor = Color.Gainsboro;
            btnNu.FlatAppearance.BorderColor = Color.Gray;
            btnNu.FlatStyle = FlatStyle.Flat;
            btnNu.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNu.ForeColor = Color.Black;
            btnNu.Location = new Point(396, 3);
            btnNu.Name = "btnNu";
            btnNu.Size = new Size(125, 40);
            btnNu.TabIndex = 7;
            btnNu.Text = "Nữ";
            btnNu.UseVisualStyleBackColor = false;
            // 
            // flpnlPhanLoai
            // 
            flpnlPhanLoai.Controls.Add(btnTatCa);
            flpnlPhanLoai.Controls.Add(btnTuoiTac);
            flpnlPhanLoai.Controls.Add(btnNam);
            flpnlPhanLoai.Controls.Add(btnNu);
            flpnlPhanLoai.Controls.Add(btnDocThan);
            flpnlPhanLoai.Controls.Add(btnKetHon);
            flpnlPhanLoai.Location = new Point(20, 217);
            flpnlPhanLoai.Name = "flpnlPhanLoai";
            flpnlPhanLoai.Size = new Size(799, 47);
            flpnlPhanLoai.TabIndex = 8;
            // 
            // btnDocThan
            // 
            btnDocThan.BackColor = Color.Gainsboro;
            btnDocThan.FlatAppearance.BorderColor = Color.Gray;
            btnDocThan.FlatStyle = FlatStyle.Flat;
            btnDocThan.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDocThan.ForeColor = Color.Black;
            btnDocThan.Location = new Point(527, 3);
            btnDocThan.Name = "btnDocThan";
            btnDocThan.Size = new Size(125, 40);
            btnDocThan.TabIndex = 8;
            btnDocThan.Text = "Độc thân";
            btnDocThan.UseVisualStyleBackColor = false;
            // 
            // btnKetHon
            // 
            btnKetHon.BackColor = Color.Gainsboro;
            btnKetHon.FlatAppearance.BorderColor = Color.Gray;
            btnKetHon.FlatStyle = FlatStyle.Flat;
            btnKetHon.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKetHon.ForeColor = Color.Black;
            btnKetHon.Location = new Point(658, 3);
            btnKetHon.Name = "btnKetHon";
            btnKetHon.Size = new Size(125, 40);
            btnKetHon.TabIndex = 9;
            btnKetHon.Text = "Kết hôn";
            btnKetHon.UseVisualStyleBackColor = false;
            // 
            // FDanhSachCongDan
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1532, 782);
            Controls.Add(flpnlPhanLoai);
            Controls.Add(txtTimKiem);
            Controls.Add(gvDanhSachCongDan);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FDanhSachCongDan";
            Text = "DanhSachCongDan";
            Load += FDanhSachCongDan_Load;
            ((System.ComponentModel.ISupportInitialize)gvDanhSachCongDan).EndInit();
            flpnlPhanLoai.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
    }
}