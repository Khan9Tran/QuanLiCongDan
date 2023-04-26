
namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyHoKhau : Form
    {
        private Form currentChildForm;

        public FDangKyHoKhau()
        {
            InitializeComponent();
            StackForm.Add(this);
        }

        private void SetButton()
        {
            btnTachGop.BackColor = Color.Gray;
            btnThem.BackColor = Color.WhiteSmoke;
        }

        public FDangKyHoKhau(string maHoTach)
        {
            InitializeComponent();
            StackForm.Add(this);
            OpenChildForm(new FTachGopHo(maHoTach));
            SetButton();
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlLuaChon.Controls.Add(childForm);
            pnlLuaChon.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnTachGop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTachGopHo());
            SetButton();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThemNguoiVaoHo());
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
