using QuanLiCongDanThanhPho.Models;
using System.Data;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinHoKhau : FormThongTin
    {
        public FThongTinHoKhau(string maHoKhau)
        {
            MaHoKhau = maHoKhau;
            InitializeComponent();
            SetTools();
        }

        public void LayThongTinHoKhau()
        {
            HoKhau hk = HKDAO.LayThongTin(MaHoKhau);
            if (hk.MaHoKhau != null)
            {
                txtCCCDChuHo.Text = hk.CCCDChuHo;
                txtMaHoKhau.Text = hk.MaHoKhau;
                txtDiaChi.Text = hk.DiaChi.toString();

                // Hiện thị thông tin của chủ hộ
                CongDan chuHo = CDDAO.LayThongTin(hk.CCCDChuHo);
                if (chuHo.CCCD != null)
                    txtTenChuHo.Text = chuHo.Ten.ToString();

                // Hiện thị danh sách những người trong hộ
                DataTable dsNguoiTrongHo = CDDAO.LayDanhSachTheoHoKhau(MaHoKhau);
                gvQuanHeVoiChuHo.DataSource = dsNguoiTrongHo;
                lblTong.Text = "Tổng thành viên: " + dsNguoiTrongHo.Rows.Count.ToString();
            }
        }

        private void CapNhatHoKhau()
        {
            HoKhau hoKhau = HKDAO.LayThongTin(MaHoKhau);
            if (KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text) && hoKhau.MaHoKhau != null)
            {
                hoKhau.DiaChi.DinhDang(txtDiaChi.Text);
            }
            if (HKDAO.CapNhatHoKhau(hoKhau))
                MessageBox.Show("Cập nhất hộ khẩu thành công");
            else
                MessageBox.Show("Cập nhật hổ khẩu thất bại");
        }

        private void FThongTinHoKhau_Load(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
        }

        internal override void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            {txtDiaChi};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan
            };
            Tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private void gvQuanHeVoiChuHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var maCCCD = gvQuanHeVoiChuHo.CurrentRow.Cells[0].Value;
                if (maCCCD.ToString() != "")
                {
                    CongDan cd = CDDAO.LayThongTin((string)maCCCD);
                    if (cd.CCCD != null)
                    {
                        FThongTinCongDan ttCD = new FThongTinCongDan(cd);
                        ttCD.ShowDialog();
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Tool.AutoReadOnly();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHoKhau();
            LayThongTinHoKhau();
            Tool.TurnOff();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
            Tool.State = ToolsForControl.Turn.on;
            Tool.TurnOff();
        }
    }
}
