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
            if (KiemTraThongTin())
            { 
                if (cDDAO.LayThongTin(txtCCCD.Text).Ten == txtTen.Text)
                {
                    CCCD cCCD = new CCCD(txtCCCD.Text, dtmNgayCap.Value, txtDDNhanDang.Text);
                    if (cCCDDAO.CapNhatCCCD(cCCD))
                        MessageBox.Show("Cấp căn cước thành công");
                    else
                        MessageBox.Show("Cấp căn cước thất bại");
                }
                else
                {
                    MessageBox.Show("CCCD và Họ tên không khớp");
                }    
                
            }
            LoadDanhSach();
            
        }
        private void LoadDanhSach()
        {
            gvDanhSachChuaCapCCCD.DataSource = cCCDDAO.DanhSachCCCDTheoDacDiem("Unknow");
            Reset();
        }    
        private void gvDanhSachChuaCapCCCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtCCCD.Text = gvDanhSachChuaCapCCCD.Rows[dong].Cells["maCCCD"].Value.ToString();
                txtTen.Text = gvDanhSachChuaCapCCCD.Rows[dong].Cells["Ten"].Value.ToString();
            }
            txtDDNhanDang.Text = "";
            dtmNgayCap.Value = DateTime.Now;
        }
    }
}
