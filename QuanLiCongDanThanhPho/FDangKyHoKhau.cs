
namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyHoKhau : Form
    {
        public OpenChildForm openChildForm;

        private void KhoiTao()
        {
            InitializeComponent();
            openChildForm = new OpenChildForm(pnlLuaChon);
            StackForm.Add(this);
        }

        public FDangKyHoKhau()
        {
            KhoiTao();
        }

        private void SetButton()
        {
            btnTachGop.BackColor = Color.Gray;
            btnThem.BackColor = Color.WhiteSmoke;
        }

        public FDangKyHoKhau(string maHoTach)
        {
            KhoiTao();
            openChildForm.Open(new FTachGopHo(maHoTach));
            SetButton();
        }

        private void btnTachGop_Click(object sender, EventArgs e)
        {
            openChildForm.Open(new FTachGopHo());
            SetButton();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            openChildForm.Open(new FThemNguoiVaoHo());
            btnTachGop.BackColor = Color.WhiteSmoke;
            btnThem.BackColor = Color.Gray;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }
    }
}
