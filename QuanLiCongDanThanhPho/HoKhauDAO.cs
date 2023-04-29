using QuanLiCongDanThanhPho.Models;
using System.Data;

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

        // Lấy chuỗi đặt bí danh cho các thuộc tính trong sql
        private string DatTenThuocTinh()
        {
            string str = " HOKHAU.MaHK as 'Mã hộ khẩu', DiaChi as 'Địa chỉ', CCCDChuHo as 'CCCD của chủ hộ' ";
            return str;
        }
        // Lấy chuổi điều kiện giá trị chứa từ tìm kiếm
        private string ChuoiChuaTu(string tu)
        {
            string str = $" DiaChi like N'%{tu}%' OR CCCDChuHo like '%{tu}%' OR HOKHAU.MaHK like '%{tu}%' ";
            return str;
        }
        // Lấy chuổi điều kiện giá trị MaHK là 00000A hoặc 00000B
        private string ChuoiDieuKien()
        {
            string str = " MaHK like '00000A' OR MaHK like '00000B' ";
            return str;
        }

        public HoKhau LayThongTin(string maHoKhau)
        {
            string sqlStr = string.Format("SELECT * FROM HOKHAU WHERE MaHK = '{0}'", maHoKhau);
            return conn.LayThongTinHoKhau(sqlStr);
        }
        public DataTable LayDanhSachChuaTu(string tu)
        {
            string sqlStr = string.Format("SELECT " + DatTenThuocTinh() + " FROM HOKHAU WHERE " + ChuoiChuaTu(tu) + " EXCEPT SELECT " + DatTenThuocTinh() + " FROM HOKHAU WHERE " + ChuoiDieuKien());
            return conn.LayDanhSach(sqlStr);
        }
        public DataTable LayDanhSachXepTheoSoTV(string tu)
        {
            string sqlStr = string.Format("SELECT " + DatTenThuocTinh() + $", SL FROM (SELECT * FROM HOKHAU EXCEPT SELECT * FROM HOKHAU WHERE " + DatTenThuocTinh() + ") as HOKHAU INNER JOIN (SELECT MaHK, count(CCCD) as SL FROM CONGDAN GROUP BY MaHK) as SLCONGDAN ON HOKHAU.MaHK = SLCONGDAN.MaHK WHERE " + ChuoiChuaTu(tu) + " ORDER BY SL ASC");
            DataTable ds = conn.LayDanhSach(sqlStr);
            ds.Columns.Remove("SL");
            return ds;
        }
        public void CapNhatHoKhau(HoKhau hK)
        {
            string sqlStr = string.Format($"UPDATE HOKHAU SET DiaChi = N'{hK.DiaChi.toString()}', CCCDChuHo = '{hK.CCCDChuHo}' WHERE MaHK = '{hK.MaHoKhau}'");
            conn.ThucThi(sqlStr, $"Cập nhật hộ khẩu thành công");
        }
        public void XoaHoKhau(HoKhau hK)
        {
            string sqlStr = string.Format($"DELETE HOKHAU WHERE MaHK = '{hK.MaHoKhau}'");
            conn.ThucThi(sqlStr, "Đã xóa hộ không còn thành viên");
        }

        public DataTable TimHoNhieuNguoiNhat()
        {
            string sqlStr = string.Format("SELECT MaHK as 'Mã hộ', count(CCCD) as 'Số lượng' FROM CONGDAN GROUP BY MaHK HAVING count(CCCD) = (SELECT max(SL) FROM (SELECT count(CCCD) as SL FROM CONGDAN WHERE MaHK != '00000B' AND MaHK != '00000A' GROUP BY MaHK) as A)");
            return conn.LayDanhSach(sqlStr);
        }
    }
}
