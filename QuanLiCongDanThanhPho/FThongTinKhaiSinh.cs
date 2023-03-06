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
        public FThongTinKhaiSinh()
        {
            InitializeComponent();
        }

        private void btnThongTinCha_Click(object sender, EventArgs e)
        {
            FThongTinCongDan tTCD = new FThongTinCongDan();
            tTCD.ShowDialog();
        }

        private void btnThongTinMe_Click(object sender, EventArgs e)
        {
            FThongTinCongDan tTCD = new FThongTinCongDan();
            tTCD.ShowDialog();
        }
    }
}
