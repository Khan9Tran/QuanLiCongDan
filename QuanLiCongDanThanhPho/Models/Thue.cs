
namespace QuanLiCongDanThanhPho.Models
{
    internal class Thue
    {
        private string maThue;
        private string cCCD;
        private DateTime ngayCapMa;
        private DateTime hanNop;
        private string soTienCanNop;
        private string soTienDaNop;

        private void GanMacDinh()
        {
            ngayCapMa = DateTime.Now;
            hanNop = DateTime.Now;
            soTienCanNop = "0";
            soTienDaNop = "0";
        }

        public Thue() 
        {
            GanMacDinh();
        }

        public Thue(string maThue, string cCCD, DateTime ngayCapMa, DateTime hanNop, string soTienCanNop, string soTienDaNop)
        {
            this.maThue = maThue;
            this.cCCD = cCCD;
            this.ngayCapMa = ngayCapMa;
            this.hanNop = hanNop;
            this.soTienCanNop = soTienCanNop;
            this.soTienDaNop = soTienDaNop;
        }

        public Thue(string maThue, string cCCD)
        {
            this.maThue = maThue;
            this.cCCD = cCCD;
            GanMacDinh();
        }

        public bool ThanhToan(int tien)
        {
            if (tien > int.Parse(this.soTienCanNop))
            {
                return false;
            }
            this.soTienCanNop = (int.Parse(this.soTienCanNop)-tien).ToString();
            int tongThu = int.Parse(this.soTienDaNop) + tien;
            this.soTienDaNop = tongThu.ToString();
            return true;
        }

        public string MaThue { get => maThue; set => maThue = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public DateTime NgayCapMa { get => ngayCapMa; set => ngayCapMa = value; }
        public DateTime HanNop { get => hanNop; set => hanNop = value; }
        public string SoTienCanNop { get => soTienCanNop; set => soTienCanNop = value; }
        public string SoTienDaNop { get => soTienDaNop; set => soTienDaNop = value; }
    }
}
