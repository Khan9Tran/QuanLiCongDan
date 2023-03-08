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
    public partial class FThongTinHoKhau : Form
    {
        private string maHoKhau;
        HoKhauDAO hkDAO = new HoKhauDAO();
        public string MaHoKhau
        {
            get { return maHoKhau; }
            set { maHoKhau = value; }
        }
        public FThongTinHoKhau()
        {
            InitializeComponent();
        }
        public FThongTinHoKhau(string maHoKhau)
        {
            MaHoKhau = maHoKhau;
            InitializeComponent();
        }

        private void FThongTinHoKhau_Load(object sender, EventArgs e)
        {
            HoKhau hk = hkDAO.LayThongTin(MaHoKhau);
            txtCCCDChuHo.Text = hk.CCCDChuHo;
            txtMaHoKhau.Text = hk.MaHoKhau;
            txtDiaChi.Text = hk.DiaChi.toString();
        }
    }
}
