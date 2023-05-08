
namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyHoKhau : Form
    {
        private OpenChildForm childForm;

        public OpenChildForm ChildForm { get => childForm; set => childForm = value; }

        private void KhoiTao()
        {
            InitializeComponent();
            childForm = new OpenChildForm(pnlLuaChon);
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
            childForm.Open(new FTachGopHo(maHoTach));
            SetButton();
        }

        private void btnTachGop_Click(object sender, EventArgs e)
        {
            childForm.Open(new FTachGopHo());
            SetButton();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            childForm.Open(new FThemNguoiVaoHo());
            btnTachGop.BackColor = Color.WhiteSmoke;
            btnThem.BackColor = Color.Gray;
        }
    }
}
