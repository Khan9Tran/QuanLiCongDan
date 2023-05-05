using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinKhaiSinh : MoveForm
    {
        private string? maCCCD;
        private KhaiSinhDAO ksDAO;
        private CongDanDAO cdDAO;

        private ToolsForControl tool;

        public string? MaCCCD { get => maCCCD; set => maCCCD = value; }

        public FThongTinKhaiSinh(string maCCCD)
        {
            MaCCCD = maCCCD;

            InitializeComponent();
            StackForm.Add(this);

            ksDAO = new KhaiSinhDAO();
            cdDAO = new CongDanDAO();

            SetTools();
        }

        private void OpenThanNhan(TextBox txtCongDan)
        {
            if (KiemTraDuLieuNhap.isCCCD(txtCongDan.Text))
            {
                CongDan cD = cdDAO.LayThongTin(txtCongDan.Text);
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

        private void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            { txtGioiTinh, txtQuocTich, txtDanToc, txtQueQuan, txtNoiSinh};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan, dtmNgaySinh, dtmNgayDangKy
            };
            tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isGioiTinh(txtGioiTinh.Text))
            {
                MessageBox.Show("Giới tính sai địng dạng");
                txtGioiTinh.Focus();
                return false;
            }
            if (txtQuocTich.Text == "")
            {
                MessageBox.Show("Quốc tịch không được để trống");
                txtQuocTich.Focus();
                return false;
            }
            if (txtDanToc.Text == "")
            {
                MessageBox.Show("Dân tộc không được để trống");
                txtDanToc.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtQueQuan.Text))
            {
                MessageBox.Show("Quê quán sai địng dạng");
                txtQueQuan.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtNoiSinh.Text))
            {
                MessageBox.Show("Nơi sinh sai địng dạng");
                txtNoiSinh.Focus();
                return false;
            }
            return true;
        }

        private void btnThongTinMe_Click(object sender, EventArgs e)
        {
            OpenThanNhan(txtCccdMe);
        }

        private void LoadQuocTich(string? cCCD, TextBox quocTich)
        {
            KhaiSinh ks = ksDAO.LayThongTin(cCCD);
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
            if (maCCCD != null)
            {
                KhaiSinh ks = ksDAO.LayThongTin(maCCCD);
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
            if (KiemTraThongTin())
            {
                if (MaCCCD != null)
                {
                    KhaiSinh kS = ksDAO.LayThongTin(MaCCCD);
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
                        if (ksDAO.CapNhatKhaiSinh(kS))
                            MessageBox.Show("Cập nhật khai sinh thành công");
                        else
                            MessageBox.Show("Cập nhật khai sinh thất bại");
                        tool.TurnOff();
                        LayThongTinKhaiKhaiSinh();
                    }
                }
            }    
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatKhaiSinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tool.AutoReadOnly();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            tool.TurnOff();
            LayThongTinKhaiKhaiSinh();
        }
    }
}
