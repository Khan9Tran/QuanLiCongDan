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
    public partial class FDangKyTamTruTamVang : Form
    {
        TamTruTamVangDAO tTTVDAO;
        public FDangKyTamTruTamVang()
        {
            InitializeComponent();
            tTTVDAO = new TamTruTamVangDAO();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (rdoTamTru.Checked == true)
            {
                CongDan cDTamTru = new CongDan(txtCCCD.Text, txtTen.Text, txtSDT.Text);
                CongDanDAO cDTamTruDAO = new CongDanDAO();
                cDTamTruDAO.ThemCongDan(cDTamTru);
            }
            TamTruTamVang tTTV = new TamTruTamVang(txtMaSo.Text, txtCCCD.Text, rdoTamTru.Checked.ToString(), dtpNgayBatDau.Value, dtpNgayKetThuc.Value, txtDiaChi.Text, txtLiDo.Text);
            tTTVDAO.ThemTamTruTamVang(tTTV);   
        }
    }
}
