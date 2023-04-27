
namespace QuanLiCongDanThanhPho
{
    public partial class FThongKe : Form
    {
        public OpenChildForm openChildForm;

        enum ThongKe
        {
            congDan,
            thue,
            phanBoDanCu,
        }

        public FThongKe()
        {
            InitializeComponent();
            StackForm.Add(this);
            openChildForm = new OpenChildForm(pnlHienThiThongKe);
        }

        private void cmbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLuaChon.SelectedIndex == (int)ThongKe.congDan)
                openChildForm.Open(new FThongKeCongDan());
            else if (cmbLuaChon.SelectedIndex == (int)ThongKe.phanBoDanCu)
                openChildForm.Open(new FThongKePhanBo());
            else if (cmbLuaChon.SelectedIndex == (int)ThongKe.thue)
                openChildForm.Open(new FThongKeThue());
        }
    }
}
