
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

        private void XoaCongDan()
        {
            CongDan cD = new CongDan(txtCCCD.Text, txtTen.Text);
            if (cD.CCCD != null && cD.Ten == txtTen.Text && congDanDAO.XoaCongDan(cD))
                MessageBox.Show("Đã Khai tử");
            else
                MessageBox.Show("Khai tử thất bại");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
                XoaCongDan();
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
