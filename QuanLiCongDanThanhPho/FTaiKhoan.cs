using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Drawing.Imaging;

namespace QuanLiCongDanThanhPho
{
    public partial class FTaiKhoan : Form
    {
        private AccountDAO accountDAO;
        private Account account;

        public Account Account { get => account; set => account = value; }

        public FTaiKhoan(Account acc)
        {
            InitializeComponent();
            StackForm.Add(this);
            pnlDoiPass.Hide();
            accountDAO = new AccountDAO();
            account = acc;
        }
        private void ClearPass()
        {
            txtMatKhau.Clear();
            txtMatKhauMoiNhapLai.Clear();
            txtMatKhauMoi.Clear();
        }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (btnDoiMK.Text == "Đổi mật khẩu")
            {
                pnlDoiPass.Show();
                btnDoiMK.Text = "Đóng";
            }
            else
            {
                ClearPass();
                pnlDoiPass.Hide();
                btnDoiMK.Text = "Đổi mật khẩu";
            }
        }
        private void HienThiThongTin()
        {
            txtDisplayName.Text = account.DisplayName;
            txtUserName.Text = account.UserName;
            LayHinhDaiDien();
        }
        private void CapNhatMatKhau(string matKhauMoi, string userName)
        {
            Account acc = new Account();
            acc.Password = matKhauMoi;
            acc.UserName = userName;
            accountDAO.CapNhatMatKhau(acc);
        }
        private void CapNhatDisplayName(string newDisplayName, string userName)
        {
            account.DisplayName = newDisplayName;
            accountDAO.CapNhatDisplayName(account);
        }
        private void Reset()
        {
            txtMatKhauMoi.Clear();
            txtMatKhau.Clear();
            txtMatKhauMoiNhapLai.Clear();
        }

        private bool KiemTraPass()
        {
            if (txtMatKhau.Text != account.Password)
            {
                MessageBox.Show("Mật khẩu không chính xác.");
                return false;
            }
            if (txtMatKhauMoi.Text != txtMatKhauMoiNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp");
                return false;
            }
            if (txtMatKhauMoi.Text == txtMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ");
                return false;
            }
            if (txtMatKhauMoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải từ 6 kí tự");
                return false;
            }
            if (!KiemTraDuLieuNhap.isPass(txtMatKhauMoi.Text))
            {

                MessageBox.Show("Mật khẩu phải chứa ít nhất một chữ viết hoa, một chữ thường, một số và một kí tự đặt biệt");
                return false;
            }
            return true;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraPass())
            {
                CapNhatMatKhau(txtMatKhauMoi.Text, account.UserName);

               Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void ReadOnly()
        {
            btnThemHinh.Enabled = false;
            txtDisplayName.ReadOnly = true;
            txtDisplayName.BackColor = Color.Gainsboro;
            btnCapNhat.Enabled = false;
        }
        private void UnReadOnly()
        {
            btnThemHinh.Enabled = true;
            txtDisplayName.ReadOnly = false;
            txtDisplayName.BackColor = Color.SteelBlue;
            btnCapNhat.Enabled = true;
        }

        private void AutoReadOnLy()
        {
            if (txtDisplayName.ReadOnly == false)
            {
                ReadOnly();
            }
            else
            {
                UnReadOnly();
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtDisplayName.Text != "" && KiemTraDuLieuNhap.isTen(txtUserName.Text))
            {
                CapNhatDisplayName(txtDisplayName.Text, account.UserName);
                StackForm.fTrangChu.Account.DisplayName = txtDisplayName.Text;
                ReadOnly();
            }
            else
            {
                MessageBox.Show("Tên hiển thị sai định dạng");
            }
            SaveHinhDaiDien();
            HienThiThongTin();
            StackForm.fTrangChu.LoadTaiKhoan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AutoReadOnLy();
        }

        private void FTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void btnXemMK_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnXemMKMoi_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.UseSystemPasswordChar == true)
            {
                txtMatKhauMoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauMoi.UseSystemPasswordChar = true;
            }
        }

        private void btnXemMKNhapLai_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoiNhapLai.UseSystemPasswordChar == true)
            {
                txtMatKhauMoiNhapLai.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauMoiNhapLai.UseSystemPasswordChar = true;
            }
        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            ofdHinhDaiDien.Filter = "PImage Files (*.jpg, *.png)|*.jpg;*.png";
            try
            {
                if (ofdHinhDaiDien.ShowDialog() == DialogResult.OK)
                {
                    ptcHinhDaiDien.Image = new Bitmap(ofdHinhDaiDien.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không mở được ảnh" + ex);
            }
        }
        private void SaveHinhDaiDien()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = string.Format($"{account.UserName}");
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\..\HinhTaiKhoan"));
            string fullPath;
            if (ofdHinhDaiDien.FileName.Contains(".jpg"))
            {
                fileName += ".jpg";
                fullPath = Path.Combine(folderPath, fileName);
                ptcHinhDaiDien.Image.Save(fullPath, ImageFormat.Jpeg);
            }
            else
            {
                fileName += ".png";
                fullPath = Path.Combine(folderPath, fileName);
                ptcHinhDaiDien.Image.Save(fullPath, ImageFormat.Png);
            }
        }
        private void LayHinhDaiDien()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\..\HinhTaiKhoan"));
            string imagePath = string.Format(@$"{folderPath}\{account.UserName}");
            string png = imagePath + ".png";
            string jpg = imagePath + ".jpg";
            if (File.Exists(png))
            {
                ptcHinhDaiDien.Image = Image.FromFile(png);
                return;
            }
            if (File.Exists(jpg))
            {
                ptcHinhDaiDien.Image = Image.FromFile(jpg);
                return;
            }

        }
    } 
}
