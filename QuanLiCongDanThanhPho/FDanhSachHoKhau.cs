using System.Data;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachHoKhau : Form
    {
        private HoKhauDAO hkDAO;
        private dynamic luaChon;
        private DataTable ds;

        enum Loc
        {
            tatCa,
            soThanhVien,
        }

        public FDanhSachHoKhau()
        {
            InitializeComponent();
            StackForm.Add(this);
            ds = new DataTable();
            hkDAO = new HoKhauDAO();
            luaChon = Loc.tatCa;
        }

        private void FDanhSachHoKhau_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            flpnlPhanLoai.Width = 45;
        }

        private void gvHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && gvHoKhau.Rows[e.RowIndex].Cells[0].Value.ToString().Length > 0)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
        }

        private void LoadDanhSach()
        {
            gvHoKhau.DataSource = NgatTrang(ds, 13);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == Loc.tatCa)
               ds = hkDAO.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (luaChon == Loc.soThanhVien)
               ds = hkDAO.LayDanhSachXepTheoSoTV(txtTimKiem.Text);
            nudPage.Value = 1;
            LoadDanhSach();
        }

        private string GetMaHoKhau()
        {
            return (string)gvHoKhau.CurrentRow.Cells["Mã hộ khẩu"].Value;
        }

        private void btnSoTV_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.soThanhVien);
        }

        private void TimKiem(dynamic type)
        {
            luaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maHoKhau = GetMaHoKhau();
            if (maHoKhau != "")
            {
                FThongTinHoKhau tTHK = new FThongTinHoKhau(maHoKhau);
                tTHK.ShowDialog();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyHoKhau dangKyHoKhau = new FDangKyHoKhau();
            (StackForm.TrangChu).ChildForm.Open(dangKyHoKhau);
        }

        private void cmnusMenuTachGop_Click(object sender, EventArgs e)
        {
            string maHoKhau = GetMaHoKhau();
            if (maHoKhau != "")
            {
                FDangKyHoKhau dangKyHoKhau = new FDangKyHoKhau(maHoKhau);
                (StackForm.TrangChu).ChildForm.Open(dangKyHoKhau);
            }
        }

        //Tạo ngắt trang
        private DataTable NgatTrang(DataTable ds, int recordNum)
        {
            int totalRecord = ds.Rows.Count;
            if (totalRecord <= 0)
                return ds;
            if (totalRecord % recordNum != 0)
                nudPage.Maximum = (totalRecord / recordNum) + 1;
            else
                nudPage.Maximum = totalRecord / recordNum;
            int page = int.Parse(nudPage.Value.ToString());
            return ds.AsEnumerable().Skip((page - 1) * recordNum).Take(recordNum).CopyToDataTable();
        }

        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (flpnlPhanLoai.Width > 50)
                flpnlPhanLoai.Width = 45;
            else
                flpnlPhanLoai.Width = 800;
        }
    }
}
