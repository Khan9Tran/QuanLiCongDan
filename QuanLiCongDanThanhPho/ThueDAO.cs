﻿using QuanLiCongDanThanhPho.Models;
using System.Data;

namespace QuanLiCongDanThanhPho
{
    internal class ThueDAO
    {
        //Lấy kết nối
        DBConnection conn = new DBConnection();

        public ThueDAO() { }

        public bool ThemThue(Thue thue)
        {
            string sqlStr = string.Format($"INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('{thue.MaThue}','{thue.CCCD}', '{thue.SoTienCanNop}','{thue.SoTienDaNop}', '{thue.NgayCapMa}', '{thue.HanNop}');");
            return conn.ThucThi(sqlStr);
        }

        public bool XoaThue(string canCuoc)
        {
            string sqlStr = string.Format($"DELETE FROM THUE WHERE CCCD = '{canCuoc}'");
            return conn.ThucThi(sqlStr);
        }

        public Thue LayThongTin(string maCCCD)
        {
            string sqlStr = string.Format("SELECT * FROM THUE WHERE CCCD = '{0}'", maCCCD);
            return conn.LayThongTinThue(sqlStr);
        }

        public string ChuoiLayDanhSachTheoTu(string tu)
        {
            string str = string.Format($"SELECT MaThue as 'Mã thuế', CCCD, SoTienCanNop as 'Số tiền cần nộp', SoTienDaNop as 'Số tiền đã nộp', NgayCap as 'Ngày cấp', HanNop as 'Hạn nộp' FROM THUE WHERE (MaThue like '%{tu}%' OR CCCD like '%{tu}%' OR SoTienCanNop like '%{tu}%' OR Convert(varchar,Format(HanNop, 'dd/MM/yyyy')) like '%{tu}%')");
            return str;
        }

        public DataTable LayDanhSachChuaTu(string tu)
        {
            string strSql = ChuoiLayDanhSachTheoTu(tu);
            return conn.LayDanhSach(strSql);
        }

        public DataTable LayDanhSachSoTienDaNop(string tu)
        {
            string sqlStr = ChuoiLayDanhSachTheoTu(tu) + " ORDER BY SoTienDaNop ASC";
            return conn.LayDanhSach(sqlStr);
        }

        public DataTable LayDanhSachTreHan(string tu)
        {
            string sqlStr = ChuoiLayDanhSachTheoTu(tu) + " AND GETDATE() > THUE.HanNop";
            return conn.LayDanhSach(sqlStr);
        }

        public bool CapNhatThue(Thue thue) 
        {
            string sqlStr = string.Format($"UPDATE THUE SET SoTienCanNop = '{thue.SoTienCanNop}', SoTienDaNop = '{thue.SoTienDaNop}', NgayCap = '{thue.NgayCapMa}', HanNop = '{thue.HanNop}' WHERE MaThue = '{thue.MaThue}'");
            return conn.ThucThi(sqlStr);
        }

        public int[] LayThongKeThue()
        {
            string sqlStr = string.Format("SELECT SUM(CONVERT(INT,SoTienCanNop)) as TongTienCanNop, SUM(CONVERT(INT,SoTienDaNop)) as TongTienDaNop, COUNT(*) as SL FROM THUE");
            DataTable dt = conn.LayDanhSach(sqlStr);
            int[] thues = new int[4];
            thues[0] = dt.Rows[0].Field<int>("TongTienCanNop");
            thues[1] = dt.Rows[0].Field<int>("TongTienDaNop");
            thues[2] = thues[0] + thues[1];
            thues[3] = dt.Rows[0].Field<int>("SL");
            return thues;
        }

        public int LaySoNguoiTreHan()
        {
            string sqlStr = string.Format("SELECT COUNT(*) as SL FROM THUE WHERE GETDATE() > THUE.HanNop");
            DataTable dt = conn.LayDanhSach(sqlStr);
            int cnt = dt.Rows[0].Field<int>("SL");
            return cnt;
        }

        public DataTable DuTuoiDongThue()
        {
            string sqlStr = string.Format("SELECT CONGDAN.CCCD, CONGDAN.Ten as 'Họ và tên', CONGDAN.SDT as 'Số điện thoại', CONGDAN.NgheNghiep as 'Nghề nghiệp', CONGDAN.TonGiao as 'Tôn giáo' FROM CONGDAN JOIN KHAISINH ON CONGDAN.CCCD = KHAISINH.MaKS WHERE (GETDATE() < DATEADD(year, YEAR(GETDATE()) - YEAR(NgaySinh), NgaySinh) AND YEAR(GETDATE())- YEAR(NgaySinh) - 1 >= 18) OR (GETDATE() >= DATEADD(year, YEAR(GETDATE()) - YEAR(NgaySinh), NgaySinh) AND YEAR(GETDATE()) - YEAR(NgaySinh) >= 18) EXCEPT SELECT CONGDAN.CCCD, CONGDAN.Ten as 'Họ và tên', CONGDAN.SDT as 'Số điện thoại', CONGDAN.NgheNghiep as 'Nghề nghiệp', CONGDAN.TonGiao as 'Tôn giáo' FROM THUE, CONGDAN WHERE THUE.CCCD = CONGDAN.CCCD");
            return conn.LayDanhSach(sqlStr);
        }

        public DataTable LayDanhSachTienDongThueCacQuan()
        {
            CongDanDAO cDDAO = new CongDanDAO();
            DataTable cacQuan = cDDAO.LayDanhSachDiaChi();
            DataTable result = new DataTable();
            result.Columns.Add("Quận", typeof(string));
            result.Columns.Add("Tiền đã thu", typeof(int));
            foreach (DataRow row in cacQuan.Rows)
            {
                string sqlStr = string.Format($"SELECT SUM(CONVERT(INT,SoTienDaNop)) as 'Tiền đã thu' FROM\r\nTHUE inner join\r\n(SELECT  CCCD, DiaChi FROM CONGDAN INNER JOIN HOKHAU ON CONGDAN.MaHK = HOKHAU.MaHK WHERE HOKHAU.DiaChi <> N'Tạm trú' AND HOKHAU.DiaChi <> N'Tạm vắng' UNION ALL SELECT CCCD, DiaChi FROM TAMTRUTAMVANG) QUAN\r\non Thue.CCCD = Quan.CCCD\r\nWHERE DiaChi like N'%{row["Quận"].ToString()}%'\r\n");
                DataTable temp = conn.LayDanhSach(sqlStr);
                result.Rows.Add(row["Quận"].ToString(), temp.Rows[0]["Tiền đã thu"]);
            }
            return result;
        }
    }
}
