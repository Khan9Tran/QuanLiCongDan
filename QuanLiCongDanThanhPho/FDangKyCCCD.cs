using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyCCCD : Form
    {
        private CCCDDAO cCCDDAO;
        private CongDanDAO cDDAO;

        public FDangKyCCCD()
        {
            InitializeComponent();
            cCCDDAO = new CCCDDAO();
            cDDAO = new CongDanDAO();
            StackForm.Add(this);
        }
        
        private void FDangKyCCCD_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
       private bool KiemTraThongTin()
       {
            if (txtCCCD.Text == "")
            {
                MessageBox.Show("CCCD không hợp lệ");
                return false;
            }
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text))
            {
                MessageBox.Show("Họ và tên không hợp lệ");
                return false;
            }
            if (txtDDNhanDang.Text== "")
            {
                MessageBox.Show("Đặc điểm nhận dạng không được để trống");
                return false;
            }
            return true;

       }
        private void Reset()
        {
            txtCCCD.Text = "";
            txtDDNhanDang.Text = "";
            txtTen.Text = "";
            dtmNgayCap.Value = DateTime.Now;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            CongDan cD = cDDAO.LayThongTin(txtCCCD.Text);
            CCCD cCCD = cCCDDAO.LayThongTin(txtCCCD.Text);
            if (cD.CCCD != null && cD.Ten == txtTen.Text && KiemTraDuLieuNhap.KiemTraTenVaCCCD(cD) && KiemTraDuLieuNhap.isEmpty(txtDDNhanDang) == false && cCCD.MaCCCD != null)
            {
                cCCD.NgayCap = dtmNgayCap.Value;
                cCCD.DacDiem = txtDDNhanDang.Text;
                if (cCCDDAO.CapNhatCCCD(cCCD))
                    MessageBox.Show("Cấp căn cước thành công");
                else
                    MessageBox.Show("Cấp căn cước thất bại");
            }
            else
            {
                MessageBox.Show("CCCD và họ tên không khớp");
            }
            LoadDanhSach();
            
        }
        private void LoadDanhSach()
        {
            gvDanhSachChuaCapCCCD.DataSource = cCCDDAO.DanhSachCCCDTheoDacDiem("unknow");
            Reset();
        }    
        private void gvDanhSachChuaCapCCCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtCCCD.Text = gvDanhSachChuaCapCCCD.Rows[dong].Cells["CCCD"].Value.ToString();
                txtTen.Text = gvDanhSachChuaCapCCCD.Rows[dong].Cells["Tên"].Value.ToString();
            }
            txtDDNhanDang.Text = "";
            dtmNgayCap.Value = DateTime.Now;
        }
    }
}
