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
    public partial class FThongKe : Form
    {
        private Form currentChildForm;

        enum ThongKe
        {
            congDan,
            thue,
            phanBoDanCu,
        }

        public FThongKe()
        {
            InitializeComponent();
            StackForm.Add(this);
        }

        private void cmbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLuaChon.SelectedIndex == (int)ThongKe.congDan)
                OpenChildForm(new FThongKeCongDan());
            else if (cmbLuaChon.SelectedIndex == (int)ThongKe.phanBoDanCu)
                OpenChildForm(new FThongKePhanBo());
            else if (cmbLuaChon.SelectedIndex == (int)ThongKe.thue)
                OpenChildForm(new FThongKeThue());
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlHienThiThongKe.Controls.Add(childForm);
            pnlHienThiThongKe.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
