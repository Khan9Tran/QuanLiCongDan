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
        private CongDan chuHo;
        private List<QuanHeVoiChuHo> quanHeVoiChuHo;

        public HoKhau(string maHoKhau, DiaChi diaChi, CongDan chuHo, List<QuanHeVoiChuHo> quanHeVoiChuHo)
        {
            this.MaHoKhau = maHoKhau;
            this.DiaChi = diaChi;
            this.ChuHo = chuHo;
            this.QuanHeVoiChuHo = quanHeVoiChuHo;
        }

        public string MaHoKhau { get => maHoKhau; set => maHoKhau = value; }
        internal DiaChi DiaChi { get => diaChi; set => diaChi = value; }
        internal CongDan ChuHo { get => chuHo; set => chuHo = value; }
        internal List<QuanHeVoiChuHo> QuanHeVoiChuHo { get => quanHeVoiChuHo; set => quanHeVoiChuHo = value; }
    }
}
