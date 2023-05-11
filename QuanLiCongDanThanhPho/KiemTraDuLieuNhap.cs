using QuanLiCongDanThanhPho.Models;
using System.Text.RegularExpressions;

namespace QuanLiCongDanThanhPho
{
    internal static class KiemTraDuLieuNhap
    {
        public static bool KiemTra(string s, string rule)
        {
            return Regex.IsMatch(s, rule);
        }
        public static bool isTien(string tien)
        {
            string rule = @"^\d{1,15}$";
            return KiemTra(tien, rule);
        }
        public static bool isPass(string pass)
        {;
            string rule = @"^.*(?=.{6,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@ #$%^&+=]).*$";
            return KiemTra(pass, rule);
        }
        public  static bool isDiaChi(string diaChi)
        {
            string rule = @"^([^#$%*+.@!]{1,25})[,]([^#$%*+.@!]{1,25})[,]([^#$%*+.@!]{1,25})[,]([^#$%*+.@!]{1,25})$";
            return KiemTra(diaChi, rule);
        }
        public static bool isSoDT(string SoDT)
        {
            string rule = @"^\d{9,11}$";
            return KiemTra(SoDT, rule);
        }

        public static bool isCCCD(string CCCD)
        {
            string rule = @"^\d{12}$";
            return KiemTra(CCCD, rule);
        }

        public static bool isEmpty(string data)
        {
            if (data == "" || data == null)
            {
                MessageBox.Show("Không để trống dữ liệu");
                return true;
            }
            return false;
        }

        public static bool KiemTraHonNhan(HonNhan honnhan)
        {
            CongDanDAO cdDAO = new CongDanDAO();
            if (!isMaSo(honnhan.MaSo))
            {
                return false;
            }
            CongDan chong = cdDAO.LayThongTin(honnhan.CCCDChong);
            CongDan vo = cdDAO.LayThongTin(honnhan.CCCDVo);

            if (chong.CCCD == null || vo.CCCD == null)
            {
                return false;
            }

            if (!KiemTraTenVaCCCD(chong) || !KiemTraTenVaCCCD(vo))
            {
                return false;
            }

            if (isEmpty(honnhan.NoiDangKy.toString()))
            {
                return false;
            }
            return true;
        }

        public static bool isTen(string Ten) 
        {
            string rule = @"^[^!@#$%^*()|+*0123456789]{3,30}$";
            return KiemTra(Ten, rule);
        }
        public static bool isMaSo(string MaSo)
        {
            string rule = @"^[0-9a-zA-Z]{5,15}$";
            return KiemTra(MaSo, rule);
        }
        public static bool isGioiTinh(string GioiTinh)
        {
            string rule = @"^([Nn]{1})((\u1EEE{1})|(\u1EEF{1})|([Uu]{1})|([Aa]{1}[Mm]{1}))$";
            return KiemTra(GioiTinh, rule);
        }
        public static bool KiemTraTenVaCCCD(CongDan congdan)
        {
            if (!isCCCD(congdan.CCCD))
            {
                return false;
            }
            if (!isTen(congdan.Ten))
            {
                return false;
            }
            return true;
        }
        public static bool KiemTraCongDan(CongDan congdan)
        {
            return KiemTraTenVaCCCD(congdan) && isSoDT(congdan.SDT) && !isEmpty(congdan.NgheNghiep) && !isEmpty(congdan.TonGiao);
        }
        public static bool isTamTruTamVang(TamTruTamVang data)
        {
            if (!isMaSo(data.MaSo))
            {
                return false;
            }
            if (data.TrangThai != "Tạm trú" && data.TrangThai != "Tạm vắng")
            {
                return false;
            }
            if (data.LyDo == "" || data.LyDo == null)
            {
                return false;
            }
            if (!isDiaChi(data.DiaChi.toString()))
            {
                return false;
            }
            if (!isCCCD(data.CCCD))
            {
                return false;
            }
            return true;
        }
        public static bool KiemTraHoKhau(HoKhau hokhau)
        {
            return isMaSo(hokhau.MaHoKhau) && isCCCD(hokhau.CCCDChuHo) && isDiaChi(hokhau.DiaChi.toString());
        }

        public static bool KiemTraThueDonGian(Thue thue)
        {
            return isCCCD(thue.CCCD) && isMaSo(thue.MaThue);
        }
        public static bool KiemTraThue(Thue thue)
        {
            return KiemTraThueDonGian(thue) && !isEmpty(thue.SoTienCanNop) && !isEmpty(thue.SoTienDaNop)
                 && isTien(thue.SoTienDaNop) && isTien(thue.SoTienCanNop);
        }

        public static bool KiemTraHaiHo(string maHk1, string maHk2)
        {
            if (!isMaSo(maHk1) || !isMaSo(maHk2))
            {
                return false;
            }
            if (maHk1 == maHk2)
            {
                return false;
            }
            return true;
        }

        public static bool KiemTraKhaiSinh(KhaiSinh khaiSinh)
        {
            return isDiaChi(khaiSinh.QueQuan.toString()) && isDiaChi(khaiSinh.NoiSinh.toString()) && !isEmpty(khaiSinh.QuocTich) && !isEmpty(khaiSinh.DanToc);
        }
    }
}
