using System.Data;
using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    internal class CCCDDAO
    {
        DBConnection conn = new DBConnection();
        public bool ThemCCCD(CCCD canCuoc)
        {
            string sqlStr = string.Format($"INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('{canCuoc.MaCCCD}', N'{canCuoc.DacDiem}', '{canCuoc.NgayCap}');");
            return conn.ThucThi(sqlStr);
            //"Căn cước đã khởi tạo"
        }
        public bool XoaCCCD(string maCanCuoc) 
        {
            string sqlStr = string.Format($"DELETE FROM CCCD WHERE MaCCCD = '{maCanCuoc}'");
            return conn.ThucThi(sqlStr);
            //"Xóa căn cước thành công"
        }
        public bool CapNhatCCCD(CCCD canCuoc) 
        {
            string sqlStr = string.Format($"UPDATE CCCD SET DacDiem = N'{canCuoc.DacDiem}', NgayCap = '{canCuoc.NgayCap}' WHERE MaCCCD = '{canCuoc.MaCCCD}'");
            return conn.ThucThi(sqlStr);
        }
        public DataTable DanhSachCCCDTheoDacDiem(string dacDiem)
        {
            string sqlStr = string.Format($"SELECT CCCD.MaCCCD, CONGDAN.Ten FROM CCCD INNER JOIN CONGDAN ON CCCD.MaCCCD = CONGDAN.CCCD WHERE DacDiem = N'{dacDiem}'");
            return conn.LayDanhSach(sqlStr);
        }
        public CCCD LayThongTin(CCCD cCCD)
        {
            string sqlStr = string.Format($"SELECT * FROM CCCD WHERE MaCCCD = '{cCCD.MaCCCD}'");
            return conn.LayThongTinCCCD(sqlStr);
        }
        static public string GetCCCD(DataGridView gvDanhSach, int index)
        {
            return (string)gvDanhSach.CurrentRow.Cells[index].Value;
        }
    }
}
