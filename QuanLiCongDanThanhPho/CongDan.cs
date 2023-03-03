using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class CongDan
    {
        private string maCccd;
        private string hoTen;
        private string ngheNghiep;
        private string soDienThoai;
        private string tonGiao;
        private string maHoKhau;

        public CongDan(string maCccd, string hoTen, string ngheNghiep, string soDienThoai, string tonGiao, string maHoKhau)
        {
            this.maCccd = maCccd;
            this.hoTen = hoTen;
            this.ngheNghiep = ngheNghiep;
            this.soDienThoai = soDienThoai;
            this.tonGiao = tonGiao;
            this.maHoKhau = maHoKhau;
        }

        public string MaCccd { get => maCccd; set => maCccd = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
        public string MaHoKhau { get => maHoKhau; set => maHoKhau = value; }
    }
}