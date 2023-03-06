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
        CCCDDAO cCCDDAO;
        public FDangKyCongDan()
        {
            InitializeComponent();
            cdDAO = new CongDanDAO();
            kSDAO = new KhaiSinhDAO();
            thueDAO = new ThueDAO();
            hNDAO= new HonNhanDAO();
            cCCDDAO = new CCCDDAO();
        }
        
        public void ThemCongDan()
        {
            CongDan cD = new CongDan(txtCCCD.Text, txtTen.Text, txtNgheNghiep.Text, txtSoDT.Text, cboTonGiao.SelectedItem.ToString(), txtHoKhau.Text, cboQuanHe.SelectedItem.ToString(), txtDiaChi.Text);
            cdDAO.ThemCongDan(cD);

            KhaiSinh kS = new KhaiSinh(txtCCCD.Text, txtTen.Text, cboQuocTich.SelectedItem.ToString(), cboDanToc.SelectedItem.ToString(),cboDanToc.SelectedItem.ToString(),dtmNgaySinh.Value, dtmDKKhaiSinh.Value, txtNoiSinh.Text, txtQueQuan.Text, txtCCCDCha.Text, txtTenCha.Text, txtCCCDMe.Text, txtTenMe.Text);
            kSDAO.ThemKhaSinh(kS);

            Thue thue = new Thue(txtThue.Text, txtCCCD.Text);
            thueDAO.ThemThue(thue);

            if (cboTinhTrang.SelectedItem.ToString() == "Kết hôn")
            { 

                HonNhan hN = new HonNhan(txtMaHonNhan.Text, txtCCCD.Text, txtTen.Text, txtCCCDVoChong.Text, txtTenVoChong.Text,"" ,DateTime.Now, rdoNam.ToString());
                hNDAO.ThemHonNhan(hN);
            }    
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
