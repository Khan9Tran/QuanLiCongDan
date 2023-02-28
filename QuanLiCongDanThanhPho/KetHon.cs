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

        public CongDan Vo { get { return vo; } }
        public CongDan Chong { get { return chong; } }
        public DiaChi NoiDangKy { get { return noiDangKy; } }
        public DateTime NgayDangKy { get { return ngayDangKy; } }
    }
}
