using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinHonNhan : MoveForm
    {
        private string? maCCCD;
        private HonNhanDAO hNDAO;
        private CongDanDAO cDDAO;

        private ToolsForControl tool;

        public string? MaCCCD { get => maCCCD; set => maCCCD = value; }

        public FThongTinHonNhan(string maCCCD)
        {
            MaCCCD = maCCCD;

            InitializeComponent();
            StackForm.Add(this);

            hNDAO = new HonNhanDAO();
            cDDAO = new CongDanDAO();

            SetTools();
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
                if (hn.MaSo != null)
                {
                    txtTenChong.Text = hn.TenChong;
                    txtTenVo.Text = hn.TenVo;
                    txtCCCDChong.Text = hn.CCCDChong;
                    txtCCCDVo.Text = hn.CCCDVo;
                    txtNoiDangKy.Text = hn.NoiDangKy.toString();
                    dtmNgayDangKy.Value = hn.NgayDangKy;
                }
            }
        }    

        private void FThongTinHonNhan_Load(object sender, EventArgs e)
        {
            LayThongTinHonNhan();
        }

        private void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            { txtNoiDangKy};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan, dtmNgayDangKy
            };
            tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tool.AutoReadOnly();
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
            if (KiemTraThongTin() && hN.MaSo != null)
            {
                hN.NoiDangKy.DinhDang(txtNoiDangKy.Text);
                hN.NgayDangKy = dtmNgayDangKy.Value;
                if (hNDAO.CapNhatHonNhan(hN))
                    MessageBox.Show("Cập nhật hôn nhân thành công");
                else
                    MessageBox.Show("Cập nhật hôn nhân thất bại");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHonNhan();
            tool.TurnOff();
            LayThongTinHonNhan();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHonNhan();
        }
    }
}
