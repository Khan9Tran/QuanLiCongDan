using QuanLiCongDanThanhPho.Models;
using System.Data;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachThue : FormDanhSach
    {
        private ThueDAO thueDAO;
        private CongDanDAO cDDAO;

        enum Loc
        {
            tatCa,
            daNop,
            treHan,
        }

        public FDanhSachThue()
        {
            InitializeComponent();

            thueDAO = new ThueDAO();
            cDDAO = new CongDanDAO();

            LuaChon = Loc.tatCa;
            ListData = new Paging(nudPage, 10);
        }

        private void FDanhSachThue_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            flpnPhanLoai.Width = 45;
        }
      
        private void gvThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kiểm tra xem ô/dòng click nếu ko phải là header hoặc dòng trống cuối cùng mới thực hiện
            if (e.RowIndex != -1 && gvThue.Rows[e.RowIndex].Cells[0].Value.ToString()?.Length > 0)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
                LoadLblThue(e.RowIndex);
            }
 
        }

        // Danh sach thuế của tất cả công dân
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
        }

        // Thay đổi danh sách trong datagridview theo từ tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (LuaChon == Loc.tatCa)
                Ds = thueDAO.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (LuaChon == Loc.daNop)
                Ds = thueDAO.LayDanhSachSoTienDaNop(txtTimKiem.Text);
            else if (LuaChon == Loc.treHan)
                Ds = thueDAO.LayDanhSachTreHan(txtTimKiem.Text);
            nudPage.Value = 1;
            LoadDanhSach(gvThue);

        }

        internal override void HeaderText()
        {
            gvThue.Columns[4].DefaultCellStyle.Format = DayFormat();
            gvThue.Columns[5].DefaultCellStyle.Format = DayFormat();
        }

        // Hàm hiện thị tiền cần thanh toán
        private void LoadLblThue(int rowIndex)
        {
            CongDan cD = cDDAO.LayThongTin(CCCDDAO.GetCCCD(gvThue, 1));
            if (cD.CCCD != null)
            {
                string Ten = cD.Ten;
                string soTienCanNop = (string)gvThue.Rows[rowIndex].Cells[2].Value;
                lblThongTin.Text = Ten + " cần thanh toán " + soTienCanNop + " VNĐ";
            }
        }
        
        // Sắp xếp danh sách tăng dần theo số tiền đã nộp
        private void btnTienDaNop_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.daNop);
        }
        
        private void TimKiem(dynamic type)
        {
            LuaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        // Xóa thông tin thuế của công dân ra khỏi csdl
        private void cmnusMenuXoa_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có thật sự muốn xóa thông tin thuế?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                string maCCCD = CCCDDAO.GetCCCD(gvThue, 1);
                if (maCCCD != "")
                {
                    if (thueDAO.XoaThue(maCCCD))
                        MessageBox.Show("Xóa thuế thành công");
                    else
                        MessageBox.Show("Xóa thuế thất bại");
                    TimKiem(LuaChon);
                }
            }
        }

        // Mở ra form thông tin thuế của công dân được chọn
        private void cmnusMenuChiTiet_Click(object sender, EventArgs e)
        {
            string maCCCD = CCCDDAO.GetCCCD(gvThue, 1);
            if (maCCCD != "")
            {
                FThongTinThue ttThue = new FThongTinThue(maCCCD);
                ttThue.ShowDialog();
            }
        }

        // Mở ra form đăng kí thuế
        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyThue dangKyThue = new FDangKyThue();
            (StackForm.TrangChu)?.ChildForm.Open(dangKyThue);
        }

        // Lọc danh sách những người đóng tiền trẽ hạn/ chưa đủ tiền khi quá thời gian
        private void btnTreHan_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.treHan);
        }

        //Thay đổi page
        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach(gvThue);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Loc_Click(flpnPhanLoai);
        }

        private void btnCongDanCanTaoThue_Click(object sender, EventArgs e)
        {
            FDanhSachCongDan dscd = new FDanhSachCongDan(thueDAO.DuTuoiDongThue());
            FDanhSach ds = new FDanhSach();
            (StackForm.TrangChu)?.ChildForm.Open(ds);
            ds.ChildForm.Open(dscd);
        }

        private bool ThanhToan()
        {
            if (txtDongThue.Text.Length == 0) return false;
            if (KiemTraDuLieuNhap.isTien(txtDongThue.Text))
            {
                int tienNhap = int.Parse(txtDongThue.Text);
                Thue thue = thueDAO.LayThongTin(CCCDDAO.GetCCCD(gvThue, 1));
                if (thue.MaThue != null && thue.ThanhToan(tienNhap))
                {
                    return thueDAO.CapNhatThue(thue);
                }
            }
            return false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (ThanhToan())
            {
                int lastSelectedRowIndex;   // Lấy số chỉ dòng trong gridview dang chọn vì lát nữa load danh sách thì dòng được chọn sẽ chuyển về dòng đầu
                int lastSelectedColumnIndex;    // Lấy số chỉ cột trong gridvew đang chọn vì tương tự như trên
                lastSelectedRowIndex = gvThue.CurrentCell.RowIndex; // Tìm lại dòng đã chọn trước khi load lại
                lastSelectedColumnIndex = gvThue.CurrentCell.ColumnIndex;   // Tìm lại ô đã chọn
                MessageBox.Show("Thanh toán thành công");
                TimKiem(LuaChon);
                DataGridViewRow lastSelectedRow = gvThue.Rows[lastSelectedRowIndex];
                gvThue.CurrentCell = lastSelectedRow.Cells[lastSelectedColumnIndex];
                LoadLblThue(gvThue.CurrentCell.RowIndex);
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
        }
    }
}
