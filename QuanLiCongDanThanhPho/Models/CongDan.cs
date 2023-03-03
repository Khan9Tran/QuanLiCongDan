using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class CongDan
    {
        private string cCCD;
        private string ten;
        private string ngheNghiep;
        private string sDT;
        private string tonGiao;
        private string maHoKhau;
        private string quanHeVoiChuHo;

        public CongDan(string cCCD, string ten, string ngheNghiep, string sDT, string tonGiao, string maHoKhau, string quanHeVoiChuHo)
        {
            this.cCCD = cCCD;
            this.ten = ten;
            this.ngheNghiep = ngheNghiep;
            this.sDT = sDT;
            this.tonGiao = tonGiao;
            this.maHoKhau = maHoKhau;
            this.quanHeVoiChuHo = quanHeVoiChuHo;
        }

        public string CCCD { get => cCCD; set => cCCD = value; }
        public string Ten { get => ten; set => ten = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
        public string MaHoKhau { get => maHoKhau; set => maHoKhau = value; }
        public string QuanHeVoiChuHo { get => quanHeVoiChuHo; set => quanHeVoiChuHo = value; }
    }
}