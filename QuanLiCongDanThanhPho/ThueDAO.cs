using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class ThueDAO
    {
        DBConnection conn = new DBConnection();
        public DataTable LayDanhSach()
        {
            return conn.LayDanhSach("SELECT MaThue, CCCD FROM THUE");
        }
        public void ThemThue(Thue thue)
        {
            string sqlStr = string.Format($"INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('{thue.MaThue}','{thue.CCCD}', '{thue.SoTienCanNop}','{thue.SoTienDaNop}', '{thue.NgayCapMa}', '{thue.HanNop}');");
            conn.ThucThi(sqlStr);
        }
    }
}
