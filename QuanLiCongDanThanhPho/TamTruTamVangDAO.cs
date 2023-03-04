using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class TamTruTamVangDAO
    {
        DBConnection conn = new DBConnection();
        public DataTable LayDanhSachTamTru()
        {
            return conn.LayDanhSach("SELECT * FROM TAMTRUTAMVANG WHERE TrangThai = N'Tạm trú'");
        }
        public DataTable LayDanhSachTamVang()
        {
            return conn.LayDanhSach("SELECT * FROM TAMTRUTAMVANG WHERE TrangThai = N'Tạm vắng'");
        }
    }
}
