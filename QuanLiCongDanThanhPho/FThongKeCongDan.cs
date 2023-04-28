
namespace QuanLiCongDanThanhPho
{
    public partial class FThongKeCongDan : Form
    {
        private CongDanDAO cdDAO;
        private KhaiSinhDAO ksDAO;

        public FThongKeCongDan()
        {
            InitializeComponent();
            cdDAO = new CongDanDAO();
            ksDAO = new KhaiSinhDAO();
            StackForm.Add(this);
        }

        private void FThongKeCongDancs_Load(object sender, EventArgs e)
        {
            gvSoLuongNamNu.DataSource = ksDAO.LayDanhSachVeSoNamNu();
            lblSoCongDan.Text += string.Format($" {cdDAO.LaySoLuongCongDan()}");
            lblSoLuongDaKetHon.Text += string.Format($" {cdDAO.LaySoLuongDaKetHon()}");
            lblSoLuongChuaKetHon.Text += string.Format($" {cdDAO.LaySoLuongDocThan()}");
            gvNhomTuoi.DataSource = ksDAO.LayTuoiCongDan();
            gvNgheNghiep.DataSource = cdDAO.LayDanhSachNgheNghiep();

        }
    }
}
