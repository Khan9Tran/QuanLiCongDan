using QuanLiCongDanThanhPho.Models;
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
        public HoKhauDAO() { }
        public void ThemHoKhau(HoKhau hK)
        {
            string sqlStr = string.Format($"INSERT INTO HOKHAU(MaHK,DiaChi,CCCDChuHo) VALUES('{hK.MaHoKhau}',N'{hK.DiaChi.toString()}', '{hK.CCCDChuHo}');");
            conn.ThucThi(sqlStr, "Tạo hộ khẩu mới thành công");
        }
        public DataTable LayDanhSach()
        {
            return conn.LayDanhSach("SELECT * FROM HOKHAU");
        }
    }
}
