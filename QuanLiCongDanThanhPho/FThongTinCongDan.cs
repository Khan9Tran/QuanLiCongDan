using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCongDan : FormThongTin
    {
        private string maTamTru = "00000B";
        private string maChuaCoHK = "00000A";

        public FThongTinCongDan(CongDan congDan)
        {
            InitializeComponent();
            CongDan = congDan;
            HinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
            SetTools();
        }
        
        //Mở F khai sinh
        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            FThongTinKhaiSinh tTKS = new FThongTinKhaiSinh(CongDan.CCCD);
            tTKS.ShowDialog();
        }

        internal override void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            { txtNgheNghiep, txtHoVaTen, txtSDT, txtTonGiao, txtDanToc, txtQueQuan,
                txtQuocTich, txtDiaChi, txtGioiTinh, txtQuanHeVoiChuHo};
            List<Control> listControl = new List<Control>()
            {
                btnXacNhan, dtmNgaySinh, ptcHinhDaiDien
            };
            Tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        //Lấy ảnh công dân hiện lên picturebox
        private void LayCongDan()
        {
            if (CongDan.CCCD != null)
            {
                txtCCCD.Text = CongDan.CCCD;
                txtHoVaTen.Text = CongDan.Ten;

                if (isMaHK(CongDan.MaHoKhau))
                    txtMaHoKhau.Text = CongDan.MaHoKhau;

                txtSDT.Text = CongDan.SDT;
                txtTonGiao.Text = CongDan.TonGiao;
                txtNgheNghiep.Text = CongDan.NgheNghiep;
                txtQuanHeVoiChuHo.Text = CongDan.QuanHeVoiChuHo;
            }
        }

        private void LayKhaiSinh()
        {
            KhaiSinh ks = KSDAO.LayThongTin(CongDan.CCCD);
            if (ks.MaKhaiSinh != null)
            {
                dtmNgaySinh.Value = ks.NgaySinh;
                if (ks.GioiTinh == "f")  // "f" là giới tính nữ, "m" là nam
                    txtGioiTinh.Text = "Nữ";
                else
                    txtGioiTinh.Text = "Nam";
                txtDanToc.Text = ks.DanToc;
                txtQuocTich.Text = ks.QuocTich;
                txtQueQuan.Text = ks.QueQuan.toString();
            }
        }

        private void LayThue()
        {
            Thue thue = ThueDAO.LayThongTin(CongDan.CCCD);
            if (thue.MaThue == null || thue.MaThue == "")
                btnThue.Enabled = false;
            if (thue.MaThue != null)
                txtMaThue.Text = thue.MaThue;
        }

        private void LayHonNhan()
        {
            if (!HNDAO.KiemTraHonNhan(CongDan.CCCD))
            {
                txtHonNhan.Text = "Chưa có hôn nhân";
                btnHonNhan.Enabled = false;
            }
            else
            {
                HonNhan hn = HNDAO.LayThongTin(CongDan.CCCD);
                txtHonNhan.Text = hn.MaSo;
            }
        }

        private void LayHoKhau()
        {
            HoKhau hk = HKDAO.LayThongTin(CongDan.MaHoKhau);
            if (hk.MaHoKhau != null && isMaHK(hk.MaHoKhau))
            {
                txtDiaChi.Text = hk.DiaChi.toString();
            }
            else
            {
                txtQuanHeVoiChuHo.Text = "Không có";
                btnHoKhau.Enabled = false;
            }
        }

        private void LayTamTruTamVang()
        {
            TamTruTamVang tttv = new TamTruTamVang();
            if (!TTTVDAO.KiemTraTamTruTamVang(CongDan.CCCD))
                txtGhiChu.Text = "Không có ghi chú";
            else
            {
                tttv = TTTVDAO.LayThongTin(CongDan.CCCD);
                txtGhiChu.Text = tttv.TrangThai;
            }
        }

        public void LayThongTinCongDan()
        {
            if (CongDan != null)
            {
                LayCongDan();
                LayKhaiSinh();
                LayThue();
                LayHonNhan();
                LayHoKhau();
                LayTamTruTamVang();
                HinhCongDan.LayHinhDaiDien(txtCCCD.Text, ptcHinhDaiDien);
            }
        }

        private void TatXemCCCD()
        {
            CCCD cccd = new CCCD(CongDan.CCCD);
            cccd = CCCDDAO.LayThongTin(cccd);
            if (cccd.MaCCCD != null && cccd.DacDiem == "unknow")
            {
                    btnThongTinCCCD.Enabled = false;
            }

        }

        private void FThongTinCongDan_Load(object sender, EventArgs e)
        {
            LayThongTinCongDan();
            TatXemCCCD();
        }

        private bool isMaHK(string? maHK)
        {
            return maHK != maTamTru && maHK != maChuaCoHK;
        }

        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            CongDan cd = CDDAO.LayThongTin(CongDan.CCCD);
            if (cd.CCCD != null)
            {
                if (isMaHK(cd.MaHoKhau))
                {
                    FThongTinHoKhau tTHK = new FThongTinHoKhau(CongDan.MaHoKhau);
                    tTHK.ShowDialog();
                }
            }
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            FThongTinThue tTThue = new FThongTinThue(CongDan.CCCD);
            tTThue.ShowDialog();
        }

        private void btnHonNhan_Click(object sender, EventArgs e)
        {
            FThongTinHonNhan tTHN = new FThongTinHonNhan(CongDan.CCCD);
            tTHN.ShowDialog();
        }

        private void CapNhatKhaiSinh()
        {
            KhaiSinh khaiSinh = KSDAO.LayThongTin(CongDan.CCCD);
            if (khaiSinh.MaKhaiSinh != null)
            {
                khaiSinh.HoTen = txtHoVaTen.Text;
                khaiSinh.QueQuan.DinhDang(txtQueQuan.Text);
                khaiSinh.NgaySinh = dtmNgaySinh.Value;
                khaiSinh.DanToc = txtDanToc.Text;
                khaiSinh.QuocTich = txtQuocTich.Text;
                khaiSinh.GioiTinh = txtGioiTinh.Text;
                khaiSinh.DinhDangGioiTinh();
                if (KiemTraDuLieuNhap.KiemTraKhaiSinh(khaiSinh))
                    KSDAO.CapNhatKhaiSinh(khaiSinh);
            }
        }    

        private void CapNhatCongDan()
        {
            CongDan.Ten = txtHoVaTen.Text;
            CongDan.SDT = txtSDT.Text;
            CongDan.NgheNghiep = txtNgheNghiep.Text;
            CongDan.TonGiao = txtTonGiao.Text;
            CongDan.QuanHeVoiChuHo = txtQuanHeVoiChuHo.Text;
            if (KiemTraDuLieuNhap.KiemTraCongDan(CongDan))
                CDDAO.CapNhatCongDan(CongDan);
        }

        //Thay đổi chủ hộ ở table hộ khẩu nếu có
        private void CapNhatHoKhau()
        {
            HoKhau hoKhau = HKDAO.LayThongTin(txtMaHoKhau.Text);
            if (hoKhau.MaHoKhau != null)
            {
                if (txtQuanHeVoiChuHo.Text == "Chủ hộ" && hoKhau.CCCDChuHo != txtCCCD.Text)
                {
                    CongDan cD = CDDAO.LayThongTin(hoKhau.CCCDChuHo);
                    if (cD.CCCD != null)
                    {
                        cD.QuanHeVoiChuHo = "Unknow";
                        hoKhau.CCCDChuHo = txtCCCD.Text;
                        CDDAO.CapNhatCongDan(cD);
                    }
                }
                hoKhau.DiaChi.DinhDang(txtDiaChi.Text);
                if (KiemTraDuLieuNhap.KiemTraHoKhau(hoKhau))
                    HKDAO.CapNhatHoKhau(hoKhau);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {  
            Tool.AutoReadOnly();
        }

        private void CapNhatHonNhan()
        {
            if (txtHonNhan.Text != "Chưa có hôn nhân" && txtHonNhan.Text != "")
            {
                HonNhan hn = HNDAO.LayThongTin(CongDan.CCCD);
                if (txtCCCD.Text == hn.CCCDChong)
                    hn.TenChong = txtHoVaTen.Text;  
                else
                    hn.TenVo = txtHoVaTen.Text;
                if (KiemTraDuLieuNhap.KiemTraHonNhan(hn))
                    HNDAO.CapNhatHonNhan(hn);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHoKhau();
            CapNhatCongDan();
            CapNhatKhaiSinh();
            CapNhatHonNhan();
            LayThongTinCongDan();
            Tool.AutoReadOnly();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinCongDan();
            Tool.AutoReadOnly();
        }

        private void ThemHinh()
        {
            if (HinhCongDan.ThemHinhDaiDien(ofdHinhDaiDien, ptcHinhDaiDien))
            {
                HinhCongDan.SaveHinhDaiDien(txtCCCD.Text, ofdHinhDaiDien, ptcHinhDaiDien);
            }
        }

        private void picCongDan_Click(object sender, EventArgs e)
        {
            ptcHinhDaiDien.Image = null;
            ThemHinh();
        }

        private void btnThongTinCCCD_Click(object sender, EventArgs e)
        {
            FThongTinCCCD thongTinCCCD = new FThongTinCCCD(CongDan);
            thongTinCCCD.ShowDialog();
        }
    }
}
