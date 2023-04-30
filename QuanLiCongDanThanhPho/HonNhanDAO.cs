using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    internal class HonNhanDAO
    {
        DBConnection conn = new DBConnection();

        //Kiểm tra tên nhập vào có trùng khớp với trong hệ thống không
        private bool isGiongNhau(string a, string b)
        {
            if (a != b) return false;
            return true;
        }

        //Đnăng ký hôn nhân
        public bool ThemHonNhan(HonNhan hN)
        {
            CongDanDAO congDanDAO = new CongDanDAO();
            CongDan chong = congDanDAO.LayThongTin(hN.CCCDChong);
            CongDan vo = congDanDAO.LayThongTin(hN.CCCDVo);

            //Nếu 2 người không sống trong khu vực thì không thể đăng ký
            if (chong.CCCD == null || vo.CCCD == null)
            {
                MessageBox.Show("Thông tin không tồn tại trong hệ thống");
                return false;
            }

            //Kiểm tra tên có khớp không
            if (chong.Ten != null && !isGiongNhau(chong.Ten, hN.TenChong))
            {
                MessageBox.Show("Tên chồng không khớp với CCCD");
                return false;
            }
            if (vo.Ten != null && !isGiongNhau(vo.Ten, hN.TenVo))
            {
                MessageBox.Show("Tên vợ không khớp với CCCD");
                return false;
            }

            string sqlStr = string.Format($"INSERT INTO HONNHAN(MaHonNhan, CCCDNam, TenNam, CCCDNu, TenNu, NoiDangKy, NgayDangKy) VALUES('{hN.MaSo}','{hN.CCCDChong}',N'{hN.TenChong}','{hN.CCCDVo}',N'{hN.TenVo}',N'{hN.NoiDangKy.toString()}','{hN.NgayDangKy}');");
            return conn.ThucThi(sqlStr);
            //  "Thêm hôn nhân thành công"
        }

        //Cập nhật thông tin hôn nhân
        public bool CapNhatHonNhan(HonNhan hN)
        {
            string sqlStr = string.Format($"UPDATE HONNHAN SET CCCDNam = '{hN.CCCDChong}', TenNam = N'{hN.TenChong}', CCCDNu = '{hN.CCCDVo}', TenNu = N'{hN.TenVo}', NoiDangKy = N'{hN.NoiDangKy.toString()}', NgayDangKy = '{hN.NgayDangKy}' WHERE MaHonNhan = '{hN.MaSo}'");
            return conn.ThucThi(sqlStr);
            // "Cập nhật hôn nhân thành công"
        }

        //Kiểm tra xem người có CCCD này đã kết hôn chưa
        public Boolean KiemTraHonNhan(string maCCCD)
        {
            string sqlStr = string.Format("SELECT COUNT(*) as COUNT FROM HONNHAN WHERE CCCDNam = '{0}' OR CCCDNu = '{0}'", maCCCD);
            return conn.KiemTraCoKhong(sqlStr);
        }

        //Xóa hôn nhân
        public bool Xoa(HonNhan honNhan)
        {
            string sqlStr = string.Format("DELETE HONNHAN WHERE MaHonNhan = {0}", honNhan.MaSo);
            return conn.ThucThi(sqlStr);
            //Xóa hôn nhân thành công
        }

        //Lấy tất cả thông tin của hôn nhân theo CCCD
        public HonNhan LayThongTin(string maCCCD)
        {
            string sqlStr = string.Format("SELECT * FROM HONNHAN WHERE CCCDNam = '{0}' OR CCCDNu = '{0}'", maCCCD);
            return conn.LayThongTinHonNhan(sqlStr);
        }

        //Lấy tất cả thông tin của hôn nhân theo mã số
        public HonNhan LayThongTinTheoMaSo(string maHonNhan)
        {
            string sqlStr = string.Format("SELECT * FROM HONNHAN WHERE MaHonNhan = '{0}'", maHonNhan);
            return conn.LayThongTinHonNhan(sqlStr);
        }
    }
}
