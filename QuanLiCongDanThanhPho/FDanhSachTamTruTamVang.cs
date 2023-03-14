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
    public partial class FDanhSachTamTruTamVang : Form
    {
        TamTruTamVangDAO tttvDao = new TamTruTamVangDAO();
        private string luaChon;
        public FDanhSachTamTruTamVang()
        {
            InitializeComponent();
            StackForm.Add(this);
            luaChon = "tat ca";
        }

        private void FDanhSachTamTruTamVang_Load(object sender, EventArgs e)
        {
            gvTVTT.DataSource = tttvDao.LayDanhSach();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            luaChon = "tat ca";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == "tat ca")
                gvTVTT.DataSource = tttvDao.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (luaChon == "tam tru")
                gvTVTT.DataSource = tttvDao.LayDanhSachTamTru(txtTimKiem.Text);
            else if (luaChon == "tam vang")
                gvTVTT.DataSource = tttvDao.LayDanhSachTamVang(txtTimKiem.Text);
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            luaChon = "tam vang";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            luaChon = "tam tru";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyTamTruTamVang dangKyTTTV = new FDangKyTamTruTamVang();
            (StackForm.fTrangChu).OpenChildForm(dangKyTTTV);
        }

        private void gvTVTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        private void cmnusMenuXoa_Click(object sender, EventArgs e)
        {
            string maCCCD = gvTVTT.CurrentRow.Cells["CCCD"].Value.ToString();
            if (maCCCD != "")
            {
                tttvDao.XoaTamTruTamVang(maCCCD);
                txtTimKiem_TextChanged(txtTimKiem, null);
            }
        }
    }
}
