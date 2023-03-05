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

        }

        private void FThongTinCongDan_MouseLeave(object sender, EventArgs e)
        {
        }
    }
}
