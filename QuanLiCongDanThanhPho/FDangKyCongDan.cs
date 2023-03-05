using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyCongDan : Form
    {
        CongDanDAO cdDAO;
        KhaiSinhDAO kSDAO;
        ThueDAO thueDAO;
        HonNhanDAO hNDAO;
        TamTruTamVangDAO tTTVDAO;
        CCCDDAO cCCDDAO;
        public FDangKyCongDan()
        {
            InitializeComponent();
            cdDAO = new CongDanDAO();
            kSDAO = new KhaiSinhDAO();
            thueDAO = new ThueDAO();
            hNDAO= new HonNhanDAO();
            tTTVDAO = new TamTruTamVangDAO();
            cCCDDAO = new CCCDDAO();
        }
        
        public void ThemCongDan()
        {
            CongDan cD = new CongDan(txtCCCD.Text, txtTen.Text, txtNgheNghiep.Text, txtSoDT.Text, cboTonGiao.SelectedItem.ToString(), txtHoKhau.Text, cboQuanHe.SelectedItem.ToString(), txtDiaChi.Text);
            cdDAO.ThemCongDan(cD);
            CCCD cCCD = new CCCD(txtCCCD.Text);
            cCCDDAO.ThemCCCD(cCCD);
            Thue thue = new Thue(txtThue.Text, txtCCCD.Text);
            thueDAO.ThemThue(thue);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemCongDan();
        }

        private void FDangKyCongDan_Load(object sender, EventArgs e)
        {

        }
    }
}
