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
        private string luaChon;
        public FDanhSachCongDan()
        {
            InitializeComponent();
            StackForm.Add(this);
            luaChon = "tat ca";
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == "tat ca")
                gvDanhSachCongDan.DataSource = cdDao.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (luaChon == "nam")
                gvDanhSachCongDan.DataSource = cdDao.LayDanhSachCongDanNam(txtTimKiem.Text);
            else if (luaChon == "nu")
                gvDanhSachCongDan.DataSource = cdDao.LayDanhSachCongDanNu(txtTimKiem.Text);
            else if (luaChon == "ket hon")
                gvDanhSachCongDan.DataSource = cdDao.LayDanhSachDaKetHon(txtTimKiem.Text);
            else if (luaChon == "doc than")
                gvDanhSachCongDan.DataSource = cdDao.LayDanhSachChuaKetHon(txtTimKiem.Text);
            else if (luaChon == "tuoi tac")
                gvDanhSachCongDan.DataSource = cdDao.LayDanhSachTuoiXepTuBeDenLon(txtTimKiem.Text);
        }

        private void FDanhSachCongDan_Load(object sender, EventArgs e)
        {
            gvDanhSachCongDan.DataSource = cdDao.LayDanhSach();
            fpnlPhanLoai.Width = 45;
        }

        private void gvDanhSachCongDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            luaChon = "nam";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            luaChon = "tat ca";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void btnNu_Click(object sender, EventArgs e)
        {
            luaChon = "nu";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void btnDocThan_Click(object sender, EventArgs e)
        {
            luaChon = "doc than";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void btnKetHon_Click(object sender, EventArgs e)
        {
            luaChon = "ket hon";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void btnTuoiTac_Click(object sender, EventArgs e)
        {
            luaChon = "tuoi tac";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyCongDan dangKyCongDan = new FDangKyCongDan();
            (StackForm.fTrangChu).OpenChildForm(dangKyCongDan);
        }

        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maCCCD = gvDanhSachCongDan.CurrentRow.Cells[0].Value.ToString();
            if (maCCCD != "")
            {
                FThongTinCongDan ttCD = new FThongTinCongDan(maCCCD);
                ttCD.ShowDialog();
            }
        }

        private void cmnusMenuXoa_Click(object sender, EventArgs e)
        {
            string maCCCD = gvDanhSachCongDan.CurrentRow.Cells[0].Value.ToString();
            if (maCCCD != "")
            {
                CongDan cd = cdDao.LayThongTin(maCCCD);
                cdDao.XoaCongDan(cd);
                txtTimKiem_TextChanged(txtTimKiem, null);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (fpnlPhanLoai.Width > 50)
            {
                fpnlPhanLoai.Width = 45;
            }    
            else 
            {
                fpnlPhanLoai.Width = 800;
            }
        }
    }
}
