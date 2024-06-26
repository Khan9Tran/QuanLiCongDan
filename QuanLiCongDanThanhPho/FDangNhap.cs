﻿using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangNhap : Form
    {
        private AccountDAO accDAO;
        private bool checkTK = false;
        private bool checkPass = false;
        private FLOGO flogo;

        enum  Quyen
        {
            congDan,
            admin,
        }

        public FDangNhap()
        {
            InitializeComponent();
            accDAO = new AccountDAO();
            KeyPreview = true;
            tmrShowTime.Interval = 5;
        }

        private void txtTaiKhoan_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkTK == false)
            {
                txtTaiKhoan.Clear();
            }
            checkTK = true;
        }

        private void txtMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkPass == false)
            {
                txtMatKhau.Clear();
            }
            checkPass = true;
            txtMatKhau.UseSystemPasswordChar = true;
        }
        
        private void DangNhap()
        {
            Account acc = new Account(txtTaiKhoan.Text,txtMatKhau.Text);
            if (accDAO.LayThongTinTaiKhoan(acc).UserName == null || !accDAO.DangNhap(acc))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }    
            else
            {
                Hide();
                tmrShowTime.Start();
                flogo = new FLOGO();
                flogo.Show();
            }    
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void FDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
                base.OnKeyDown(e);
            }
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void tmrShowTime_Tick(object sender, EventArgs e)
        {
            if (flogo.Width > 20)
            {
                flogo.Width -= 20;
            }
            else
            {
                tmrShowTime.Stop();
                flogo.Close();
                Account acc = new Account(txtTaiKhoan.Text, txtMatKhau.Text);
                acc = accDAO.LayThongTinTaiKhoan(acc);
                if ((Quyen)acc.Type == Quyen.admin)
                {
                    FTrangChu newTrangChu = new FTrangChu(acc, this);
                    newTrangChu.Show();
                }
                else
                {
                    FTrangChuCongDan newTrangChu = new FTrangChuCongDan(acc, this);
                    newTrangChu.Show();
                }
            }
        }
    }
}
