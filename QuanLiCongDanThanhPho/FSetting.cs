using QuanLiCongDanThanhPho.Models;
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
    public partial class FSetting : Form
    {
        private Account account;
        private AccountDAO accountDAO;
        public FSetting(Account account)
        {
            InitializeComponent();
            this.account = account;
            accountDAO = new AccountDAO();
        }

        private bool KiemTraPass()
        {
            if (txtMatKhauHienTai.Text != account.Password)
            {
                MessageBox.Show("Mật khẩu không chính xác.");
                return false;
            }
            return KiemTraDuLieuNhap.KiemTraPass(txtMatKhauHienTai.Text, txtMatKhauMoi.Text, txtNhapLai.Text);
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (KiemTraPass())
            {
                account.Password = txtNhapLai.Text;
                accountDAO.CapNhatMatKhau(account);
            }
        }

    }
}
