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
    public partial class FDangKyCongDan : Form
    {
        CongDanDAO cdDao = new CongDanDAO();
        public FDangKyCongDan()
        {
            InitializeComponent();
        }
        public void ThemCongDan()
        {
            char gioiTinh;
            if (rdoNam.Checked)
                gioiTinh = 'm';
            else
                gioiTinh = 'f';
            CongDan cDan = new CongDan(txtCCCD.Text, txtTen.Text,txtNgheNghiep.Text,txtSoDT.Text,cboTonGiao.SelectedText,txtHoKhau.Text);
            KhaiSinh khaiSinh = new KhaiSinh(txtCCCD.Text, txtTen.Text,
                                                gioiTinh, cboQuocTich.SelectedText
                                                , cboDanToc.SelectedText, dtmNgaySinh.Value, DateTime.Now
                                                , txtNoiSinh.Text, txtQueQuan.Text, txtCCCDCha.Text
                                               , txtTenCha.Text, txtCCCDMe.Text, txtTenMe.Text);
            HonNhan honNhan;
            if (gioiTinh == 'm')
                honNhan = new HonNhan(txtMaHonNhan.Text, txtCCCD.Text, txtTen.Text, txtCCCDVoChong.Text, txtTenVoChong.Text, "", DateTime.Now);
            else
                honNhan = new HonNhan(txtMaHonNhan.Text, txtCCCDVoChong.Text, txtTenVoChong.Text, txtCCCD.Text, txtTen.Text, "", DateTime.Now);
            Thue thue = new Thue(txtThue.Text);
        }
    }
}
