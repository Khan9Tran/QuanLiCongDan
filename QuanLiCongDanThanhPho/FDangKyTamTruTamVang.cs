using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FDangKyTamTruTamVang : Form
    {
        private TamTruTamVangDAO tTTVDAO;
        private CongDanDAO cDDAO;

        private void KhoiTao()
        {
            InitializeComponent();
            tTTVDAO = new TamTruTamVangDAO();
            cDDAO = new CongDanDAO();
            StackForm.Add(this);
        }

        public FDangKyTamTruTamVang()
        {
            KhoiTao();
        }

        public FDangKyTamTruTamVang(string cCCD)
        {
            KhoiTao();
            LoadThongTin(cCCD);
        }

        private void LoadThongTin(string cCCD)
        {
            if (cCCD != null)
            {
                CongDan congDan = cDDAO.LayThongTin(cCCD);
                txtTen.Text = congDan.Ten;
                txtCCCD.Text = congDan.CCCD;
                txtMaSo.Text = congDan.CCCD;
                txtSDT.Text = congDan.SDT;
                rdoTamVang.Checked = true;
            }
        }

        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isMaSo(txtMaSo.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra mã số");
                txtMaSo.Focus();
                return false;
            }    
            if (!KiemTraDuLieuNhap.isCCCD(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại CCCD");
                txtCCCD.Focus(); 
                return false;
            }    
            if (!KiemTraDuLieuNhap.isTen(txtTen.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại họ và tên");
                txtTen.Focus();
                return false;
            }
            if (rdoTamTru.Checked == false && rdoTamVang.Checked == false) 
            {
                MessageBox.Show("Vui lòng chọn tạm trú hoặc tạm vắng");
                return false;
            }
            if (txtLiDo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Lí do");
                return false;
            }    
            if (!KiemTraDuLieuNhap.isSoDT(txtSDT.Text))
            {
                txtSDT.Focus();
                MessageBox.Show("Vui lòng SDT đúng định dạng");
                return false;
            }   
            if (!KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text))
            {
                txtDiaChi.Focus();
                MessageBox.Show("Vui lòng kiểm tra lại địa chỉ");
                return false;
            }  
            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                if (rdoTamTru.Checked == true)
                {
                    CongDan cDTamTru = new CongDan(txtCCCD.Text, txtTen.Text, txtSDT.Text);
                    try
                    {
                        cDDAO.ThemCongDan(cDTamTru);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Không thể dùng tùy chọn này");
                        return;
                    }
                }
                TamTruTamVang tTTV = new TamTruTamVang(txtMaSo.Text, txtCCCD.Text, rdoTamTru.Checked.ToString(), dtpNgayBatDau.Value, dtpNgayKetThuc.Value, txtDiaChi.Text, txtLiDo.Text);
                if (tTTVDAO.LayThongTin(tTTV.CCCD) == null)
                    tTTVDAO.ThemTamTruTamVang(tTTV);
                else
                    MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ToolsForControl.ClearTextBox(Controls);
        }
    }
}
