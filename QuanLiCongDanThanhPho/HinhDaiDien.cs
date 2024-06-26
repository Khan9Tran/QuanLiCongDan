﻿using System.Drawing.Imaging;


namespace QuanLiCongDanThanhPho
{
    public class HinhDaiDien
    {
        //String lưu địa chỉ folder chứa hình ảnh
        private static string pathAdmin = @"..\..\..\..\HinhTaiKhoan";
        private static string pathCongdan = @"..\..\..\..\HinhCongDan";

        private string path;

        public enum Type
        {
            admin, 
            congDan
        }

        public HinhDaiDien(Type type) 
        {
            if (type == Type.admin)
                path = pathAdmin;
            else 
                path = pathCongdan;
        }

        public string GetFolderPath()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, path));
            return folderPath;
        }

        //Xóa hình
        public void DeleteDirectory(string folderPath, string fileName)
        {
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

        //Lưu hình đại diện từ picturbox về với name mới
        public void SaveHinhDaiDien(string name, OpenFileDialog ofdHinhDaiDien, PictureBox ptcHinhDaiDien)
        {
            string fileExtension = Path.GetExtension(ofdHinhDaiDien.FileName).ToLowerInvariant();

            if (fileExtension != ".jpg" && fileExtension != ".png")
            {
                // Thông báo lỗi nếu ko phải file png với jpg
                MessageBox.Show("File ảnh không hợp lệ. Chọn ảnh jpg hoặc png.");
                return;
            }

            string fileName = string.Format($"{name}{fileExtension}");
            string folderPath = GetFolderPath();
            string fullPath = Path.Combine(folderPath, fileName);

            DeleteDirectory(folderPath, $"{name}"); // Xóa ảnh cũ

            ptcHinhDaiDien.Image.Save(fullPath, fileExtension == ".jpg" ? ImageFormat.Jpeg : ImageFormat.Png);
        }

        //Mở file để lấy hình đưa vào picturebox
        public bool ThemHinhDaiDien(OpenFileDialog ofdHinhDaiDien, PictureBox ptcHinhDaiDien)
        {
            ofdHinhDaiDien.Filter = "PImage Files (*.jpg, *.png)|*.jpg;*.png";
            try
            {
                if (ofdHinhDaiDien.ShowDialog() == DialogResult.OK)
                {
                    ptcHinhDaiDien.Image = new Bitmap(ofdHinhDaiDien.FileName);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        private void GanHinh(string filename, PictureBox ptcHinhDaiDien)
        {
            Bitmap? bitmap = null;
            bitmap?.Dispose();
            ptcHinhDaiDien.Image?.Dispose();

            using (Bitmap tempImage = new Bitmap(filename, true)) //Giúp k bị lỗi không thể truy cập file đang hoạt động khi xóa
            {
                bitmap = new Bitmap(tempImage);
                ptcHinhDaiDien.Image = bitmap;
            }
        }

        //Đưa hình đại diện lên DataGridView
        public void LayHinhDaiDien(string name, PictureBox ptcHinhDaiDien)
        {
            string folderPath = GetFolderPath();
            string imagePath = string.Format(@$"{folderPath}\{name}");
            string png = imagePath + ".png";
            string jpg = imagePath + ".jpg";

            if (File.Exists(png))
            {
                GanHinh(png, ptcHinhDaiDien);
            }
            else if (File.Exists(jpg))
            {
                GanHinh(jpg, ptcHinhDaiDien);
            }
            else
            {
                ptcHinhDaiDien.Image = null;
            }
        }
    }
}
