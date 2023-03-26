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
    public partial class FThongKePhanBo : Form
    {
        CongDanDAO cdDAO = new CongDanDAO();
        public FThongKePhanBo()
        {
            InitializeComponent();
            StackForm.Add(this);
        }

        private void FThongKePhanBo_Load(object sender, EventArgs e)
        {
            gvDanhSachQuan.DataSource = cdDAO.LayDanhSachDiaChi();
        }
    }
}
