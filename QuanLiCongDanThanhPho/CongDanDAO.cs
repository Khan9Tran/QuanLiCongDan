using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class CongDanDAO
    {
        DBConnection conn = new DBConnection();
        void ThemCongDan(CongDan cD)
        {
            string strSql = String.Format($"INSERT FROM CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaKS,MaHK,MaThue,MaTTTV,MaHN) VALUES ('{cD.MaCccd}','{cD.HoTen}','{cD.NgheNghiep}','{cD.SoDienThoai}','{cD.TonGiao}','{cD.MaCccd}','{cD.MaHoKhau}','{cD.MaThue}','{cD.TamTruTamVang.MaSo}','{cD.KetHon.MaSo}')\n" +
                $"INSERT FROM KHAISINH(MaKS,NgaySinh,GioiTinh,DanToc,QuocTich,QueQuan,CCCDCha,TenCha,CCCDMe,TenMe) VAULES('{cD.MaCccd}',{cD.KhaiSinh.NgaySinh},'{cD.KhaiSinh.GioiTinh}','{cD.KhaiSinh.DanToc}','{cD.TonGiao}','{cD.KhaiSinh.QuocTich}','{cD.KhaiSinh.QuocTich}','{cD.KhaiSinh.Cha.MaCccd}','{cD.KhaiSinh.Cha.HoTen}','{cD.KhaiSinh.Me.MaCccd},'{cD.KhaiSinh.Me.HoTen}')\n"
                + $"INSERT FROM THUE(MaThue) VALUES('{cD.MaThue}')\n" +
                $"INSERT FROM HONNHAN(MaHonNhan) VALUES('{cD.KetHon.MaSo}') ");
            conn.ThucThi(strSql);
        }
    }
}
