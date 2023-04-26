
namespace QuanLiCongDanThanhPho
{
    public partial class SideBarWhite : UserControl
    {
        public SideBarWhite()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StackForm.Back();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            StackForm.ClearAll();
            StackForm.fTrangChu.BringToFront();
        }
    }
}
