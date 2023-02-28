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
        private QuanHeVoiChuHo[] quanHeVoiChuHo;

        public string MaHoKhau { get { return maHoKhau;} }
        public DiaChi DiaChi { get { return diaChi; } }
        public CongDan ChuHo { get { return chuHo; } }
        public QuanHeVoiChuHo[] QHeVoiChuHo { get { return quanHeVoiChuHo; } }

    }
}
