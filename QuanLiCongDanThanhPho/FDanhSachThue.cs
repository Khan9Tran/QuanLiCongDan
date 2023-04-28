using QuanLiCongDanThanhPho.Models;
using System.Data;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachThue : Form
    {
        private ThueDAO thueDAO;
        private CongDanDAO cDDAO;
        private dynamic luaChon; // Khởi tạo lựa chọn bộ lọc
        private DataTable ds; //Khởi tạo danh sách cho datagridview
        private Paging listThue;

        enum Loc
        {
            tatCa,
            daNop,
            treHan,
        }

        public FDanhSachThue()
        {
            InitializeComponent();
            StackForm.Add(this);
            thueDAO = new ThueDAO();
            cDDAO = new CongDanDAO();
            ds = new DataTable();
            luaChon = Loc.tatCa;
            listThue = new Paging(nudPage, 10);
        }

        private void FDanhSachThue_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            flpnPhanLoai.Width = 45;
        }
      
        private void gvThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kiểm tra xem ô/dòng click nếu ko phải là header hoặc dòng trống cuối cùng mới thực hiện
            if (e.RowIndex != -1 && gvThue.Rows[e.RowIndex].Cells[0].Value.ToString().Length > 0)
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
            if (luaChon == Loc.tatCa)
                ds = thueDAO.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (luaChon == Loc.daNop)
                ds = thueDAO.LayDanhSachSoTienDaNop(txtTimKiem.Text);
            else if (luaChon == Loc.treHan)
                ds = thueDAO.LayDanhSachTreHan(txtTimKiem.Text);
            nudPage.Value = 1;
            LoadDanhSach();

        }

        // Hàm sửa gán datatable cho datagridview
        private void LoadDanhSach()
        {
            gvThue.DataSource = NgatTrang(ds,10);
            gvThue.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // Hàm hiện thị tiền cần thanh toán
        private void LoadLblThue(int rowIndex)
        {
            CongDan cD = cDDAO.LayThongTin(CCCDDAO.GetCCCD(gvThue, 1));
            string Ten = cD.Ten;
            string soTienCanNop = (string)gvThue.Rows[rowIndex].Cells[2].Value;
            lblThongTin.Text = Ten + " cần thanh toán " + soTienCanNop + " VNĐ";
        }
        
        // Sắp xếp danh sách tăng dần theo số tiền đã nộp
        private void btnTienDaNop_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.daNop);
        }
        
        private void TimKiem(dynamic type)
        {
            luaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        private string GetCCCD()
        {
            return (string)gvThue.CurrentRow.Cells["CCCD"].Value;
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
                    thueDAO.XoaThue(maCCCD);
                    TimKiem(luaChon);
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
            (StackForm.TrangChu).ChildForm.Open(dangKyThue);
        }

        // Lọc danh sách những người đóng tiền trẽ hạn/ chưa đủ tiền khi quá thời gian
        private void btnTreHan_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.treHan);
        }

        //Ngắt trang
        private DataTable NgatTrang(DataTable ds, int recordNum)
        {
            int totalRecord = ds.Rows.Count;
            if (totalRecord <= 0)
                return ds;
            if (totalRecord % recordNum != 0)
                nudPage.Maximum = (totalRecord / recordNum) + 1;
            else
                nudPage.Maximum = totalRecord / recordNum;
            int page = int.Parse(nudPage.Value.ToString());
            return ds.AsEnumerable().Skip((page - 1) * recordNum).Take(recordNum).CopyToDataTable();
        }

        //Thay đổi page
        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (flpnPhanLoai.Width > 50)
                flpnPhanLoai.Width = 45;
            else
                flpnPhanLoai.Width = 1000;
        }

        private void btnCongDanCanTaoThue_Click(object sender, EventArgs e)
        {
            FDanhSachCongDan dscd = new FDanhSachCongDan(thueDAO.DuTuoiDongThue());
            FDanhSach ds = new FDanhSach();
            (StackForm.TrangChu).ChildForm.Open(ds);
            ds.ChildForm.Open(dscd);
        }

        private bool ThanhToan()
        {
            if (txtDongThue.Text.Length == 0) return false;
            if (KiemTraDuLieuNhap.isTien(txtDongThue.Text))
            {
                int tienNhap = int.Parse(txtDongThue.Text);
                Thue thue = thueDAO.LayThongTin(CCCDDAO.GetCCCD(gvThue, 1));
                if (thue.ThanhToan(tienNhap))
                {
                    thueDAO.CapNhatThue(thue);
                    return true;
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
                TimKiem(luaChon);
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
