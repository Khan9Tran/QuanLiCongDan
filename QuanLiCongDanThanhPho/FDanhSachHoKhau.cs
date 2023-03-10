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
    public partial class FDanhSachHoKhau : Form
    {
        HoKhauDAO hkDao = new HoKhauDAO();
        public FDanhSachHoKhau()
        {
            InitializeComponent();
            StackForm.Add(this);
        }

        private void gvHoKhau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FDanhSachHoKhau_Load(object sender, EventArgs e)
        {
            gvHoKhau.DataSource = hkDao.LayDanhSach();
        }

        private void gvHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string maHoKhau = gvHoKhau.CurrentRow.Cells[0].Value.ToString();
                if (maHoKhau != "")
                {
                    FThongTinHoKhau tTHK = new FThongTinHoKhau(maHoKhau);
                    tTHK.ShowDialog();
                }
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            gvHoKhau.DataSource = hkDao.LayDanhSach();
            txtTimKiem.Clear();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            gvHoKhau.DataSource = hkDao.LayDanhSachChuaTu(txtTimKiem.Text);
        }
    }
}
