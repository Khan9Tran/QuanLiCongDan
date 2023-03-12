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
    public partial class FDanhSachThue : Form
    {
        ThueDAO thueDAO = new ThueDAO();
        private string luaChon;
        public FDanhSachThue()
        {
            InitializeComponent();
            StackForm.Add(this);
            luaChon = "tat ca";
        }

        private void gvThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FDanhSachThue_Load(object sender, EventArgs e)
        {
            gvThue.DataSource = thueDAO.LayDanhSach();
        }

        private void gvThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string maCCCD = gvThue.CurrentRow.Cells["CCCD"].Value.ToString();
                if (maCCCD != "")
                {
                    FThongTinThue ttThue = new FThongTinThue();
                    ttThue.MaCCCD = maCCCD;
                    ttThue.ShowDialog();
                }
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            luaChon = "tat ca";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void btnXepLoaiDaNop_Click(object sender, EventArgs e)
        {

        }

        private void btnXepLoaiCanNop_Click(object sender, EventArgs e)
        {

        }

        private void btnHanNop_Click(object sender, EventArgs e)
        {
            luaChon = "han nop";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == "tat ca")
                gvThue.DataSource = thueDAO.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (luaChon == "han nop")
                gvThue.DataSource = thueDAO.LayDanhSachHanNop(txtTimKiem.Text);
            else if (luaChon == "da nop")
                gvThue.DataSource = thueDAO.LayDanhSachSoTienDaNop(txtTimKiem.Text);
            else if (luaChon == "can nop")
                gvThue.DataSource = thueDAO.LayDanhSachSoTienChuaNop(txtTimKiem.Text);

        }

        private void btnTienDaNop_Click(object sender, EventArgs e)
        {
            luaChon = "da nop";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private void btnTienChuaNop_Click(object sender, EventArgs e)
        {
            luaChon = "can nop";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }
    }
}
