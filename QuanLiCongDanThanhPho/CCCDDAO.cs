using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    internal class CCCDDAO
    {
        DBConnection conn = new DBConnection();
        public void ThemCCCD(CCCD canCuoc)
        {
            string sqlStr = string.Format($"INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('{canCuoc.MaCCCD}', N'{canCuoc.DacDiem}', '{canCuoc.NgayCap}');");
            conn.ThucThi(sqlStr, "Căn cước đã khởi tạo");
        }
    }
}
