using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinHonNhan : FormThongTin
    {
        public FThongTinHonNhan(string maCCCD)
        {
            MaCCCD = maCCCD;

            InitializeComponent();

            SetTools();
        }

        private void btnThongTinChong_Click(object sender, EventArgs e)
        {
            if (txtCCCDChong.Text != "")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(CDDAO.LayThongTin(txtCCCDChong.Text));
                tTCD.ShowDialog();
            }
        }

        private void btnThongTinVo_Click(object sender, EventArgs e)
        {
            if (txtCCCDVo.Text != "")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(CDDAO.LayThongTin(txtCCCDVo.Text));
                tTCD.ShowDialog();
            }
        }

        public void LayThongTinHonNhan()
        {
            if (MaCCCD != null)
            {
                HonNhan hn = HNDAO.LayThongTin(MaCCCD);
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

        internal override void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            { txtNoiDangKy};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan, dtmNgayDangKy
            };
            Tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Tool.AutoReadOnly();
        }

        public void CapNhatHonNhan()
        {
            HonNhan hN = HNDAO.LayThongTin(MaCCCD);
            if (hN.MaSo != null)
            {
                hN.NoiDangKy.DinhDang(txtNoiDangKy.Text);
                hN.NgayDangKy = dtmNgayDangKy.Value;
                if (KiemTraDuLieuNhap.KiemTraHonNhan(hN) && HNDAO.CapNhatHonNhan(hN))
                    MessageBox.Show("Cập nhật hôn nhân thành công");
                else
                    MessageBox.Show("Cập nhật hôn nhân thất bại");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHonNhan();
            Tool.TurnOff();
            LayThongTinHonNhan();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHonNhan();
        }
    }
}
