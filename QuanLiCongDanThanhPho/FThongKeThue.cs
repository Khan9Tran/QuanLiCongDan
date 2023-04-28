
namespace QuanLiCongDanThanhPho
{
    public partial class FThongKeThue : Form
    {
        private ThueDAO thueDAO;

        public FThongKeThue()
        {
            InitializeComponent();
            thueDAO = new ThueDAO();
            StackForm.Add(this);
        }

        private string DinhDangTienTe(string s)
        {
            string result = s;
            for (int i = result.Length-3; i > 0; i -= 3)
            {
                result = result.Insert(i, ".");
            }
            return result +" VND";
        }

        private void FThongKeThue_Load(object sender, EventArgs e)
        {
            int[] thues = thueDAO.LayThongKeThue();
            int soNguoiTreHan = thueDAO.LaySoNguoiTreHan();
            lblTongTienThue.Text += " " + DinhDangTienTe(thues[2].ToString());
            lblTongThueCanDong.Text += " " + DinhDangTienTe(thues[1].ToString());
            lblTongThueDaDong.Text += " " + DinhDangTienTe(thues[0].ToString());
            lblTrungBinhThue.Text += " " + DinhDangTienTe(((int)(thues[2] / thues[3])).ToString());
            lblSoNguoiTreHan.Text += " " + soNguoiTreHan.ToString();
        }
    }
}
