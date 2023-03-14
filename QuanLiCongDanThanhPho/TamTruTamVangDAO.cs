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

        public DataTable LayDanhSach()
        {
            return conn.LayDanhSach("SELECT MaTTTV as 'Mã tạm trú/tạm vắng', CCCD, DiaChi as 'Địa chỉ', NgayBD as 'Ngày bắt đầu', NgayKT as 'Ngày kết thúc', TrangThai as 'Trạng thái', LiDo as 'Lí do' FROM TAMTRUTAMVANG");
        }
        public DataTable LayDanhSachTamTru(string tu)
        {
            return conn.LayDanhSach($"SELECT MaTTTV as 'Mã tạm trú', CCCD, DiaChi as 'Địa chỉ', NgayBD as 'Ngày bắt đầu', NgayKT as 'Ngày kết thúc', TrangThai as 'Trạng thái', LiDo as 'Lí do' FROM TAMTRUTAMVANG WHERE TrangThai = N'Tạm trú' AND (MaTTTV like '%{tu}%' OR CCCD like '%{tu}%' OR DiaChi like N'%{tu}%' OR Convert(varchar,Format(NgayBD, 'dd/MM/yyyy')) like '%{tu}%' OR Convert(varchar,Format(NgayKT, 'dd/MM/yyyy')) like '%{tu}%' OR TrangThai like N'%{tu}%' OR LiDo like N'%{tu}%')");
        }
        public DataTable LayDanhSachTamVang(string tu)
        {
            return conn.LayDanhSach($"SELECT MaTTTV as 'Mã tạm vắng', CCCD, DiaChi as 'Địa chỉ', NgayBD as 'Ngày bắt đầu', NgayKT as 'Ngày kết thúc', TrangThai as 'Trạng thái', LiDo as 'Lí do' FROM TAMTRUTAMVANG WHERE TrangThai = N'Tạm vắng' AND (MaTTTV like '%{tu}%' OR CCCD like '%{tu}%' OR DiaChi like N'%{tu}%' OR Convert(varchar,Format(NgayBD, 'dd/MM/yyyy')) like '%{tu}%' OR Convert(varchar,Format(NgayKT, 'dd/MM/yyyy')) like '%{tu}%' OR TrangThai like N'%{tu}%' OR LiDo like N'%{tu}%')");
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
            string strSql = string.Format($"SELECT MaTTTV as 'Mã tạm trú/tạm vắng', CCCD, DiaChi as 'Địa chỉ', NgayBD as 'Ngày bắt đầu', NgayKT as 'Ngày kết thúc', TrangThai as 'Trạng thái', LiDo as 'Lí do' FROM TAMTRUTAMVANG WHERE MaTTTV like '%{tu}%' OR CCCD like '%{tu}%' OR DiaChi like N'%{tu}%' OR Convert(varchar,Format(NgayBD, 'dd/MM/yyyy')) like '%{tu}%' OR Convert(varchar,Format(NgayKT, 'dd/MM/yyyy')) like '%{tu}%' OR TrangThai like N'%{tu}%' OR LiDo like N'%{tu}%'");
            return conn.LayDanhSach(strSql);
        }
    }
}
