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

        private void FDanhSachThue_Load(object sender, EventArgs e)
        {
            gvThue.DataSource = thueDAO.LayDanhSach();
        }
      
        private void gvThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
 
        }
        // Danh sach thuế của tất cả công dân
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            luaChon = "tat ca";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        // Thay đổi danh sách trong datagridview theo từ tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == "tat ca")
                LoadDanhSach(thueDAO.LayDanhSachChuaTu(txtTimKiem.Text));
            else if (luaChon == "da nop")
                LoadDanhSach(thueDAO.LayDanhSachSoTienDaNop(txtTimKiem.Text));
            else if (luaChon == "tre han")
                LoadDanhSach(thueDAO.LayDanhSachTreHan(txtTimKiem.Text));

        }
        // Hàm sửa gán datatable cho datagridview
        private void LoadDanhSach(DataTable ds)
        {
            gvThue.DataSource = ds;
        }
        // Sắp xếp danh sách tăng dần theo số tiền đã nộp
        private void btnTienDaNop_Click(object sender, EventArgs e)
        {
            luaChon = "da nop";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }
        
        // Xóa thông tin thuế của công dân ra khỏi csdl
        private void cmnusMenuXoa_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có thật sự muốn xóa thông tin thuế?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                string maCCCD = gvThue.CurrentRow.Cells["CCCD"].Value.ToString();
                if (maCCCD != "")
                {
                    thueDAO.XoaThue(maCCCD);
                    txtTimKiem_TextChanged(txtTimKiem, null);
                }
            }
        }
        // Mở ra form thông tin thuế của công dân được chọn
        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maCCCD = gvThue.CurrentRow.Cells["CCCD"].Value.ToString();
            if (maCCCD != "")
            {
                FThongTinThue ttThue = new FThongTinThue();
                ttThue.MaCCCD = maCCCD;
                ttThue.ShowDialog();
            }
        }
        // Mở ra form đăng kí thuế
        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyThue dangKyThue = new FDangKyThue();
            (StackForm.fTrangChu).OpenChildForm(dangKyThue);
        }
        // Lọc danh sách những người đóng tiền trẽ hạn/ chưa đủ tiền khi quá thời gian
        private void btnTreHan_Click(object sender, EventArgs e)
        {
            luaChon = "tre han";
            txtTimKiem_TextChanged(txtTimKiem, null);
        }
    }
}
