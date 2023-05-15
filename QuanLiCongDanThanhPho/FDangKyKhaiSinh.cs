using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyKhaiSinh : FormDangKy
    {
        //Hàm khởi tạo các thành phần của form
        private void KhoiTao()
        {
            InitializeComponent();
        }

        public FDangKyKhaiSinh()
        {
            KhoiTao();
        }

        //Hiện thị thông tin của cha mẹ nếu được truyền vào mã cccd của cha hoặc mẹ
        public FDangKyKhaiSinh(string cCCDThanNhan)
        {
            KhoiTao();
            LoadThongTinChaMe(cCCDThanNhan);
        }

        //Lấy thông tin cha mẹ để vào các TextBox
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

        //Clear các TextBox có trong form
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
            {
                MessageBox.Show("Cha/ mẹ chưa có hôn nhân");
                return false;
            }
            if (chong.MaSo != vo.MaSo)
            {
                MessageBox.Show("Cha mẹ không khớp trong hôn nhân");
                return false;
            }
            if (txtTenCha.Text != chong.TenChong)
                return false;
            if (txtTenMe.Text != vo.TenVo)
                return false;
            return true;
        }

        //Đăng ký khai sinh
        internal override void DangKy()
        {
            CongDan congDan = new CongDan(txtCccd.Text, txtTen.Text);
            KhaiSinh kS = new KhaiSinh(txtCccd.Text, txtTen.Text, rdoNam.Checked.ToString(), (string)cboQuocTich.SelectedItem, (string)cboDanToc.SelectedItem, dtmNgaySinh.Value, dtmNgayDangKy.Value, txtNoiSinh.Text, txtQueQuan.Text, txtCccdCha.Text, txtTenCha.Text, txtCccdMe.Text, txtTenMe.Text);

            if (KiemTraChaMe() && KiemTraDuLieuNhap.KiemTraTenVaCCCD(congDan) && KiemTraDuLieuNhap.KiemTraKhaiSinh(kS) && CDDAO.ThemCongDan(congDan) && KSDAO.ThemKhaiSinh(kS))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Sai thông tin"); ;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy();
        }

        private int turn = 0;
        private void TuDongNhap()
        {
            KhaiSinh chong = KSDAO.LayThongTin(txtCccdCha.Text);
            KhaiSinh vo = KSDAO.LayThongTin(txtCccdMe.Text);
            if (turn == 0 && chong.MaKhaiSinh == null)
            {
                turn = 1;
                if (vo.MaKhaiSinh == null) turn = 2;
            }
            switch (turn)
            {
                case 0:
                    txtQueQuan.Text = chong.QueQuan.toString();
                    txtNoiSinh.Text = chong.NoiSinh.toString();
                    cboQuocTich.SelectedItem = chong.QuocTich;
                    cboDanToc.SelectedItem = chong.DanToc;
                    if (vo.MaKhaiSinh != null)
                    {
                        turn += 1;
                    }
                    else
                    {
                        turn += 2;
                    }    
                    break;
                case 1:
                    txtQueQuan.Text = vo.QueQuan.toString();
                    txtNoiSinh.Text = vo.NoiSinh.toString();
                    cboQuocTich.SelectedItem = vo.QuocTich;
                    cboDanToc.SelectedItem = vo.DanToc;
                    turn++;
                    break;
                case 2:
                    txtQueQuan.Text = "";
                    txtNoiSinh.Text = "";
                    cboQuocTich.SelectedItem = "";
                    cboDanToc.SelectedItem = "";
                    turn = 0;
                    break;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            TuDongNhap();
        }
    }
}
