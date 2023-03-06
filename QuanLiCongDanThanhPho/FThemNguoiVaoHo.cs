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
    public partial class FThemNguoiVaoHo : Form
    {
       
        public FThemNguoiVaoHo()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CongDan congDan= new CongDan(txtCCCD.Text,txtTen.Text,"","","",txtMaHo.Text,txtQuanHeVoiChuHo.Text,"u,u,u,u,u");
            CongDanDAO cDDAO = new CongDanDAO();
            cDDAO.ThayDoiHoKhau(congDan);
        }
    }
}
