using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinHonNhan : Form
    {
        private string maCCCD;
        HonNhanDAO hnDAO = new HonNhanDAO();
        CongDanDAO cdDAO = new CongDanDAO();
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        public string MaCCCD
        {
            set { maCCCD = value; }
            get { return maCCCD; }
        }

        private void KhoiTao()
        {
            hnDAO = new HonNhanDAO();
            cdDAO = new CongDanDAO();
            StackForm.Add(this);
        }

        public FThongTinHonNhan()
        {
            InitializeComponent();
            StackForm.Add(this);
        }

        public FThongTinHonNhan(string maCCCD)
        {
            MaCCCD = maCCCD;
            InitializeComponent();
            KhoiTao();
        }

        private void btnThongTinChong_Click(object sender, EventArgs e)
        {
            if (txtCCCDChong.Text != "")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(cdDAO.LayThongTin(txtCCCDChong.Text));
                tTCD.ShowDialog();
            }
        }

        private void btnThongTinVo_Click(object sender, EventArgs e)
        {
            if (txtCCCDVo.Text != "")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(cdDAO.LayThongTin(txtCCCDVo.Text));
                tTCD.ShowDialog();
            }
        }

        public void LayThongTinHonNhan()
        {
            if (maCCCD != null)
            {
                HonNhan hn = hnDAO.LayThongTin(maCCCD);
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
            HonNhan hN = hnDAO.LayThongTin(maCCCD);
            hN.NoiDangKy.DinhDang(txtNoiDangKy.Text);
            hN.NgayDangKy = dtmNgayDangKy.Value;
            hnDAO.CapNhatHonNhan(hN);
        }

        private void CapNhat()
        {   if (KiemTraThongTin())
            {
                CapNhatHonNhan();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhat();
            ReadOnly();
            LayThongTinHonNhan();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHonNhan();
        }
    }
}
