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
    public partial class FDanhSachHoKhau : Form
    {
        HoKhauDAO hkDao = new HoKhauDAO();
        public FDanhSachHoKhau()
        {
            InitializeComponent();
        }

        private void gvHoKhau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FDanhSachHoKhau_Load(object sender, EventArgs e)
        {
            gvHoKhau.DataSource = hkDao.LayDanhSach();
        }
    }
}
