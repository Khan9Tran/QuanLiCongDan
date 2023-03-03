using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCongDanThanhPho.Models;
namespace QuanLiCongDanThanhPho
{
    internal class CongDanDAO
    {
        DBConnection conn = new DBConnection();
        public CongDanDAO() { }
        public void ThemCongDan(CongDan cD)
        {
            string strSql = string.Format(
                $"INSERT INTO CONGDAN(CCCD, Ten, NgheNghiep, SDT, TonGiao, MaHK, QuanHeVoiChuHo) VALUES ('{cD.CCCD}','{cD.Ten}','{cD.NgheNghiep}','{cD.SDT}','{cD.TonGiao}','{cD.MaHoKhau}', '{cD.QuanHeVoiChuHo}')");
                conn.ThucThi(strSql);
        }
        public void ThemHoKhau()
        {

        }
        public void ThemCCCD()
        {

        }
        public void ThemKhaiSinh() 
        {

        }
        public void ThemHonNhan()
        {

        }
        public void ThemThue() 
        {

        }

        public DataTable LayDanhSach()
        {
            return conn.LayDanhSach("SELECT CCCD, Ten, SDT FROM CONGDAN");
        }
    }
}
