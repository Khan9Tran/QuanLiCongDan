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
        CongDanDAO cdDAO = new CongDanDAO();
        KhaiSinhDAO ksDAO = new KhaiSinhDAO();
        ThueDAO thueDAO = new ThueDAO();
        HonNhanDAO hnDAO = new HonNhanDAO();
        HoKhauDAO hkDAO = new HoKhauDAO();
        TamTruTamVangDAO tttvDAO = new TamTruTamVangDAO();
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        
        public string MaCCCD
        {
            set { maCCCD = value; }
            get { return maCCCD; }
        }
 
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        public FThongTinCongDan()
        {
            InitializeComponent();
        }

        public FThongTinCongDan(string maCCCD)
        {
            MaCCCD = maCCCD;
            InitializeComponent();
            StackForm.Add(this);
        }

        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            FThongTinKhaiSinh tTKS = new FThongTinKhaiSinh(MaCCCD);
            tTKS.ShowDialog();
        }

        private void FThongTinCongDan_Load(object sender, EventArgs e)
        {
            if (maCCCD != null)
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
                if (ks.GioiTinh == "f")
                    txtGioiTinh.Text = "Nữ";
                else
                    txtGioiTinh.Text = "Nam";
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
                if (!tttvDAO.KiemTraTamTruTamVang(MaCCCD))
                    txtGhiChu.Text = "Không có ghi chú";
                else
                {
                    tttv = tttvDAO.LayThongTin(MaCCCD);
                    txtGhiChu.Text = tttv.TrangThai;
                }
            }
        }

        private void FThongTinCongDan_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pnlThongTinCD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            CongDan cd = cdDAO.LayThongTin(maCCCD);
            FThongTinHoKhau tTHK = new FThongTinHoKhau(cd.MaHoKhau);
            tTHK.ShowDialog();
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            FThongTinThue tTThue = new FThongTinThue(MaCCCD);
            tTThue.ShowDialog();
        }

        private void btnHonNhan_Click(object sender, EventArgs e)
        {
            FThongTinHonNhan tTHN = new FThongTinHonNhan(MaCCCD);
            tTHN.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtNgheNghiep.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTonGiao.ReadOnly = false;
        }

        
    }
}
