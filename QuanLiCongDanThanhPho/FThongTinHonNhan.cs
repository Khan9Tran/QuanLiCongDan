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
        public FThongTinHonNhan()
        {
            InitializeComponent();
        }

        private void btnThongTinChong_Click(object sender, EventArgs e)
        {
            FThongTinCongDan tTCD = new FThongTinCongDan();
            tTCD.ShowDialog();
        }

        private void btnThongTinVo_Click(object sender, EventArgs e)
        {
            FThongTinCongDan tTCD = new FThongTinCongDan();
            tTCD.ShowDialog();
        }
    }
}
