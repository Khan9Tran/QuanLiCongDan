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
        KhaiSinhDAO ksDAO = new KhaiSinhDAO();
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        public string MaCCCD
        {
            set { maCCCD = value; }
            get { return maCCCD; }
        }
        public FThongTinKhaiSinh()
        {
            InitializeComponent();
        }
        public FThongTinKhaiSinh(string maCCCD)
        {
            MaCCCD = maCCCD;
            InitializeComponent();
            StackForm.Add(this);
        }
        private void btnThongTinCha_Click(object sender, EventArgs e)
        {
            if (txtCccdCha.Text != "" && txtCccdCha.Text != "unknow")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(txtCccdCha.Text);
                tTCD.ShowDialog();
            }
        }

        private void btnThongTinMe_Click(object sender, EventArgs e)
        {
            if (txtCccdMe.Text != "" && txtCccdMe.Text != "unknow")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(txtCccdMe.Text);
                tTCD.ShowDialog();
            }
        }
        public void LayThongTinKhaiKhaiSinh()
        {
            if (maCCCD != null)
            {
                KhaiSinh ks = ksDAO.LayThongTin(maCCCD);
                KhaiSinh ksCha = ksDAO.LayThongTin(ks.CCCDCha);
                KhaiSinh ksMe = ksDAO.LayThongTin(ks.CCCDMe);
                txtTen.Text = ks.HoTen;
                txtCccd.Text = ks.MaKhaiSinh;
                txtNoiSinh.Text = ks.NoiSinh.toString();
                dtpNgaySinh.Value = ks.NgaySinh;
                if (ks.GioiTinh == "f")
                    txtGioiTinh.Text = "Nữ";
                else if (ks.GioiTinh == "m")
                    txtGioiTinh.Text = "Nam";
                else
                    txtGioiTinh.Text = "unknow";
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
        private void FThongTinKhaiSinh_Load(object sender, EventArgs e)
        {
            LayThongTinKhaiKhaiSinh();
        }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        private void lblTittle_Click(object sender, EventArgs e)
        {

        }
    }
}
