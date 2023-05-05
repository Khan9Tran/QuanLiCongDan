
namespace QuanLiCongDanThanhPho
{
    public partial class TitleBarWhite : UserControl
    {
        public TitleBarWhite()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            StackForm.RemoveForm();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            FindForm().WindowState = FormWindowState.Minimized;
        }
    }
}
