using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinThue : MoveForm
    {
        private string maCCCD;
        private ThueDAO thueDAO;
        private CongDanDAO cdDAO;
        private HoKhauDAO hkDAO;

        private ToolsForControl tool;

        public string MaCCCD
        {
            set { maCCCD = value; }
            get { return maCCCD; }
        }

        public FThongTinThue(string maCCCD)
        {
            MaCCCD = maCCCD;
            InitializeComponent();
            StackForm.Add(this);

            thueDAO = new ThueDAO();
            cdDAO = new CongDanDAO();
            hkDAO = new HoKhauDAO();

            SetTools();
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isTien(txtSoTienCanNop.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại số tiền cần nộp");
                txtSoTienCanNop.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isTien(txtSoTienDaNop.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại số tiền đã nộp");
                txtSoTienDaNop.Focus();
                return false;
            }   
            return true;
        }

        private void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            {txtSoTienCanNop, txtSoTienDaNop};

            List<Control> listControl = new List<Control>()
            {
                dtmHanNopThue, dtmNgayCapMaSoThue, btnXacNhan
            };
            tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private void LayThongTinThue()
        {
            if (MaCCCD != null)
            {
                Thue thue = thueDAO.LayThongTin(MaCCCD);
                CongDan cd = cdDAO.LayThongTin(MaCCCD);
                HoKhau hk = hkDAO.LayThongTin(cd.MaHoKhau);
                txtMaSoThue.Text = thue.MaThue;
                txtTen.Text = cd.Ten;
                txtCCCD.Text = cd.CCCD;
                txtSdt.Text = cd.SDT;
                txtDiaChi.Text = hk.DiaChi.toString();
                txtSoTienCanNop.Text = thue.SoTienCanNop;
                txtSoTienDaNop.Text = thue.SoTienDaNop;
                dtmNgayCapMaSoThue.Value = thue.NgayCapMa;
                dtmHanNopThue.Value = thue.HanNop;
            }
        }

        private void FThongTinThue_Load(object sender, EventArgs e)
        {
            LayThongTinThue();
        }

        private void CapNhatThue()
        {
            Thue thue = thueDAO.LayThongTin(MaCCCD);
            if (txtMaSoThue.Text != "")
            {
                thue.CCCD = txtCCCD.Text;
                thue.SoTienCanNop = txtSoTienCanNop.Text;
                thue.SoTienDaNop = txtSoTienDaNop.Text;
                thue.NgayCapMa = dtmNgayCapMaSoThue.Value;
                thue.HanNop = dtmHanNopThue.Value;
            }
            thueDAO.CapNhatThue(thue);
        }    

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                CapNhatThue();
                LayThongTinThue();
                tool.TurnOff();
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tool.AutoReadOnly();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinThue();
            tool.TurnOff();
        }
    }
}
