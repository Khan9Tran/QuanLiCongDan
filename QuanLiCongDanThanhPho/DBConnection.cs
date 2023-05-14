using System.Data.SqlClient;
using System.Data;
using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    internal class DBConnection
    {
        //Tạo kết nối
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        //Thực thi câu lệnh sql
        public bool ThucThi(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        //Trả về danh sách thỏa chuỗi sql
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

        //Trả về công dân thỏa câu sql
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
                    cd.SDT = reader["SDT"].ToString();
                    cd.Ten = reader["Ten"].ToString();
                    cd.CCCD = reader["CCCD"].ToString();
                    cd.TonGiao = reader["TonGiao"].ToString();
                    cd.MaHoKhau = reader["MaHK"].ToString();
                    cd.QuanHeVoiChuHo = reader["QuanHeVoiChuHo"].ToString();
                    cd.NgheNghiep = reader["NgheNghiep"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
            return cd;
        }

        //Trả về CCCD thỏa câu sql
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
                    cCCD.MaCCCD = reader["MaCCCD"].ToString();
                    if (reader["NgayCap"] != DBNull.Value)
                    {
                        cCCD.NgayCap = reader.GetDateTime("NgayCap");
                    }
                    cCCD.DacDiem = reader["DacDiem"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
            return cCCD;
        }

        //Trả về tài khoản thỏa câu sql
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
                MessageBox.Show("Thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
            return accTmp;
        }

        //Trả về thông tin khai sinh thỏa câu sql
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
                    ks.MaKhaiSinh = reader["MaKS"].ToString();
                    ks.HoTen = reader["Ten"].ToString();
                    ks.NgaySinh = reader.GetDateTime("NgaySinh");
                    ks.NgayDangKy = reader.GetDateTime("NgayDangKy");
                    ks.GioiTinh = reader["GioiTinh"].ToString();
                    ks.DanToc = reader["DanToc"].ToString();
                    ks.QuocTich = reader["QuocTich"].ToString();
                    DiaChi temp = new DiaChi();
                    temp.DinhDang(reader["NoiSinh"].ToString());
                    ks.NoiSinh = temp;
                    DiaChi temp2 = new DiaChi();
                    temp2.DinhDang(reader["QueQuan"].ToString());
                    ks.QueQuan = temp2;
                    ks.CCCDCha = reader["CCCDCha"].ToString();
                    ks.TenCha = reader["TenCha"].ToString();
                    ks.CCCDMe = reader["CCCDMe"].ToString();
                    ks.TenMe = reader["TenMe"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
            return ks;
        }

        //Trả về Thue thỏa câu sql
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
                    thue.MaThue = reader["MaThue"].ToString();
                    thue.CCCD = reader["CCCD"].ToString();
                    thue.NgayCapMa = reader.GetDateTime("NgayCap");
                    thue.HanNop = reader.GetDateTime("HanNop");
                    thue.SoTienCanNop = reader["SoTienCanNop"].ToString();
                    thue.SoTienDaNop = reader["SoTienDaNop"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
            return thue;
        }

        //Trả về hộ khẩu thỏa câu Sql
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
                    hk.MaHoKhau = reader["MaHK"].ToString();
                    hk.CCCDChuHo = reader["CCCDChuHo"].ToString();
                    DiaChi temp = new DiaChi();
                    temp.DinhDang(reader["DiaChi"].ToString());
                    hk.DiaChi = temp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
            return hk;
        }

        //Trả về hôn nhân thỏa câu sql
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
                    hn.MaSo = reader["MaHonNhan"].ToString();
                    hn.CCCDChong = reader["CCCDNam"].ToString();
                    hn.TenChong = reader["TenNam"].ToString();
                    hn.CCCDVo = reader["CCCDNu"].ToString();
                    hn.TenVo = reader["TenNu"].ToString();
                    hn.NgayDangKy = reader.GetDateTime("NgayDangKy");
                    DiaChi temp = new DiaChi();
                    temp.DinhDang(reader["NoiDangKy"].ToString());
                    hn.NoiDangKy = temp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
            return hn;
        }

        //Trả về TamTruTamVang thỏa câu sql
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
                    tttv.MaSo = reader["MaTTTV"].ToString();
                    tttv.CCCD = reader["CCCD"].ToString();
                    tttv.NgayBatDau = reader.GetDateTime("NgayBD");
                    tttv.NgayKetThuc = reader.GetDateTime("NgayKT");
                    tttv.TrangThai = reader["TrangThai"].ToString();
                    tttv.LyDo = reader["LiDo"].ToString();
                    DiaChi temp = new DiaChi();
                    temp.DinhDang(reader["DiaChi"].ToString());
                    tttv.DiaChi = temp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
            return tttv;
        }

        //Kiểm tra có tồn tại đối tượng thỏa câu sql không
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
