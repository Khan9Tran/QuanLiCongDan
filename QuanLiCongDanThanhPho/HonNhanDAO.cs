using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class HonNhanDAO
    {
        DBConnection conn = new DBConnection();
        public void ThemHonNhan(HonNhan hN)
        {
            Boolean checkChong = this.KiemTraHonNhan(hN.CCCDChong);
            Boolean chekVo = this.KiemTraHonNhan(hN.CCCDVo);

            if (checkChong == false && chekVo == false)
            {
                MessageBox.Show("Thông tin không tồn tại trong hệ thống");
            }
            else
            {
                if (checkChong == false)
                {
                    CongDan voChong = new CongDan(hN.CCCDChong, hN.TenChong, "");
                    CongDanDAO cdDAO = new CongDanDAO();
                    cdDAO.ThemCongDan(voChong);

                    MessageBox.Show("Thông tin vợ/ chồng đã được tạo, nếu sống trong khu vực hãy bổ sung thông tin");
                }
                if  (chekVo == false)
                {
                    CongDan voChong = new CongDan(hN.CCCDChong, hN.TenChong, "");
                    CongDanDAO cdDAO = new CongDanDAO();
                    cdDAO.ThemCongDan(voChong);

                    MessageBox.Show("Thông tin vợ/ chồng đã được tạo, nếu sống trong khu vực hãy bổ sung thông tin");
                }
                string sqlStr = string.Format($"INSERT INTO HONNHAN(MaHonNhan, CCCDNam, TenNam, CCCDNu, TenNu, NoiDangKy, NgayDangKy) VALUES('{hN.MaSo}','{hN.CCCDChong}',N'{hN.TenChong}','{hN.CCCDVo}',N'{hN.TenVo}',N'{hN.NoiDangKy.toString()}','{hN.NgayDangKy}');");
                conn.ThucThi(sqlStr, "Thêm hôn nhân thành công");
            }
        }
        public Boolean KiemTraHonNhan(string maCCCD)
        {
            string sqlStr = string.Format("SELECT COUNT(*) as COUNT FROM HONNHAN WHERE CCCDNam = {0} OR CCCDNu = {0}", maCCCD);
            return conn.KiemTraCoKhong(sqlStr);
        }
        public HonNhan LayThongTin(string maCCCD)
        {
            string sqlStr = string.Format("SELECT * FROM HONNHAN WHERE CCCDNam = {0} OR CCCDNu = {0}", maCCCD);
            return conn.LayThongTinHonNhan(sqlStr);
        }
    }
}
