
namespace QuanLiCongDanThanhPho
{
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            StackForm.ClearAll();
            StackForm.TrangChu?.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StackForm.Back();
        }
    }
}
