using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Models;
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
        public void ThemKhaSinh(KhaiSinh kS)
        {
            string sqlStr = StringKhaiSinh(kS);
            conn.ThucThi(sqlStr,"Thêm khai sinh thành công");
        }
        public KhaiSinh LayThongTin(string MaCCCD)
        {
            string strSql = string.Format("SELECT * FROM KHAISINH WHERE MaKS = '{0}'", MaCCCD);
            return conn.LayThongTinKhaiSinh(strSql);
        }
    }
}
