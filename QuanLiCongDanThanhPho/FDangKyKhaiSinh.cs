using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyKhaiSinh : Form
    {
        private KhaiSinhDAO kSDAO;
        private CongDanDAO cDDAO;
        private HonNhanDAO hNDAO;
        public FDangKyKhaiSinh()
        {
            InitializeComponent();
            kSDAO = new KhaiSinhDAO();
            cDDAO = new CongDanDAO();
            hNDAO = new HonNhanDAO();
            StackForm.Add(this);
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
            if ((cha.Ten != "unknow") && (txtTenCha.Text != cha.Ten))
            {
                MessageBox.Show("Tên và căn cước công dân cha không khớp");
                return false;
            }
            if ((me.Ten != "unknow") && (txtTenMe.Text != me.Ten))
            {
                MessageBox.Show("Tên và căn cước công dân mẹ không khớp");
                return false;
            }
            HonNhan Chong = hNDAO.LayThongTin(txtCccdCha.Text);
            HonNhan Vo = hNDAO.LayThongTin(txtCccdMe.Text);
            //Cả vợ và chồng đều có thông tin hôn nhân ở khu vực mới có thể đăng kí khai sinh cho con
            if (Chong.MaSo != Vo.MaSo || Chong.MaSo == "unknow" || Vo.MaSo == "unknow")
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
                cDDAO.ThemCongDan(congDan);
                KhaiSinh kS = new KhaiSinh(txtCccd.Text, txtTen.Text, rdoNam.Checked.ToString(), (string)cboQuocTich.SelectedItem, (string)cboDanToc.SelectedItem, dtmNgaySinh.Value, dtmNgayDangKy.Value, txtNoiSinh.Text, txtQueQuan.Text, txtCccdCha.Text, txtTenCha.Text, txtCccdMe.Text, txtTenMe.Text);
                kSDAO.ThemKhaSinh(kS);
            }
        }


    }
}
