using System.Data.SqlClient;
using System.Data;
using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void ThucThi(string sqlStr, string thongBao)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(thongBao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LayDanhSach(string sqlStr)
        {
            DataTable ds = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }
        public CongDan LayThongTinCongDan(string sqlStr)
        {
            CongDan cd = new CongDan();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cd.SDT = (string)reader["SDT"];
                    cd.Ten = (string)reader["Ten"];
                    cd.CCCD = (string)reader["CCCD"];
                    cd.TonGiao = (string)reader["TonGiao"];
                    cd.MaHoKhau = (string)reader["MaHK"];
                    cd.QuanHeVoiChuHo = (string)reader["QuanHeVoiChuHo"];
                    cd.NgheNghiep = (string)reader["NgheNghiep"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai " + ex);
            }
            finally
            {
                conn.Close();
            }
            return cd;
        }

        public CCCD LayThongTinCCCD(string sqlStr)
        {
           CCCD cCCD = new CCCD();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cCCD.MaCCCD = (string)reader["MaCCCD"];
                    cCCD.NgayCap = reader.GetDateTime("NgayCap");
                    cCCD.DacDiem = (string)reader["DacDiem"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai " + ex);
            }
            finally
            {
                conn.Close();
            }
            return cCCD;
        }
        public Account LayThongTinTaiKhoan(string sqlStr)
        {
            Account accTmp = new Account();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    accTmp.UserName = (string)reader["UserName"];
                    accTmp.Password = (string)reader["StrPassword"];
                    accTmp.DisplayName = (string)reader["DisplayName"];
                    int type;
                    int.TryParse(reader["QuyenTruyCap"].ToString(), out type);
                    accTmp.Type = type;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai " + ex);
            }
            finally
            {
                conn.Close();
            }
            return accTmp;
        }
        public KhaiSinh LayThongTinKhaiSinh(string sqlStr)
        {
            KhaiSinh ks = new KhaiSinh();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ks.MaKhaiSinh = (string)reader["MaKS"];
                    ks.HoTen = (string)reader["Ten"];
                    ks.NgaySinh = reader.GetDateTime("NgaySinh");
                    ks.NgayDangKy = reader.GetDateTime("NgayDangKy");
                    ks.GioiTinh = (string)reader["GioiTinh"];
                    ks.DanToc = (string)reader["DanToc"];
                    ks.QuocTich = (string)reader["QuocTich"];
                    DiaChi temp = new DiaChi();
                    temp.DinhDang((string)reader["NoiSinh"]);
                    ks.NoiSinh = temp;
                    DiaChi temp2 = new DiaChi();
                    temp2.DinhDang((string)reader["QueQuan"]);
                    ks.QueQuan = temp2;
                    ks.CCCDCha = (string)reader["CCCDCha"];
                    ks.TenCha = (string)reader["TenCha"];
                    ks.CCCDMe = (string)reader["CCCDMe"];
                    ks.TenMe = (string)reader["TenMe"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai " + ex);
            }
            finally
            {
                conn.Close();
            }
            return ks;
        }

        public Thue LayThongTinThue(string sqlStr)
        {
            Thue thue = new Thue();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    thue.MaThue = (string)reader["MaThue"];
                    thue.NgayCapMa = reader.GetDateTime("NgayCap");
                    thue.HanNop = reader.GetDateTime("HanNop");
                    thue.SoTienCanNop = (string)reader["SoTienCanNop"];
                    thue.SoTienDaNop = (string)reader["SoTienDaNop"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai " + ex);
            }
            finally
            {
                conn.Close();
            }
            return thue;
        }

        public HoKhau LayThongTinHoKhau(string sqlStr)
        {
            HoKhau hk = new HoKhau();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hk.MaHoKhau = (string)reader["MaHK"];
                    hk.CCCDChuHo = (string)reader["CCCDChuHo"];
                    DiaChi temp = new DiaChi();
                    temp.DinhDang((string)reader["DiaChi"]);
                    hk.DiaChi = temp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai " + ex);
            }
            finally
            {
                conn.Close();
            }
            return hk;
        }
        public HonNhan LayThongTinHonNhan(string sqlStr)
        {
            HonNhan hn = new HonNhan();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hn.MaSo = (string)reader["MaHonNhan"];
                    hn.CCCDChong = (string)reader["CCCDNam"];
                    hn.TenChong = (string)reader["TenNam"];
                    hn.CCCDVo = (string)reader["CCCDNu"];
                    hn.TenVo = (string)reader["TenNu"];
                    hn.NgayDangKy = reader.GetDateTime("NgayDangKy");
                    DiaChi temp = new DiaChi();
                    temp.DinhDang((string)reader["NoiDangKy"]);
                    hn.NoiDangKy = temp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai " + ex);
            }
            finally
            {
                conn.Close();
            }
            return hn;
        }
        public TamTruTamVang LayThongTinTamTruTamVang(string sqlStr)
        {
            TamTruTamVang tttv = new TamTruTamVang();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tttv.MaSo = (string)reader["MaTTTV"];
                    tttv.CCCD = (string)reader["CCCD"];
                    tttv.NgayBatDau = reader.GetDateTime("NgayBD");
                    tttv.NgayKetThuc = reader.GetDateTime("NgayKT");
                    tttv.TrangThai = (string)reader["TrangThai"];
                    tttv.LyDo = (string)reader["LiDo"];
                    DiaChi temp = new DiaChi();
                    temp.DinhDang((string)reader["DiaChi"]);
                    tttv.DiaChi = temp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai " + ex);
            }
            finally
            {
                conn.Close();
            }
            return tttv;
        }
        public Boolean KiemTraCoKhong(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return reader.GetInt32("COUNT") > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
                return false;
            }
            finally
            { 
                conn.Close();
            }
            return false;
        }
    }
}
