using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class HoKhau
    {
        private string maHoKhau;
        private DiaChi diaChi;
        private string cCCDChuHo;
        private string quanHeVoiChuHo;

        public HoKhau(string maHoKhau, string diaChi, string cCCDChuHo, string quanHeVoiChuHo)
        {
            this.maHoKhau = maHoKhau;
            this.diaChi = new DiaChi();
            this.diaChi.DinhDang(diaChi);
            this.cCCDChuHo = cCCDChuHo;
            this.quanHeVoiChuHo = quanHeVoiChuHo;
        }
        public HoKhau(string maHoKhau)
        {
            this.maHoKhau = maHoKhau;
            this.diaChi = new DiaChi();
            this.quanHeVoiChuHo = "";
        }

        public string MaHoKhau { get => maHoKhau; set => maHoKhau = value; }
        public string CCCDChuHo { get => cCCDChuHo; set => cCCDChuHo = value; }
        public string QuanHeVoiChuHo { get => quanHeVoiChuHo; set => quanHeVoiChuHo = value; }
        internal DiaChi DiaChi { get => diaChi; set => diaChi = value; }
    }
}
