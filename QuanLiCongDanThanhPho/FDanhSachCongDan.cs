using System.Data;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachCongDan : Form
    {
        private CongDanDAO cdDao;
        private dynamic luaChon;
        private DataTable ds;
        private Paging listCongDan;

        public DataTable Ds { get => ds; set => ds = value; }

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
            cdDao = new CongDanDAO();
            StackForm.Add(this);
            luaChon = Loc.tatCa;
            btnTamVang.Enabled = false;
            btnThue.Enabled = false;
            listCongDan = new Paging(nudPage, 15);
        }

        public FDanhSachCongDan()
        {
            InitializeComponent();
            ds = new DataTable();
            KhoiTao();
        }

        public FDanhSachCongDan(DataTable ds)
        {
            InitializeComponent();
            Ds = ds;
            KhoiTao();
        }

        //Tìm kiếm công dân theo các điều kiện
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == Loc.tatCa)
            {
                ds = cdDao.LayDanhSachChuaTu(txtTimKiem.Text);
            }
            else if (luaChon == Loc.nam)
            {
                ds = cdDao.LayDanhSachCongDanNam(txtTimKiem.Text);
            }
            else if (luaChon == Loc.nu)
            {
                ds = cdDao.LayDanhSachCongDanNu(txtTimKiem.Text);
            }
            else if (luaChon == Loc.ketHon)
            {
                ds = cdDao.LayDanhSachDaKetHon(txtTimKiem.Text);
            }
            else if (luaChon == Loc.docThan)
            {
                ds = cdDao.LayDanhSachChuaKetHon(txtTimKiem.Text);
            }
            else if (luaChon == Loc.tuoiTac)
            {
                ds = cdDao.LayDanhSachTuoiXepTuBeDenLon(txtTimKiem.Text);
            }
            nudPage.Value = 1;
            LoadDanhSach();
        }

        //Tải danh sách lên datagridview
        private void LoadDanhSach()
        {
            gvDanhSachCongDan.DataSource = listCongDan.NgatTrang(ds); 
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
            string cCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            if (e.RowIndex != -1 && gvDanhSachCongDan.Rows[e.RowIndex].Cells[0].Value.ToString().Length > 0)
            {
                ThueDAO thueDAO = new ThueDAO();
                // Kiểm tra nếu không có trong ds thuế thì có thể đăng kí
                if (thueDAO.LayThongTin(cCCD).MaThue != "unknow")
                {
                    btnThue.Enabled = false;
                }
                TamTruTamVangDAO tttvDAO = new TamTruTamVangDAO();
                // Kiểm tra nếu không có trogn ds tạm trú, tạm vắng thì có thể đắng kí
                if (tttvDAO.LayThongTin(cCCD).MaSo != "unknow")
                {
                    btnTamVang.Enabled = false;
                }
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        //Lọc những người có giới tính: Nam
        private void btnNam_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.nam);
        }

        //Show tất cả
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
        }

        //Lọc những người có giới tính: nữ
        private void btnNu_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.nu);
        }

        //Lọc ra người chưa kết hôn
        private void btnDocThan_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.docThan);
        }

        //Lọc ra người đã kết hôn
        private void btnKetHon_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.ketHon);
        }

        //Sắp xếp danh sách theo tuổi tác
        private void btnTuoiTac_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tuoiTac);
        }

        private void TimKiem(dynamic type)
        {
            luaChon = type;
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
            if (maCCCD != "")
            {
                CongDan cD = cdDao.LayThongTin(maCCCD);
                FThongTinCongDan ttCD = new FThongTinCongDan(cD);
                ttCD.ShowDialog();
            }
        }

        //Xóa công dân
        private void XoaCongDan()
        {
            string maCCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            if (maCCCD != "")
            {
                CongDan cD = cdDao.LayThongTin(maCCCD);
                if (cD != null)
                {
                    cdDao.XoaCongDan(cD);
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
            if (fpnlPhanLoai.Width > 50)
            {
                fpnlPhanLoai.Width = 45;
            }    
            else 
            {
                fpnlPhanLoai.Width = 900;
            }
        }

        //Thay đổi ngắt trang
        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            string cCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            FDangKyThue dangKyThue = new FDangKyThue(cCCD);
            (StackForm.TrangChu).ChildForm.Open(dangKyThue); 
        }

        private void btnTamVang_Click(object sender, EventArgs e)
        {
            string cCCD = CCCDDAO.GetCCCD(gvDanhSachCongDan, 0);
            FDangKyTamTruTamVang dKTamTruTamVang = new FDangKyTamTruTamVang(cCCD);
            (StackForm.TrangChu).ChildForm.Open(dKTamTruTamVang);
        }
    }
}