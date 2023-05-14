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

namespace QuanLiCongDanThanhPho
{
    public partial class FXemCongDan : Form
    {
        private HinhDaiDien hinhCongDan;
        private CongDan congDan;
        private KhaiSinhDAO kSDAO;
        private HoKhauDAO hKDAO;
        private ThueDAO thueDAO;
        private HonNhanDAO hNDAO;
        private string maTamTru = "00000B";
        private string maChuaCoHK = "00000A";

        public FXemCongDan(CongDan congdan)
        {
            InitializeComponent();
            hinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
            kSDAO = new KhaiSinhDAO();
            hKDAO = new HoKhauDAO();
            thueDAO = new ThueDAO();
            hNDAO = new HonNhanDAO();
            congDan = congdan;
        }

        private bool isMaHK(string? maHK)
        {
            return maHK != maTamTru && maHK != maChuaCoHK;
        }

        private void LayCongDan()
        {
            txtCCCD.Text = congDan.CCCD;
            txtTen.Text = congDan.Ten;
            txtSDT.Text = congDan.SDT;
            hinhCongDan.LayHinhDaiDien(txtCCCD.Text, picHinhDaiDien);
        }

        private void LayKhaiSinh()
        {
            KhaiSinh ks = kSDAO.LayThongTin(congDan.CCCD);
            if (ks.MaKhaiSinh != null)
            {
                txtQuocTich.Text = ks.QuocTich;
                txtDanToc.Text = ks.DanToc;
                dtpNgaySinh.Value = ks.NgaySinh;
                if (ks.GioiTinh == "f")
                {
                    picNam.Hide();
                    picNu.Show();
                }
                else
                {
                    picNu.Hide();
                    picNam.Show();
                }
            }
        }

        private void LayHoKhau()
        {
            if (congDan.MaHoKhau != null)
            {
                HoKhau hk = hKDAO.LayThongTin(congDan.MaHoKhau);
                if (hk.MaHoKhau != null && isMaHK(hk.MaHoKhau))
                {
                    txtMaHoKhau.Text = hk.MaHoKhau;
                    txtDiaChi.Text = hk.DiaChi.toString();
                }
            }
        }

        private void LayThue()
        {
            Thue thue = thueDAO.LayThongTin(congDan.CCCD);
            if (thue.MaThue != null)
                txtMaThue.Text = thue.MaThue;
        }

        private void LayHonNhan()
        {
            HonNhan hn = hNDAO.LayThongTin(congDan.CCCD);
            if (hn.MaSo == null)
            {
                txtMaHonNhan.Text = "Chưa có hôn nhân";
            }
            else
                txtMaHonNhan.Text = hn.MaSo;
        }

        private void FXemCongDan_Load(object sender, EventArgs e)
        {
            if (congDan.CCCD != null)
            {
                LayCongDan();
                LayKhaiSinh();
                LayHoKhau();
                LayHonNhan();
                LayThue();
            }
        }
    }
}
