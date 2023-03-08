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
            string strSql = string.Format($"INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('{cD.CCCD}' , N'{cD.Ten}', N'{cD.NgheNghiep}', '{cD.SDT}', N'{cD.TonGiao}', '{cD.MaHoKhau}', N'{cD.QuanHeVoiChuHo}');");
            conn.ThucThi(strSql, "Công dân hợp lệ");
            CCCD cCCD = new CCCD(cD.CCCD, DateTime.Now, "Không xác định");
            CCCDDAO cCCDDAO = new CCCDDAO();
            cCCDDAO.ThemCCCD(cCCD);
        }
        public void ThayDoiHoKhau(CongDan cD)
        {
            string strSql = string.Format("UPDATE CONGDAN SET MaHK = '{0}' , QuanHeVoiChuHo = N'{1}' WHERE CCCD = '{2}'", cD.MaHoKhau, cD.QuanHeVoiChuHo, cD.CCCD);
            conn.ThucThi(strSql, "Thêm thành viên thành công");
        }
        public void NhapHoKhau(CongDan cD)
        {
            string strSql = string.Format("UPDATE CONGDAN SET MaHK = '{0}' , QuanHeVoiChuHo = N'Vừa nhập hộ' WHERE CCCD = '{1}'", cD.MaHoKhau, cD.CCCD);
            conn.ThucThi(strSql, "Nhập hộ thành công");
        }
        public DataTable LayDanhSach()
        {
            return conn.LayDanhSach("SELECT CCCD, Ten as 'Họ và tên', SDT as 'Số điện thoại', NgheNghiep as 'Nghề nghiệp', TonGiao as 'Tôn giáo' FROM CONGDAN");
        }
        public DataTable LayDanhSachTheoHoKhau(string maHK)
        {
            return conn.LayDanhSach($"SELECT CCCD, Ten as 'Họ và tên', SDT as 'Số điện thoại', NgheNghiep as 'Nghề nghiệp' FROM CONGDAN WHERE MaHK = '{maHK}'");
        }
        public CongDan LayThongTin(string maCCCD)
        {
            string strSql = string.Format("SELECT * FROM CONGDAN WHERE CCCD = '{0}'", maCCCD);
            return conn.LayThongTinCongDan(strSql);
        }
    }
}
