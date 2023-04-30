using QuanLiCongDanThanhPho.Models;
using System.Data;

namespace QuanLiCongDanThanhPho
{
    internal class AccountDAO
    {
        public AccountDAO() { }
        DBConnection conn = new DBConnection();

        public bool XoaTaiKhoan(Account acc)
        {
            string sqlStr = string.Format($"DELETE ACCOUNT WHERE UserName = {acc.UserName}");
            return conn.ThucThi(sqlStr);
        }
        public void CapNhatMatKhau(Account acc)
        {
            string sqlStr = string.Format($"UPDATE ACCOUNT SET StrPassword = '{acc.Password}' WHERE UserName = '{acc.UserName}'");
            if (conn.ThucThi(sqlStr))
                MessageBox.Show("Đổi mật khẩu thành công");
            else
                MessageBox.Show("Đổi mật khẩu thất bại");
        }
        public void CapNhatDisplayName(Account acc)
        {
            string sqlStr = string.Format($"UPDATE ACCOUNT SET DisplayName = N'{acc.DisplayName}' WHERE UserName = '{acc.UserName}'");
            if (conn.ThucThi(sqlStr))
                MessageBox.Show("Cập nhật tên thành công");
            else
                MessageBox.Show("Đổi mật tên thất bại");
        }
        public Account LayThongTinTaiKhoan(Account acc)
        {
            string sqlStr = string.Format($"SELECT *FROM ACCOUNT WHERE UserName = '{acc.UserName}'");
            return conn.LayThongTinTaiKhoan(sqlStr);
        }
        public bool DangNhap(Account acc)
        {
            string sqlStr = string.Format($"SELECT *FROM ACCOUNT WHERE UserName = '{acc.UserName}' AND StrPassword = '{acc.Password}'");
            DataTable dt = new DataTable();
            dt = conn.LayDanhSach(sqlStr);
            return dt.Rows.Count > 0;
        }
    }
}
