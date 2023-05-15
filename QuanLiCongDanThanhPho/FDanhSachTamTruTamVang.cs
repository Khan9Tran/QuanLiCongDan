using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSachTamTruTamVang : FormDanhSach
    {
        private TamTruTamVangDAO tttvDAO;

        private enum Loc
        {
            tatCa,
            tamTru,
            tamVang,
            quaHan,
            choDuyet,
        }

        private enum ThoiGian
        {
            ngay,
            thang,
            nam,
        }

        //Đổi màu nút nhấn
        private void ChangeBtnColor(Loc type)
        {
            btnTatCa.BackColor = Color.RoyalBlue;
            btnQuaHan.BackColor = Color.RoyalBlue;
            btnTT.BackColor = Color.RoyalBlue;
            btnTV.BackColor = Color.RoyalBlue;
            btnChoDuyet.BackColor = Color.RoyalBlue;

            if (type == Loc.tatCa)
            {
                btnTatCa.BackColor = Color.DarkBlue;
            }
            else if (type == Loc.tamTru)
            {
                btnTT.BackColor = Color.DarkBlue;
            }
            else if (type == Loc.tamVang)
            {
                btnTV.BackColor = Color.DarkBlue;
            }
            else if (type == Loc.quaHan)
            {
                btnQuaHan.BackColor = Color.DarkBlue;
            }
            else if (type == Loc.choDuyet)
            {
                btnChoDuyet.BackColor = Color.DarkBlue;
            }
        }

        public FDanhSachTamTruTamVang()
        {
            InitializeComponent();

            tttvDAO = new TamTruTamVangDAO();
            ListData = new Paging(nudPage, 15);

            LuaChon = Loc.tatCa;
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        //Load danh sách ban đầu
        private void FDanhSachTamTruTamVang_Load(object sender, EventArgs e)
        {
            TimKiem(Loc.tatCa);
            flpnlPhanLoai.Width = 45;
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {   
            ChangeBtnColor(Loc.tatCa);
            TimKiem(Loc.tatCa);
        }


        //Tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (LuaChon == Loc.tatCa)
                Ds = tttvDAO.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (LuaChon == Loc.tamTru)
                Ds = tttvDAO.LayDanhSachTamTru(txtTimKiem.Text);
            else if (LuaChon == Loc.tamVang)
                Ds = tttvDAO.LayDanhSachTamVang(txtTimKiem.Text);
            else if (LuaChon == Loc.quaHan)
                Ds = tttvDAO.LayDanhSachQuaHan(txtTimKiem.Text);
            else if (LuaChon == Loc.choDuyet)
                Ds = tttvDAO.LayDanhSachChoDuyet(txtTimKiem.Text);
            nudPage.Value = 1;
            LoadDanhSach(gvTVTT);
        }

        internal override void HeaderText()
        {
            gvTVTT.Columns[4].DefaultCellStyle.Format = DayFormat();
            gvTVTT.Columns[3].DefaultCellStyle.Format = DayFormat();
            HightLightQuaHan();
        }

        //Tăng số ngày kết thúc tạm trú tạm vắng
        private void GiaHan(dynamic thoiGian, int soLuong)
        {
            TamTruTamVang tTTV = tttvDAO.LayThongTin(CCCDDAO.GetCCCD(gvTVTT, 1));
            if (tTTV.CCCD != null)
            {
                if (thoiGian == ThoiGian.ngay)
                    tTTV.NgayKetThuc = tTTV.NgayKetThuc.AddDays(soLuong);
                else if (thoiGian == ThoiGian.thang)
                    tTTV.NgayKetThuc = tTTV.NgayKetThuc.AddMonths(soLuong);
                else
                    tTTV.NgayKetThuc = tTTV.NgayKetThuc.AddYears(soLuong);
                tttvDAO.CapNhat(tTTV);
                TimKiem(LuaChon);
            }
        }

        // Tô đỏ những người quá hạn tạm trú/tạm vắng
        private void HightLightQuaHan()
        {
            for (int index = 0; index < gvTVTT.Rows.Count; index++)
            {
                if (gvTVTT.Rows[index].Cells[4].Value != null && (DateTime)(gvTVTT.Rows[index].Cells[4]).Value < DateTime.Now)
                {
                    gvTVTT.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                } 
            }
        }

        // Lọc danh sách tạm vắng
        private void btnTV_Click(object sender, EventArgs e)
        {   
            ChangeBtnColor(Loc.tamVang);
            TimKiem(Loc.tamVang);
        }

        // Lọc danh sách tạm trú
        private void btnTT_Click(object sender, EventArgs e)
        {   
            ChangeBtnColor(Loc.tamTru);
            TimKiem(Loc.tamTru);
        }

        //Chuyển đến form thêm tttv
        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyTamTruTamVang dangKyTTTV = new FDangKyTamTruTamVang();
            (StackForm.TrangChu)?.ChildForm.Open(dangKyTTTV);
        }

        private void gvTVTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && gvTVTT.Rows[e.RowIndex].Cells[0].Value.ToString()?.Length > 0)
            {
                cmnusMenu.Show(this, this.PointToClient(MousePosition));
            }
        }

        //Xóa thông tin
        private void cmnusMenuXoa_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có thật sự muốn xóa thông tin tạm trú/tạm vắng?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                string maCCCD = CCCDDAO.GetCCCD(gvTVTT, 1);
                if (maCCCD != "")
                {
                    if (tttvDAO.XoaTamTruTamVang(maCCCD))
                        MessageBox.Show("Xóa tạm trú/tạm vắng thành công");
                    else
                        MessageBox.Show("Xóa tạm trú/tạm vắng thất bại");
                    txtTimKiem_TextChanged(txtTimKiem, null);
                }
            }
        }

        // Lọc danh sách hết hạn tạm trú tạm vắng
        private void btnQuaHan_Click(object sender, EventArgs e)
        {   
            ChangeBtnColor(Loc.quaHan);
            TimKiem(Loc.quaHan);
        }

        // Tìm kiếm theo lựa chọn
        private void TimKiem(dynamic type)
        {
            LuaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        //Tải lại danh sách khi chuyển trang
        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach(gvTVTT);
        }

        //Mở chức năng lọc
        private void btnLoc_Click(object sender, EventArgs e)
        {
            Loc_Click(flpnlPhanLoai);
        }

        // Tăng thời gian tạm trú/tạm vắng thêm 3 ngày
        private void ngayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GiaHan(ThoiGian.ngay, 3);
        }

        // Tăng thời gian tạm trú/tạm vắng thêm 7 ngày / 1 tuần
        private void tuanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GiaHan(ThoiGian.ngay, 7);
        }

        // Tăng thời gian tạm trú/tạm vắng thêm 1 tháng
        private void thangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GiaHan(ThoiGian.thang, 1);
        }

        // Tăng thời gian tạm trú/tạm vắng thêm 1 năm
        private void namToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GiaHan(ThoiGian.nam, 1);
        }

        //Mở danh sách công dân chờ duyệt tttv
        private void btnChoDuyet_Click(object sender, EventArgs e)
        {
            ChangeBtnColor(Loc.choDuyet);
            TimKiem(Loc.choDuyet);
        }

        //Duyệt yêu cầu tạm trú tạm vắng
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (gvTVTT.Rows.Count > 1)
            {
                string maCCCD = CCCDDAO.GetCCCD(gvTVTT, 1);

                TamTruTamVang tTTV = tttvDAO.LayThongTin(maCCCD);
                if (tTTV.MaSo != null)
                {
                    if (tTTV.TrangThai == "CDTV" || tTTV.TrangThai == "CDTT")
                    {
                        if (tTTV.TrangThai == "CDTV")
                            tTTV.TrangThai = "Tạm vắng";
                        if (tTTV.TrangThai == "CDTT")
                            tTTV.TrangThai = "Tạm trú";

                        tttvDAO.CapNhat(tTTV);
                        MessageBox.Show("Đã duyệt");
                        txtTimKiem_TextChanged(txtTimKiem, null);
                    }
                }
            }
        }
    }
}
