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
        CongDanDAO cdDAO = new CongDanDAO();
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
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
            StackForm.Add(this);
        }
        public void LayThongTinHoKhau()
        {
            if (MaHoKhau != null)
            {
                HoKhau hk = hkDAO.LayThongTin(MaHoKhau);
                txtCCCDChuHo.Text = hk.CCCDChuHo;
                txtMaHoKhau.Text = hk.MaHoKhau;
                txtDiaChi.Text = hk.DiaChi.toString();
                //---Thong tin chu ho---//
                CongDan chuHo = cdDAO.LayThongTin(hk.CCCDChuHo);
                txtTenChuHo.Text = chuHo.Ten.ToString();
                //---Quan he voi chu ho---//
                DataTable dsNguoiTrongHo = cdDAO.LayDanhSachTheoHoKhau(maHoKhau);
                DataTable dsNguoiKoPhaiChuHo = dsNguoiTrongHo.Clone();
                foreach (DataRow row in dsNguoiTrongHo.Rows)
                {
                    if (row["Quan hệ với chủ hộ"].ToString() != "Chủ hộ")
                        dsNguoiKoPhaiChuHo.ImportRow(row);
                }
                gvQuanHeVoiChuHo.DataSource = dsNguoiKoPhaiChuHo;
            }
        }
        private void FThongTinHoKhau_Load(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
        }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void gvQuanHeVoiChuHo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
