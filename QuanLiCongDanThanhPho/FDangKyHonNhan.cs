using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyHonNhan : FormDangKy
    {
        public FDangKyHonNhan()
        {
            InitializeComponent();
        }
        
        //Thêm hôn nhân mới
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            HonNhan hN = new HonNhan(txtMaHonNhan.Text, txtCCCDChong.Text, txtTenChong.Text, txtCCCDVo.Text, txtTenVo.Text, txtNoiDK.Text, dtpNgayDangKy.Value);
            if (KiemTraDuLieuNhap.KiemTraHonNhan(hN) && HNDAO.ThemHonNhan(hN))
                MessageBox.Show("Đăng ký hôn nhân thành công");
            else
                MessageBox.Show("Đắng ký thất bại");
        }

        //Bật các nút giúp cho phép đăng ký li hôn
        public void ChoPhepLiHon()
        {
            txtCCCDChong.ReadOnly = true;
            txtCCCDVo.ReadOnly = true;
            txtTenChong.ReadOnly = true;
            txtTenVo.ReadOnly = true;
            txtNoiDK.ReadOnly = true;
            dtpNgayDangKy.Enabled = false;
            btnDelete.Enabled = true;
            btnDangKy.Enabled = false;
        }

        //Bật các nút cho phép kết hôn
        public void ChoPhepDangKy()
        {
            txtCCCDChong.ReadOnly = false;
            txtCCCDVo.ReadOnly = false;
            txtTenChong.ReadOnly = false;
            txtTenVo.ReadOnly = false;
            txtNoiDK.ReadOnly = false;
            dtpNgayDangKy.Enabled = true;
            btnDelete.Enabled = false;
            btnDangKy.Enabled = true;
        }

        //Li hôn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            HonNhan hN = new HonNhan(txtMaHonNhan.Text, txtCCCDChong.Text, txtTenChong.Text, txtCCCDVo.Text, txtCCCDChong.Text, txtNoiDK.Text, dtpNgayDangKy.Value);
            if (HNDAO.Xoa(hN))
                MessageBox.Show("Xóa hôn nhân thành công");
            else
                MessageBox.Show("Xóa hôn nhân thất bại");
            Reset();
        }

        //Đưa form về trạng thái ban đầu
        internal override void Reset()
        {
            base.Reset();
            dtpNgayDangKy.Value = DateTime.Now;
            ChoPhepDangKy();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Tải thông tin hôn nhân lên
        private void LoadHonNhan()
        {
            HonNhan hn = HNDAO.LayThongTinTheoMaSo(txtMaHonNhan.Text);
            txtCCCDChong.Text = hn.CCCDChong;
            txtCCCDVo.Text = hn.CCCDVo;
            txtTenChong.Text = hn.TenChong;
            txtTenVo.Text = hn.TenVo;
            txtNoiDK.Text = hn.NoiDangKy.toString();
            dtpNgayDangKy.Value = hn.NgayDangKy;

            if (hn.CCCDChong != null)
                ChoPhepLiHon();
            else
                ChoPhepDangKy();
        }

        //Tìm kiếm theo mã số
        private void txtMaHonNhan_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHonNhan.Text.Length > 0)
            {
                LoadHonNhan();  
            }

        }

        //Trả về tên hôn nhân thep mã số
        private string LayTenTheoCCCD(string cCCD)
        {
            KhaiSinh ks = KSDAO.LayThongTin(cCCD);
            if (ks.HoTen != null)
                return ks.HoTen;
            return null;
        }

        //Tìm kiếm theo CCCD
        private void btnTimChong_Click(object sender, EventArgs e)
        {
            txtTenChong.Text = LayTenTheoCCCD(txtCCCDChong.Text);
        }

        private void btnTimVo_Click(object sender, EventArgs e)
        {
            txtTenVo.Text = LayTenTheoCCCD(txtCCCDVo.Text);
        }
    }
}