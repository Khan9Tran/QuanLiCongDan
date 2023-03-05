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

        }
    }
}
