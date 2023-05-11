using QuanLiCongDanThanhPho.Models;
using System.Windows.Forms.VisualStyles;

namespace QuanLiCongDanThanhPho
{
    public partial class FTachGopHo : Form
    {
        private CongDanDAO cDDAO;
        private HoKhauDAO hKDAO;
        private bool isTach = false;
        private string cCCD;

        private void KhoiTao()
        {
            InitializeComponent();
            cDDAO = new CongDanDAO();
            hKDAO = new HoKhauDAO();
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
            try
            {
                int index = gvHoTach.CurrentCell.RowIndex;
                if (index >= 0 && gvHoTach.Rows[index].Cells[0] != null)
                {
                    string temp = (string)gvHoTach.Rows[index].Cells[0].Value;
                    if (KiemTraDuLieuNhap.isCCCD(temp))
                    {
                        cCCD = temp;
                        isTach = true;
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Không tồn tại hộ này");
            }

        }

        private bool TaoHoMoi()
        {
            //Kiểm tra 
            HoKhau hK = new HoKhau(txtMaHoGop.Text, "unknow, unknow, unknow,uknow", cCCD);
            if (hKDAO.ThemHoKhau(hK))
            {
                CongDan cD = cDDAO.LayThongTin(cCCD);
                cD.QuanHeVoiChuHo = "Chủ hộ";
                cD.MaHoKhau = txtMaHoGop.Text;

                cDDAO.ThayDoiHoKhau(cD); 

                LoadHoTach();
                LoadHoGop();
                XoaHoThua();
                return true;
            }
            return false;
        }

        private void btnTaoHoMoi_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap.KiemTraHaiHo(txtMaHoGop.Text, txtMaHoTach.Text) && isTach == true && TaoHoMoi())
            {
                MessageBox.Show("Tạo hộ mới thành công");
            }
            else
            {
                MessageBox.Show("Tạo hộ mới thất bại");

            }
            isTach = false;
        }

        //Thực hiện xóa hộ nếu không còn thành viên
        private void XoaHoThua()
        {
            HoKhau hK = new HoKhau(txtMaHoTach.Text, "unknow, unknow, unknow,uknow", cCCD);
            if (hK.MaHoKhau != null && gvHoTach.Rows.Count <=1)
            {
                if (hKDAO.XoaHoKhau(hK))
                    MessageBox.Show("Xóa hộ thừa thành công");
            }
        }

        public bool ThemVaoHo()
        {
            CongDan cD = cDDAO.LayThongTin(cCCD);
            cD.MaHoKhau = txtMaHoGop.Text;
            if (hKDAO.LayThongTin(txtMaHoGop.Text).MaHoKhau == null)
                return false;
            if (!cDDAO.NhapHoKhau(cD))
                return false;
            LoadHoTach();
            LoadHoGop();
            XoaHoThua();
            return true;
        }

        private void btnGopHo_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap.KiemTraHaiHo(txtMaHoGop.Text, txtMaHoTach.Text) && isTach == true && ThemVaoHo())
            {

                MessageBox.Show("Gộp hộ thành công");
            }
            else
            {
                MessageBox.Show("Gộp thất bại");
            }
            isTach = false;
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
