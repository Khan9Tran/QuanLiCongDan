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
        public FDangKyCongDan()
        {
            InitializeComponent();
            cdDAO = new CongDanDAO();
            kSDAO = new KhaiSinhDAO();
        }
        
        public void ThemCongDan()
        {
            CongDan cD = new CongDan(txtCCCD.Text, txtTen.Text, txtNgheNghiep.Text, txtSoDT.Text, cboTonGiao.SelectedItem.ToString(), txtHoKhau.Text, txtQHVoiChuHo.Text);
             cdDAO.ThemCongDan(cD);
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
