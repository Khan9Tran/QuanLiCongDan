using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Models;
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
        public void ThemTamTruTamVan(TamTruTamVang tTTV)
        {
            string sqlStr = string.Format($"INSERT INTO TAMTRUTAMVANG(MaTTTV, CCCD, DiaChi, NgayBD, NgayKT, TrangThai, LiDo) VALUES('{tTTV.MaSo}','{tTTV.CCCD}',N'{tTTV.DiaChi}' ,'{tTTV.NgayBatDau}', '{tTTV.NgayKetThuc}', N'{tTTV.TrangThai}', N'{tTTV.LyDo}' );");
            conn.ThucThi(sqlStr);
        }
    }
}
