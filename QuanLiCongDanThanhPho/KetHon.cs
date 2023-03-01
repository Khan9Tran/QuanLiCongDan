using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class KetHon
    {
        private CongDan vo;
        private CongDan chong;
        private DiaChi noiDangKy;
        private DateTime ngayDangKy;

        public KetHon(CongDan vo, CongDan chong, DiaChi noiDangKy, DateTime ngayDangKy)
        {
            this.vo = vo;
            this.chong = chong;
            this.noiDangKy = noiDangKy;
            this.ngayDangKy = ngayDangKy;
        }

        public DateTime NgayDangKy { get => ngayDangKy; set => ngayDangKy = value; }
        internal CongDan Vo { get => vo; set => vo = value; }
        internal CongDan Chong { get => chong; set => chong = value; }
        internal DiaChi NoiDangKy { get => noiDangKy; set => noiDangKy = value; }
    }
}
