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
    public partial class FDanhSachCongDan : Form
    {
        CongDanDAO cdDao = new CongDanDAO();
        public FDanhSachCongDan()
        {
            InitializeComponent();
            StackForm.Add(this);
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            gvDanhSachCongDan.DataSource = cdDao.LayDanhSachChuaTu(txtTimKiem.Text);
        }

        private void FDanhSachCongDan_Load(object sender, EventArgs e)
        {
            gvDanhSachCongDan.DataSource = cdDao.LayDanhSach();
        }

        private void gvDanhSachCongDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string maCCCD = gvDanhSachCongDan.CurrentRow.Cells[0].Value.ToString();
                if (maCCCD != "")
                {
                    FThongTinCongDan ttCD = new FThongTinCongDan(maCCCD);
                    ttCD.ShowDialog();
                }
            }
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            gvDanhSachCongDan.DataSource = cdDao.LayDanhSachCongDanNam();
            txtTimKiem.Clear();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            gvDanhSachCongDan.DataSource = cdDao.LayDanhSach();
            txtTimKiem.Clear();
        }

        private void btnNu_Click(object sender, EventArgs e)
        {
            gvDanhSachCongDan.DataSource = cdDao.LayDanhSachCongDanNu();
            txtTimKiem.Clear();
        }

        private void btnDocThan_Click(object sender, EventArgs e)
        {
            gvDanhSachCongDan.DataSource = cdDao.LayDanhSachChuaKetHon();
            txtTimKiem.Clear();
        }

        private void btnKetHon_Click(object sender, EventArgs e)
        {
            gvDanhSachCongDan.DataSource = cdDao.LayDanhSachDaKetHon();
            txtTimKiem.Clear();
        }

        private void btnTuoiTac_Click(object sender, EventArgs e)
        {
            gvDanhSachCongDan.DataSource = cdDao.LayDanhSachTuoiXepTuBeDenLon();
            txtTimKiem.Clear();
        }
    }
}
