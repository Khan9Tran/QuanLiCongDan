using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho.Models
{
    internal class Thue
    {
        private string maThue;
        private string coQuanQuanLy;
        private DateTime ngayCapMa;
        private DateTime hanNop;
        private string soTien;
        public Thue(string maThue)
        {
            this.maThue = maThue;
            coQuanQuanLy = "";
            ngayCapMa = DateTime.Now;
            hanNop = DateTime.Now;
            soTien = "";
        }
        public Thue(string maThue, string coQuanQuanLy, DateTime ngayCapMa, DateTime hanNop, string soTien)
        {
            this.maThue = maThue;
            this.coQuanQuanLy = coQuanQuanLy;
            this.ngayCapMa = ngayCapMa;
            this.hanNop = hanNop;
            this.soTien = soTien;
        }

        public string MaThue { get => maThue; set => maThue = value; }
        public string CoQuanQuanLy { get => coQuanQuanLy; set => coQuanQuanLy = value; }
        public DateTime NgayCapMa { get => ngayCapMa; set => ngayCapMa = value; }
        public DateTime HanNop { get => hanNop; set => hanNop = value; }
        public string SoTien { get => soTien; set => soTien = value; }
    }
}
