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
    public partial class FDanhSachTamTruTamVang : Form
    {
        TamTruTamVangDAO tttvDao = new TamTruTamVangDAO();
        public FDanhSachTamTruTamVang()
        {
            InitializeComponent();
            StackForm.Add(this);
        }

        private void gvTamTru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gvTamVang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FDanhSachTamTruTamVang_Load(object sender, EventArgs e)
        {
            gvTamTru.DataSource = tttvDao.LayDanhSachTamTru();
            gvTamVang.DataSource = tttvDao.LayDanhSachTamVang();
        }
    }
}
