using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class HoKhauDAO
    {
        DBConnection conn = new DBConnection();
        public DataTable LayDanhSach()
        {
            return conn.LayDanhSach("SELECT * FROM HOKHAU");
        }
    }
}
