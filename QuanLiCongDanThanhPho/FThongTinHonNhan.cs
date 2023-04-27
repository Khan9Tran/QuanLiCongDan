using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinHonNhan : Form
    {
        private string maCCCD;
        HonNhanDAO hNDAO = new HonNhanDAO();
        CongDanDAO cDDAO = new CongDanDAO();

        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        public string MaCCCD { get => maCCCD; set => maCCCD = value; }

        public FThongTinHonNhan(string maCCCD)
        {
            MaCCCD = maCCCD;
            InitializeComponent();
            hNDAO = new HonNhanDAO();
            cDDAO = new CongDanDAO();
            StackForm.Add(this);
        }

        private void btnThongTinChong_Click(object sender, EventArgs e)
        {
            if (txtCCCDChong.Text != "")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(cDDAO.LayThongTin(txtCCCDChong.Text));
                tTCD.ShowDialog();
            }
        }

        private void btnThongTinVo_Click(object sender, EventArgs e)
        {
            if (txtCCCDVo.Text != "")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(cDDAO.LayThongTin(txtCCCDVo.Text));
                tTCD.ShowDialog();
            }
        }

        public void LayThongTinHonNhan()
        {
            if (maCCCD != null)
            {
                HonNhan hn = hNDAO.LayThongTin(maCCCD);
                txtTenChong.Text = hn.TenChong;
                txtTenVo.Text = hn.TenVo;
                txtCCCDChong.Text = hn.CCCDChong;
                txtCCCDVo.Text = hn.CCCDVo;
                txtNoiDangKy.Text = hn.NoiDangKy.toString();
                dtmNgayDangKy.Value = hn.NgayDangKy;
            }
        }    

        private void FThongTinHonNhan_Load(object sender, EventArgs e)
        {
            LayThongTinHonNhan();
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
            dtmNgayDangKy.Enabled = false;
            txtNoiDangKy.ReadOnly = true;
            btnXacNhan.Enabled = false;
            txtNoiDangKy.BackColor = Color.Gainsboro;
        }

        private void UnReadOnLy()
        {
            dtmNgayDangKy.Enabled = true;
            txtNoiDangKy.ReadOnly = false;
            btnXacNhan.Enabled = true;
            txtNoiDangKy.BackColor = Color.SteelBlue;
        }

        private void ChoPhepThayDoi()
        {
            if (txtNoiDangKy.ReadOnly == false)
            {
                ReadOnly();
            }
            else
            {
                UnReadOnLy();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChoPhepThayDoi();
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isDiaChi(txtNoiDangKy.Text))
            {
                MessageBox.Show("Kiểm tra lại nơi đăng ký");
                txtNoiDangKy.Focus();
                return false;
            }    
            return true;
        }    

        public void CapNhatHonNhan()
        {
            HonNhan hN = hNDAO.LayThongTin(maCCCD);
            if (KiemTraThongTin())
            {
                hN.NoiDangKy.DinhDang(txtNoiDangKy.Text);
                hN.NgayDangKy = dtmNgayDangKy.Value;
                hNDAO.CapNhatHonNhan(hN);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHonNhan();
            ReadOnly();
            LayThongTinHonNhan();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHonNhan();
        }
    }
}
