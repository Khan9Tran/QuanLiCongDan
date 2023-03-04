using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyCongDan : Form
    {
        CongDanDAO cdDAO;
        public FDangKyCongDan()
        {
            InitializeComponent();
            cdDAO = new CongDanDAO();
        }
        
        public void ThemCongDan()
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemCongDan();
        }

        private void FDangKyCongDan_Load(object sender, EventArgs e)
        {

        }
    }
}
