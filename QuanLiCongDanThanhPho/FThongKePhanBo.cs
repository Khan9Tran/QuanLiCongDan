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
    public partial class FThongKePhanBo : Form
    {
        CongDanDAO cdDAO;
        TamTruTamVangDAO tttvDAO;
        HoKhauDAO hkDAO;

        public FThongKePhanBo()
        {
            InitializeComponent();
            cdDAO = new CongDanDAO();
            tttvDAO = new TamTruTamVangDAO();
            hkDAO = new HoKhauDAO();
            StackForm.Add(this);
        }

        private void FThongKePhanBo_Load(object sender, EventArgs e)
        {
            gvDanhSachQuan.DataSource = cdDAO.LayDanhSachDiaChi();
            lblSoNguoiTamTru.Text += " " + tttvDAO.LaySoLuongTamTru().ToString();
            lblSoNguoiTamVang.Text += " " + tttvDAO.LaySoLuongTamVang().ToString();
            lblSoNguoiQuaHanTT.Text += " " + tttvDAO.LaySoLuongQuaHanTamTru().ToString();
            lblSoNguoiQuaHanTV.Text += " " + tttvDAO.LaySoLuongQuaHanTamVang().ToString();
            gvHoNhieuNguoiNhat.DataSource = hkDAO.TimHoNhieuNguoiNhat();
            lblSoNguoiTrungBinhMotQuan.Text += " " + cdDAO.LaySoNguoiTrungBinhCuaMotQuan().ToString();
        }
    }
}
