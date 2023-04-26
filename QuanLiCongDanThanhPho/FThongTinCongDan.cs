using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCongDan : Form
    {
        private CongDan congDan;
        CongDanDAO cdDAO;
        KhaiSinhDAO ksDAO;
        ThueDAO thueDAO;
        HonNhanDAO hnDAO;
        HoKhauDAO hkDAO;
        TamTruTamVangDAO tttvDAO;

        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
 
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void KhoiTao()
        {
            StackForm.Add(this);
            cdDAO = new CongDanDAO();
            ksDAO = new KhaiSinhDAO();
            thueDAO = new ThueDAO();
            hkDAO = new HoKhauDAO();
            hnDAO = new HonNhanDAO();
            tttvDAO = new TamTruTamVangDAO();
        }

        public FThongTinCongDan()
        {
            InitializeComponent();
            KhoiTao();
        }

        public FThongTinCongDan(CongDan congDan)
        {
            InitializeComponent();
            KhoiTao();
            this.congDan = congDan;
        }
        
        //Mở F khai sinh
        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            FThongTinKhaiSinh tTKS = new FThongTinKhaiSinh(congDan.CCCD);
            tTKS.ShowDialog();
        }

        //Chỉ cho phép xem
        private void ReadOnly()
        {
            txtNgheNghiep.ReadOnly = true;
            txtNgheNghiep.BackColor = Color.Gainsboro;
            txtHoVaTen.ReadOnly = true;
            txtHoVaTen.BackColor = Color.Gainsboro;
            txtSDT.ReadOnly= true;
            txtSDT.BackColor = Color.Gainsboro;
            txtTonGiao.ReadOnly= true;
            txtTonGiao.BackColor = Color.Gainsboro;
            btnXacNhan.Enabled = false;
            txtDanToc.ReadOnly = true;
            txtDanToc.BackColor= Color.Gainsboro;
            txtQueQuan.ReadOnly = true;
            txtQueQuan.BackColor = Color.Gainsboro;
            txtQuocTich.ReadOnly = true;
            txtQuocTich.BackColor = Color.Gainsboro;
            txtDiaChi.ReadOnly = true;
            txtDiaChi.BackColor = Color.Gainsboro;
            txtGioiTinh.ReadOnly = true;
            txtGioiTinh.BackColor = Color.Gainsboro;
            txtQuanHeVoiChuHo.ReadOnly = true;
            txtQuanHeVoiChuHo.BackColor = Color.Gainsboro;
            dtmNgaySinh.Enabled = false;
            ptcHinhDaiDien.Enabled = false;
            ptcHinhDaiDien.BackColor = Color.Transparent;
        }

        //Cho phép sửa đổi
        private void UnReadOnLy()
        {
            txtNgheNghiep.ReadOnly = false;
            txtNgheNghiep.BackColor = Color.SteelBlue;
            txtHoVaTen.ReadOnly = false;
            txtHoVaTen.BackColor = Color.SteelBlue;  
            txtSDT.ReadOnly = false;
            txtSDT.BackColor = Color.SteelBlue;
            txtTonGiao.ReadOnly = false;
            txtTonGiao.BackColor = Color.SteelBlue;
            btnXacNhan.Enabled = true;
            txtDanToc.ReadOnly = false;
            txtDanToc.BackColor = Color.SteelBlue;
            txtQueQuan.ReadOnly = false;
            txtQueQuan.BackColor = Color.SteelBlue;
            txtQuocTich.ReadOnly = false;
            txtQuocTich.BackColor = Color.SteelBlue;
            txtDiaChi.ReadOnly = false;
            txtDiaChi.BackColor = Color.SteelBlue;
            txtGioiTinh.ReadOnly = false;
            txtGioiTinh.BackColor = Color.SteelBlue;
            if (txtMaHoKhau.Text != "Unknow")
            {
                txtQuanHeVoiChuHo.ReadOnly = false;
                txtQuanHeVoiChuHo.BackColor = Color.SteelBlue;
            }
            dtmNgaySinh.Enabled = true;
            ptcHinhDaiDien.Enabled = true;
            ptcHinhDaiDien.BackColor = Color.SteelBlue;
        }

        //Tự động đổi chế độ
        private void AutoReadOnly()
        {
            if (txtHoVaTen.ReadOnly == true)
            {
                UnReadOnLy();
            }
            else
            {
                ReadOnly();
            }
        }

        //Lấy ảnh công dân hiện lên picturebox
        private void LayCongDan()
        {
            txtCCCD.Text = congDan.CCCD;
            txtHoVaTen.Text = congDan.Ten;
            txtMaHoKhau.Text = congDan.MaHoKhau;
            txtSDT.Text = congDan.SDT;
            txtTonGiao.Text = congDan.TonGiao;
            txtNgheNghiep.Text = congDan.NgheNghiep;
            txtQuanHeVoiChuHo.Text = congDan.QuanHeVoiChuHo;
        }

        private void LayKhaiSinh()
        {
            KhaiSinh ks = ksDAO.LayThongTin(congDan.CCCD);
            dtmNgaySinh.Value = ks.NgaySinh;
            if (ks.GioiTinh == "f")  // "f" là giới tính nữ, "m" là nam
                txtGioiTinh.Text = "Nữ";
            else
                txtGioiTinh.Text = "Nam";
            txtDanToc.Text = ks.DanToc;
            txtQuocTich.Text = ks.QuocTich;
            txtQueQuan.Text = ks.QueQuan.toString();
        }

        private void LayThue()
        {
            Thue thue = thueDAO.LayThongTin(congDan.CCCD);
            if (thue.MaThue == null || thue.MaThue == "")
                btnThue.Enabled = false;
            txtMaThue.Text = thue.MaThue;
        }

        private void LayHonNhan()
        {
            HonNhan hn = new HonNhan();
            hn = hnDAO.LayThongTin(congDan.CCCD);
            if (!hnDAO.KiemTraHonNhan(congDan.CCCD))
            {
                txtHonNhan.Text = "Chưa có hôn nhân";
                btnHonNhan.Enabled = false;
            }
            else
                txtHonNhan.Text = hn.MaSo;
        }

        private void LayHoKhau()
        {
            HoKhau hk = hkDAO.LayThongTin(congDan.MaHoKhau);
            txtDiaChi.Text = hk.DiaChi.toString();
        }

        private void LayTamTruTamVang()
        {
            TamTruTamVang tttv = new TamTruTamVang();
            if (!tttvDAO.KiemTraTamTruTamVang(congDan.CCCD))
                txtGhiChu.Text = "Không có ghi chú";
            else
            {
                tttv = tttvDAO.LayThongTin(congDan.CCCD);
                txtGhiChu.Text = tttv.TrangThai;
            }
        }

        private void GanHinh(string filename)
        {
            Bitmap bitmap = null;
            bitmap?.Dispose();
            ptcHinhDaiDien.Image?.Dispose();

            using (Bitmap tempImage = new Bitmap(filename, true)) //Giúp k bị lỗi không thể truy cập file đang hoạt động khi xóa
            {
                bitmap = new Bitmap(tempImage);
                ptcHinhDaiDien.Image = bitmap;
            }
        }

        private string GetFolderPath()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\..\HinhCongDan"));
            return folderPath;
        }

        //Lấy hình công dân từ folder HinhCongDan
        private void LayHinhDaiDien()
        {
            string folderPath = GetFolderPath();
            string imagePath = string.Format(@$"{folderPath}\{txtCCCD.Text}");
            string png = imagePath + ".png";
            string jpg = imagePath + ".jpg";
            if (File.Exists(png))
            {
                GanHinh(png);
            }
            else if (File.Exists(jpg))
            {
                GanHinh(jpg);
            }
        }

        public void LayThongTinCongDan()
        {
            if (congDan != null)
            {
                LayCongDan();
                LayKhaiSinh();
                LayThue();
                LayHonNhan();
                LayHoKhau();
                LayTamTruTamVang();
                LayHinhDaiDien();
            }
        }

        private void FThongTinCongDan_Load(object sender, EventArgs e)
        {
                LayThongTinCongDan();
        }

        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            FThongTinHoKhau tTHK = new FThongTinHoKhau(congDan.MaHoKhau);
            tTHK.ShowDialog();
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            FThongTinThue tTThue = new FThongTinThue(congDan.CCCD);
            tTThue.ShowDialog();
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isTen(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại họ và tên");
                txtHoVaTen.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isGioiTinh(txtGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại giới tính");
                txtGioiTinh.Focus();
                return false;
            }
            if (txtNgheNghiep.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại nghề nghiệp");
                txtNgheNghiep.Focus();
                return false;
            }
            if (txtQuocTich.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại quốc tịch");
                txtQuocTich.Focus();
                return false;
            }
            if (txtDanToc.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại dân tộc");
                txtDanToc.Focus();
                return false;
            }
            if (txtTonGiao.Text == "")
            {
                MessageBox.Show("Tôn giáo không được để trống");
                txtTonGiao.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại địa chỉ");
                txtDiaChi.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtQueQuan.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại quê quán");
                txtQueQuan.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isSoDT(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại số điện thoại");
                txtSDT.Focus();
                return false;
            }      
            if (txtQuanHeVoiChuHo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mối quan hệ với chủ hộ");
                txtQuanHeVoiChuHo.Focus();
                return false;
            }    
            return true;
        }

        private void btnHonNhan_Click(object sender, EventArgs e)
        {
            FThongTinHonNhan tTHN = new FThongTinHonNhan(congDan.CCCD);
            tTHN.ShowDialog();
        }

        private void CapNhatKhaiSinh()
        {
            KhaiSinh khaiSinh = ksDAO.LayThongTin(congDan.CCCD);
            khaiSinh.HoTen = txtHoVaTen.Text;
            khaiSinh.QueQuan.DinhDang(txtQueQuan.Text);
            khaiSinh.NgaySinh = dtmNgaySinh.Value;
            khaiSinh.DanToc = txtDanToc.Text;
            khaiSinh.QuocTich = txtQuocTich.Text;
            khaiSinh.GioiTinh = txtGioiTinh.Text;
            khaiSinh.DinhDangGioiTinh();
            ksDAO.CapNhatKhaiSinh(khaiSinh);  
        }    

        private void CapNhatCongDan()
        {
            congDan.Ten = txtHoVaTen.Text;
            congDan.SDT = txtSDT.Text;
            congDan.NgheNghiep = txtNgheNghiep.Text;
            congDan.TonGiao = txtTonGiao.Text;
            congDan.QuanHeVoiChuHo = txtQuanHeVoiChuHo.Text;
            cdDAO.CapNhatCongDan(congDan);
        }

        //Thay đổi chủ hộ ở table hộ khẩu nếu có
        private void CapNhatHoKhau()
        {
            HoKhau hoKhau = hkDAO.LayThongTin(txtMaHoKhau.Text);
            if (txtQuanHeVoiChuHo.Text == "Chủ hộ" && hoKhau.CCCDChuHo != txtCCCD.Text)
            {
                    CongDan cD = cdDAO.LayThongTin(hoKhau.CCCDChuHo);
                    cD.QuanHeVoiChuHo = "Unknow";
                    hoKhau.CCCDChuHo = txtCCCD.Text;
                    cdDAO.CapNhatCongDan(cD);
            }
            hoKhau.DiaChi.DinhDang(txtDiaChi.Text);
            hkDAO.CapNhatHoKhau(hoKhau);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {  
            AutoReadOnly();
        }

        private void CapNhatHonNhan()
        {
            if (txtHonNhan.Text != "Chưa có hôn nhân" && txtHonNhan.Text != "")
            {
                HonNhan hn = hnDAO.LayThongTin(congDan.CCCD);
                if (txtCCCD.Text == hn.CCCDChong)
                    hn.TenChong = txtHoVaTen.Text;  
                else
                    hn.TenVo = txtHoVaTen.Text;
                hnDAO.CapNhatHonNhan(hn);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {  
            if (KiemTraThongTin())
            {
                CapNhatCongDan();
                CapNhatKhaiSinh();
                CapNhatHonNhan();
                LayThongTinCongDan();
                CapNhatHoKhau();
                ReadOnly();
            }    
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinCongDan();
            ReadOnly();
        }

        //Xóa file ảnh tồn tại
        public void DeleteDirectory(string folderPath, string fileName)
        {
            //Phải kiểm tra từng phần đuôi file, vì ofdHinhDaiDien được gán cho giá trị mới rồi, ko thể dùng để lấy đuôi ảnh cũ được
            string fileNamePng = fileName + ".png";
            string fullPathPng = Path.Combine(folderPath, fileNamePng);

            string fileNameJpg = fileName + ".jpg";
            string fullPathJpg = Path.Combine(folderPath, fileNameJpg);

            if (File.Exists(fullPathPng)) 
            {
                File.Delete(fullPathPng);
            }
            if (File.Exists(fullPathJpg)) 
            {
                File.Delete(fullPathJpg);
            }
        }

        private void SaveHinhDaiDien()
        {
            string fileExtension = Path.GetExtension(ofdHinhDaiDien.FileName).ToLowerInvariant();

            if (fileExtension != ".jpg" && fileExtension != ".png")
            {
                // Thông báo lỗi nếu ko phải file png với jpg
                MessageBox.Show("File ảnh không hợp lệ. Chọn ảnh jpg hoặc png.");
                return;
            }

            string fileName = $"{txtCCCD.Text}{fileExtension}";
            string folderPath = GetFolderPath();
            string fullPath = Path.Combine(folderPath, fileName);

            DeleteDirectory(folderPath, $"{txtCCCD.Text}"); // Xóa ảnh cũ

            ptcHinhDaiDien.Image.Save(fullPath, fileExtension == ".jpg" ? ImageFormat.Jpeg : ImageFormat.Png);
        }

        private void ThemHinh()
        {
            ofdHinhDaiDien.Filter = "PImage Files (*.jpg, *.png)|*.jpg;*.png";
            try
            {
                if (ofdHinhDaiDien.ShowDialog() == DialogResult.OK)
                {
                    ptcHinhDaiDien.Image = new Bitmap(ofdHinhDaiDien.FileName);
                    SaveHinhDaiDien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không mở được ảnh" + ex);
            }
        }

        private void picCongDan_Click(object sender, EventArgs e)
        {
            ptcHinhDaiDien.Image = null;
            ThemHinh();
        }

        private void btnThongTinCCCD_Click(object sender, EventArgs e)
        {
            FThongTinCCCD thongTinCCCD = new FThongTinCCCD(congDan);
            thongTinCCCD.ShowDialog();
        }
    }
}
