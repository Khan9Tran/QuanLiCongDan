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
        public bool isGiongNhau(string a, string b)
        {
            if (a != b) return false;
            return true;
        }
        public void ThemHonNhan(HonNhan hN)
        {
            CongDanDAO congDanDAO = new CongDanDAO();
            string tenChong = congDanDAO.LayThongTin(hN.CCCDChong).Ten;
            string tenVo = congDanDAO.LayThongTin(hN.CCCDVo).Ten;
            if (tenChong == "unknow" && tenVo == "unknow")
            {
                MessageBox.Show("Thông tin không tồn tại trong hệ thống");
                return;
            }
            if (tenChong != "unknow" && !isGiongNhau(tenChong, hN.TenChong))
            {
                MessageBox.Show("Tên chồng không khớp với CCCD");
                return;
            }
            if (tenVo != "unknow" && !isGiongNhau(tenVo, hN.TenVo))
            {
                MessageBox.Show("Tên vợ không khớp với CCCD");
                return;
            }
            CongDan congDan;
            if (tenChong == "unknow")
            {
                congDan = new CongDan(hN.CCCDChong, hN.TenChong);
                MessageBox.Show("Thông chồng đã được tạo, nếu sống trong khu vực hãy bổ sung thông tin");
                congDanDAO.ThemCongDan(congDan);
            }
            if (tenVo == "unknow")
            {
                congDan = new CongDan(hN.CCCDVo, hN.TenVo);
                MessageBox.Show("Thông tin vợ đã được tạo, nếu sống trong khu vực hãy bổ sung thông tin");
                congDanDAO.ThemCongDan(congDan);
            }
            string sqlStr = string.Format($"INSERT INTO HONNHAN(MaHonNhan, CCCDNam, TenNam, CCCDNu, TenNu, NoiDangKy, NgayDangKy) VALUES('{hN.MaSo}','{hN.CCCDChong}',N'{hN.TenChong}','{hN.CCCDVo}',N'{hN.TenVo}',N'{hN.NoiDangKy.toString()}','{hN.NgayDangKy}');");
            conn.ThucThi(sqlStr, "Thêm hôn nhân thành công");
        }
        public void CapNhatHonNhan(HonNhan hN)
        {
            string sqlStr = string.Format($"UPDATE HONNHAN SET CCCDNam = '{hN.CCCDChong}', TenNam = N'{hN.TenChong}', CCCDNu = '{hN.CCCDVo}', TenNu = N'{hN.TenVo}', NoiDangKy = N'{hN.NoiDangKy.toString()}', NgayDangKy = '{hN.NgayDangKy}' WHERE MaHonNhan = '{hN.MaSo}'");
            conn.ThucThi(sqlStr, "Cập nhật hôn nhân thành công");
        }
        public Boolean KiemTraHonNhan(string maCCCD)
        {
            string sqlStr = string.Format("SELECT COUNT(*) as COUNT FROM HONNHAN WHERE CCCDNam = '{0}' OR CCCDNu = '{0}'", maCCCD);
            return conn.KiemTraCoKhong(sqlStr);
        }
        public void Xoa(HonNhan honNhan)
        {
            string sqlStr = string.Format("DELETE HONNHAN WHERE MaHonNhan = {0}", honNhan.MaSo);
            conn.ThucThi(sqlStr, "Li hôn thành công");
        }    
        public HonNhan LayThongTin(string maCCCD)
        {
            string sqlStr = string.Format("SELECT * FROM HONNHAN WHERE CCCDNam = '{0}' OR CCCDNu = '{0}'", maCCCD);
            return conn.LayThongTinHonNhan(sqlStr);
        }
        public HonNhan LayThongTinTheoMaSo(string maHonNhan)
        {
            string sqlStr = string.Format("SELECT * FROM HONNHAN WHERE MaHonNhan = '{0}'", maHonNhan);
            return conn.LayThongTinHonNhan(sqlStr);
        }
        public HonNhan LayThongTinGoiYTheoMaSo(string maHonNhan)
        {
            string sqlStr = string.Format($"SELECT * FROM HONNHAN WHERE MaHonNhan like '%{maHonNhan}%'");
            return conn.LayThongTinHonNhan(sqlStr);
        }
    }
}
