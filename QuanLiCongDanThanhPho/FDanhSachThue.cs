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
    public partial class FDanhSachThue : Form
    {
        ThueDAO thueDAO = new ThueDAO();
        public FDanhSachThue()
        {
            InitializeComponent();
        }

        private void gvThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FDanhSachThue_Load(object sender, EventArgs e)
        {
            gvThue.DataSource = thueDAO.LayDanhSach();
        }
    }
}
