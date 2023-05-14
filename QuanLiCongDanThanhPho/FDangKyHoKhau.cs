
namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyHoKhau : Form
    {
        private OpenChildForm childForm;

        public OpenChildForm ChildForm { get => childForm; set => childForm = value; }

        //Hàm khởi tạo các thành phần của form 
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

        //Đổi màu các nút để biết đang chọn form tách gộp hộ
        private void SetButton()
        {
            btnTachGop.BackColor = Color.Gray;
            btnThem.BackColor = Color.WhiteSmoke;
        }

        //Mở Form tách gộp hộ, khi form đăng kí được truyền mã hộ tách 
        public FDangKyHoKhau(string maHoTach)
        {
            KhoiTao();
            childForm.Open(new FTachGopHo(maHoTach));
            SetButton();
        }

        //Mở form tách gộp hộ
        private void btnTachGop_Click(object sender, EventArgs e)
        {
            childForm.Open(new FTachGopHo());
            SetButton();
        }

        //Mở form thêm người vào hộ có sẵn
        private void btnThem_Click(object sender, EventArgs e)
        {
            childForm.Open(new FThemNguoiVaoHo());
            btnTachGop.BackColor = Color.WhiteSmoke;
            btnThem.BackColor = Color.Gray;
        }
    }
}
