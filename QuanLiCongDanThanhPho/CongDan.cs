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
        private KhaiSinh khaiSinh;
        private string maHoKhau;
        private string maThue;
        private TamTruTamVang tamTruTamVang;
        private KetHon ketHon;

        public CongDan(string maCccd, string hoTen, string ngheNghiep, string soDienThoai, string tonGiao,KhaiSinh khaiSinh, string maHoKhau, string maThue, TamTruTamVang tamTruTamVang, KetHon ketHon)
        {
            this.maCccd = maCccd;
            this.hoTen = hoTen;
            this.ngheNghiep = ngheNghiep;
            this.soDienThoai = soDienThoai;
            this.khaiSinh = khaiSinh;
            this.maHoKhau = maHoKhau;
            this.maThue = maThue;
            this.tamTruTamVang = tamTruTamVang;
            this.ketHon = ketHon;
            this.tonGiao = tonGiao;
        }

        public string MaCccd { get => maCccd; set => maCccd = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string MaHoKhau { get => maHoKhau; set => maHoKhau = value; }
        public string MaThue { get => maThue; set => maThue = value; }
        internal KhaiSinh KhaiSinh { get => khaiSinh; set => khaiSinh = value; }
        internal TamTruTamVang TamTruTamVang { get => tamTruTamVang; set => tamTruTamVang = value; }
        internal KetHon KetHon { get => ketHon; set => ketHon = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
    }
}