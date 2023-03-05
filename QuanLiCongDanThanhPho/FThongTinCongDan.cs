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
    public partial class FThongTinCongDan : Form
    {
        private string maCCCD;
        public string MaCCCD
        {
            set { maCCCD = value; }
            get { return maCCCD; }
        }
        CongDanDAO cdDAO = new CongDanDAO();
        KhaiSinhDAO ksDAO = new KhaiSinhDAO();
        ThueDAO thueDAO = new ThueDAO();
        HonNhanDAO hnDAO = new HonNhanDAO();
        HoKhauDAO hkDAO = new HoKhauDAO();
        TamTruTamVangDAO tttvDAO = new TamTruTamVangDAO();
        public FThongTinCongDan()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            FThongTinKhaiSinh tTKS = new FThongTinKhaiSinh();
            tTKS.ShowDialog();
        }

        private void FThongTinCongDan_Load(object sender, EventArgs e)
        {
            CongDan cd = cdDAO.LayThongTin(MaCCCD);
            txtCCCD.Text = cd.CCCD;
            txtHoVaTen.Text = cd.Ten;
            txtMaHoKhau.Text = cd.MaHoKhau;
            txtSDT.Text = cd.SDT;
            txtTonGiao.Text = cd.TonGiao;
            txtNgheNghiep.Text = cd.NgheNghiep;
            //----------------//
            KhaiSinh ks = ksDAO.LayThongTin(MaCCCD);
            dtpNgaySinh.Value = ks.NgaySinh;
            txtDanToc.Text = ks.DanToc;
            txtGioiTinh.Text = ks.GioiTinh;
            txtDanToc.Text = ks.DanToc;
            txtQuocTich.Text = ks.QuocTich;
            txtQueQuan.Text = ks.QueQuan.toString();
            //-----------------//
            Thue thue = thueDAO.LayThongTin(MaCCCD);
            txtMaThue.Text = thue.MaThue.ToString();
            //------------------//
            HonNhan hn = new HonNhan();
            hn = hnDAO.LayThongTin(MaCCCD);
            if (!hnDAO.KiemTraHonNhan(MaCCCD))
                txtHonNhan.Text = "Chưa có hôn nhân";
            else
                txtHonNhan.Text = hn.MaSo;
            //---------------------//
            HoKhau hk = new HoKhau();
            hk = hkDAO.LayThongTin(cd.MaHoKhau);
            txtDiaChi.Text = hk.DiaChi.toString();
            //---------------------//
            TamTruTamVang tttv = new TamTruTamVang();
            tttv = tttvDAO.LayThongTin(MaCCCD);
            if (!tttvDAO.KiemTraTamTruTamVang(MaCCCD))
                txtGhiChu.Text = "Không có ghi chú";
            else
                txtGhiChu.Text = tttv.TrangThai;
        }

        private void FThongTinCongDan_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pnlThongTinCD_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
