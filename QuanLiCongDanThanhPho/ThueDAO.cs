using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class ThueDAO
    {
        DBConnection conn = new DBConnection();
        public ThueDAO() { }
        public DataTable LayDanhSach()
        {
            return conn.LayDanhSach("SELECT MaThue as 'Mã thuế', CCCD, SoTienCanNop as 'Số tiền cần nộp', HanNop as 'Hạn nộp' FROM THUE");
        }
        public void ThemThue(Thue thue)
        {
            string sqlStr = string.Format($"INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('{thue.MaThue}','{thue.CCCD}', '{thue.SoTienCanNop}','{thue.SoTienDaNop}', '{thue.NgayCapMa}', '{thue.HanNop}');");
            conn.ThucThi(sqlStr,"Thêm thông tin thuế thành công");
        }
        public Thue LayThongTin(string maCCCD)
        {
            string sqlStr = string.Format("SELECT * FROM THUE WHERE CCCD = {0}", maCCCD);
            return conn.LayThongTinThue(sqlStr);
        }
        public DataTable LayDanhSachChuaTu(string tu)
        {
            string strSql = string.Format($"SELECT MaThue as 'Mã thuế', CCCD, SoTienCanNop as 'Số tiền cần nộp', HanNop as 'Hạn nộp' FROM THUE WHERE MaThue like '%{tu}%' OR CCCD like '%{tu}%' OR SoTienCanNop like '%{tu}%' OR Convert(varchar,Format(HanNop, 'dd/MM/yyyy')) like '%{tu}%'");
            return conn.LayDanhSach(strSql);
        }
        public DataTable LayDanhSachHanNop(string tu)
        {
            return conn.LayDanhSach($"SELECT MaThue as 'Mã thuế', CCCD, SoTienCanNop as 'Số tiền cần nộp', HanNop as 'Hạn nộp' FROM THUE WHERE MaThue like '%{tu}%' OR CCCD like '%{tu}%' OR SoTienCanNop like '%{tu}%' OR Convert(varchar,Format(HanNop, 'dd/MM/yyyy')) like '%{tu}%' ORDER BY HanNop DESC");
        }
        public DataTable LayDanhSachSoTienDaNop(string tu)
        {
            return conn.LayDanhSach($"SELECT MaThue as 'Mã thuế', CCCD, SoTienCanNop as 'Số tiền cần nộp', HanNop as 'Hạn nộp' FROM THUE WHERE MaThue like '%{tu}%' OR CCCD like '%{tu}%' OR SoTienCanNop like '%{tu}%' OR Convert(varchar,Format(HanNop, 'dd/MM/yyyy')) like '%{tu}%' ORDER BY SoTienDaNop ASC");
        }
        public DataTable LayDanhSachSoTienChuaNop(string tu)
        {
            return conn.LayDanhSach($"SELECT MaThue as 'Mã thuế', CCCD, SoTienCanNop as 'Số tiền cần nộp', HanNop as 'Hạn nộp' FROM THUE WHERE MaThue like '%{tu}%' OR CCCD like '%{tu}%' OR SoTienCanNop like '%{tu}%' OR Convert(varchar,Format(HanNop, 'dd/MM/yyyy')) like '%{tu}%' ORDER BY SoTienCanNop ASC");
        }
        public void CapNhatThue(Thue thue) 
        {
            string sqlStr = string.Format($"UPDATE THUE SET CCCD = '{thue.CCCD}', SoTienCanNop = '{thue.SoTienCanNop}', SoTienDaNop = '{thue.SoTienDaNop}', NgayCap = '{thue.NgayCapMa}', HanNop = '{thue.HanNop}' WHERE MaThue = '{thue.MaThue}'");
            conn.ThucThi(sqlStr, $"Cập nhật thuế thành công");
        }
    }
}
