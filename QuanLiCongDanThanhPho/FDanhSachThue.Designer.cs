﻿namespace QuanLiCongDanThanhPho
{
    partial class FDanhSachThue
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
            this.gvThue = new System.Windows.Forms.DataGridView();
            this.cmnusMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnusMenuChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnusMenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.flpnPhanLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnThoiHan = new System.Windows.Forms.Button();
            this.btnTienDaNop = new System.Windows.Forms.Button();
            this.btnTienChuaNop = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).BeginInit();
            this.cmnusMenu.SuspendLayout();
            this.flpnPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // gvThue
            // 
            this.gvThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvThue.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThue.ContextMenuStrip = this.cmnusMenu;
            this.gvThue.Location = new System.Drawing.Point(25, 201);
            this.gvThue.Name = "gvThue";
            this.gvThue.RowHeadersWidth = 51;
            this.gvThue.RowTemplate.Height = 29;
            this.gvThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvThue.Size = new System.Drawing.Size(1477, 450);
            this.gvThue.TabIndex = 0;
            this.gvThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvThue_CellClick);
            this.gvThue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvThue_CellContentClick);
            // 
            // cmnusMenu
            // 
            this.cmnusMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmnusMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmnusMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnusMenuChiTiet,
            this.cmnusMenuXoa});
            this.cmnusMenu.Name = "contextMenuStrip1";
            this.cmnusMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmnusMenu.ShowImageMargin = false;
            this.cmnusMenu.Size = new System.Drawing.Size(129, 68);
            // 
            // cmnusMenuChiTiet
            // 
            this.cmnusMenuChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmnusMenuChiTiet.Name = "cmnusMenuChiTiet";
            this.cmnusMenuChiTiet.Size = new System.Drawing.Size(128, 32);
            this.cmnusMenuChiTiet.Text = "Chi tiết";
            this.cmnusMenuChiTiet.Click += new System.EventHandler(this.cmnusMenuChiTiet_Click);
            // 
            // cmnusMenuXoa
            // 
            this.cmnusMenuXoa.Name = "cmnusMenuXoa";
            this.cmnusMenuXoa.Size = new System.Drawing.Size(128, 32);
            this.cmnusMenuXoa.Text = "Xóa";
            this.cmnusMenuXoa.Click += new System.EventHandler(this.cmnusMenuXoa_Click);
            // 
            // flpnPhanLoai
            // 
            this.flpnPhanLoai.Controls.Add(this.btnTatCa);
            this.flpnPhanLoai.Controls.Add(this.btnThoiHan);
            this.flpnPhanLoai.Controls.Add(this.btnTienDaNop);
            this.flpnPhanLoai.Controls.Add(this.btnTienChuaNop);
            this.flpnPhanLoai.Location = new System.Drawing.Point(25, 148);
            this.flpnPhanLoai.Name = "flpnPhanLoai";
            this.flpnPhanLoai.Size = new System.Drawing.Size(699, 47);
            this.flpnPhanLoai.TabIndex = 9;
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
            // btnThoiHan
            // 
            this.btnThoiHan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThoiHan.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnThoiHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoiHan.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoiHan.ForeColor = System.Drawing.Color.Black;
            this.btnThoiHan.Location = new System.Drawing.Point(134, 3);
            this.btnThoiHan.Name = "btnThoiHan";
            this.btnThoiHan.Size = new System.Drawing.Size(125, 40);
            this.btnThoiHan.TabIndex = 5;
            this.btnThoiHan.Text = "Thời hạn";
            this.btnThoiHan.UseVisualStyleBackColor = false;
            this.btnThoiHan.Click += new System.EventHandler(this.btnHanNop_Click);
            // 
            // btnTienDaNop
            // 
            this.btnTienDaNop.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTienDaNop.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTienDaNop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienDaNop.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTienDaNop.ForeColor = System.Drawing.Color.Black;
            this.btnTienDaNop.Location = new System.Drawing.Point(265, 3);
            this.btnTienDaNop.Name = "btnTienDaNop";
            this.btnTienDaNop.Size = new System.Drawing.Size(125, 40);
            this.btnTienDaNop.TabIndex = 6;
            this.btnTienDaNop.Text = "Tiền đã nộp";
            this.btnTienDaNop.UseVisualStyleBackColor = false;
            this.btnTienDaNop.Click += new System.EventHandler(this.btnTienDaNop_Click);
            // 
            // btnTienChuaNop
            // 
            this.btnTienChuaNop.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTienChuaNop.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTienChuaNop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienChuaNop.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTienChuaNop.ForeColor = System.Drawing.Color.Black;
            this.btnTienChuaNop.Location = new System.Drawing.Point(396, 3);
            this.btnTienChuaNop.Name = "btnTienChuaNop";
            this.btnTienChuaNop.Size = new System.Drawing.Size(153, 40);
            this.btnTienChuaNop.TabIndex = 7;
            this.btnTienChuaNop.Text = "Tiền chưa nộp";
            this.btnTienChuaNop.UseVisualStyleBackColor = false;
            this.btnTienChuaNop.Click += new System.EventHandler(this.btnTienChuaNop_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(25, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(600, 31);
            this.txtTimKiem.TabIndex = 55;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // picTimKiem
            // 
            this.picTimKiem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.search;
            this.picTimKiem.Location = new System.Drawing.Point(640, 12);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(37, 31);
            this.picTimKiem.TabIndex = 57;
            this.picTimKiem.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QuanLiCongDanThanhPho.Properties.Resources.page;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(1352, 146);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 50);
            this.btnThem.TabIndex = 58;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FDanhSachThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1532, 679);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.flpnPhanLoai);
            this.Controls.Add(this.gvThue);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDanhSachThue";
            this.Text = "FDanhSachThue";
            this.Load += new System.EventHandler(this.FDanhSachThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).EndInit();
            this.cmnusMenu.ResumeLayout(false);
            this.flpnPhanLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvThue;
        private FlowLayoutPanel flpnPhanLoai;
        private Button btnTatCa;
        private Button btnThoiHan;
        private Button btnTienDaNop;
        private Button btnTienChuaNop;
        private TextBox txtTimKiem;
        private PictureBox picTimKiem;
        private ContextMenuStrip cmnusMenu;
        private ToolStripMenuItem cmnusMenuChiTiet;
        private ToolStripMenuItem cmnusMenuXoa;
        private Button btnThem;
    }
}