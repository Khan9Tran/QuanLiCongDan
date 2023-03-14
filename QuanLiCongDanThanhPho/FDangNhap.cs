using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
        }

        private void txtTaiKhoan_MouseDown(object sender, MouseEventArgs e)
        {
            txtTaiKhoan.Clear();
        }

        private void txtMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.Clear();
            txtMatKhau.UseSystemPasswordChar = true;
        }
        
        public void KiemTraPass()
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FTrangChu newTrangChu = new FTrangChu();
            newTrangChu.ShowDialog();
            this.Hide();
        }

        private bool checkTK = false;
        private bool checkPass = false;
        private void txtTaiKhoan_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (checkTK == false)
            {
                txtTaiKhoan.Clear();
            }
            checkTK = true;
        }

        private void txtMatKhau_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (checkPass == false)
            {
                txtMatKhau.Clear();
            }
            checkPass = true;
        }
        private void FDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Close(); }
            base.OnKeyDown(e);
        }
    }
}
