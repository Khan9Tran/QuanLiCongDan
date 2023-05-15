using System.Data;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachCongDan : FormDanhSach
    {
        private CongDanDAO cdDao;
        enum Loc
        {
            tatCa,
            nam,
            nu,
            ketHon,
            docThan,
            tuoiTac,
        }

        private void KhoiTao()
        {
            InitializeComponent();

            cdDao = new CongDanDAO();
            ListData = new Paging(nudPage, 15);

            LuaChon = Loc.tatCa;

            btnTamVang.Enabled = false;
            btnThue.Enabled = false;
            btnKhaiSinh.Enabled = false;
        }

        public FDanhSachCongDan()
        {
            KhoiTao();
        }

        public FDanhSachCongDan(DataTable ds)
        {
            KhoiTao();
            Ds = ds;
        }

        private void ChangeBtnColor(Loc type)
        {
            btnDocThan.BackColor = Color.RoyalBlue;
            btnNam.BackColor = Color.RoyalBlue;
            btnNu.BackColor = Color.RoyalBlue;
            btnKetHon.BackColor = Color.RoyalBlue;
            btnTuoiTac.BackColor = Color.RoyalBlue;
            btnDocThan.BackColor = Color.RoyalBlue;
            btnTatCa.BackColor = Color.RoyalBlue;

            if (type == Loc.tatCa)
            {
                btnTatCa.BackColor = Color.DarkBlue;
            }
            else if (type == Loc.nam)
            {
                btnNam.BackColor = Color.DarkBlue;
            }
            else if (type == Loc.tuoiTac)
            {
                btnTuoiTac.BackColor = Color.DarkBlue;
            }
            else if (type == Loc.ketHon)
            {
                btnKetHon.BackColor = Color.DarkBlue;
            }
            else if (type == Loc.nu)
            {
                btnNu.BackColor = Color.DarkBlue;
            }
            else if (type == Loc.docThan)
            {
                btnDocThan.BackColor = Color.DarkBlue;
            }
        }

        //Tìm kiếm công dân theo các điều kiện
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (LuaChon == Loc.tatCa)
            {
                Ds = cdDao.LayDanhSachChuaTu(txtTimKiem.Text);
            }
            else if (LuaChon == Loc.nam)
            {
                Ds = cdDao.LayDanhSachCongDanNam(txtTimKiem.Text);
            }
            else if (LuaChon == Loc.nu)
            {
                Ds = cdDao.LayDanhSachCongDanNu(txtTimKiem.Text);
            }
            else if (LuaChon == Loc.ketHon)
            {
                Ds = cdDao.LayDanhSachDaKetHon(txtTimKiem.Text);
            }
            else if (LuaChon == Loc.docThan)
            {
                Ds = cdDao.LayDanhSachChuaKetHon(txtTimKiem.Text);
            }
            else if (LuaChon == Loc.tuoiTac)
            {
                Ds = cdDao.LayDanhSachTuoiXepTuBeDenLon(txtTimKiem.Text);
            }
            nudPage.Value = 1;
            LoadDanhSach(gvDanhSachCongDan);
        }

        private void FDanhSachCongDan_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            fpnlPhanLoai.Width = 45;
        }

        //Kiem tra lai
        private void gvDanhSachCongDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThue.Enabled = true;
            btnTamVang.Enabled = true;
            btnKhaiSinh.Enabled = true;
            string cCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            if (e.RowIndex != -1 && gvDanhSachCongDan.Rows[e.RowIndex].Cells[0].Value.ToString()?.Length > 0)
            {
                ThueDAO thueDAO = new ThueDAO();
                // Kiểm tra nếu không có trong ds thuế thì có thể đăng kí
                if (thueDAO.LayThongTin(cCCD).MaThue != null)
                {
                    btnThue.Enabled = false;
                }
                TamTruTamVangDAO tttvDAO = new TamTruTamVangDAO();
                // Kiểm tra nếu không có trogn ds tạm trú, tạm vắng thì có thể đắng kí
                if (tttvDAO.LayThongTin(cCCD).MaSo != null)
                {
                    btnTamVang.Enabled = false;
                }
                HonNhanDAO hnDAO = new HonNhanDAO();
                if (hnDAO.LayThongTin(cCCD).MaSo == null)
                {
                    btnKhaiSinh.Enabled = false;
                }
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        //Lọc những người có giới tính: Nam
        private void btnNam_Click(object sender, EventArgs e)
        {
            ChangeBtnColor(Loc.nam);
            TimKiem(Loc.nam);
        }

        //Show tất cả
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            ChangeBtnColor(Loc.tatCa);
            TimKiem(Loc.tatCa);
        }

        //Lọc những người có giới tính: nữ
        private void btnNu_Click(object sender, EventArgs e)
        {   
            ChangeBtnColor(Loc.nu);
            TimKiem(Loc.nu);
        }

        //Lọc ra người chưa kết hôn
        private void btnDocThan_Click(object sender, EventArgs e)
        {   
            ChangeBtnColor(Loc.docThan);
            TimKiem(Loc.docThan);
        }

        //Lọc ra người đã kết hôn
        private void btnKetHon_Click(object sender, EventArgs e)
        {   
            ChangeBtnColor(Loc.ketHon);
            TimKiem(Loc.ketHon);
        }

        //Sắp xếp danh sách theo tuổi tác
        private void btnTuoiTac_Click(object sender, EventArgs e)
        {
            ChangeBtnColor(Loc.tuoiTac);
            TimKiem(Loc.tuoiTac);
        }

        private void TimKiem(dynamic type)
        {
            LuaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        //Đưa đến form đăng ký công dân
        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyCongDan dangKyCongDan = new FDangKyCongDan();
            (StackForm.TrangChu).ChildForm.Open(dangKyCongDan);
        }

        //Menu
        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maCCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            if (maCCCD != "" && maCCCD != null)
            {
                CongDan cD = cdDao.LayThongTin(maCCCD);
                FThongTinCongDan? ttCD = new FThongTinCongDan(cD);
                if (ttCD != null) 
                    ttCD?.ShowDialog();
            }
        }

        //Xóa công dân
        private void XoaCongDan()
        {
            string maCCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            if (maCCCD != "")
            {
                CongDan cD = cdDao.LayThongTin(maCCCD);
                if (cD.CCCD != null)
                {
                    HinhDaiDien hinhDaiDien = new HinhDaiDien(HinhDaiDien.Type.congDan);
                    hinhDaiDien.DeleteDirectory(hinhDaiDien.GetFolderPath(), cD.CCCD);
                    if (cdDao.XoaCongDan(cD))
                        MessageBox.Show("Xóa công dân thành công");
                    else
                        MessageBox.Show("Xóa công dân thất bại");
                    txtTimKiem_TextChanged(txtTimKiem, null);
                }
            }
        }

        private void cmnusMenuXoa_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Bạn có thật sự muốn xóa công dân?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (message == DialogResult.Yes)
            {
                XoaCongDan();
            }
        }

        //Đóng mở các nút lọc
        private void btnLoc_Click(object sender, EventArgs e)
        {
            Loc_Click(fpnlPhanLoai);
        }

        //Thay đổi ngắt trang
        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach(gvDanhSachCongDan);
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            string cCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            FDangKyThue dangKyThue = new FDangKyThue(cCCD);
            (StackForm.TrangChu)?.ChildForm.Open(dangKyThue); 
        }

        private void btnTamVang_Click(object sender, EventArgs e)
        {
            string cCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            FDangKyTamTruTamVang dKTamTruTamVang = new FDangKyTamTruTamVang(cCCD);
            (StackForm.TrangChu)?.ChildForm.Open(dKTamTruTamVang);
        }

        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            string cCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            FDangKyKhaiSinh dKKhaiSinh = new FDangKyKhaiSinh(cCCD);
            (StackForm.TrangChu)?.ChildForm.Open(dKKhaiSinh);
        }
    }
}