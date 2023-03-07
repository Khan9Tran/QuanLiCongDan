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
            return conn.LayDanhSach("SELECT MaHK as 'Mã hộ khẩu', DiaChi as 'Địa chỉ', CCCDChuHo as 'CCCD của chủ hộ' FROM HOKHAU");
        }
        public HoKhau LayThongTin(string maHoKhau)
        {
            string sqlStr = string.Format("SELECT * FROM HOKHAU WHERE MaHK = '{0}'", maHoKhau);
            return conn.LayThongTinHoKhau(sqlStr);
        }
    }
}
