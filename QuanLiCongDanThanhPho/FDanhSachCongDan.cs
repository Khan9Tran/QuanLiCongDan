using System.Data;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachCongDan : Form
    {
        private CongDanDAO cdDao;
        private dynamic luaChon;
        private DataTable ds;
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
            gvDanhSachCongDan.DataSource = NgatTrang(ds,15); 
        }


        private void FDanhSachCongDan_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            fpnlPhanLoai.Width = 45;
        }

        private void gvDanhSachCongDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && gvDanhSachCongDan.Rows[e.RowIndex].Cells[0].Value.ToString().Length > 0)
            {
                ThueDAO thueDAO = new ThueDAO();
                // Kiểm tra nếu không có trong ds thuế thì có thể đăng kí
                if (thueDAO.LayThongTin(GetCCCD()) != null)
                {
                    btnThue.Enabled = true;
                }
                TamTruTamVangDAO tttvDAO = new TamTruTamVangDAO();
                // Kiểm tra nếu không có trogn ds tạm trú, tạm vắng thì có thể đắng kí
                if (tttvDAO.LayThongTin(GetCCCD()) != null)
                {
                    btnTamVang.Enabled = true;
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

        //Lấy mã cccd bằng kick vào gridview
        private string GetCCCD()
        {
            return (string)gvDanhSachCongDan.CurrentRow.Cells[0].Value;
        }

        //Menu
        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maCCCD = GetCCCD();
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
            string maCCCD = GetCCCD();
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

        //Phân trang cho datagridview
        private DataTable NgatTrang(DataTable ds, int recordNum)
        {
            int totalRecord = ds.Rows.Count;
            if (totalRecord <= 0)
                return ds;
            if (totalRecord % recordNum != 0)
                nudPage.Maximum = (totalRecord / recordNum) + 1;
            else
                nudPage.Maximum =  totalRecord / recordNum;
            int page = int.Parse(nudPage.Value.ToString());
            return ds.AsEnumerable().Skip((page -1)* recordNum).Take(recordNum).CopyToDataTable();
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
            FDangKyThue dangKyThue = new FDangKyThue(GetCCCD());
            (StackForm.TrangChu).ChildForm.Open(dangKyThue); 
        }

        private void btnTamVang_Click(object sender, EventArgs e)
        {
            FDangKyTamTruTamVang dKTamTruTamVang = new FDangKyTamTruTamVang(GetCCCD());
            (StackForm.TrangChu).ChildForm.Open(dKTamTruTamVang);
        }
    }
}