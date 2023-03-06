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
    public partial class FDangKyKhaiSinh : Form
    {
        public FDangKyKhaiSinh()
        {
            InitializeComponent();
        }
        KhaiSinhDAO kSDAO = new KhaiSinhDAO();

        private void FDangKyKhaiSinh_Load(object sender, EventArgs e)
        {

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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            KhaiSinh kS = new KhaiSinh(txtCccd.Text,txtTen.Text, rdoNam.Checked.ToString(),txtQuocTich.Text,txtDanToc.Text,dtmNgaySinh.Value, dtmNgayDangKy.Value, txtNoiSinh.Text, txtQueQuan.Text, txtCccdCha.Text, txtTenCha.Text, txtCccdMe.Text, txtTenMe.Text);
        }

     
    }
}
