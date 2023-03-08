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
    public partial class FThongTinHonNhan : Form
    {
        private string maCCCD;
        HonNhanDAO hnDAO = new HonNhanDAO();

        public string MaCCCD
        {
            set { maCCCD = value; }
            get { return maCCCD; }
        }
        public FThongTinHonNhan()
        {
            InitializeComponent();
        }
        public FThongTinHonNhan(string maCCCD)
        {
            MaCCCD = maCCCD;
            InitializeComponent();
        }
        private void btnThongTinChong_Click(object sender, EventArgs e)
        {
            if (txtCCCDChong.Text != "")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(txtCCCDChong.Text);
                tTCD.ShowDialog();
            }
        }

        private void btnThongTinVo_Click(object sender, EventArgs e)
        {
            if (txtCCCDVo.Text != "")
            {
                FThongTinCongDan tTCD = new FThongTinCongDan(txtCCCDVo.Text);
                tTCD.ShowDialog();
            }
        }

        private void FThongTinHonNhan_Load(object sender, EventArgs e)
        {
            if (maCCCD != null)
            {
                HonNhan hn = hnDAO.LayThongTin(maCCCD);
                txtTenChong.Text = hn.TenChong;
                txtTenVo.Text = hn.TenVo;
                txtCCCDChong.Text = hn.CCCDChong;
                txtCCCDVo.Text = hn.CCCDVo;
                txtNoiDangKy.Text = hn.NoiDangKy.toString();
                dtpNgayDangKy.Value = hn.NgayDangKy;
            }
        }
    }
}
