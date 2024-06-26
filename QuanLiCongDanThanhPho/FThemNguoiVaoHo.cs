﻿
namespace QuanLiCongDanThanhPho
{
    public partial class FThemNguoiVaoHo : FormDangKy
    {
        public FThemNguoiVaoHo()
        {
            InitializeComponent();
            lblThongTin.Hide();
            gvNguoiChuaCoHoKhau.Hide();
        }

        //Hiện thị danh sách của những người chưa có hộ khẩu
        private void LoadDanhSachChuaHoKhau()
        {
            gvNguoiChuaCoHoKhau.DataSource = CDDAO.LayDanhSachTheoHoKhau("00000A");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            lblThongTin.Show();
            gvNguoiChuaCoHoKhau.Show();
            LoadDanhSachChuaHoKhau();
        }

        //Thêm công dân vào hộ được chọn
        internal override void DangKy()
        {
            CongDan congDan = CDDAO.LayThongTin(txtCCCD.Text);
            if (congDan.CCCD == null)
            {
                MessageBox.Show("Công dân không tồn tại");
            }    
            else if (congDan.Ten != txtTen.Text) 
            {
                MessageBox.Show("Tên không khớp với CCCD");
            }
            else if (KiemTraDuLieuNhap.KiemTraHaiHo(txtMaHo.Text, congDan.MaHoKhau) && HKDAO.LayThongTin(txtMaHo.Text).MaHoKhau != null)
            {
                congDan.MaHoKhau = txtMaHo.Text;
                if (CDDAO.ThayDoiHoKhau(congDan))
                    MessageBox.Show("Thêm công dân vào hộ khẩu thành công");
                else
                    MessageBox.Show("Thêm công dân vào hộ thất bại");
            }
            else
                MessageBox.Show("Thêm công dân vào hộ khẩu thất bại");
            LoadDanhSachChuaHoKhau();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DangKy();
        }

        //Hiện thị thông tin công dân được chọn bên TextBox
        private void gvNguoiChuaCoHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtCCCD.Text = gvNguoiChuaCoHoKhau.Rows[dong].Cells[0].Value.ToString();
                txtTen.Text = gvNguoiChuaCoHoKhau.Rows[dong].Cells[1].Value.ToString();
            }
        }

        //Clear các TextBox,...
        internal override void Reset()
        {
            base.Reset();
            gvNguoiChuaCoHoKhau.Hide();
            lblThongTin.Hide();
            LoadDanhSachChuaHoKhau();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
