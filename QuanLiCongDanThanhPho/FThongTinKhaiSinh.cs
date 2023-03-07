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
    public partial class FThongTinKhaiSinh : Form
    {
        private string maCCCD;
        public string MaCCCD
        {
            set { maCCCD = value; }
            get { return maCCCD; }
        }
        KhaiSinhDAO ksDAO = new KhaiSinhDAO();
        public FThongTinKhaiSinh()
        {
            InitializeComponent();
        }

        private void btnThongTinCha_Click(object sender, EventArgs e)
        {
            if (txtCccdCha.Text != "" && txtCccdCha.Text != "u")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan();
                tTCD.MaCCCD = txtCccdCha.Text;
                tTCD.ShowDialog();
            }
        }

        private void btnThongTinMe_Click(object sender, EventArgs e)
        {
            if (txtCccdMe.Text != "" && txtCccdMe.Text != "u")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan();
                tTCD.MaCCCD = txtCccdMe.Text;
                tTCD.ShowDialog();
            }
        }

        private void FThongTinKhaiSinh_Load(object sender, EventArgs e)
        {
            KhaiSinh ks = ksDAO.LayThongTin(maCCCD);
            KhaiSinh ksCha = ksDAO.LayThongTin(ks.CCCDCha);
            KhaiSinh ksMe = ksDAO.LayThongTin(ks.CCCDMe);
            txtTen.Text = ks.HoTen;
            txtCccd.Text = ks.MaKhaiSinh;
            txtNoiSinh.Text = ks.NoiSinh.toString();
            dtpNgaySinh.Value = ks.NgaySinh;
            txtGioiTinh.Text = ks.GioiTinh;
            txtDanToc.Text = ks.DanToc;
            txtQuocTich.Text = ks.QuocTich;
            txtQueQuan.Text = ks.QueQuan.toString();
            txtTenCha.Text = ks.TenCha;
            txtTenMe.Text = ks.TenMe;
            txtCccdCha.Text = ks.CCCDCha;
            txtCccdMe.Text = ks.CCCDMe;
            txtQuocTichCha.Text = ksCha.QuocTich;
            txtQuocTichMe.Text = ksMe.QuocTich;
        }
    }
}
