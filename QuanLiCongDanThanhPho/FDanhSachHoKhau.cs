
namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachHoKhau : FormDanhSach
    {
        private HoKhauDAO hkDAO;

        enum Loc
        {
            tatCa,
            soThanhVien,
        }

        public FDanhSachHoKhau()
        {
            InitializeComponent();

            hkDAO = new HoKhauDAO();
            ListData = new Paging(nudPage, 15);

            LuaChon = Loc.tatCa;
        }
        private void ChangeBtnColor(Loc type)
        {
            btnSoTV.BackColor = Color.DodgerBlue;
            btnTatCa.BackColor = Color.DodgerBlue;

            if (type == Loc.tatCa)
            {
                btnTatCa.BackColor = Color.DarkBlue;
            }
            else if (type == Loc.soThanhVien)
            {
                btnSoTV.BackColor = Color.DarkBlue;
            }
        }

        private void FDanhSachHoKhau_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            flpnlPhanLoai.Width = 45;
        }

        private void gvHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && gvHoKhau.Rows[e.RowIndex].Cells[0].Value.ToString()?.Length > 0)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            ChangeBtnColor(Loc.tatCa);
            TimKiem(Loc.tatCa);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (LuaChon == Loc.tatCa)
               Ds = hkDAO.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (LuaChon == Loc.soThanhVien)
               Ds = hkDAO.LayDanhSachXepTheoSoTV(txtTimKiem.Text);
            nudPage.Value = 1;
            LoadDanhSach(gvHoKhau);
        }

        private string GetMaHoKhau()
        {
            return (string)gvHoKhau.CurrentRow.Cells["Mã hộ khẩu"].Value;
        }

        private void btnSoTV_Click(object sender, EventArgs e)
        {
            ChangeBtnColor(Loc.soThanhVien);
            TimKiem(Loc.soThanhVien);
        }

        private void TimKiem(dynamic type)
        {
            LuaChon = type;
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
            (StackForm.TrangChu)?.ChildForm.Open(dangKyHoKhau);
        }

        private void cmnusMenuTachGop_Click(object sender, EventArgs e)
        {
            string maHoKhau = GetMaHoKhau();
            if (maHoKhau != "")
            {
                FDangKyHoKhau dangKyHoKhau = new FDangKyHoKhau(maHoKhau);
                (StackForm.TrangChu)?.ChildForm.Open(dangKyHoKhau);
            }
        }

        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach(gvHoKhau);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Loc_Click(flpnlPhanLoai);
        }
    }
}
