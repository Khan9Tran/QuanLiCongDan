using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyThue : Form
    {
        private CongDanDAO cDDAO;
        private ThueDAO thueDAO;

        private void KhoiTao()
        {
            InitializeComponent();
            StackForm.Add(this);
            cDDAO = new CongDanDAO();
            thueDAO = new ThueDAO();
        }

        public FDangKyThue()
        {
            KhoiTao();
        }

        public FDangKyThue(string cCCD)
        {
            KhoiTao();
            LoadThongTin(cCCD);
        }

        private void LoadThongTin(string cCCD)
        {
            if (cCCD != null)
            {
                CongDan congDan = cDDAO.LayThongTin(cCCD);
                if (congDan.CCCD != null)
                {
                    txtCCCD.Text = congDan.CCCD;
                    txtMaSoThue.Text = congDan.CCCD;
                    txtSoTienDaNop.Text = "0";
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ToolsForControl.ClearTextBox(Controls);
            dtpNgayCapMa.Value = DateTime.Now;
            dtpHanNop.Value = DateTime.Now;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Thue thue = new Thue(txtMaSoThue.Text, txtCCCD.Text, dtpNgayCapMa.Value, dtpHanNop.Value, txtSoTienCanNop.Text, txtSoTienDaNop.Text);
            if (KiemTraDuLieuNhap.KiemTraThue(thue) && thueDAO.ThemThue(thue))
                MessageBox.Show("Đăng ký thuế thành công");
            else
                MessageBox.Show("Đăng ký thuế thất bại");
        }
    }
}
