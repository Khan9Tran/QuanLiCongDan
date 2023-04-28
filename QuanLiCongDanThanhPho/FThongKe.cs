
namespace QuanLiCongDanThanhPho
{
    public partial class FThongKe : Form
    {
        private OpenChildForm childForm;
        public OpenChildForm ChildForm { get => childForm; set => childForm = value; }


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
            childForm = new OpenChildForm(pnlHienThiThongKe);
        }

        private void cmbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLuaChon.SelectedIndex == (int)ThongKe.congDan)
                childForm.Open(new FThongKeCongDan());
            else if (cmbLuaChon.SelectedIndex == (int)ThongKe.phanBoDanCu)
                childForm.Open(new FThongKePhanBo());
            else if (cmbLuaChon.SelectedIndex == (int)ThongKe.thue)
                childForm.Open(new FThongKeThue());
        }
    }
}
