using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinThue : FormThongTin
    {
        public FThongTinThue(string maCCCD)
        {
            MaCCCD = maCCCD;
            InitializeComponent();
            SetTools();
        }

        internal override void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            {txtSoTienCanNop, txtSoTienDaNop};

            List<Control> listControl = new List<Control>()
            {
                dtmHanNopThue, dtmNgayCapMaSoThue, btnXacNhan
            };
            Tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private void LayThongTinThue()
        {
            if (MaCCCD != null)
            {
                Thue thue = ThueDAO.LayThongTin(MaCCCD);
                CongDan cd = CDDAO.LayThongTin(MaCCCD);
                HoKhau hk = HKDAO.LayThongTin(cd.MaHoKhau);
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
            Thue thue = ThueDAO.LayThongTin(MaCCCD);
            if (txtMaSoThue.Text != "" && thue.MaThue != null && KiemTraDuLieuNhap.isTien(txtSoTienDaNop.Text) && KiemTraDuLieuNhap.isTien(txtSoTienCanNop.Text))
            {
                thue.CCCD = txtCCCD.Text;
                thue.SoTienCanNop = txtSoTienCanNop.Text;
                thue.SoTienDaNop = txtSoTienDaNop.Text;
                thue.NgayCapMa = dtmNgayCapMaSoThue.Value;
                thue.HanNop = dtmHanNopThue.Value;
                if (KiemTraDuLieuNhap.KiemTraThue(thue) && ThueDAO.CapNhatThue(thue))
                    MessageBox.Show("Cập nhật thuế thành công");
                else
                    MessageBox.Show("Cập nhật thuế thất bại");
            }
            else
            {
                MessageBox.Show("Thông tin nhập sai");
            }
        }    

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatThue();
            LayThongTinThue();
            Tool.TurnOff();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Tool.AutoReadOnly();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinThue();
            Tool.TurnOff();
        }
    }
}
