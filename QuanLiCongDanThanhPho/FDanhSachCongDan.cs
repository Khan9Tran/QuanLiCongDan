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
    public partial class FDanhSachCongDan : Form
    {
        CongDanDAO cdDao = new CongDanDAO();
        public FDanhSachCongDan()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void gvDanhSachCongDan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FDanhSachCongDan_Load(object sender, EventArgs e)
        {
            gvDanhSachCongDan.DataSource = cdDao.LayDanhSach();
        }
    }
}
