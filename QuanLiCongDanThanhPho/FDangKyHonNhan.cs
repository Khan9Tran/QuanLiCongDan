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
    public partial class FDangKyHonNhan : Form
    {
        HonNhanDAO hNDAO;
        public FDangKyHonNhan()
        {
            InitializeComponent();
            hNDAO = new HonNhanDAO();
            StackForm.Add(this);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            HonNhan hN = new HonNhan(txtMaHonNhan.Text, txtCCCDChong.Text, txtTenChong.Text, txtCCCDVo.Text, txtTenVo.Text, txtNoiDK.Text, dtmNgayDangKy.Value);
            hNDAO.ThemHonNhan(hN);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HonNhan hN = new HonNhan(txtMaHonNhan.Text, txtCCCDChong.Text, txtTenChong.Text, txtCCCDVo.Text, txtCCCDChong.Text, txtNoiDK.Text, dtmNgayDangKy.Value);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }

        private void btnTimVo_Click(object sender, EventArgs e)
        {

        }

        private void btnTimChong_Click(object sender, EventArgs e)
        {

        }
        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isMaSo(txtMaHonNhan.Text))
            {
                MessageBox.Show("Mã hôn nhân sai định dạng");
                txtMaHonNhan.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCDChong.Text))
            {
                MessageBox.Show("CCCD chồng sai định dạng");
                txtCCCDChong.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCDVo.Text))
            {
                MessageBox.Show("CCCD vợ sai định dạng");
                txtCCCDVo.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenChong.Text))
            {
                MessageBox.Show("Tên chồng sai định dạng");
                txtTenChong.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenVo.Text))
            {
                MessageBox.Show("Tên vợ sai định dạng");
                txtTenVo.Focus();
                return false;
            }
            return true;

        }
        private void btnMaHonNhan_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                HonNhan hN = new HonNhan();
                hN = hNDAO.LayThongTinTheoMaSo(txtMaHonNhan.Text);
                txtCCCDChong.Text = hN.CCCDChong;
                txtCCCDVo.Text = hN.CCCDVo;
                txtTenChong.Text = hN.TenChong;
                txtTenVo.Text = hN.TenVo;
                txtNoiDK.Text = hN.NoiDangKy.toString();
            }
        }
    }
}
