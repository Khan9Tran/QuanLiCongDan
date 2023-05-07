using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyKhaiSinh : Form
    {
        private KhaiSinhDAO kSDAO;
        private CongDanDAO cDDAO;
        private HonNhanDAO hNDAO;

        private void KhoiTao()
        {
            InitializeComponent();
            kSDAO = new KhaiSinhDAO();
            cDDAO = new CongDanDAO();
            hNDAO = new HonNhanDAO();
            StackForm.Add(this);
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
                HonNhan honNhan = hNDAO.LayThongTin(cCCDThanNhan);
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
            ToolsForControl.ClearTextBox(Controls);
        }

        // Kiểm tra thông tin cha mẹ nhập có hợp lệ không
        private bool KiemTraChaMe()
        {
            HonNhan chong = hNDAO.LayThongTin(txtCccdCha.Text);
            HonNhan vo = hNDAO.LayThongTin(txtCccdMe.Text);

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

        // Nếu 2 người cùng trong thành phố thì phải kiểm tra hai người phải kết hôn rồi
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            CongDan congDan = new CongDan(txtCccd.Text, txtTen.Text);
            KhaiSinh kS = new KhaiSinh(txtCccd.Text, txtTen.Text, rdoNam.Checked.ToString(), (string)cboQuocTich.SelectedItem, (string)cboDanToc.SelectedItem, dtmNgaySinh.Value, dtmNgayDangKy.Value, txtNoiSinh.Text, txtQueQuan.Text, txtCccdCha.Text, txtTenCha.Text, txtCccdMe.Text, txtTenMe.Text);

            if (KiemTraChaMe() && KiemTraDuLieuNhap.KiemTraTenVaCCCD(congDan) && KiemTraDuLieuNhap.KiemTraKhaiSinh(kS) && cDDAO.ThemCongDan(congDan) && kSDAO.ThemKhaiSinh(kS))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Sai thông tin");
        }
    }
}
