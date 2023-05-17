using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyCongDan : FormDangKy
    {
        enum LuaChon
        {
            docThan,
            ketHon,
        }

        public FDangKyCongDan()
        {
            InitializeComponent();
            HinhCongDan = new HinhDaiDien(HinhDaiDien.Type.congDan);
        }

        //Thêm hộ khẩu mới nếu công dân đăng kí là chủ hộ
        private bool ThemHoKhau()
        {
            if (HKDAO.LayThongTin(txtHoKhau.Text).MaHoKhau == null)
            {
                HoKhau hK = new HoKhau(txtHoKhau.Text, txtDiaChi.Text, txtCCCD.Text);
                if (KiemTraDuLieuNhap.KiemTraHoKhau(hK) && cboQuanHe.SelectedItem.ToString() == "Chủ hộ" && HKDAO.ThemHoKhau(hK))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Tạo hộ khẩu lỗi");
                    return false;
                }
            }
            return true;
        }

        //Đăng ký thông tin cho công dân bao gồm thông tin cơ bản của về công dân, khai sinh, thuế, hộ khẩu, hôn nhân nếu có
        internal override void DangKy()
        {
            CongDan cD = new CongDan(txtCCCD.Text, txtTen.Text, txtNgheNghiep.Text, txtSoDT.Text, (string)cboTonGiao.SelectedItem, txtHoKhau.Text, (string)cboQuanHe.SelectedItem, txtDiaChi.Text);
            KhaiSinh kS = new KhaiSinh(txtCCCD.Text, txtTen.Text, rdoNam.Checked.ToString(), (string)cboQuocTich.SelectedItem, (string)cboDanToc.SelectedItem, dtmNgaySinh.Value, dtmDKKhaiSinh.Value, txtNoiSinh.Text, txtQueQuan.Text, txtCCCDCha.Text, txtTenCha.Text, txtCCCDMe.Text, txtTenMe.Text);
            Thue thue = new Thue(txtThue.Text, txtCCCD.Text);

            if (KiemTraDuLieuNhap.KiemTraCongDan(cD) && KiemTraDuLieuNhap.KiemTraKhaiSinh(kS) && KiemTraDuLieuNhap.KiemTraThueDonGian(thue)
            && KiemTraDuLieuNhap.isHinh(ptcHinhDaiDien) && ThemHoKhau() && CDDAO.ThemCongDan(cD) && KSDAO.ThemKhaiSinh(kS))
            {
                HinhCongDan.SaveHinhDaiDien(txtCCCD.Text, ofdHinhDaiDien, ptcHinhDaiDien);

                if (!ThueDAO.ThemThue(thue))
                {
                    MessageBox.Show("Mã số thuế bị trùng. Vui lòng đăng kí thuế sau");
                }

                if (cboTinhTrang.SelectedIndex == (int)LuaChon.ketHon)
                {

                    HonNhan hN = new HonNhan(txtMaHonNhan.Text, txtCCCD.Text, txtTen.Text, txtCCCDVoChong.Text, txtTenVoChong.Text, "u,u,u,u", DateTime.Now, rdoNam.ToString());

                    if (KiemTraDuLieuNhap.KiemTraHonNhan(hN) && HNDAO.ThemHonNhan(hN))
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

        //Clear các TextBox, đặt lại các DateTimePicker
        internal override void Reset()
        {
            base.Reset();
            dtmDKKhaiSinh.Value = DateTime.Now;
            dtmNgaySinh.Value = DateTime.Now;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy();
        }



        //Chỉnh lại trạng thái(đọc/ghi) của TextBox theo tình trạng hôn nhân
        private void cboTinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            List<TextBox> textBoxs = new List<TextBox>() { txtTenVoChong, txtMaHonNhan, txtCCCDVoChong };
            if (cboTinhTrang.SelectedIndex == (int)LuaChon.ketHon)
            {
                ToolsForControl.ReadOnly(textBoxs, false, Color.Gainsboro);
            }
            else
            {
                ToolsForControl.ReadOnly(textBoxs, true, Color.WhiteSmoke);
            }
        }

        //Thêm hình đại diện của công dân
        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            HinhCongDan.ThemHinhDaiDien(ofdHinhDaiDien, ptcHinhDaiDien);
        }
    }
}
