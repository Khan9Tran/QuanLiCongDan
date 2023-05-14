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

        //Hàm tạo các thành phần cơ bản của form
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

        //Load thông tin của hộ tách nếu được truyền Mã hộ khẩu của hộ tách
        public FTachGopHo(string maHoTach)
        {
            KhoiTao();
            txtMaHoTach.Text = maHoTach;
            LoadHoTach();
        }

        //Chọn công dân để tách ra khỏi hộ
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

        //Tạo hộ khẩu mới nếu mã hộ gộp không tồn tại
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

        //Thêm người được chọn tách từ hộ tách vào hộ mới
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

        //Hiện thị danh sách thành viên trong hộ tách
        private void btnMaHoTach_Click(object sender, EventArgs e)
        {
            if (txtMaHoTach.Text != "")
                LoadHoTach();
        }

        //Hiện thị danh sách thành viên trong hộ gọp
        private void btnMaHoGop_Click(object sender, EventArgs e)
        {
            if (txtMaHoGop.Text != "")
            LoadHoGop();
        }

        //Clear các TextBox
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
