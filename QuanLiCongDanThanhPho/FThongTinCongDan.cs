using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCongDan : MoveForm
    {
        private CongDan congDan;
        private CongDanDAO cdDAO;
        private KhaiSinhDAO ksDAO;
        private ThueDAO thueDAO;
        private HonNhanDAO hnDAO;
        private HoKhauDAO hkDAO;
        private TamTruTamVangDAO tttvDAO;
        private CCCDDAO cCCDDAO;

        private ToolsForControl tool;

        private string maTamTru = "00000B";
        private string maChuaCoHK = "00000A";
        private HinhDaiDien hinhCongDan;

        public FThongTinCongDan(CongDan congDan)
        {
            InitializeComponent();
            StackForm.Add(this);
            cdDAO = new CongDanDAO();
            ksDAO = new KhaiSinhDAO();
            thueDAO = new ThueDAO();
            hkDAO = new HoKhauDAO();
            hnDAO = new HonNhanDAO();
            tttvDAO = new TamTruTamVangDAO();
            cCCDDAO = new CCCDDAO();
            this.congDan = congDan;
            hinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
            SetTools();
        }
        
        //Mở F khai sinh
        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            FThongTinKhaiSinh tTKS = new FThongTinKhaiSinh(congDan.CCCD);
            tTKS.ShowDialog();
        }

        private void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            { txtNgheNghiep, txtHoVaTen, txtSDT, txtTonGiao, txtDanToc, txtQueQuan,
                txtQuocTich, txtDiaChi, txtGioiTinh, txtQuanHeVoiChuHo};
            List<Control> listControl = new List<Control>()
            {
                btnXacNhan, dtmNgaySinh, ptcHinhDaiDien
            };
            tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        //Lấy ảnh công dân hiện lên picturebox
        private void LayCongDan()
        {
            if (congDan.CCCD != null)
            {
                txtCCCD.Text = congDan.CCCD;
                txtHoVaTen.Text = congDan.Ten;

                if (isMaHK(congDan.MaHoKhau))
                    txtMaHoKhau.Text = congDan.MaHoKhau;

                txtSDT.Text = congDan.SDT;
                txtTonGiao.Text = congDan.TonGiao;
                txtNgheNghiep.Text = congDan.NgheNghiep;
                txtQuanHeVoiChuHo.Text = congDan.QuanHeVoiChuHo;
            }
        }

        private void LayKhaiSinh()
        {
            KhaiSinh ks = ksDAO.LayThongTin(congDan.CCCD);
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
            Thue thue = thueDAO.LayThongTin(congDan.CCCD);
            if (thue.MaThue == null || thue.MaThue == "")
                btnThue.Enabled = false;
            if (thue.MaThue != null)
                txtMaThue.Text = thue.MaThue;
        }

        private void LayHonNhan()
        {
            if (!hnDAO.KiemTraHonNhan(congDan.CCCD))
            {
                txtHonNhan.Text = "Chưa có hôn nhân";
                btnHonNhan.Enabled = false;
            }
            else
            {
                HonNhan hn = hnDAO.LayThongTin(congDan.CCCD);
                txtHonNhan.Text = hn.MaSo;
            }
        }

        private void LayHoKhau()
        {
            HoKhau hk = hkDAO.LayThongTin(congDan.MaHoKhau);
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
            if (!tttvDAO.KiemTraTamTruTamVang(congDan.CCCD))
                txtGhiChu.Text = "Không có ghi chú";
            else
            {
                tttv = tttvDAO.LayThongTin(congDan.CCCD);
                txtGhiChu.Text = tttv.TrangThai;
            }
        }

        public void LayThongTinCongDan()
        {
            if (congDan != null)
            {
                LayCongDan();
                LayKhaiSinh();
                LayThue();
                LayHonNhan();
                LayHoKhau();
                LayTamTruTamVang();
                hinhCongDan.LayHinhDaiDien(txtCCCD.Text, ptcHinhDaiDien);
            }
        }

        private void TatXemCCCD()
        {
            CCCD cccd = new CCCD(congDan.CCCD);
            cccd = cCCDDAO.LayThongTin(cccd);
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
            CongDan cd = cdDAO.LayThongTin(congDan.CCCD);
            if (cd.CCCD != null)
            {
                if (isMaHK(cd.MaHoKhau))
                {
                    FThongTinHoKhau tTHK = new FThongTinHoKhau(congDan.MaHoKhau);
                    tTHK.ShowDialog();
                }
            }
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            FThongTinThue tTThue = new FThongTinThue(congDan.CCCD);
            tTThue.ShowDialog();
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isTen(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại họ và tên");
                txtHoVaTen.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isGioiTinh(txtGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại giới tính");
                txtGioiTinh.Focus();
                return false;
            }
            if (txtNgheNghiep.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại nghề nghiệp");
                txtNgheNghiep.Focus();
                return false;
            }
            if (txtQuocTich.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại quốc tịch");
                txtQuocTich.Focus();
                return false;
            }
            if (txtDanToc.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại dân tộc");
                txtDanToc.Focus();
                return false;
            }
            if (txtTonGiao.Text == "")
            {
                MessageBox.Show("Tôn giáo không được để trống");
                txtTonGiao.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại địa chỉ");
                txtDiaChi.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtQueQuan.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại quê quán");
                txtQueQuan.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isSoDT(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại số điện thoại");
                txtSDT.Focus();
                return false;
            }      
            if (txtQuanHeVoiChuHo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mối quan hệ với chủ hộ");
                txtQuanHeVoiChuHo.Focus();
                return false;
            }    
            return true;
        }

        private void btnHonNhan_Click(object sender, EventArgs e)
        {
            FThongTinHonNhan tTHN = new FThongTinHonNhan(congDan.CCCD);
            tTHN.ShowDialog();
        }

        private bool CapNhatKhaiSinh()
        {
            KhaiSinh khaiSinh = ksDAO.LayThongTin(congDan.CCCD);
            if (khaiSinh.MaKhaiSinh != null)
            {
                khaiSinh.HoTen = txtHoVaTen.Text;
                khaiSinh.QueQuan.DinhDang(txtQueQuan.Text);
                khaiSinh.NgaySinh = dtmNgaySinh.Value;
                khaiSinh.DanToc = txtDanToc.Text;
                khaiSinh.QuocTich = txtQuocTich.Text;
                khaiSinh.GioiTinh = txtGioiTinh.Text;
                khaiSinh.DinhDangGioiTinh();
                return ksDAO.CapNhatKhaiSinh(khaiSinh);
            }
            else
                return false;
        }    

        private bool CapNhatCongDan()
        {
            congDan.Ten = txtHoVaTen.Text;
            congDan.SDT = txtSDT.Text;
            congDan.NgheNghiep = txtNgheNghiep.Text;
            congDan.TonGiao = txtTonGiao.Text;
            congDan.QuanHeVoiChuHo = txtQuanHeVoiChuHo.Text;
            return cdDAO.CapNhatCongDan(congDan);
        }

        //Thay đổi chủ hộ ở table hộ khẩu nếu có
        private bool CapNhatHoKhau()
        {
            HoKhau hoKhau = hkDAO.LayThongTin(txtMaHoKhau.Text);
            if (hoKhau.MaHoKhau != null)
            {
                if (txtQuanHeVoiChuHo.Text == "Chủ hộ" && hoKhau.CCCDChuHo != txtCCCD.Text)
                {
                    CongDan cD = cdDAO.LayThongTin(hoKhau.CCCDChuHo);
                    if (cD.CCCD != null)
                    {
                        cD.QuanHeVoiChuHo = "Unknow";
                        hoKhau.CCCDChuHo = txtCCCD.Text;
                        if (!cdDAO.CapNhatCongDan(cD))
                            return false;
                    }
                }
                hoKhau.DiaChi.DinhDang(txtDiaChi.Text);
                return hkDAO.CapNhatHoKhau(hoKhau);
            }
            return false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {  
            tool.AutoReadOnly();
        }

        private bool CapNhatHonNhan()
        {
            if (txtHonNhan.Text != "Chưa có hôn nhân" && txtHonNhan.Text != "")
            {
                HonNhan hn = hnDAO.LayThongTin(congDan.CCCD);
                if (txtCCCD.Text == hn.CCCDChong)
                    hn.TenChong = txtHoVaTen.Text;  
                else
                    hn.TenVo = txtHoVaTen.Text;
                return hnDAO.CapNhatHonNhan(hn);
            }
            return false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {  
            if (KiemTraThongTin())
            {
                if (!CapNhatCongDan())
                {
                    MessageBox.Show("Cập nhật thông tin công dân thất bại");
                    return;
                }
                if (!CapNhatKhaiSinh())
                {
                    MessageBox.Show("Cập nhật thông tin công dân thất bại");
                    return;
                }
                if (!CapNhatHonNhan())
                {
                    MessageBox.Show("Cập nhật thông tin công dân thất bại");
                    return;
                }
                LayThongTinCongDan();
                if (!CapNhatHoKhau())
                {
                    MessageBox.Show("Cập nhật thông tin công dân thất bại");
                    return;
                }
                MessageBox.Show("Cập nhật thông tin công dân thành công");
                tool.AutoReadOnly();
            }    
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinCongDan();
            tool.AutoReadOnly();
        }

        private void ThemHinh()
        {
            if (hinhCongDan.ThemHinhDaiDien(ofdHinhDaiDien, ptcHinhDaiDien))
            {
                hinhCongDan.SaveHinhDaiDien(txtCCCD.Text, ofdHinhDaiDien, ptcHinhDaiDien);
            }
        }

        private void picCongDan_Click(object sender, EventArgs e)
        {
            ptcHinhDaiDien.Image = null;
            ThemHinh();
        }

        private void btnThongTinCCCD_Click(object sender, EventArgs e)
        {
            FThongTinCCCD thongTinCCCD = new FThongTinCCCD(congDan);
            thongTinCCCD.ShowDialog();
        }
    }
}
