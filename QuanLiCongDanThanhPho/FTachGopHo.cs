using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FTachGopHo : Form
    {
        private CongDanDAO cDDAO;
        private HoKhauDAO hKDAO;
        private bool isTach = false;
        private CongDan cD;

        private void KhoiTao()
        {
            InitializeComponent();
            cDDAO = new CongDanDAO();
            hKDAO = new HoKhauDAO();
            cD = new CongDan();
            StackForm.Add(this);
        }

        public FTachGopHo()
        {
            KhoiTao();
        }

        public FTachGopHo(string maHoTach)
        {
            KhoiTao();
            txtMaHoTach.Text = maHoTach;
            LoadHoTach();
        }

        private void btnTach_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            try 
            { 

                int index = gvHoTach.CurrentCell.RowIndex;
                    if (index >= 0)
                    {
                        cD.CCCD = gvHoTach.Rows[index].Cells[0].Value.ToString();
                        isTach = true;
                    }
            }
            catch 
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
        } 

        private bool KiemTraThongTin()
        {
            if (txtMaHoTach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hộ cần tách");
                txtMaHoTach.Focus();
                return false;
            }
            if (txtMaHoGop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hộ mới hoặc hộ muốn gộp vào");
                txtMaHoGop.Focus();
                return false;
            }
            return true;
        }

        private void TaoHoMoi()
        {
            //Kiểm tra 
            HoKhau hK = new HoKhau(txtMaHoGop.Text, "unknow, unknow, unknow,uknow", cD.CCCD);
            hKDAO.ThemHoKhau(hK);
            cD.QuanHeVoiChuHo = "Chủ hộ";
            cD.MaHoKhau = txtMaHoGop.Text;
            cDDAO.ThayDoiHoKhau(cD);
            LoadHoTach();
            LoadHoGop();
            XoaHoThua();
        }

        private bool isHoKhau(string maHoKhau)
        {
            HoKhau hk = hKDAO.LayThongTin(maHoKhau);
            if (hk.MaHoKhau == null)
                return false;
            return true;
        }

        private void btnTaoHoMoi_Click(object sender, EventArgs e)
        { 
            if (KiemTraThongTin() && isTach == true)
            {
                    //Kiểm tra 
                if (isHoKhau(txtMaHoGop.Text))
                {
                    MessageBox.Show("Hộ đã tồn tại");
                }
                else if (cD.MaHoKhau == txtMaHoGop.Text)
                {
                    MessageBox.Show("Đây là một hộ duy nhất!");
                }
                else
                {
                    TaoHoMoi();
                }
                isTach = false;
            }
        }

        //Thực hiện xóa hộ nếu không còn thành viên
        private void XoaHoThua()
        {
            HoKhau hK = new HoKhau(txtMaHoTach.Text, "unknow, unknow, unknow,uknow", cD.CCCD);
            if (gvHoTach.Rows.Count <=1)
            {
                hKDAO.XoaHoKhau(hK);
            }
        }

        public void ThemVaoHo()
        {
            cD.MaHoKhau = txtMaHoGop.Text;
            cDDAO.NhapHoKhau(cD);   
            LoadHoTach();
            LoadHoGop();
            XoaHoThua();
        }

        private void btnGopHo_Click(object sender, EventArgs e)
        {   
            if (KiemTraThongTin() && isTach == true)
            {
                if (isHoKhau(txtMaHoGop.Text))
                {
                    MessageBox.Show("Hộ không tồn tại");
                }
                else if (cD.MaHoKhau == txtMaHoGop.Text)
                {
                    MessageBox.Show("Đây là một hộ duy nhất!");
                }
                else
                {
                    ThemVaoHo();
                }
                isTach = false;
            }
        }

        private void LoadHoTach()
        {
             gvHoTach.DataSource = cDDAO.LayDanhSachTheoHoKhau(txtMaHoTach.Text);
        }

        private void LoadHoGop()
        {
            gvHoGop.DataSource = cDDAO.LayDanhSachTheoHoKhau(txtMaHoGop.Text);
        }

        private void btnMaHoTach_Click(object sender, EventArgs e)
        {
            if (txtMaHoTach.Text != "")
                LoadHoTach();
        }

        private void btnMaHoGop_Click(object sender, EventArgs e)
        {
            if (txtMaHoGop.Text != "")
            LoadHoGop();
        }

        private void Reset()
        {
            txtMaHoGop.Text = "";
            txtMaHoTach.Text = "";
            isTach = false;
            LoadHoTach();
            LoadHoGop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
