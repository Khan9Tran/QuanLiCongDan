using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinKhaiSinh : MoveForm
    {
        private string maCCCD;
        private KhaiSinhDAO ksDAO;
        private CongDanDAO cdDAO;

        private ToolsForControl tool;

        public string MaCCCD { get => maCCCD; set => maCCCD = value; }

        public FThongTinKhaiSinh(string maCCCD)
        {
            MaCCCD = maCCCD;

            InitializeComponent();
            StackForm.Add(this);

            ksDAO = new KhaiSinhDAO();
            cdDAO = new CongDanDAO();

            SetTools();
        }

        private void btnThongTinCha_Click(object sender, EventArgs e)
        {
            if (txtCccdCha.Text != "" && txtCccdCha.Text != "unknow")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(cdDAO.LayThongTin(txtCccdCha.Text));
                tTCD.ShowDialog();
            }
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
            if (txtCccdMe.Text != "" && txtCccdMe.Text != "unknow")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(cdDAO.LayThongTin(txtCccdMe.Text));
                tTCD.ShowDialog();
            }
        }

        private void HienThiCha(KhaiSinh con)
        {
            KhaiSinh ksCha = ksDAO.LayThongTin(con.CCCDCha);
            if (con.CCCDCha != "" || con.CCCDCha != null)
                txtQuocTichCha.Text = ksCha.QuocTich;
        }

        private void HienThiMe(KhaiSinh con)
        {
            KhaiSinh ksMe = ksDAO.LayThongTin(con.CCCDMe);
            if (con.CCCDMe != "" || con.CCCDMe != null)
                txtQuocTichMe.Text = ksMe.QuocTich;
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
                HienThiThongTin(ks);
                HienThiCha(ks);
                HienThiMe(ks);
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
                KhaiSinh kS = ksDAO.LayThongTin(MaCCCD);
                kS.NoiSinh.DinhDang(txtNoiSinh.Text);
                kS.QueQuan.DinhDang(txtQueQuan.Text);
                kS.NgaySinh = dtmNgaySinh.Value;
                kS.DanToc = txtDanToc.Text;
                kS.QuocTich = txtQuocTich.Text;
                kS.GioiTinh = txtGioiTinh.Text;
                kS.DinhDangGioiTinh();
                kS.NgayDangKy = dtmNgayDangKy.Value;
                ksDAO.CapNhatKhaiSinh(kS);
                tool.TurnOff();
                LayThongTinKhaiKhaiSinh();
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
