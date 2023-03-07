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

        private void gvThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maCCCD = gvThue.CurrentRow.Cells["CCCD"].Value.ToString();
            if (maCCCD != "")
            {
                FThongTinThue ttThue = new FThongTinThue();
                ttThue.MaCCCD = maCCCD;
                ttThue.ShowDialog();
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {

        }

        private void btnXepLoaiDaNop_Click(object sender, EventArgs e)
        {

        }

        private void btnXepLoaiCanNop_Click(object sender, EventArgs e)
        {

        }

        private void btnXepLoaiThoiGian_Click(object sender, EventArgs e)
        {

        }
    }
}
