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
        public DataTable LayDanhSachChuaTu(string tu)
        {
            string strSql = string.Format($"SELECT MaHK as 'Mã hộ khẩu', DiaChi as 'Địa chỉ', CCCDChuHo as 'CCCD của chủ hộ' FROM HOKHAU WHERE DiaChi like N'%{tu}%' OR CCCDChuHo like '%{tu}%' OR MaHK like '%{tu}%'");
            return conn.LayDanhSach(strSql);
        }
        public DataTable LayDanhSachXepTheoSoTV(string tu)
        {
            string strSql = string.Format($"SELECT HOKHAU.MaHK as 'Mã hộ khẩu', DiaChi as 'Địa chỉ', CCCDChuHo as 'CCCD của chủ hộ' FROM HOKHAU INNER JOIN (SELECT MaHK, count(CCCD) as SL FROM CONGDAN GROUP BY MaHK) AS CONGDAN ON HOKHAU.MaHK = CONGDAN.MAHK WHERE DiaChi like N'%{tu}%' OR CCCDChuHo like '%{tu}%' OR HOKHAU.MaHK like '%{tu}%' ORDER BY SL ASC");
            return conn.LayDanhSach(strSql);
        }
    }
}
