using System.Data;
using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    internal class CCCDDAO
    {
        //Lấy kết nối
        DBConnection conn = new DBConnection();

        public bool ThemCCCD(CCCD canCuoc)
        {
            string sqlStr = string.Format($"INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('{canCuoc.MaCCCD}', N'{canCuoc.DacDiem}', '{canCuoc.NgayCap}');");
            return conn.ThucThi(sqlStr);
        }

        public bool XoaCCCD(string maCanCuoc) 
        {
            string sqlStr = string.Format($"DELETE FROM CCCD WHERE MaCCCD = '{maCanCuoc}'");
            return conn.ThucThi(sqlStr);
        }

        public bool CapNhatCCCD(CCCD canCuoc) 
        {
            string sqlStr = string.Format($"UPDATE CCCD SET DacDiem = N'{canCuoc.DacDiem}', NgayCap = '{canCuoc.NgayCap}' WHERE MaCCCD = '{canCuoc.MaCCCD}'");
            return conn.ThucThi(sqlStr);
        }

        public DataTable DanhSachCCCDTheoDacDiem(string dacDiem)
        {
            string sqlStr = string.Format($"SELECT CCCD.MaCCCD as 'CCCD', CONGDAN.Ten as 'Tên' FROM CCCD INNER JOIN CONGDAN ON CCCD.MaCCCD = CONGDAN.CCCD WHERE DacDiem = N'{dacDiem}' or DacDiem is NULL");
            return conn.LayDanhSach(sqlStr);
        }

        public CCCD LayThongTin(CCCD cCCD)
        {
            string sqlStr = string.Format($"SELECT * FROM CCCD WHERE MaCCCD = '{cCCD.MaCCCD}'");
            return conn.LayThongTinCCCD(sqlStr);
        }

        public CCCD LayThongTin(string cCCD)
        {
            string sqlStr = string.Format($"SELECT * FROM CCCD WHERE MaCCCD = '{cCCD}'");
            return conn.LayThongTinCCCD(sqlStr);
        }

        //Sử dụng để lấy CCCD trên DataGridView
        static public string GetCCCD(DataGridView gvDanhSach, int index)
        {
            var value = gvDanhSach.CurrentRow.Cells[index].Value;
            if (value.ToString() != "")
                return (string)value;
            return "";
        }
    }
}
