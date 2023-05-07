using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinKhaiSinh : FormThongTin
    {
        public FThongTinKhaiSinh(string maCCCD)
        {
            MaCCCD = maCCCD;
            InitializeComponent();
            SetTools();
        }

        private void OpenThanNhan(TextBox txtCongDan)
        {
            if (KiemTraDuLieuNhap.isCCCD(txtCongDan.Text))
            {
                CongDan cD = CDDAO.LayThongTin(txtCongDan.Text);
                if (cD.CCCD != null)
                {
                    FThongTinCongDan tTCD = new FThongTinCongDan(cD);
                    tTCD.ShowDialog();
                }
            }
        }

        private void btnThongTinCha_Click(object sender, EventArgs e)
        {
            OpenThanNhan(txtCccdCha);
        }

        internal override void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            { txtGioiTinh, txtQuocTich, txtDanToc, txtQueQuan, txtNoiSinh};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan, dtmNgaySinh, dtmNgayDangKy
            };
            Tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private void btnThongTinMe_Click(object sender, EventArgs e)
        {
            OpenThanNhan(txtCccdMe);
        }

        private void LoadQuocTich(string? cCCD, TextBox quocTich)
        {
            KhaiSinh ks = KSDAO.LayThongTin(cCCD);
            if (ks.MaKhaiSinh != null)
            {
                quocTich.Text = ks.QuocTich;
            }
        }

        private void HienThiCha(KhaiSinh con)
        {
            if (con.CCCDCha != null)
                LoadQuocTich(con.CCCDCha, txtQuocTichCha);
        }

        private void HienThiMe(KhaiSinh con)
        {
            if (con.CCCDMe != null)
                LoadQuocTich(con.CCCDMe, txtQuocTichMe);
        }

        private void HienThiThongTin(KhaiSinh ks)
        {
            txtTen.Text = ks.HoTen;
            txtCccd.Text = ks.MaKhaiSinh;
            txtNoiSinh.Text = ks.NoiSinh.toString();
            dtmNgaySinh.Value = ks.NgaySinh;
            if (ks.GioiTinh == "f")
                txtGioiTinh.Text = "Nữ";
            else if (ks.GioiTinh == "m")
                txtGioiTinh.Text = "Nam";
            else
                txtGioiTinh.Text = "u";
            txtDanToc.Text = ks.DanToc;
            txtQuocTich.Text = ks.QuocTich;
            txtQueQuan.Text = ks.QueQuan.toString();
            if (ks.NgayDangKy != null)
                dtmNgayDangKy.Value = ks.NgayDangKy;

            txtTenCha.Text = ks.TenCha;
            txtTenMe.Text = ks.TenMe;
            txtCccdCha.Text = ks.CCCDCha;
            txtCccdMe.Text = ks.CCCDMe;
        }

        public void LayThongTinKhaiKhaiSinh()
        {
            if (MaCCCD != null)
            {
                KhaiSinh ks = KSDAO.LayThongTin(MaCCCD);
                if (ks.MaKhaiSinh != null)
                {
                    HienThiThongTin(ks);
                    HienThiCha(ks);
                    HienThiMe(ks);
                }
            }
        }

        private void FThongTinKhaiSinh_Load(object sender, EventArgs e)
        {
            LayThongTinKhaiKhaiSinh();
        }

        private void CapNhatKhaiSinh()
        {
            if (MaCCCD != null)
            {
                KhaiSinh kS = KSDAO.LayThongTin(MaCCCD);
                if (kS.MaKhaiSinh != null)
                {
                    kS.NoiSinh.DinhDang(txtNoiSinh.Text);
                    kS.QueQuan.DinhDang(txtQueQuan.Text);
                    kS.NgaySinh = dtmNgaySinh.Value;
                    kS.DanToc = txtDanToc.Text;
                    kS.QuocTich = txtQuocTich.Text;
                    kS.GioiTinh = txtGioiTinh.Text;
                    kS.DinhDangGioiTinh();
                    kS.NgayDangKy = dtmNgayDangKy.Value;

                    if (KiemTraDuLieuNhap.KiemTraKhaiSinh(kS) && KSDAO.CapNhatKhaiSinh(kS))
                    {
                        Tool.TurnOff();
                        LayThongTinKhaiKhaiSinh();
                        MessageBox.Show("Cập nhật khai sinh thành công");
                    }
                    else
                        MessageBox.Show("Cập nhật khai sinh thất bại");
                }
            }

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatKhaiSinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Tool.AutoReadOnly();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            Tool.TurnOff();
            LayThongTinKhaiKhaiSinh();
        }
    }
}
