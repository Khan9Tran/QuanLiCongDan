﻿using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyCCCD : FormDangKy
    {
        public FDangKyCCCD()
        {
            InitializeComponent();
        }
        
        private void FDangKyCCCD_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        //Clear các ô TextBox
        internal override void Reset()
        {
            base.Reset();
            dtmNgayCap.Value = DateTime.Now;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Đăng ký CCCD cho các công dân chưa có đặc điểm nhận dạng
        internal override void DangKy()
        {
            CongDan cD = CDDAO.LayThongTin(txtCCCD.Text);
            CCCD cCCD = CCCDDAO.LayThongTin(txtCCCD.Text);
            if (cD.CCCD != null && cD.Ten == txtTen.Text && KiemTraDuLieuNhap.KiemTraTenVaCCCD(cD) && KiemTraDuLieuNhap.isEmpty(txtDDNhanDang.Text) == false && cCCD.MaCCCD != null)
            {
                cCCD.NgayCap = dtmNgayCap.Value;
                cCCD.DacDiem = txtDDNhanDang.Text;
                if (CCCDDAO.CapNhatCCCD(cCCD))
                    MessageBox.Show("Cấp căn cước thành công");
                else
                    MessageBox.Show("Cấp căn cước thất bại");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadDanhSach();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy();
        }

        //Load danh sách các công dân chưa có đặc điểm nhận dạng
        private void LoadDanhSach()
        {
            gvDanhSachChuaCapCCCD.DataSource = CCCDDAO.DanhSachCCCDTheoDacDiem("unknow");
            Reset();
        }    

        //Hàm load thông tin dòng được chọn vào TextBox CCCD và Tên
        private void gvDanhSachChuaCapCCCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtCCCD.Text = gvDanhSachChuaCapCCCD.Rows[dong].Cells["CCCD"].Value.ToString();
                txtTen.Text = gvDanhSachChuaCapCCCD.Rows[dong].Cells["Tên"].Value.ToString();
            }
            txtDDNhanDang.Text = "";
            dtmNgayCap.Value = DateTime.Now;
        }
    }
}
