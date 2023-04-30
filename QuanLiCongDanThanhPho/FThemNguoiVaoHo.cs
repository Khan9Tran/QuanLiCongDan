
namespace QuanLiCongDanThanhPho
{
    public partial class FThemNguoiVaoHo : Form
    {
        private CongDanDAO cDDAO;
        public FThemNguoiVaoHo()
        {
            InitializeComponent();
            cDDAO = new CongDanDAO();
            lblThongTin.Hide();
            gvNguoiChuaCoHoKhau.Hide();
            StackForm.Add(this);
        }

        private void LoadDanhSachChuaHoKhau()
        {
            gvNguoiChuaCoHoKhau.DataSource = cDDAO.LayDanhSachTheoHoKhau("00000A");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            lblThongTin.Show();
            gvNguoiChuaCoHoKhau.Show();
            LoadDanhSachChuaHoKhau();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CongDan congDan= new CongDan(txtCCCD.Text,txtTen.Text,"","","",txtMaHo.Text,txtQuanHeVoiChuHo.Text,"u,u,u,u,u");
            if (!cDDAO.ThayDoiHoKhau(congDan))
                MessageBox.Show("Thêm công dân vào hộ khẩu thất bại");
            else
                MessageBox.Show("Thêm công dân vào hộ khẩu thành công");
            LoadDanhSachChuaHoKhau();
        }

        private void gvNguoiChuaCoHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtCCCD.Text = gvNguoiChuaCoHoKhau.Rows[dong].Cells[0].Value.ToString();
            txtTen.Text = gvNguoiChuaCoHoKhau.Rows[dong].Cells[1].Value.ToString();
        }

        private void Reset()
        {
            ToolsForControl.ClearTextBox(Controls);
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
