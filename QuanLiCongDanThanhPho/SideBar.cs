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
            if (ParentForm.Name == "FTrangChu")
            {
                if ((ParentForm as FTrangChu).currentChildForm == null)
                    return;
                (ParentForm as FTrangChu).currentChildForm.Close();
            }
            else
                this.ParentForm.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

    }
}
