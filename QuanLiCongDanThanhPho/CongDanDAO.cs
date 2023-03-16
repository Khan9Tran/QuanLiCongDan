﻿using System;
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
            CCCD cCCD = new CCCD(cD.CCCD);
            CCCDDAO cCCDDAO = new CCCDDAO();
            cCCDDAO.ThemCCCD(cCCD);
        }
        public void XoaCongDan(CongDan cD)
        {
            ThueDAO thueDAO = new ThueDAO();
            KhaiSinhDAO ksDAO = new KhaiSinhDAO();
            TamTruTamVangDAO tTTTVDAO = new TamTruTamVangDAO();
            HonNhanDAO hnDAO = new HonNhanDAO();
            CCCDDAO cCCCDAO = new CCCDDAO();
            thueDAO.XoaThue(cD.CCCD);
            ksDAO.XoaKhaiSinh(cD.CCCD);
            if (tTTTVDAO.KiemTraTamTruTamVang(cD.CCCD))
            {
                tTTTVDAO.XoaTamTruTamVang(cD.CCCD);
            }
            if (hnDAO.KiemTraHonNhan(cD.CCCD))
            {
                HonNhan hn = hnDAO.LayThongTin(cD.CCCD);
                hnDAO.Xoa(hn);
            }
            cCCCDAO.XoaCCCD(cD.CCCD);
            string strSql = string.Format($"DELETE FROM CONGDAN WHERE CCCD = '{cD.CCCD}'");
            conn.ThucThi(strSql, "Xóa công dân thành công");
        }
        public void CapNhatCongDan(CongDan cD )
        {
            string strSql = string.Format($"UPDATE CONGDAN SET Ten = N'{cD.Ten}', NgheNghiep = N'{cD.NgheNghiep}', TonGiao = N'{cD.TonGiao}', SDT = '{cD.SDT}', MaHK = '{cD.MaHoKhau}', QuanHeVoiChuHo = N'{cD.QuanHeVoiChuHo}' WHERE CCCD = '{cD.CCCD}'");
            conn.ThucThi(strSql, "Cập nhật thông tin thành công");
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
            return conn.LayDanhSach($"SELECT CCCD, Ten as 'Họ và tên', SDT as 'Số điện thoại', NgheNghiep as 'Nghề nghiệp', QuanHeVoiChuHo as 'Quan hệ với chủ hộ' FROM CONGDAN WHERE MaHK = '{maHK}'");
        }
        public CongDan LayThongTin(string maCCCD)
        {
            string strSql = string.Format("SELECT * FROM CONGDAN WHERE CCCD = '{0}'", maCCCD);
            return conn.LayThongTinCongDan(strSql);
        }
        /*
        public string LayTenCongDan(string maCCCD) 
        {   
            CongDan tmpCD = new CongDan();
            if (!conn.KiemTraCoKhong("SELECT Ten FROM CONGDAN WHERE CCCD = '{maCCCD}'"))
            {
                return "Căn cước không tồn tại";
            }
            tmpCD = LayThongTin("SELECT Ten FROM CONGDAN WHERE CCCD = '{maCCCD}'");
            return tmpCD.Ten;
        } */
        public DataTable LayDanhSachCongDanNam(string tu)
        {
            string strSql = string.Format($"SELECT distinct CONGDAN.CCCD, CONGDAN.Ten as 'Họ và tên', CONGDAN.SDT as 'Số điện thoại', CONGDAN.NgheNghiep as 'Nghề nghiệp', CONGDAN.TonGiao as 'Tôn giáo' FROM CONGDAN INNER JOIN KHAISINH ON CONGDAN.CCCD = KHAISINH.MaKS AND KHAISINH.GioiTinh like 'm' WHERE CONGDAN.Ten like N'%{tu}%' OR CCCD like '%{tu}%' OR SDT like '%{tu}%' OR NgheNghiep like N'%{tu}%' OR TonGiao like N'%{tu}%'");
            return conn.LayDanhSach(strSql);
        }
        public DataTable LayDanhSachCongDanNu(string tu)
        {
            string strSql = string.Format($"SELECT distinct CONGDAN.CCCD, CONGDAN.Ten as 'Họ và tên', CONGDAN.SDT as 'Số điện thoại', CONGDAN.NgheNghiep as 'Nghề nghiệp', CONGDAN.TonGiao as 'Tôn giáo' FROM CONGDAN INNER JOIN KHAISINH ON CONGDAN.CCCD = KHAISINH.MaKS AND KHAISINH.GioiTinh like 'f' WHERE CONGDAN.Ten like N'%{tu}%' OR CCCD like '%{tu}%' OR SDT like '%{tu}%' OR NgheNghiep like N'%{tu}%' OR TonGiao like N'%{tu}%'");
            return conn.LayDanhSach(strSql);
        }
        public DataTable LayDanhSachDaKetHon(string tu)
        { 
            string strSql = string.Format($"SELECT distinct CONGDAN.CCCD, CONGDAN.Ten as 'Họ và tên', CONGDAN.SDT as 'Số điện thoại', CONGDAN.NgheNghiep as 'Nghề nghiệp', CONGDAN.TonGiao as 'Tôn giáo' FROM CONGDAN INNER JOIN HONNHAN ON CONGDAN.CCCD = HONNHAN.CCCDNam OR CONGDAN.CCCD = HONNHAN.CCCDNu WHERE CONGDAN.Ten like N'%{tu}%' OR CCCD like '%{tu}%' OR SDT like '%{tu}%' OR NgheNghiep like N'%{tu}%' OR TonGiao like N'%{tu}%'");
            return conn.LayDanhSach(strSql);
        }
        public DataTable LayDanhSachChuaKetHon(string tu)
        {
            string strSql = string.Format($"SELECT CONGDAN.CCCD, CONGDAN.Ten as 'Họ và tên', CONGDAN.SDT as 'Số điện thoại', CONGDAN.NgheNghiep as 'Nghề nghiệp', CONGDAN.TonGiao as 'Tôn giáo' FROM (SELECT CD.CCCD, CD.Ten, CD.SDT, CD.NgheNghiep, CD.TonGiao FROM CONGDAN AS CD EXCEPT SELECT CONGDAN.CCCD, CONGDAN.Ten, CONGDAN.SDT, CONGDAN.NgheNghiep, CONGDAN.TonGiao FROM CONGDAN, HONNHAN WHERE CONGDAN.CCCD = HONNHAN.CCCDNam OR CONGDAN.CCCD = HONNHAN.CCCDNu) as CONGDAN WHERE  CONGDAN.Ten like N'%{tu}%' OR CCCD like '%{tu}%' OR SDT like '%{tu}%' OR NgheNghiep like N'%{tu}%' OR TonGiao like N'%{tu}%'");
            return conn.LayDanhSach(strSql);
        }
        public DataTable LayDanhSachTuoiXepTuBeDenLon(string tu)
        {
            string strSql = string.Format($"SELECT CONGDAN.CCCD, CONGDAN.Ten as 'Họ và tên', CONGDAN.SDT as 'Số điện thoại', CONGDAN.NgheNghiep as 'Nghề nghiệp', CONGDAN.TonGiao as 'Tôn giáo' FROM CONGDAN INNER JOIN KHAISINH ON CONGDAN.CCCD = KHAISINH.MaKS WHERE CONGDAN.Ten like N'%{tu}%' OR CCCD like '%{tu}%' OR SDT like '%{tu}%' OR NgheNghiep like N'%{tu}%' OR TonGiao like N'%{tu}%' ORDER BY NgaySinh DESC");
            return conn.LayDanhSach(strSql);
        }
        public DataTable LayDanhSachChuaTu(string tu)
        {
            string strSql = string.Format($"SELECT CONGDAN.CCCD, CONGDAN.Ten as 'Họ và tên', CONGDAN.SDT as 'Số điện thoại', CONGDAN.NgheNghiep as 'Nghề nghiệp', CONGDAN.TonGiao as 'Tôn giáo' FROM CONGDAN WHERE Ten like N'%{tu}%' OR CCCD like '%{tu}%' OR SDT like '%{tu}%' OR NgheNghiep like N'%{tu}%' OR TonGiao like N'%{tu}%'");
            return conn.LayDanhSach(strSql);
        }
        public DataTable LayDanhSachhVeSoCongDan()
        {
            string sqlStr = string.Format("SELECT COUNT(*) as 'Số công dân' FROM CONGDAN");
            return conn.LayDanhSach
        }
    }
}
