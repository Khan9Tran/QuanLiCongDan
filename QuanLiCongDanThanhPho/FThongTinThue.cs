using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinThue : Form
    {
        private string maCCCD;
        private ThueDAO thueDAO;
        private CongDanDAO cdDAO;
        private HoKhauDAO hkDAO;
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
            thueDAO = new ThueDAO();
            cdDAO = new CongDanDAO();
            hkDAO = new HoKhauDAO();
            StackForm.Add(this);
        }

        public FThongTinThue()
        {
            InitializeComponent();
            KhoiTao();
        }

        public FThongTinThue(string maCCCD)
        {
            MaCCCD = maCCCD;
            InitializeComponent();
            KhoiTao();
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isTien(txtSoTienCanNop.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại số tiền cần nộp");
                txtSoTienCanNop.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isTien(txtSoTienDaNop.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại số tiền đã nộp");
                txtSoTienDaNop.Focus();
                return false;
            }   
            return true;
        }

        private void ReadOnly()
        {
            txtSoTienCanNop.ReadOnly = true;
            txtSoTienCanNop.BackColor = Color.Gainsboro;
            txtSoTienDaNop.ReadOnly = true;
            txtSoTienDaNop.BackColor = Color.Gainsboro;
            dtmHanNopThue.Enabled = false;
            dtmNgayCapMaSoThue.Enabled = false;
            btnXacNhan.Enabled = false;
        }

        private void UnReanOnly()
        {
            txtSoTienCanNop.ReadOnly = false;
            txtSoTienCanNop.BackColor = Color.SteelBlue;
            txtSoTienDaNop.ReadOnly = false;
            txtSoTienDaNop.BackColor = Color.SteelBlue;
            dtmHanNopThue.Enabled = true;
            dtmNgayCapMaSoThue.Enabled = true;
            btnXacNhan.Enabled = true;
        }

        private void AutoReadOnly()
        {
            if (txtSoTienCanNop.ReadOnly == false)
            {
                ReadOnly();
            }
            else
            {
                UnReanOnly();
            } 
                
        }

        private void LayThongTinThue()
        {
            if (MaCCCD != null)
            {
                Thue thue = thueDAO.LayThongTin(MaCCCD);
                CongDan cd = cdDAO.LayThongTin(MaCCCD);
                HoKhau hk = hkDAO.LayThongTin(cd.MaHoKhau);
                txtMaSoThue.Text = thue.MaThue;
                txtTen.Text = cd.Ten;
                txtCCCD.Text = cd.CCCD;
                txtSdt.Text = cd.SDT;
                txtDiaChi.Text = hk.DiaChi.toString();
                txtSoTienCanNop.Text = thue.SoTienCanNop;
                txtSoTienDaNop.Text = thue.SoTienDaNop;
                dtmNgayCapMaSoThue.Value = thue.NgayCapMa;
                dtmHanNopThue.Value = thue.HanNop;
            }
        }

        private void FThongTinThue_Load(object sender, EventArgs e)
        {
            LayThongTinThue();
        }

        // Tạo kéo thả form
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void CapNhatThue()
        {
            Thue thue = thueDAO.LayThongTin(MaCCCD);
            if (txtMaSoThue.Text != "")
            {
                thue.CCCD = txtCCCD.Text;
                thue.SoTienCanNop = txtSoTienCanNop.Text;
                thue.SoTienDaNop = txtSoTienDaNop.Text;
                thue.NgayCapMa = dtmNgayCapMaSoThue.Value;
                thue.HanNop = dtmHanNopThue.Value;
            }
            thueDAO.CapNhatThue(thue);
        }    

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                CapNhatThue();
                LayThongTinThue();
                ReadOnly();
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AutoReadOnly();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinThue();
            ReadOnly();
        }
    }
}
