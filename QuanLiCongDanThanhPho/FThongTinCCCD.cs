using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCCCD : Form
    {
        KhaiSinhDAO khaiSinhDAO;
        HoKhauDAO hoKhauDAO;
        CCCDDAO cCCDDAO;
        private CongDan congDan;

        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        private void KhoiTao()
        {
            khaiSinhDAO = new KhaiSinhDAO();
            hoKhauDAO = new HoKhauDAO();
            cCCDDAO = new CCCDDAO();
            StackForm.Add(this);
        }

        public FThongTinCCCD()
        {
            InitializeComponent();
            KhoiTao();
        }

        public FThongTinCCCD(CongDan congDan)
        {
            InitializeComponent();
            KhoiTao();
            this.congDan = congDan;
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
            if (ks.GioiTinh == "m")
                lblGioiTinh.Text = "Nam";
            else lblGioiTinh.Text = "Nữ";
            lblNgaySinh.Text = ks.NgaySinh.ToString("dd/MM/yyyy");
            lblQueQuan.Text = ks.QueQuan.toString();
            lblQuocTich.Text = ks.QuocTich;
        }

        // Hiển thị thông tin lấy từ class hộ khẩu
        private void HienThiHoKhau()
        {
            HoKhau hk = hoKhauDAO.LayThongTin(congDan.MaHoKhau);
            lblDiaChi.Text = hk.DiaChi.toString();
        }
        
        // Hiển thị thông tin láy từ class CCCD
        private void HienThiCCCD()
        {
            CCCD cCCD = cCCDDAO.LayThongTin(new CCCD(congDan.CCCD, DateTime.Now, "unknow"));
            lblNgayCap.Text = ((DateTime)cCCD.NgayCap).ToString("dd/MM/yyyy");
            lblDDNhanDang.Text = cCCD.DacDiem;
        }

        private void HienThiThongTin()
        {
            HienThiCongDan();
            HienThiKhaiSinh();
            HienThiHoKhau();
            HienThiCCCD();
        }

        private void GanHinh(string filename)
        {
            Bitmap bitmap = null;
            bitmap?.Dispose();
            ptcHinhDaiDien.Image?.Dispose();

            using (Bitmap tempImage = new Bitmap(filename, true)) //Giúp k bị lỗi không thể truy cập file đang hoạt động khi xóa
            {
                bitmap = new Bitmap(tempImage);
                ptcHinhDaiDien.Image = bitmap;
            }
        }

        //Lấy hình công dân từ folder HinhCongDan
        private void LayHinhDaiDien()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\..\HinhCongDan"));
            string imagePath = string.Format(@$"{folderPath}\{lblCCCD.Text}");
            string png = imagePath + ".png";
            string jpg = imagePath + ".jpg";
            if (File.Exists(png))
            {
                GanHinh(png);
            }
            else if (File.Exists(jpg))
            {
                GanHinh(jpg);
            }
        }

        private void FThongTinCCCD_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            LayHinhDaiDien();
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
    }
}
