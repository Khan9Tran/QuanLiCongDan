using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCongDanThanhPho.Models;
namespace QuanLiCongDanThanhPho
{
    public partial class FTrangChu : Form
    {
        public Form currentChildForm;
        public FTrangChu()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lblHideApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            cmnusDangKy.Show(this, this.PointToClient(MousePosition));
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            cmnusDanhMuc.Show(this, this.PointToClient(MousePosition));
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
            pnlHienThiForm.Controls.Add(childForm);
            pnlHienThiForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void cmnusDangKyItemTamTruTamVang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyTamTruTamVang());
        }

        private void cmnusitemDangKyHonNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyHonNhan());
        }

        private void cmnusDangKyItemKhaiSinh_Click(object sender, EventArgs e)
        {

        }

        private void cmnusDanhMucItemCongDan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachCongDan());
        }

        private void cmnusDanhMucItemHoKhau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachHoKhau());
        }
        private void cmnusDanhMucItemTamTruTamVang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachTamTruTamVang());
        }

        private void cmnusDanhMucItemThue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachThue());
        }

        private void cmnusDangKyItemCongDan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyCongDan());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlChucNang.Size.Width > 0 && pnlChucNang.Size.Height > 0)
            {
                pnlChucNang.Size = new System.Drawing.Size(0, 0);
            }
            else
            {
                pnlChucNang.BackColor = Color.Gray;
                pnlChucNang.Controls.Add(USHomeAndBack);
                pnlChucNang.Size = new System.Drawing.Size(256, 752);

            }

        }
    }
}
