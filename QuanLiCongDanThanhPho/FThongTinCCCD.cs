using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCCCD : MoveForm
    {
        private KhaiSinhDAO khaiSinhDAO;
        private HoKhauDAO hoKhauDAO;
        private CCCDDAO cCCDDAO;
        private CongDan congDan;
        private HinhDaiDien hinhCongDan;

        public FThongTinCCCD(CongDan congDan)
        {
            InitializeComponent();
            khaiSinhDAO = new KhaiSinhDAO();
            hoKhauDAO = new HoKhauDAO();
            cCCDDAO = new CCCDDAO();
            StackForm.Add(this);
            this.congDan = congDan;
            hinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
        }

        // Hiển thị thông tin lấy từ class công dân
        private void HienThiCongDan()
        {
            lblCCCD.Text = congDan.CCCD;
            lblTen.Text = congDan.Ten.ToUpper();
        }

        // Hiển thị thông tin lấy từ class khai sinh
        private void HienThiKhaiSinh()
        {
            KhaiSinh ks = khaiSinhDAO.LayThongTin(lblCCCD.Text);
            if (ks.MaKhaiSinh != "unknow")
            {
                if (ks.GioiTinh == "m")
                    lblGioiTinh.Text = "Nam";
                else lblGioiTinh.Text = "Nữ";
                lblNgaySinh.Text = ks.NgaySinh.ToString("dd/MM/yyyy");
                lblQueQuan.Text = ks.QueQuan.toString();
                lblQuocTich.Text = ks.QuocTich;
            }
        }

        // Hiển thị thông tin lấy từ class hộ khẩu
        private void HienThiHoKhau()
        {
            HoKhau hk = hoKhauDAO.LayThongTin(congDan.MaHoKhau);
            if (hk.MaHoKhau != "unknow")
            {
                lblDiaChi.Text = hk.DiaChi.toString();
            }
        }
        
        // Hiển thị thông tin láy từ class CCCD
        private void HienThiCCCD()
        {
            CCCD cCCD = cCCDDAO.LayThongTin(new CCCD(congDan.CCCD, DateTime.Now, "unknow"));
            if (cCCD.MaCCCD != "unknow")
            {
                lblNgayCap.Text = ((DateTime)cCCD.NgayCap).ToString("dd/MM/yyyy");
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
            hinhCongDan.LayHinhDaiDien(lblCCCD.Text, ptcHinhDaiDien);
        }

    }
}
