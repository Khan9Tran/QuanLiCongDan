using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class KhaiSinh
    {
        private string gioiTinh;
        private string quocTich;
        private string danToc;
        private DateTime ngaySinh;
        private DateTime ngayDangKy;
        private DiaChi noiSinh;
        private string queQuan;
        private CongDan cha;
        private CongDan me;

        public KhaiSinh(string gioiTinh, string quocTich, string danToc, DateTime ngaySinh, DateTime ngayDangKy, DiaChi noiSinh, string queQuan, CongDan cha, CongDan me)
        {
            this.gioiTinh = gioiTinh;
            this.quocTich = quocTich;
            this.danToc = danToc;
            this.ngaySinh = ngaySinh;
            this.ngayDangKy = ngayDangKy;
            this.noiSinh = noiSinh;
            this.queQuan = queQuan;
            this.cha = cha;
            this.me = me;
        }

        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayDangKy { get => ngayDangKy; set => ngayDangKy = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        internal DiaChi NoiSinh { get => noiSinh; set => noiSinh = value; }
        internal CongDan Cha { get => cha; set => cha = value; }
        internal CongDan Me { get => me; set => me = value; }
    }
}
