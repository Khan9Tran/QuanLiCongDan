
namespace QuanLiCongDanThanhPho
{
    public partial class FDanhSach : Form
    {
        public OpenChildForm openChildForm;

        public FDanhSach()
        {
            InitializeComponent();
            StackForm.Add(this);
            openChildForm = new OpenChildForm(pnlHienThiDanhSach);
            FlatStyle();
        }

        private void FlatStyle()
        {
            btnCongDan.FlatAppearance.BorderSize = 0;
            btnHoKhau.FlatAppearance.BorderSize = 0;
            btnThue.FlatAppearance.BorderSize = 0;
            btnTTTV.FlatAppearance.BorderSize = 0;
        }

        private void FDanhSach_Load(object sender, EventArgs e)
        {
            flpnlPhanLoai.Width = 45;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (flpnlPhanLoai.Width > 50)
                flpnlPhanLoai.Width = 45;
            else
                flpnlPhanLoai.Width = 1600;
        }

        private void btnCongDan_Click(object sender, EventArgs e)
        {
            openChildForm.Open(new FDanhSachCongDan());
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            openChildForm.Open(new FDanhSachThue());
        }

        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            openChildForm.Open(new FDanhSachHoKhau());
        }

        private void btnTTTV_Click(object sender, EventArgs e)
        {
            openChildForm.Open(new FDanhSachTamTruTamVang());
        }
    }
}
