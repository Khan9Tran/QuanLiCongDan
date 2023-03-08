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
    public partial class FThongTinThue : Form
    {
        private string maCCCD;
        ThueDAO thueDAO = new ThueDAO();
        CongDanDAO cdDAO = new CongDanDAO();
        HoKhauDAO hkDAO = new HoKhauDAO();
        public string MaCCCD
        {
            set { maCCCD = value; }
            get { return maCCCD; }
        }
        public FThongTinThue()
        {
            InitializeComponent();
        }
        public FThongTinThue(string maCCCD)
        {
            MaCCCD = maCCCD;
        }
        private void FThongTinThue_Load(object sender, EventArgs e)
        {
            Thue thue = thueDAO.LayThongTin(MaCCCD);
            CongDan cd = cdDAO.LayThongTin(MaCCCD);
            HoKhau hk = hkDAO.LayThongTin(cd.MaHoKhau);
            txtMaSoThue.Text = thue.MaThue;
            txtTen.Text = cd.Ten;
            txtCCCD.Text = cd.CCCD;
            txtSdt.Text = cd.SDT;
            txtDiaChi.Text = hk.DiaChi.toString();
            txtSoTienCanNop.Text = thue.SoTienCanNop;
            txtSoTienDaNop.Text = thue.SoTienDaNop;
            dtpNgayCapMaSoThue.Value = thue.NgayCapMa;
            dtpHanNopThue.Value = thue.HanNop;
        }
    }
}
