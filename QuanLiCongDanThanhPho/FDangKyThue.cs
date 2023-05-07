using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyThue : FormDangKy
    {
        private void KhoiTao()
        {
            InitializeComponent();
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
                CongDan congDan = CDDAO.LayThongTin(cCCD);
                if (congDan.CCCD != null)
                {
                    txtCCCD.Text = congDan.CCCD;
                    txtMaSoThue.Text = congDan.CCCD;
                    txtSoTienDaNop.Text = "0";
                }
            }
        }

        internal override void Reset()
        {
            base.Reset();
            dtpNgayCapMa.Value = DateTime.Now;
            dtpHanNop.Value = DateTime.Now;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        internal override void DangKy()
        {
            Thue thue = new Thue(txtMaSoThue.Text, txtCCCD.Text, dtpNgayCapMa.Value, dtpHanNop.Value, txtSoTienCanNop.Text, txtSoTienDaNop.Text);
            if (KiemTraDuLieuNhap.KiemTraThue(thue) && ThueDAO.ThemThue(thue))
                MessageBox.Show("Đăng ký thuế thành công");
            else
                MessageBox.Show("Đăng ký thuế thất bại");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy();
        }
    }
}
