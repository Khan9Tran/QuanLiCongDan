using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Models;
using System.Data.SqlTypes;
using System.Data;

namespace QuanLiCongDanThanhPho
{
    internal class KhaiSinhDAO
    {
        DBConnection conn = new DBConnection();
        public string StringKhaiSinh(KhaiSinh kS)
        {
            string sqlStr = string.Format($"INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy, GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('{kS.MaKhaiSinh}' , N'{kS.HoTen}', '{kS.NgaySinh}','{kS.NgayDangKy}', '{kS.GioiTinh}', N'{kS.DanToc}', N'{kS.QuocTich}', N'{kS.NoiSinh.toString()}', N'{kS.QueQuan.toString()}','{kS.CCCDCha}', N'{kS.TenCha}', '{kS.CCCDMe}', N'{kS.TenMe}');");
            return sqlStr;
        }
        public void CapNhatKhaiSinh(KhaiSinh kS)
        {
            string sqlStr = string.Format($"UPDATE KHAISINH SET  Ten = N'{kS.HoTen}', NgaySinh = '{kS.NgaySinh}', NgayDangKy = '{kS.NgayDangKy}', GioiTinh = '{kS.GioiTinh}', DanToc = N'{kS.DanToc}', QuocTich = N'{kS.QuocTich}', NoiSinh = N'{kS.NoiSinh.toString()}', QueQuan = N'{kS.QueQuan.toString()}', CCCDCha = '{kS.CCCDCha}', TenCha = N'{kS.TenCha}', CCCDMe = '{kS.CCCDMe}', TenMe = N'{kS.TenMe}' WHERE MaKS = '{kS.MaKhaiSinh}'");
            conn.ThucThi(sqlStr, "Cập nhật khai sinh thành công");
        }
        public void ThemKhaSinh(KhaiSinh kS)
        {
            string sqlStr = StringKhaiSinh(kS);
            conn.ThucThi(sqlStr,"Thêm khai sinh thành công");
        }
        public void XoaKhaiSinh(string maKhaiSinh)
        {
            string sqlStr = string.Format($"DELETE FROM KHAISINH WHERE MaKS = '{maKhaiSinh}'");
            conn.ThucThi(sqlStr, "Xóa khai sinh thành công");
        }
        public KhaiSinh LayThongTin(string maCCCD)
        {
            string strSql = string.Format("SELECT * FROM KHAISINH WHERE MaKS = '{0}'", maCCCD);
            return conn.LayThongTinKhaiSinh(strSql);
        }
        public DataTable LayDanhSachVeSoNamNu()
        {
            string sqlStr = string.Format("SELECT GioiTinh, COUNT(GioiTinh) as 'Số lượng' FROM KHAISINH GROUP BY GioiTinh");
            return conn.LayDanhSach(sqlStr);
        }
    }
}
