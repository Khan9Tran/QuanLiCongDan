
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

        internal override void DangKy()
        {
            CongDan congDan = new CongDan(txtCCCD.Text, txtTen.Text, "", "", "", txtMaHo.Text, txtQuanHeVoiChuHo.Text, "u,u,u,u,u");
            if (HKDAO.LayThongTin(txtMaHo.Text).MaHoKhau != null && CDDAO.ThayDoiHoKhau(congDan))
                MessageBox.Show("Thêm công dân vào hộ khẩu thành công");
            else
                MessageBox.Show("Thêm công dân vào hộ khẩu thất bại");
            LoadDanhSachChuaHoKhau();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DangKy();
        }

        private void gvNguoiChuaCoHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtCCCD.Text = gvNguoiChuaCoHoKhau.Rows[dong].Cells[0].Value.ToString();
                txtTen.Text = gvNguoiChuaCoHoKhau.Rows[dong].Cells[1].Value.ToString();
            }
        }

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
