using System.Data;
using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    internal class TamTruTamVangDAO
    {
        //Lấy kết nối
        DBConnection conn = new DBConnection();

        //Chuỗi đặt bí danh cho các thuộc tính trong sql
        private string DatTenThuocTinh()
        {
            string str = " MaTTTV as 'Mã tạm trú/tạm vắng', CCCD, DiaChi as 'Địa chỉ', NgayBD as 'Ngày bắt đầu', NgayKT as 'Ngày kết thúc', TrangThai as 'Trạng thái', LiDo as 'Lí do' ";
            return str;
        }

        public string ChuoiLayDanhSachTheoTu(string tu)
        {
            string str = string.Format($"SELECT " + DatTenThuocTinh() + $" FROM TAMTRUTAMVANG WHERE (MaTTTV like '%{tu}%' OR CCCD like '%{tu}%' OR DiaChi like N'%{tu}%' OR Convert(varchar,Format(NgayBD, 'dd/MM/yyyy')) like '%{tu}%' OR Convert(varchar,Format(NgayKT, 'dd/MM/yyyy')) like '%{tu}%' OR TrangThai like N'%{tu}%' OR LiDo like N'%{tu}%')");
            return str;
        }

        public string ChuoiDemSoLuong()
        {
            string str = string.Format("SELECT COUNT(*) as COUNT FROM TAMTRUTAMVANG");
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

        public DataTable LayDanhSachChoDuyet(string tu)
        {
            string sqlStr = ChuoiLayDanhSachTheoTu(tu) + " AND (TrangThai = N'CDTT' OR TrangThai = N'CDTV')";
            return conn.LayDanhSach(sqlStr);
        }

        public bool ThemTamTruTamVang(TamTruTamVang tTTV)
        {
            string sqlStr = string.Format($"INSERT INTO TAMTRUTAMVANG(MaTTTV, CCCD, DiaChi, NgayBD, NgayKT, TrangThai, LiDo) VALUES('{tTTV.MaSo}','{tTTV.CCCD}',N'{tTTV.DiaChi.toString()}' ,'{tTTV.NgayBatDau}', '{tTTV.NgayKetThuc}', N'{tTTV.TrangThai}', N'{tTTV.LyDo}' );");
            return conn.ThucThi(sqlStr);
        }
        public bool XoaTamTruTamVang(string canCuoc)
        {
            string sqlStr = string.Format($"DELETE FROM TAMTRUTAMVANG WHERE CCCD = '{canCuoc}'");
            return conn.ThucThi(sqlStr);
        }
        public Boolean KiemTraTamTruTamVang(string maCCCD)
        {
            string sqlStr = ChuoiDemSoLuong() + $" WHERE CCCD = '{maCCCD}'"; 
            return conn.KiemTraCoKhong(sqlStr);
        }
        public TamTruTamVang LayThongTin(string maCCCD)
        {
            string sqlStr = string.Format("SELECT * FROM TAMTRUTAMVANG WHERE CCCD = '{0}'", maCCCD);
            return conn.LayThongTinTamTruTamVang(sqlStr);
        }

        public TamTruTamVang LayThongTinTheoMaSo(string maSo)
        {
            string sqlStr = string.Format("SELECT * FROM TAMTRUTAMVANG WHERE MaTTTV = '{0}'", maSo);
            return conn.LayThongTinTamTruTamVang(sqlStr);
        }
        public DataTable LayDanhSachChuaTu(string tu)
        {
            string sqlStr = ChuoiLayDanhSachTheoTu(tu);
            return conn.LayDanhSach(sqlStr);
        }
        public int LaySoLuongTamTru()
        {
            return LaySoLuong(ChuoiDemSoLuong() + " WHERE TrangThai = N'Tạm trú'");
        }
        public int LaySoLuongTamVang()
        {
            return LaySoLuong(ChuoiDemSoLuong() + " WHERE TrangThai = N'Tạm vắng'");
        }
        public DataTable LayDanhSachQuaHan(string tu)
        {
            string sqlStr = ChuoiLayDanhSachTheoTu(tu) + " AND GETDATE() > NgayKT";
            return conn.LayDanhSach(sqlStr);
        }
        public int LaySoLuongQuaHanTamTru()
        {
            return LaySoLuong(ChuoiDemSoLuong() + " WHERE TrangThai = N'Tạm trú' AND GETDATE() > NgayKT");
     
        }
        public int LaySoLuongQuaHanTamVang()
        {
            return LaySoLuong(ChuoiDemSoLuong() + " WHERE TrangThai = N'Tạm vắng' AND GETDATE() > NgayKT");
        }
        public int LaySoLuong(string sqlStr)
        {
            DataTable dt = conn.LayDanhSach(sqlStr);
            int count = dt.Rows[0].Field<int>("COUNT");
            return count;
        }
        public void CapNhat(TamTruTamVang tTTV)
        {
            string strSql = string.Format($"UPDATE TAMTRUTAMVANG SET MaTTTV = '{tTTV.MaSo}', CCCD = '{tTTV.CCCD}', DiaChi = N'{tTTV.DiaChi.toString()}', NgayBD = '{tTTV.NgayBatDau}', NgayKT = '{tTTV.NgayKetThuc}', TrangThai = N'{tTTV.TrangThai}', LiDo = N'{tTTV.LyDo}' WHERE MaTTTV = '{tTTV.MaSo}' OR CCCD = '{tTTV.CCCD}'");
            conn.ThucThi(strSql);
        }
    }
}
