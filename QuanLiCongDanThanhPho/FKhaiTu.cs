
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
            congDanDAO.XoaCongDan(cD);
        }

        private void Reset()
        {
            txtCCCD.Clear();
            txtTen.Clear();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                XoaCongDan();
                Reset();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            CongDan cD = congDanDAO.LayThongTin(txtCCCD.Text);
            if (cD != null)
            {
                txtTen.Text = cD.Ten;
            }
        }
    }
}
