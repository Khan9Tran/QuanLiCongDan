using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class CongDanDAO
    {
        DBConnection conn = new DBConnection();
        public CongDanDAO() { }
        public void ThemCongDan(CongDan cD, KhaiSinh kS, HoKhau hK, HonNhan hN, Thue thue)
        {
            string strSql = string.Format(
                $"INSERT FROM CCCD(MaCCCD) VALUES({cD.MaCccd})\n"
                + "GO" +
                $"INSERT FROM HOKHAU(MaHK, DiaChi) VALUES('{hK.MaHoKhau}','{hK.DiaChi.toString()}')\n"
                + "GO" +
                $"INSERT FROM CONGDAN(CCCD, Ten, NgheNghiep, SDT, TonGiao, MaHK, QuanHeVoiChuHo) VALUES ('{cD.MaCccd}','{cD.HoTen}','{cD.NgheNghiep}','{cD.SoDienThoai}','{cD.TonGiao}','{cD.MaHoKhau}', '{cD.QHVoiChuHo}')\n"
                + "GO" +
                $"INSERT FROM KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy, GioiTinh, DanToc, QuocTich, QueQuan, NoiSinh, CCCDCha, TenCha, CCCDMe,TenMe) VAULES('{kS.MaKhaiSinh}','{kS.HoTen}',{kS.NgaySinh}, {kS.NgayDangKy},'{kS.GioiTinh}','{kS.DanToc}','{kS.QuocTich}','{kS.QueQuan.toString()}','{kS.NoiSinh.toString()}','{kS.CCCDCha}','{kS.TenCha}','{kS.CCCDMe},'{kS.TenMe}')\n"
                + "GO" +
                $"INSERT FROM THUE(MaThue) VALUES('{thue.MaThue}')\n" 
                + "GO" +
                $"INSERT FROM HONNHAN(MaHonNhan, CCCDNam, TenNam, CCCDNu, TenNu) VALUES('{hN.MaSo}','{hN.TenChong}','{hN.TenVo}','{hN.CCCDVo}','{hN.CCCDChong}')\n" );
                conn.ThucThi(strSql);
        }
        public DataTable LayDanhSach()
        {
            return conn.LayDanhSach("SELECT CCCD, Ten, SDT FROM CONGDAN");
        }
    }
}
