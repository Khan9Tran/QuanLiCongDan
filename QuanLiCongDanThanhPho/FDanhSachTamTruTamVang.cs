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
                LoadDanhSach(tttvDao.LayDanhSachChuaTu(txtTimKiem.Text));
            else if (luaChon == "tam tru")
                LoadDanhSach(tttvDao.LayDanhSachTamTru(txtTimKiem.Text));
            else if (luaChon == "tam vang")
                LoadDanhSach(tttvDao.LayDanhSachTamVang(txtTimKiem.Text));
            else if (luaChon == "qua han")
                LoadDanhSach(tttvDao.LayDanhSachQuaHan(txtTimKiem.Text));
        }

        private void LoadDanhSach(DataTable ds)
        {
            gvTVTT.DataSource = ds;
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
            DialogResult exit = MessageBox.Show("Bạn có thật sự muốn xóa thông tin tạm trú/tạm vắng?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                string maCCCD = gvTVTT.CurrentRow.Cells["CCCD"].Value.ToString();
                if (maCCCD != "")
                {
                    tttvDao.XoaTamTruTamVang(maCCCD);
                    txtTimKiem_TextChanged(txtTimKiem, null);
                }
            }
        }

        private void btnQuaHan_Click(object sender, EventArgs e)
        {
            luaChon = "qua han";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }
    }
}
