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
        private string cCCD;
        private string coQuanQuanLy;
        private DateTime ngayCapMa;
        private DateTime hanNop;
        private string soTienCanNop;
        private string soTienDaNop;

        public Thue(string maThue, string cCCD, string coQuanQuanLy, DateTime ngayCapMa, DateTime hanNop, string soTienCanNop, string soTienDaNop)
        {
            this.maThue = maThue;
            this.cCCD = cCCD;
            this.coQuanQuanLy = coQuanQuanLy;
            this.ngayCapMa = ngayCapMa;
            this.hanNop = hanNop;
            this.soTienCanNop = soTienCanNop;
            this.soTienDaNop = soTienDaNop;
        }

        public string MaThue { get => maThue; set => maThue = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string CoQuanQuanLy { get => coQuanQuanLy; set => coQuanQuanLy = value; }
        public DateTime NgayCapMa { get => ngayCapMa; set => ngayCapMa = value; }
        public DateTime HanNop { get => hanNop; set => hanNop = value; }
        public string SoTienCanNop { get => soTienCanNop; set => soTienCanNop = value; }
        public string SoTienDaNop { get => soTienDaNop; set => soTienDaNop = value; }
    }
}
