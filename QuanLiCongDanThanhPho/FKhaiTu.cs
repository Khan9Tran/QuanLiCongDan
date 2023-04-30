
namespace QuanLiCongDanThanhPho
{
    public partial class FKhaiTu : Form
    {
        private CongDanDAO congDanDAO;

        public FKhaiTu()
        {
            InitializeComponent();
            StackForm.Add(this);
            congDanDAO = new CongDanDAO();
        }

        private bool KiemTraThongTin()
        {
            CongDan cD = congDanDAO.LayThongTin(txtCCCD.Text);
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCD.Text) || cD.CCCD == null)
            {
                MessageBox.Show("CCCD không chính xác");
                txtCCCD.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text) || cD.Ten != txtTen.Text)
            {
                MessageBox.Show("Tên nhập không chính xác");
                txtTen.Focus();
                return false;

            }
            return true;
        }

        private void XoaCongDan()
        {
            CongDan cD = new CongDan(txtCCCD.Text, txtTen.Text);
            if (congDanDAO.XoaCongDan(cD))
                MessageBox.Show("Khai tử công dân thành công");
            else
                MessageBox.Show("Khai tử công dân thất bại");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                XoaCongDan();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ToolsForControl.ClearTextBox(Controls);
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            CongDan cD = congDanDAO.LayThongTin(txtCCCD.Text);
            if (cD.CCCD != null)
            {
                txtTen.Text = cD.Ten;
            }
        }
    }
}
