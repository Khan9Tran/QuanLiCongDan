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
    public partial class FDangKyHoKhau : Form
    {
        private Form currentChildForm;
        public FDangKyHoKhau()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlLuaChon.Controls.Add(childForm);
            pnlLuaChon.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnTachGop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTachGopHo());
            btnTachGop.BackColor = Color.Gray;
            btnThem.BackColor =  Color.WhiteSmoke;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThemNguoiVaoHo());
            btnTachGop.BackColor = Color.WhiteSmoke;
            btnThem.BackColor = Color.Gray;
        }
    }
}
