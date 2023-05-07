using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyKhaiSinh : FormDangKy
    {
        private void KhoiTao()
        {
            InitializeComponent();
        }

        public FDangKyKhaiSinh()
        {
            KhoiTao();
        }

        public FDangKyKhaiSinh(string cCCDThanNhan)
        {
            KhoiTao();
            LoadThongTinChaMe(cCCDThanNhan);
        }

        private void LoadThongTinChaMe(string cCCDThanNhan)
        {
            if (cCCDThanNhan != null)
            {
                HonNhan honNhan = HNDAO.LayThongTin(cCCDThanNhan);
                if (honNhan.MaSo != null)
                {
                    txtCccdCha.Text = honNhan.CCCDChong;
                    txtCccdMe.Text = honNhan.CCCDVo;
                    txtTenCha.Text = honNhan.TenChong;
                    txtTenMe.Text = honNhan.TenVo;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            base.Reset();
        }

        // Kiểm tra thông tin cha mẹ nhập có hợp lệ không
        private bool KiemTraChaMe()
        {
            HonNhan chong = HNDAO.LayThongTin(txtCccdCha.Text);
            HonNhan vo = HNDAO.LayThongTin(txtCccdMe.Text);

            if (chong.MaSo == null || vo.MaSo == null)
                return false;
            if (chong.MaSo != vo.MaSo)
                return false;
            if (txtTenCha.Text != chong.TenChong)
                return false;
            if (txtTenMe.Text != vo.TenVo)
                return false;
            return true;
        }

        internal override void DangKy()
        {
            CongDan congDan = new CongDan(txtCccd.Text, txtTen.Text);
            KhaiSinh kS = new KhaiSinh(txtCccd.Text, txtTen.Text, rdoNam.Checked.ToString(), (string)cboQuocTich.SelectedItem, (string)cboDanToc.SelectedItem, dtmNgaySinh.Value, dtmNgayDangKy.Value, txtNoiSinh.Text, txtQueQuan.Text, txtCccdCha.Text, txtTenCha.Text, txtCccdMe.Text, txtTenMe.Text);

            if (KiemTraChaMe() && KiemTraDuLieuNhap.KiemTraTenVaCCCD(congDan) && KiemTraDuLieuNhap.KiemTraKhaiSinh(kS) && CDDAO.ThemCongDan(congDan) && KSDAO.ThemKhaiSinh(kS))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Sai thông tin"); ;
        }

        // Nếu 2 người cùng trong thành phố thì phải kiểm tra hai người phải kết hôn rồi
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy();
        }
    }
}
