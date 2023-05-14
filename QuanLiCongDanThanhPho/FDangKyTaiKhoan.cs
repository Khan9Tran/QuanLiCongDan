using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyTaiKhoan : Form
    {
        CongDanDAO cdDAO;
        AccountDAO accountDAO;

        public FDangKyTaiKhoan()
        {
            InitializeComponent();
            StackForm.Add(this);
            cdDAO = new CongDanDAO();
            accountDAO = new AccountDAO();
            
        }

        //Lấy tên công dân theo CCCD
        private void btnThongTinCCCD_Click(object sender, EventArgs e)
        {
            CongDan? congDan = cdDAO.LayThongTin(txtCCCD.Text);
            if (congDan != null) 
            {
                txtTenHienThi.Text = congDan.Ten;
            }
        }

        //Kiểm tra thông tin tài khoản trước khi đăng kí
        private bool KiemTra()
        {
            CongDan cd = cdDAO.LayThongTin(txtCCCD.Text);
            CongDan congDanTmp = new CongDan(txtCCCD.Text, txtTenHienThi.Text);
            if (cd.CCCD == null || !KiemTraDuLieuNhap.KiemTraTenVaCCCD(congDanTmp))
            {
                return false;
            }
            return KiemTraDuLieuNhap.KiemTraPass("", txtMatKhau.Text, txtNhapLai.Text);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (KiemTra()) 
            {
                TaoHoacCapNhatTaiKhoan();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin đăng kí");
            }
        }

        //Tạo tài khoản mới cho công dân, hoặc cặp nhập lại nếu đã có trong cơ sở dữ liệu
        private void TaoHoacCapNhatTaiKhoan()
        {
            Account acc = new Account()
            {
                UserName = txtCCCD.Text,
                DisplayName = txtTenHienThi.Text,
                Password = txtMatKhau.Text,
                Type = 0
            };
            if (accountDAO.LayThongTinTaiKhoan(acc).UserName != acc.UserName)
            {
                accountDAO.DangKy(acc);
                MessageBox.Show("Tạo tài khoản thành công");
            }    
            else
            {
                accountDAO.CapNhatDisplayName(acc);
                accountDAO.CapNhatMatKhau(acc);
            }    
        }
    }
}
