using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyTamTruTamVang : Form
    {
        private TamTruTamVangDAO tTTVDAO;
        private CongDanDAO cDDAO;

        private void KhoiTao()
        {
            InitializeComponent();
            tTTVDAO = new TamTruTamVangDAO();
            cDDAO = new CongDanDAO();
            StackForm.Add(this);
        }

        public FDangKyTamTruTamVang()
        {
            KhoiTao();
        }

        public FDangKyTamTruTamVang(string cCCD)
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
                    txtTen.Text = congDan.Ten;
                    txtCCCD.Text = congDan.CCCD;
                    txtMaSo.Text = congDan.CCCD;
                    txtSDT.Text = congDan.SDT;
                    rdoTamVang.Checked = true;
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            TamTruTamVang tTTV = new TamTruTamVang(txtMaSo.Text, txtCCCD.Text, rdoTamTru.Checked.ToString(), dtpNgayBatDau.Value, dtpNgayKetThuc.Value, txtDiaChi.Text, txtLiDo.Text);
            CongDan congDan = cDDAO.LayThongTin(txtCCCD.Text);
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
                    if (!cDDAO.ThemCongDan(cDTamTru))
                    {
                        MessageBox.Show("Không thể dùng tùy chọn này");
                        return;
                    }
                }
            }

            if (KiemTraDuLieuNhap.isTamTruTamVang(tTTV) && KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text) && tTTVDAO.ThemTamTruTamVang(tTTV))
                MessageBox.Show("Đăng ký thành công");
            else
                MessageBox.Show("Đăng ký thất bại");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ToolsForControl.ClearTextBox(Controls);
        }
    }
}
