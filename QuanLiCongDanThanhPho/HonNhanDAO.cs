using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class HonNhanDAO
    {
        DBConnection conn = new DBConnection();
        void ThemHonNhan(HonNhan hN)
        {
            string sqlStr = string.Format($"INSERT INTO HONNHAN(MaHonNhan, CCCDNam, TenNam, CCCDNu, TenNu, NoiDangKy, NgayDangKy) VALUES('{hN.MaSo}','{hN.CCCDChong}',N'{hN.TenChong}','{hN.CCCDVo}',N'{hN.TenVo}',N'{hN.NoiDangKy}','{hN.NgayDangKy}');");
            conn.ThucThi(sqlStr,"Thêm hôn nhân thành công");
        }
    }
}
