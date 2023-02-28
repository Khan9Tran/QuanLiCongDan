using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class KhaiSinh
    {
        private string maDinhDanh;
        private string hoTen;
        private string gioiTinh;
        private string quocTich;
        private string danToc;
        private DateTime ngaySinh;
        private DateTime ngayDangKy;
        private DiaChi noiSinh;
        private string queQuan;
        private CongDan cha;
        private CongDan me;

        public string MaDinhDanh { get { return maDinhDanh; } }
        public string HoTen { get { return hoTen; } }
        public string GioiTinh { get { return gioiTinh; } }
        public string QuocTich { get { return quocTich; } }
        public string DanToc { get { return danToc; } }
        public DateTime NgaySinh { get { return ngaySinh; } }
        public DateTime NgayDangKy { get { return ngayDangKy; } }
        public DiaChi NoiSinh { get { return noiSinh; } }
        public string QueQuan { get { return queQuan; } }
        public CongDan Cha { get { return cha; } }
        public CongDan Me { get { return me; } }
    }
}
