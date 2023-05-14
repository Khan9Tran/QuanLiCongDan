using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyTamTruTamVang : FormDangKy
    {
        //Khởi tạo các thành phần cơ bản của form
        private void KhoiTao()
        {
            InitializeComponent();
        }

        public FDangKyTamTruTamVang()
        {
            KhoiTao();
        }

        //Load các thông tin của công dân vào sẵn trong TextBox nếu được truyền CCCD
        public FDangKyTamTruTamVang(string cCCD)
        {
            KhoiTao();
            LoadThongTin(cCCD);
        }

        //Hiện thị thông tin của công dân
        private void LoadThongTin(string cCCD)
        {
            if (cCCD != null)
            {
                CongDan congDan = CDDAO.LayThongTin(cCCD);
                if (congDan.CCCD != null)
                {
                    txtTen.Text = congDan.Ten;
                    txtCCCD.Text = congDan.CCCD;
                    txtMaSo.Text = congDan.CCCD;
                    txtSDT.Text = congDan.SDT;
                    rdoTamVang.Checked = true;
                }
            }
        }

        //Đăng kí tạm trú/ tạm vắng cho công dân
        internal override void DangKy()
        {
            TamTruTamVang tTTV = new TamTruTamVang(txtMaSo.Text, txtCCCD.Text, rdoTamTru.Checked.ToString(), dtpNgayBatDau.Value, dtpNgayKetThuc.Value, txtDiaChi.Text, txtLiDo.Text);
            CongDan congDan = CDDAO.LayThongTin(txtCCCD.Text);
            if (rdoTamVang.Checked == true && congDan.CCCD == null)
            {
                MessageBox.Show("Đăng ký thất bại");
                return;
            }
            else if (rdoTamTru.Checked == true)
            {
                if (congDan.CCCD == null)
                {
                    CongDan cDTamTru = new CongDan(txtCCCD.Text, txtTen.Text, txtSDT.Text);
                    if (!CDDAO.ThemCongDan(cDTamTru))
                    {
                        MessageBox.Show("Không thể dùng tùy chọn này");
                        return;
                    }
                }
            }

            if (KiemTraDuLieuNhap.isTamTruTamVang(tTTV) && KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text) && TTTVDAO.ThemTamTruTamVang(tTTV))
                MessageBox.Show("Đăng ký thành công");
            else
                MessageBox.Show("Đăng ký thất bại");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            base.Reset();
        }
    }
}
