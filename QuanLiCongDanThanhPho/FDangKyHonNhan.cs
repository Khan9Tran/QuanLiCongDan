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
        KhaiSinhDAO ksDAO;
        public FDangKyHonNhan()
        {
            InitializeComponent();
            hNDAO = new HonNhanDAO();
            ksDAO = new KhaiSinhDAO();
            StackForm.Add(this);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                HonNhan hN = new HonNhan(txtMaHonNhan.Text, txtCCCDChong.Text, txtTenChong.Text, txtCCCDVo.Text, txtTenVo.Text, txtNoiDK.Text, dtpNgayDangKy.Value);
                hNDAO.ThemHonNhan(hN);
            }
        }
        public void ChoPhepLiHon()
        {
            txtCCCDChong.ReadOnly = true;
            txtCCCDVo.ReadOnly = true;
            txtTenChong.ReadOnly = true;
            txtTenVo.ReadOnly = true;
            txtNoiDK.ReadOnly = true;
            dtpNgayDangKy.Enabled = false;
            btnDelete.Enabled = true;
            btnDangKy.Enabled = false;
        }   
        public void ChoPhepDangKy()
        {
            txtCCCDChong.ReadOnly = false;
            txtCCCDVo.ReadOnly = false;
            txtTenChong.ReadOnly = false;
            txtTenVo.ReadOnly = false;
            txtNoiDK.ReadOnly = false;
            dtpNgayDangKy.Enabled = true;
            btnDelete.Enabled = false;
            btnDangKy.Enabled = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            HonNhan hN = new HonNhan(txtMaHonNhan.Text, txtCCCDChong.Text, txtTenChong.Text, txtCCCDVo.Text, txtCCCDChong.Text, txtNoiDK.Text, dtpNgayDangKy.Value);
            hNDAO.Xoa(hN);
            Reset();
        }
        private void Reset()
        {
            Clear();
            txtMaHonNhan.Clear();
            ChoPhepDangKy();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
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
        public void Clear()
        {
            txtCCCDChong.Clear();
            txtCCCDVo.Clear();
            txtTenChong.Clear();
            txtTenVo.Clear();
            txtNoiDK.Clear();
            dtpNgayDangKy.Value = DateTime.Now;
        }    
        private void txtMaHonNhan_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHonNhan.Text.Length > 0)
            {
                HonNhan hn = hNDAO.LayThongTinGoiYTheoMaSo(txtMaHonNhan.Text);
                txtCCCDChong.Text = hn.CCCDChong;
                txtCCCDVo.Text = hn.CCCDVo;
                txtTenChong.Text = hn.TenChong;
                txtTenVo.Text = hn.TenVo;
                txtNoiDK.Text = hn.NoiDangKy.toString();
                dtpNgayDangKy.Value = hn.NgayDangKy;
                if (hn.CCCDChong != null)
                    ChoPhepLiHon();
                else
                    ChoPhepDangKy();
            }

        }

        private void txtCCCDChong_TextChanged(object sender, EventArgs e)
        {
            if (txtCCCDChong.Text.Length > 0)
            {
                KhaiSinh ks = ksDAO.LayThongTinNamNuTheoTu(txtCCCDChong.Text, "m");
                txtTenChong.Text = ks.HoTen;
            }
        }

        private void txtCCCDVo_TextChanged(object sender, EventArgs e)
        {
            if (txtCCCDVo.Text.Length > 0)
            {
                KhaiSinh ks = ksDAO.LayThongTinNamNuTheoTu(txtCCCDVo.Text, "f");
                txtTenVo.Text = ks.HoTen;
            }
        }
    }
}
