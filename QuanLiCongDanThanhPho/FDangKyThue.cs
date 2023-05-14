using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyThue : FormDangKy
    {
        //Hàm tạo các thành phần của form
        private void KhoiTao()
        {
            InitializeComponent();
        }

        public FDangKyThue()
        {
            KhoiTao();
        }

        //Load thông tin thuế của công dân nếu được truyền CCCD
        public FDangKyThue(string cCCD)
        {
            KhoiTao();
            LoadThongTin(cCCD);
        }

        //Hiện thị thông tin của công dân trong TextBox
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

        //Clear các TextBox
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

        //Đăng kí thuế cho công dân
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
