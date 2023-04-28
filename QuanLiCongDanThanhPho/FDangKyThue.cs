using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyThue : Form
    {
        private CongDanDAO cDDAO;
        private ThueDAO thueDAO;

        private void KhoiTao()
        {
            StackForm.Add(this);
            cDDAO = new CongDanDAO();
            thueDAO = new ThueDAO();
        }

        public FDangKyThue()
        {
            InitializeComponent();
            KhoiTao();
        }
        public FDangKyThue(string cCCD)
        {
            InitializeComponent();
            KhoiTao();
            LoadThongTin(cCCD);
        }
        private void LoadThongTin(string cCCD)
        {
            if (cCCD != null)
            {
                CongDan congDan = cDDAO.LayThongTin(cCCD);
                txtCCCD.Text = congDan.CCCD;
                txtMaSoThue.Text = congDan.CCCD;
                txtSoTienDaNop.Text = "0";
            }
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isMaSo(txtMaSoThue.Text))
            {
                MessageBox.Show("Mã số thuế sai định dạng");
                txtMaSoThue.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCD.Text))
            {
                MessageBox.Show("CCCD sai định dạng");
                txtCCCD.Focus();
                return false;
            }
            if (txtSoTienCanNop.Text == "")
            {
                txtSoTienCanNop.Focus();
                MessageBox.Show("Vui lòng nhập số tiền cần nộp");
                return false;
            }
            if (txtSoTienDaNop.Text == "")
            {
                txtSoTienDaNop.Focus();
                MessageBox.Show("Vui lòng nhập số tiền Đã nộp");
                return false;
            }
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                Thue thue = new Thue(txtMaSoThue.Text, txtCCCD.Text, dtpNgayCapMa.Value, dtpHanNop.Value, txtSoTienCanNop.Text, txtSoTienDaNop.Text);
                thueDAO.ThemThue(thue);
            }
        }
    }
}
