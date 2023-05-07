using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyCongDan : Form
    {
        private CongDanDAO cDDAO;
        private KhaiSinhDAO kSDAO;
        private ThueDAO thueDAO;
        private HonNhanDAO hNDAO;
        private HoKhauDAO hKDAO;
        private HinhDaiDien hinhDaiDien;

        enum LuaChon
        {
            docThan,
            ketHon,
        }

        public FDangKyCongDan()
        {
            InitializeComponent();
            StackForm.Add(this);
            cDDAO = new CongDanDAO();
            kSDAO = new KhaiSinhDAO();
            thueDAO = new ThueDAO();
            hNDAO = new HonNhanDAO();
            hKDAO = new HoKhauDAO();
            hinhDaiDien = new HinhDaiDien(HinhDaiDien.Type.congDan);
        }

        private bool ThemHoKhau()
        {
            if (hKDAO.LayThongTin(txtHoKhau.Text).MaHoKhau == null)
            {
                HoKhau hK = new HoKhau(txtHoKhau.Text, txtDiaChi.Text, txtCCCD.Text);
                if (KiemTraDuLieuNhap.KiemTraHoKhau(hK) && cboQuanHe.SelectedItem.ToString() == "Chủ hộ")
                {
                    hKDAO.ThemHoKhau(hK);
                    return true;
                }
                else
                { 
                    return false;
                }
            }
            return true;
        }

        public void ThemCongDan()
        {
            CongDan cD = new CongDan(txtCCCD.Text, txtTen.Text, txtNgheNghiep.Text, txtSoDT.Text, (string)cboTonGiao.SelectedItem, txtHoKhau.Text, (string)cboQuanHe.SelectedItem, txtDiaChi.Text);
            KhaiSinh kS = new KhaiSinh(txtCCCD.Text, txtTen.Text, rdoNam.Checked.ToString(), (string)cboQuocTich.SelectedItem, (string)cboDanToc.SelectedItem, dtmNgaySinh.Value, dtmDKKhaiSinh.Value, txtNoiSinh.Text, txtQueQuan.Text, txtCCCDCha.Text, txtTenCha.Text, txtCCCDMe.Text, txtTenMe.Text);
            Thue thue = new Thue(txtThue.Text, txtCCCD.Text);

            if (KiemTraDuLieuNhap.KiemTraCongDan(cD) && KiemTraDuLieuNhap.KiemTraKhaiSinh(kS) && KiemTraDuLieuNhap.KiemTraThueDonGian(thue)
            && ptcHinhDaiDien.Image != null && ThemHoKhau() && cDDAO.ThemCongDan(cD) && kSDAO.ThemKhaiSinh(kS))
            {
                hinhDaiDien.SaveHinhDaiDien(txtCCCD.Text, ofdHinhDaiDien, ptcHinhDaiDien);

                if (cboTinhTrang.SelectedIndex == (int)LuaChon.ketHon)
                {

                    HonNhan hN = new HonNhan(txtMaHonNhan.Text, txtCCCD.Text, txtTen.Text, txtCCCDVoChong.Text, txtTenVoChong.Text, "u,u,u,u", DateTime.Now, rdoNam.ToString());

                    if (!thueDAO.ThemThue(thue))
                    {
                        MessageBox.Show("Mã số thuế bị trùng. Vui lòng đăng kí thuế sau");
                    }
                    
                    if (KiemTraDuLieuNhap.KiemTraHonNhan(hN) && hNDAO.ThemHonNhan(hN))
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công. Thêm hôn nhân lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ToolsForControl.ClearTextBox(Controls);
            dtmDKKhaiSinh.Value = DateTime.Now;
            dtmNgaySinh.Value = DateTime.Now;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            ThemCongDan();
        }

        private void cboTinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTinhTrang.SelectedIndex == (int)LuaChon.ketHon)
            {
                txtTenVoChong.ReadOnly = false;
                txtMaHonNhan.ReadOnly = false;
                txtCCCDVoChong.ReadOnly = false;
                txtCCCDVoChong.BackColor = Color.Gainsboro;
                txtMaHonNhan.BackColor = Color.Gainsboro;
                txtTenVoChong.BackColor = Color.Gainsboro;
            } 
            else
            {
                txtTenVoChong.ReadOnly = true;
                txtMaHonNhan.ReadOnly = true;
                txtCCCDVoChong.ReadOnly = true;
                txtCCCDVoChong.BackColor = Color.WhiteSmoke;
                txtMaHonNhan.BackColor = Color.WhiteSmoke;
                txtTenVoChong.BackColor = Color.WhiteSmoke;
            }    
        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            hinhDaiDien.ThemHinhDaiDien(ofdHinhDaiDien, ptcHinhDaiDien);
        }
    }
}
