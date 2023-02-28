using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class Thue
    {
        private string maThue;
        private string coQuanQuanLy;
        private DateTime ngayCapMa;
        private DateTime hanNop;
        private string soTien;

        public string MaThue { get { return maThue; } }
        public string CoQuanQuanLy { get { return coQuanQuanLy; } }
        public DateTime HanNop { get { return hanNop; } }
        public string SoTien { get { return soTien; } }
        public DateTime NgayCapMa { get { return ngayCapMa; } }
    }
}
