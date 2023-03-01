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
        private KhaiSinh khaiSinh;
        private HoKhau hoKhau;
        private Thue thueTNCN;
        private TamTruTamVang tamTruTamVang;
        private KetHon ketHon;

        public CongDan(string maCccd, string hoTen, string ngheNghiep, string soDienThoai, KhaiSinh khaiSinh, HoKhau hoKhau, Thue thueTNCN, TamTruTamVang tamTruTamVang, KetHon ketHon)
        {
            this.maCccd = maCccd;
            this.hoTen = hoTen;
            this.ngheNghiep = ngheNghiep;
            this.soDienThoai = soDienThoai;
            this.khaiSinh = khaiSinh;
            this.hoKhau = hoKhau;
            this.thueTNCN = thueTNCN;
            this.tamTruTamVang = tamTruTamVang;
            this.ketHon = ketHon;
        }

        public string MaCccd { get => maCccd; set => maCccd = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        internal KhaiSinh KhaiSinh { get => khaiSinh; set => khaiSinh = value; }
        internal HoKhau HoKhau { get => hoKhau; set => hoKhau = value; }
        internal Thue ThueTNCN { get => thueTNCN; set => thueTNCN = value; }
        internal TamTruTamVang TamTruTamVang { get => tamTruTamVang; set => tamTruTamVang = value; }
        internal KetHon KetHon { get => ketHon; set => ketHon = value; }
    }
}