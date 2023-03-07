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
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
            lblNameApp.Hide();
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

    }
}
