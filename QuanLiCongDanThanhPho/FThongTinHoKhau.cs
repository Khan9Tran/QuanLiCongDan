using QuanLiCongDanThanhPho.Models;
using System.Data;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinHoKhau : MoveForm
    {
        private string? maHoKhau;
        private HoKhauDAO hkDAO;
        private CongDanDAO cdDAO;

        private ToolsForControl tool;

        public string? MaHoKhau { get => maHoKhau; set => maHoKhau = value; }

        public FThongTinHoKhau(string maHoKhau)
        {
            MaHoKhau = maHoKhau;
            InitializeComponent();
            StackForm.Add(this);

            hkDAO = new HoKhauDAO();
            cdDAO = new CongDanDAO();

            SetTools();
        }

        public void LayThongTinHoKhau()
        {
            HoKhau hk = hkDAO.LayThongTin(MaHoKhau);
            if (hk.MaHoKhau != null)
            {
                txtCCCDChuHo.Text = hk.CCCDChuHo;
                txtMaHoKhau.Text = hk.MaHoKhau;
                txtDiaChi.Text = hk.DiaChi.toString();

                // Hiện thị thông tin của chủ hộ
                CongDan chuHo = cdDAO.LayThongTin(hk.CCCDChuHo);
                if (chuHo.CCCD  != null)
                    txtTenChuHo.Text = chuHo.Ten.ToString();

                // Hiện thị danh sách những người trong hộ
                DataTable dsNguoiTrongHo = cdDAO.LayDanhSachTheoHoKhau(maHoKhau);
                gvQuanHeVoiChuHo.DataSource = dsNguoiTrongHo;
                lblTong.Text = "Tổng thành viên: " + dsNguoiTrongHo.Rows.Count.ToString();
            }
        }

        private void CapNhatHoKhau()
        {
            HoKhau hoKhau = hkDAO.LayThongTin(maHoKhau);
            if (KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text) && hoKhau.MaHoKhau != null)
            {
                hoKhau.DiaChi.DinhDang(txtDiaChi.Text);
            }
            if (hkDAO.CapNhatHoKhau(hoKhau))
                MessageBox.Show("Cập nhất hộ khẩu thành công");
            else
                MessageBox.Show("Cập nhật hổ khẩu thất bại");
        }

        private void FThongTinHoKhau_Load(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
        }

        private void SetTools()
        {
            List<TextBox> listTxt = new List<TextBox>()
            {txtDiaChi};

            List<Control> listControl = new List<Control>()
            {
                btnXacNhan
            };
            tool = new ToolsForControl(listTxt, listControl, ToolsForControl.Turn.off);
        }

        private void gvQuanHeVoiChuHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string maCCCD = (string)gvQuanHeVoiChuHo.CurrentRow.Cells[0].Value;
                if (maCCCD != "")
                {
                    CongDan cd = cdDAO.LayThongTin(maCCCD);
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
            tool.AutoReadOnly();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CapNhatHoKhau();
            LayThongTinHoKhau();
            tool.TurnOff();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinHoKhau();
            tool.State = ToolsForControl.Turn.on;
            tool.TurnOff();
        }
    }
}
