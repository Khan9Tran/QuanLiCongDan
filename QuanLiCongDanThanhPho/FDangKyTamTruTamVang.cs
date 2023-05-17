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

        //Nếu là tạm trú từ nơi khác cần tạo công dân cho họ
        private bool TaoCongDan(CongDan congDan)
        {
            if (congDan.CCCD != null)
            {
                if (congDan.Ten != txtTen.Text)
                {
                    MessageBox.Show("Nhập sai tên");
                    return false;
                }
                return true;
            }

            CongDan cDTamTru = new CongDan(txtCCCD.Text, txtTen.Text, txtSDT.Text);

            if (KiemTraDuLieuNhap.KiemTraTenVaCCCD(cDTamTru))
            {
                CDDAO?.ThemCongDan(cDTamTru);
                return true;
            }
            else
                return false;
        }

        private string TamTru()
        {
            return "Tạm trú";
        }

        private string TamVang()
        {
            return "Tạm vắng";
        }

        //Đăng kí tạm trú/ tạm vắng cho công dân
        internal override void DangKy()
        {
            TamTruTamVang tTTV = new TamTruTamVang(txtMaSo.Text, txtCCCD.Text, "", dtpNgayBatDau.Value, dtpNgayKetThuc.Value, txtDiaChi.Text, txtLiDo.Text);
            CongDan congDan = CDDAO.LayThongTin(txtCCCD.Text);
            if (TTTVDAO.LayThongTin(txtCCCD.Text).MaSo != null || TTTVDAO.LayThongTinTheoMaSo(txtMaSo.Text).MaSo != null)
            {
                MessageBox.Show("Công dân đã đăng ký TTTV trước đó/ hoặc mã số trùng");
                return;
            }

            if (rdoTamVang.Checked == true && congDan.CCCD == null)
            {
                MessageBox.Show("Công dân không tồn tại ở địa phương");
                return;
            }
            else if (rdoTamTru.Checked == true)
            {
                tTTV.TrangThai = TamTru();
            }
            else if (rdoTamVang.Checked == true)
            {
                tTTV.TrangThai = TamVang();
            }

            if (KiemTraDuLieuNhap.isTamTruTamVang(tTTV) && KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text) && TaoCongDan(congDan) && TTTVDAO.ThemTamTruTamVang(tTTV))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
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
