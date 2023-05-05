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

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text))
            {
                txtTen.Focus();
                MessageBox.Show("Tên Không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCccd.Text))
            {
                txtCccd.Focus();
                MessageBox.Show("CCCD không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtQueQuan.Text))
            {
                txtQueQuan.Focus();
                MessageBox.Show("Quê quán Không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtNoiSinh.Text))
            {
                txtNoiSinh.Focus();
                MessageBox.Show("Nơi sinh không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenCha.Text))
            {
                txtTenCha.Focus();
                MessageBox.Show("Tên cha Không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCccdCha.Text))
            {
                txtCccdCha.Focus();
                MessageBox.Show("CCCD cha không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTenMe.Text))
            {
                txtTenMe.Focus();
                MessageBox.Show("Tên mẹ Không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCccdMe.Text))
            {
                txtCccdMe.Focus();
                MessageBox.Show("CCCD Me không hợp lệ");
                return false;
            }
            if (rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Giới tính không hợp lệ");
                return false;
            }
            if (cboQuocTich.SelectedItem == null)
            {
                cboQuocTich.Focus();
                MessageBox.Show("Quốc tịch không hợp lệ");
                return false;
            }
            if (cboDanToc.SelectedItem == null)
            {
                cboDanToc.Focus();
                MessageBox.Show("Dân tộc không hợp lệ");
                return false;
            }
            return true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ToolsForControl.ClearTextBox(Controls);
        }

        // Kiểm tra thông tin cha mẹ nhập có hợp lệ không
        private bool KiemTraChaMe()
        {
            CongDan cha = cDDAO.LayThongTin(txtCccdCha.Text);
            CongDan me = cDDAO.LayThongTin(txtCccdMe.Text);
            if (cha.CCCD == null)
            {
                MessageBox.Show("Cha không có trong thành phố");
                return false;
            }
            if (me.CCCD == null)
            {
                MessageBox.Show("Mẹ không có trong thành phố");
                return false;
            }
            if ((cha.Ten != null) && (txtTenCha.Text != cha.Ten))
            {
                MessageBox.Show("Tên và căn cước công dân cha không khớp");
                return false;
            }
            if ((me.Ten != null) && (txtTenMe.Text != me.Ten))
            {
                MessageBox.Show("Tên và căn cước công dân mẹ không khớp");
                return false;
            }
            HonNhan Chong = hNDAO.LayThongTin(txtCccdCha.Text);
            HonNhan Vo = hNDAO.LayThongTin(txtCccdMe.Text);
            //Cả vợ và chồng đều có thông tin hôn nhân ở khu vực mới có thể đăng kí khai sinh cho con
            if (Chong.MaSo != Vo.MaSo || Chong.MaSo == null || Vo.MaSo == null)
            {
                MessageBox.Show("Hôn nhân không khớp");
                return false;
            }
            return true;
        }

        // Nếu 2 người cùng trong thành phố thì phải kiểm tra hai người phải kết hôn rồi
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin() && KiemTraChaMe())
            { 
                CongDan congDan = new CongDan(txtCccd.Text, txtTen.Text);
                if (!cDDAO.ThemCongDan(congDan))
                {
                    MessageBox.Show("Thêm khai sinh thất bại");
                    return;
                }
                KhaiSinh kS = new KhaiSinh(txtCccd.Text, txtTen.Text, rdoNam.Checked.ToString(), (string)cboQuocTich.SelectedItem, (string)cboDanToc.SelectedItem, dtmNgaySinh.Value, dtmNgayDangKy.Value, txtNoiSinh.Text, txtQueQuan.Text, txtCccdCha.Text, txtTenCha.Text, txtCccdMe.Text, txtTenMe.Text);
                if (!kSDAO.ThemKhaSinh(kS))
                {
                    MessageBox.Show("Thêm khai sinh thất bại");
                    return;
                }
                MessageBox.Show("Thêm khai sinh thành công");
            }
        }


    }
}
