using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCCCD : FormThongTin
    {
        public FThongTinCCCD(CongDan congDan)
        {
            InitializeComponent();
            CongDan = congDan;
            HinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
        }

        private string DateTimeFormat()
        {
            return "dd/MM/yyyy";
        }

        // Hiển thị thông tin lấy từ class công dân
        private void HienThiCongDan()
        {
            lblCCCD.Text = CongDan.CCCD;
            lblTen.Text = CongDan.Ten.ToUpper();
        }

        // Hiển thị thông tin lấy từ class khai sinh
        private void HienThiKhaiSinh()
        {
            KhaiSinh ks = KSDAO.LayThongTin(lblCCCD.Text);
            if (ks.MaKhaiSinh != null)
            {
                if (ks.GioiTinh == "m")
                    lblGioiTinh.Text = "Nam";
                else lblGioiTinh.Text = "Nữ";
                lblNgaySinh.Text = ks.NgaySinh.ToString(DateTimeFormat());
                lblQueQuan.Text = ks.QueQuan.toString();
                lblQuocTich.Text = ks.QuocTich;
            }
        }

        // Hiển thị thông tin lấy từ class hộ khẩu
        private void HienThiHoKhau()
        {
            HoKhau hk = HKDAO.LayThongTin(CongDan.MaHoKhau);
            if (hk.MaHoKhau != null)
            {
                lblDiaChi.Text = hk.DiaChi.toString();
            }
        }
        
        // Hiển thị thông tin láy từ class CCCD
        private void HienThiCCCD()
        {
            CCCD cCCD = CCCDDAO.LayThongTin(new CCCD(CongDan.CCCD, DateTime.Now, "unknow"));
            if (cCCD.MaCCCD != null)
            {
                lblNgayCap.Text = ((DateTime)cCCD.NgayCap).ToString(DateTimeFormat());
                lblDDNhanDang.Text = cCCD.DacDiem;
            }
        }

        private void HienThiThongTin()
        {
            HienThiCongDan();
            HienThiKhaiSinh();
            HienThiHoKhau();
            HienThiCCCD();
        }

        private void FThongTinCCCD_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            HinhCongDan.LayHinhDaiDien(lblCCCD.Text, ptcHinhDaiDien);
        }

    }
}
