using QuanLiCongDanThanhPho.Models;
using System.Data;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinHoKhau : Form
    {
        private string maHoKhau;
        HoKhauDAO hkDAO;
        CongDanDAO cdDAO;
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        public string MaHoKhau { get => maHoKhau; set => maHoKhau = value; }

        public FThongTinHoKhau(string maHoKhau)
        {
            MaHoKhau = maHoKhau;
            InitializeComponent();
            hkDAO = new HoKhauDAO();
            cdDAO = new CongDanDAO();
            StackForm.Add(this);
        }

        // Hiển thị thông tin của hổ khẩu
        private void HienThiHoKhau()
        {
            HoKhau hk = hkDAO.LayThongTin(MaHoKhau);
            txtCCCDChuHo.Text = hk.CCCDChuHo;
            txtMaHoKhau.Text = hk.MaHoKhau;
            txtDiaChi.Text = hk.DiaChi.toString();
        }

        // Hiện thị thông tin của chủ hộ
        private void HienThiCongDan()
        {
            HoKhau hk = hkDAO.LayThongTin(MaHoKhau);
            CongDan chuHo = cdDAO.LayThongTin(hk.CCCDChuHo);
            txtTenChuHo.Text = chuHo.Ten.ToString();
        }

        // Hiện thị danh sách những người trong hộ
        private void HienThiNguoiTrongHo()
        {
            DataTable dsNguoiTrongHo = cdDAO.LayDanhSachTheoHoKhau(maHoKhau);
            gvQuanHeVoiChuHo.DataSource = dsNguoiTrongHo;
            lblTong.Text = "Tổng thành viên: " + dsNguoiTrongHo.Rows.Count.ToString();
        }

        public void LayThongTinHoKhau()
        {
            if (MaHoKhau != null)
            {
                HienThiHoKhau();
                HienThiCongDan();
                HienThiNguoiTrongHo();
            }
        }

        private void CapNhatHoKhau()
        {
            HoKhau hoKhau = hkDAO.LayThongTin(maHoKhau);
            if (txtDiaChi.Text != "")
            {
                hoKhau.DiaChi.DinhDang(txtDiaChi.Text);
            }
            hkDAO.CapNhatHoKhau(hoKhau);
        }

        private void FThongTinHoKhau_Load(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
        }

        // Tạo kéo thả form
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void ReadOnly()
        {
            txtDiaChi.ReadOnly = true;
            txtDiaChi.BackColor = Color.Gainsboro;
            btnXacNhan.Enabled = false;
        }

        private void UnReadOnly()
        {
            txtDiaChi.ReadOnly = false;
            txtDiaChi.BackColor = Color.SteelBlue;
            btnXacNhan.Enabled = true;
        }

        private void AutoReadOnly()
        {
            if (txtDiaChi.ReadOnly == false)
            {
                ReadOnly();
            }
            else
            {
                UnReadOnly();
            }
        }

        private void gvQuanHeVoiChuHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string maCCCD = (string)gvQuanHeVoiChuHo.CurrentRow.Cells[0].Value;
                if (maCCCD != "")
                {
                    FThongTinCongDan ttCD = new FThongTinCongDan(cdDAO.LayThongTin(maCCCD));
                    ttCD.ShowDialog();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AutoReadOnly();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHoKhau();
            LayThongTinHoKhau();
            ReadOnly();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
            ReadOnly();
        }
    }
}
