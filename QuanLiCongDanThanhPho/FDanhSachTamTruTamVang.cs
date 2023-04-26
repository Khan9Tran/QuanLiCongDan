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
        TamTruTamVangDAO tttvDao;
        private dynamic luaChon;
        private DataTable ds;

        private enum Loc
        {
            tatCa,
            tamTru,
            tamVang,
            quaHan,
        }

        private enum ThoiGian
        {
            ngay,
            thang,
            nam,
        }
        public FDanhSachTamTruTamVang()
        {
            InitializeComponent();
            StackForm.Add(this);
            ds = new DataTable();
            tttvDao = new TamTruTamVangDAO();
            luaChon = Loc.tatCa;
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
            TimKiem(Loc.tatCa);
        }


        //Tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (luaChon == Loc.tatCa)
                ds = tttvDao.LayDanhSachChuaTu(txtTimKiem.Text);
            else if (luaChon == Loc.tamTru)
                ds = tttvDao.LayDanhSachTamTru(txtTimKiem.Text);
            else if (luaChon == Loc.tamVang)
                ds = tttvDao.LayDanhSachTamVang(txtTimKiem.Text);
            else if (luaChon == Loc.quaHan)
                ds = tttvDao.LayDanhSachQuaHan(txtTimKiem.Text);
            nudPage.Value = 1;
            LoadDanhSach();
        }

        private string GetCCCD()
        {
            return (string)gvTVTT.CurrentRow.Cells["CCCD"].Value;
        }

        private void LoadDanhSach()
        {
            gvTVTT.DataSource = NgatTrang(ds, 10);
            gvTVTT.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            gvTVTT.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            HightLightQuaHan();
        }

        private void GiaHan(dynamic thoiGian, int soLuong)
        {
            TamTruTamVang tTTV = tttvDao.LayThongTin(GetCCCD());
            if (thoiGian == ThoiGian.ngay)
                tTTV.NgayKetThuc = tTTV.NgayKetThuc.AddDays(soLuong);
            else if (thoiGian == ThoiGian.thang)
                tTTV.NgayKetThuc = tTTV.NgayKetThuc.AddMonths(soLuong);
            else
                tTTV.NgayKetThuc = tTTV.NgayKetThuc.AddYears(soLuong);
            tttvDao.CapNhat(tTTV);
            TimKiem(luaChon);
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
            TimKiem(Loc.tamVang);
        }

        // Lọc danh sách tạm trú
        private void btnTT_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.tamTru);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FDangKyTamTruTamVang dangKyTTTV = new FDangKyTamTruTamVang();
            (StackForm.fTrangChu).OpenChildForm(dangKyTTTV);
        }

        private void gvTVTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && gvTVTT.Rows[e.RowIndex].Cells[0].Value.ToString().Length > 0)
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
                string maCCCD = GetCCCD();
                if (maCCCD != "")
                {
                    tttvDao.XoaTamTruTamVang(maCCCD);
                    txtTimKiem_TextChanged(txtTimKiem, null);
                }
            }
        }

        // Lọc danh sách hết hạn tạm trú tạm vắng
        private void btnQuaHan_Click(object sender, EventArgs e)
        {
            TimKiem(Loc.quaHan);
        }

        // Tìm kiếm theo lựa chọn
        private void TimKiem(dynamic type)
        {
            luaChon = type;
            txtTimKiem_TextChanged(txtTimKiem, null);
        }

        // Ngắt trang
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

        private void nudPage_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (flpnlPhanLoai.Width > 50)
                flpnlPhanLoai.Width = 45;
            else
                flpnlPhanLoai.Width = 800;
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
    }
}
