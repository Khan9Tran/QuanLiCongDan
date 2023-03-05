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
            this.Controls.Add(this.pnlMenu);
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
            if (pnlMenu.Width > 80)
                btnMenuShow_Click(sender, e);
        }

        private void cmnusitemDangKyHonNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyHonNhan());
            if (pnlMenu.Width > 80)
                btnMenuShow_Click(sender, e);
        }

        private void cmnusDangKyItemKhaiSinh_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width > 80)
                btnMenuShow_Click(sender, e);
        }

        private void cmnusDanhMucItemCongDan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachCongDan());
            if (pnlMenu.Width > 80)
                btnMenuShow_Click(sender, e);
        }

        private void cmnusDanhMucItemHoKhau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachHoKhau());
            if (pnlMenu.Width > 80)
                btnMenuShow_Click(sender, e);
        }
        private void cmnusDanhMucItemTamTruTamVang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachTamTruTamVang());
            if (pnlMenu.Width > 80)
                btnMenuShow_Click(sender, e);
        }

        private void cmnusDanhMucItemThue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachThue());
            if (pnlMenu.Width > 80)
                btnMenuShow_Click(sender, e);
        }

        private void cmnusDangKyItemCongDan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyCongDan());
            if (pnlMenu.Width > 80)
                btnMenuShow_Click(sender, e);
        }
        private void btnSuaDoi_Click(object sender, EventArgs e)
        {
            FThongTinCongDan ttcd = new FThongTinCongDan();
            ttcd.ShowDialog();
        }

        private void FTrangChu_Load(object sender, EventArgs e)
        {
            pnlMenu.BringToFront();
        }

        private void btnMenuShow_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width <= 80) 
            {
                tmrPhongTo.Start();
            }
            else
            {
                tmrThuNho.Start();
            }    
        }


        private void tmrThuNho_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width >= 80)
            {
                pnlMenu.Width -= 70;
                if (pnlMenu.Width <= 80)
                {
                    tmrThuNho.Stop();
                }    
            }
        }

        private void tmrPhongTo_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width < 290)
            {
                pnlMenu.Width += 70;
                if (pnlMenu.Width >= 290)
                {
                    tmrPhongTo.Stop();
                }
            }
        }

        private void pnlDanhMuc_MouseHover(object sender, EventArgs e)
        {
            pnlDanhMuc.BackColor = Color.FromArgb(44, 43, 60);
        }
        private void pnlDanhMuc_MouseLeave(object sender, EventArgs e)
        {
            pnlDanhMuc.BackColor = Color.FromArgb(50, 49, 70);
        }

        private void lblDangKy_MouseHover(object sender, EventArgs e)
        {
            pnlDangKy.BackColor = Color.FromArgb(44, 43, 60);
        }

        private void lblDangKy_MouseLeave(object sender, EventArgs e)
        {
            pnlDangKy.BackColor = Color.FromArgb(50, 49, 70);
        }

        private void pnlThongKe_MouseHover(object sender, EventArgs e)
        {
            pnlThongKe.BackColor = Color.FromArgb(44, 43, 60);
        }

        private void pnlThongKe_MouseLeave(object sender, EventArgs e)
        {
            pnlThongKe.BackColor = Color.FromArgb(50, 49, 70);
        }

        private void cmnusDangKyItemHoKhau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDangKyHoKhau());
        }
    }
}
