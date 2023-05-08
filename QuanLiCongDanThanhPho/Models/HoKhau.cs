
namespace QuanLiCongDanThanhPho.Models
{
    internal class HoKhau
    {
        private string maHoKhau;
        private DiaChi diaChi;
        private string cCCDChuHo;

        public HoKhau()
        {
            cCCDChuHo = "unknow";
            diaChi= new DiaChi();
        }

        public HoKhau(string maHoKhau, string diaChi, string cCCDChuHo)
        {
            this.maHoKhau = maHoKhau;
            this.diaChi = new DiaChi();
            this.diaChi.DinhDang(diaChi);
            this.cCCDChuHo = cCCDChuHo;
        }

        public string MaHoKhau { get => maHoKhau; set => maHoKhau = value; }
        public string CCCDChuHo { get => cCCDChuHo; set => cCCDChuHo = value; }
        internal DiaChi DiaChi { get => diaChi; set => diaChi = value; }
    }
}
