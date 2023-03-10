using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCongDanThanhPho.Properties;
namespace QuanLiCongDanThanhPho
{
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            StackForm.Clear();
            (this.FindForm() as FTrangChu).currentChildForm = null;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StackForm.Back();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
