using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class HonNhan
    {
        private CongDan vo;
        private CongDan chong;
        private DiaChi noiDangKy;
        private DateTime ngayDangKy;
        private string maSo;

        public HonNhan() {
            vo = new CongDan();
            chong = new CongDan();
            noiDangKy = new DiaChi();
            ngayDangKy = DateTime.Now;
            maSo = "";
        }
        public HonNhan(CongDan vo, CongDan chong, DiaChi noiDangKy, DateTime ngayDangKy, string maSo)
        {
            this.vo = vo;
            this.chong = chong;
            this.noiDangKy = noiDangKy;
            this.ngayDangKy = ngayDangKy;
            this.maSo = maSo;
        }

        public DateTime NgayDangKy { get => ngayDangKy; set => ngayDangKy = value; }
        public string MaSo { get => maSo; set => maSo = value; }
        internal CongDan Vo { get => vo; set => vo = value; }
        internal CongDan Chong { get => chong; set => chong = value; }
        internal DiaChi NoiDangKy { get => noiDangKy; set => noiDangKy = value; }
    }
}
