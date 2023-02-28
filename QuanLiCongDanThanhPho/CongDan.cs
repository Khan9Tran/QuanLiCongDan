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
        private string tonGiao;
        private KhaiSinh khaiSinh;
        private HoKhau hoKhau;
        private Thue thueTNCN;
        private string ngheNghiep;
        private string soDienThoai;
        private TamTruTamVang tamTruTamVang;
        
        public string MaCccd { get { return maCccd; } }
        public string HoTen { get { return hoTen; } }
        public string TonGiao { get { return tonGiao; } }
        public Thue ThueTNCN { get { return thueTNCN;} }
        public string NgheNghiep { get { return ngheNghiep;} }
        public string SoDienThoai { get { return soDienThoai;} }
        public TamTruTamVang TamTruTamVang { get { return tamTruTamVang; } }
        public KhaiSinh GiayKhaiSinh { get { return khaiSinh;} }
        public HoKhau SoHoKhau { get { return hoKhau; } }
    }
}
