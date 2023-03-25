using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using QuanLiCongDanThanhPho.Models;
namespace QuanLiCongDanThanhPho
{
    internal class TamTruTamVangDAO
    {
        DBConnection conn = new DBConnection();

        public DataTable LayDanhSach()
        {
            return conn.LayDanhSach("SELECT MaTTTV as 'Mã tạm trú/tạm vắng', CCCD, DiaChi as 'Địa chỉ', NgayBD as 'Ngày bắt đầu', NgayKT as 'Ngày kết thúc', TrangThai as 'Trạng thái', LiDo as 'Lí do' FROM TAMTRUTAMVANG");
        }
        public string ChuoiLayDanhSachTheoTu(string tu)
        {
            string str = string.Format($"SELECT MaTTTV as 'Mã', CCCD, DiaChi as 'Địa chỉ', NgayBD as 'Ngày bắt đầu', NgayKT as 'Ngày kết thúc', TrangThai as 'Trạng thái', LiDo as 'Lí do' FROM TAMTRUTAMVANG WHERE (MaTTTV like '%{tu}%' OR CCCD like '%{tu}%' OR DiaChi like N'%{tu}%' OR Convert(varchar,Format(NgayBD, 'dd/MM/yyyy')) like '%{tu}%' OR Convert(varchar,Format(NgayKT, 'dd/MM/yyyy')) like '%{tu}%' OR TrangThai like N'%{tu}%' OR LiDo like N'%{tu}%')");
            return str;
        }
        public DataTable LayDanhSachTamTru(string tu)
        {
            string sqlStr = ChuoiLayDanhSachTheoTu(tu) + " AND TrangThai = N'Tạm trú'";
            return conn.LayDanhSach(sqlStr);
        }
        public DataTable LayDanhSachTamVang(string tu)
        {
            string sqlStr = ChuoiLayDanhSachTheoTu(tu) + " AND TrangThai = N'Tạm vắng'";
            return conn.LayDanhSach(sqlStr);
        }
        public void ThemTamTruTamVang(TamTruTamVang tTTV)
        {
            string sqlStr = string.Format($"INSERT INTO TAMTRUTAMVANG(MaTTTV, CCCD, DiaChi, NgayBD, NgayKT, TrangThai, LiDo) VALUES('{tTTV.MaSo}','{tTTV.CCCD}',N'{tTTV.DiaChi.toString()}' ,'{tTTV.NgayBatDau}', '{tTTV.NgayKetThuc}', N'{tTTV.TrangThai}', N'{tTTV.LyDo}' );");
            conn.ThucThi(sqlStr, "Thêm tạm vắng/tạm trú thành công");   
        }
        public void XoaTamTruTamVang(string canCuoc)
        {
            string sqlStr = string.Format($"DELETE FROM TAMTRUTAMVANG WHERE CCCD = '{canCuoc}'");
            conn.ThucThi(sqlStr, "Xóa tạm vắng/tạm trú thành công");
        }
        public Boolean KiemTraTamTruTamVang(string maCCCD)
        {
            string sqlStr = string.Format("SELECT COUNT(*) as COUNT FROM TAMTRUTAMVANG WHERE CCCD = '{0}'", maCCCD);
            return conn.KiemTraCoKhong(sqlStr);
        }
        public TamTruTamVang LayThongTin(string maCCCD)
        {
            string sqlStr = string.Format("SELECT * FROM TAMTRUTAMVANG WHERE CCCD = {0}", maCCCD);
            return conn.LayThongTinTamTruTamVang(sqlStr);
        }
        public DataTable LayDanhSachChuaTu(string tu)
        {
            string sqlStr = ChuoiLayDanhSachTheoTu(tu);
            return conn.LayDanhSach(sqlStr);
        }
        public int LaySoLuongTamTru()
        {
            string sqlStr = string.Format($"SELECT COUNT(*) as SoLuong FROM TAMTRUTAMVANG WHERE TrangThai = N'Tạm trú'");
            DataTable dt = conn.LayDanhSach(sqlStr);
            int count = dt.Rows[0].Field<int>("SoLuong");
            return count;
        }
        public int LaySoLuongTamVang()
        {
            string sqlStr = string.Format($"SELECT COUNT(*) as SoLuong FROM TAMTRUTAMVANG WHERE TrangThai = N'Tạm vắng");
            DataTable dt = conn.LayDanhSach(sqlStr);
            int count = dt.Rows[0].Field<int>("SoLuong");
            return count;
        }
        public DataTable LayDanhSachQuaHan(string tu)
        {
            string sqlStr = ChuoiLayDanhSachTheoTu(tu) + " AND GETDATE() > NgayKT";
            return conn.LayDanhSach(sqlStr);
        }
    }
}
