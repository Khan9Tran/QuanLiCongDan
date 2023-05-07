using QuanLiCongDanThanhPho.Models;
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
        public bool CapNhatKhaiSinh(KhaiSinh kS)
        {
            string sqlStr = string.Format($"UPDATE KHAISINH SET  Ten = N'{kS.HoTen}', NgaySinh = '{kS.NgaySinh}', NgayDangKy = '{kS.NgayDangKy}', GioiTinh = '{kS.GioiTinh}', DanToc = N'{kS.DanToc}', QuocTich = N'{kS.QuocTich}', NoiSinh = N'{kS.NoiSinh.toString()}', QueQuan = N'{kS.QueQuan.toString()}', CCCDCha = '{kS.CCCDCha}', TenCha = N'{kS.TenCha}', CCCDMe = '{kS.CCCDMe}', TenMe = N'{kS.TenMe}' WHERE MaKS = '{kS.MaKhaiSinh}'");
            return conn.ThucThi(sqlStr);
        }
        public bool ThemKhaiSinh(KhaiSinh kS)
        {
            string sqlStr = StringKhaiSinh(kS);
            return conn.ThucThi(sqlStr);
        }
        public bool XoaKhaiSinh(string maKhaiSinh)
        {
            string sqlStr = string.Format($"DELETE FROM KHAISINH WHERE MaKS = '{maKhaiSinh}'");
            return conn.ThucThi(sqlStr);
        }
        public KhaiSinh LayThongTin(string maCCCD)
        {
            string strSql = string.Format("SELECT * FROM KHAISINH WHERE MaKS = '{0}'", maCCCD);
            return conn.LayThongTinKhaiSinh(strSql);
        }

        public DataTable LayDanhSachVeSoNamNu()
        {
            string sqlStr = string.Format("SELECT GioiTinh as 'Giới tính', COUNT(*) as 'Số lượng' FROM KHAISINH RIGHT JOIN CONGDAN ON CONGDAN.CCCD = KHAISINH.MaKS GROUP BY GioiTinh");
            DataTable dt = conn.LayDanhSach(sqlStr);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Giới tính"] != DBNull.Value && (string)dr["Giới tính"] == "f")
                    dr["Giới tính"] = "Nữ";
                else if (dr["Giới tính"] != DBNull.Value && (string)dr["Giới tính"] == "m")
                    dr["Giới tính"] = "Nam";
                else
                    dr["Giới tính"] = "Unknown";
            }
            return dt;
        }

        private int[] SoLuongNguoiTrongNhomTuoi(DataTable dt)
        {
            int[] cntNhomTuoi = { 0, 0 ,0 };
            foreach (DataRow dr in dt.Rows)
            {
                if ((int)dr["SoTuoi"] < 15)
                    cntNhomTuoi[0]++;
                else if ((int)dr["SoTuoi"] >= 15 && (int)dr["SoTuoi"] <= 64)
                    cntNhomTuoi[1]++;
                else
                    cntNhomTuoi[2]++;
            }
            return cntNhomTuoi;
        }
        public DataTable LayTuoiCongDan()
        {
            string sqlStr = string.Format("SELECT YEAR(GETDATE()) - YEAR(NgaySinh) as SoTuoi FROM KHAISINH");
            DataTable duLieu = conn.LayDanhSach(sqlStr);
            DataTable dtNhomTuoi = new DataTable();
            dtNhomTuoi.Columns.Add("Nhóm tuổi");
            dtNhomTuoi.Columns.Add("Số lượng");

            int[] soLuongNhomTuoi = SoLuongNguoiTrongNhomTuoi(duLieu);
            dtNhomTuoi.Rows.Add("0-14", soLuongNhomTuoi[0]);
            dtNhomTuoi.Rows.Add("15-64", soLuongNhomTuoi[1]);
            dtNhomTuoi.Rows.Add("65+", soLuongNhomTuoi[2]);
            return dtNhomTuoi;
        }
    }
}
