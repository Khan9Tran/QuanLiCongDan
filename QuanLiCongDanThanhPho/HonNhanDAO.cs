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

        // Thêm công dân chưa có vào tạm trong hệ thống
        private void ThemTamCongDan(string cCCD, string ten, string mess)
        {
            CongDanDAO congDanDAO = new CongDanDAO();
            KhaiSinhDAO ksDao = new KhaiSinhDAO();
            CongDan congDan;
            KhaiSinh khaiSinh;
            congDan = new CongDan(cCCD, ten);
            khaiSinh = new KhaiSinh(cCCD, ten);
            MessageBox.Show(mess);
            congDanDAO.ThemCongDan(congDan);
            ksDao.ThemKhaSinh(khaiSinh);
        }

        //Đnăng ký hôn nhân
        public void ThemHonNhan(HonNhan hN)
        {
            CongDanDAO congDanDAO = new CongDanDAO();
            string tenChong = congDanDAO.LayThongTin(hN.CCCDChong).Ten;
            string tenVo = congDanDAO.LayThongTin(hN.CCCDVo).Ten;

            //Nếu 2 người không sống trong khu vực thì không thể đăng ký
            if (tenChong == "unknow" && tenVo == "unknow")
            {
                MessageBox.Show("Thông tin không tồn tại trong hệ thống");
                return;
            }

            //Kiểm tra tên có khớp không
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

            //Thêm công dân chưa có vào tạm trong hệ thống
            if (tenChong == "unknow")
            {
                ThemTamCongDan(hN.CCCDChong, hN.TenChong, "Thông tin chồng đã được tạo, nếu sống trong khu vực hãy bổ sung thông tin");
            }
            if (tenVo == "unknow")
            {
                ThemTamCongDan(hN.CCCDVo, hN.TenVo, "Thông tin vợ đã được tạo, nếu sống trong khu vực hãy bổ sung thông tin");
            }
            string sqlStr = string.Format($"INSERT INTO HONNHAN(MaHonNhan, CCCDNam, TenNam, CCCDNu, TenNu, NoiDangKy, NgayDangKy) VALUES('{hN.MaSo}','{hN.CCCDChong}',N'{hN.TenChong}','{hN.CCCDVo}',N'{hN.TenVo}',N'{hN.NoiDangKy.toString()}','{hN.NgayDangKy}');");
            conn.ThucThi(sqlStr, "Thêm hôn nhân thành công");
        }

        //Cập nhật thông tin hôn nhân
        public void CapNhatHonNhan(HonNhan hN)
        {
            string sqlStr = string.Format($"UPDATE HONNHAN SET CCCDNam = '{hN.CCCDChong}', TenNam = N'{hN.TenChong}', CCCDNu = '{hN.CCCDVo}', TenNu = N'{hN.TenVo}', NoiDangKy = N'{hN.NoiDangKy.toString()}', NgayDangKy = '{hN.NgayDangKy}' WHERE MaHonNhan = '{hN.MaSo}'");
            conn.ThucThi(sqlStr, "Cập nhật hôn nhân thành công");
        }

        //Kiểm tra xem người có CCCD này đã kết hôn chưa
        public Boolean KiemTraHonNhan(string maCCCD)
        {
            string sqlStr = string.Format("SELECT COUNT(*) as COUNT FROM HONNHAN WHERE CCCDNam = '{0}' OR CCCDNu = '{0}'", maCCCD);
            return conn.KiemTraCoKhong(sqlStr);
        }

        //Xóa hôn nhân
        public void Xoa(HonNhan honNhan)
        {
            string sqlStr = string.Format("DELETE HONNHAN WHERE MaHonNhan = {0}", honNhan.MaSo);
            conn.ThucThi(sqlStr, "Xóa hôn nhân thành công");
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
