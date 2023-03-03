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
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (this.ParentForm.Name == "Form1")
            { this.ParentForm.Show(); }
            else
            {
                this.ParentForm.Close();
                FTrangChu fTrangChu = new FTrangChu();
                fTrangChu.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
