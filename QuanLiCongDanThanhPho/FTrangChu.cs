using QuanLiCongDanThanhPho.Models;

namespace QuanLiCongDanThanhPho
{
    public partial class FTrangChu : MoveForm
    {
        private OpenChildForm childForm;
        private Account account;
        private AccountDAO accountDAO;
        private FDangNhap fDangNhap;
        private HinhDaiDien hinhAdmin;

        public Account Account { get => account; set => account = value; }
        public OpenChildForm ChildForm { get => childForm; set => childForm = value; }

        public FTrangChu(Account acc, FDangNhap fDangNhap)
        {
            InitializeComponent();

            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(pnlHienThiForm);

            StackForm.TrangChu = this;
            
            childForm = new OpenChildForm(pnlHienThiForm);
            accountDAO = new AccountDAO();
            account = accountDAO.LayThongTinTaiKhoan(acc);

            this.fDangNhap = fDangNhap;
            hinhAdmin = new HinhDaiDien(HinhDaiDien.Type.admin);

            //Chỉnh độ mượt của thanh menu
            tmrPhongTo.Interval = 1;
            tmrThuNho.Interval = 1;
        }

        public void LoadTaiKhoan()
        {
            account = accountDAO.LayThongTinTaiKhoan(account);
            btnTaiKhoan.Text = "Xin chào: " + account.DisplayName;
            hinhAdmin.LayHinhDaiDien(account.UserName, ptcHinhDaiDien);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            cmnusDangKy.Show(this, this.PointToClient(MousePosition));
            TatMenu(sender, e);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            childForm.Open(new FDanhSach());
            TatMenu(sender, e);

        }

        public void TatMenu(object sender, EventArgs e)
        {
            if (pnlMenu.Width > 80)
                btnMenuShow_Click(sender, e);
        }

        private void cmnusDangKyItemTamTruTamVang_Click(object sender, EventArgs e)
        {
            childForm.Open(new FDangKyTamTruTamVang());
            TatMenu(sender, e);
        }

        private void cmnusitemDangKyHonNhan_Click(object sender, EventArgs e)
        {
            childForm.Open(new FDangKyHonNhan());
            TatMenu(sender, e);
        }

        private void cmnusDangKyItemKhaiSinh_Click(object sender, EventArgs e)
        {
            childForm.Open(new FDangKyKhaiSinh());
            TatMenu(sender, e);
        }

        private void cmnusDangKyItemCongDan_Click(object sender, EventArgs e)
        {
            childForm.Open(new FDangKyCongDan());
            TatMenu(sender, e);
        }

        private void FTrangChu_Load(object sender, EventArgs e)
        {
            pnlMenu.BringToFront();
            LoadTaiKhoan();
            tmrNgayHienTai.Start();
            hinhAdmin.LayHinhDaiDien("hinhnen", ptcHinhNen);
        }

        private void btnMenuShow_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width <= 80)
            {
                tmrPhongTo.Start();
                pnlHienThiForm.BackColor = Color.Gainsboro;
            }
            else
            {
                tmrThuNho.Start();
                pnlHienThiForm.BackColor = Color.White;
            }
        }

        //Điều khiển thanh bar
        private void tmrThuNho_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width >= 80)
            {
                pnlMenu.Width -= 35;
                if (pnlMenu.Width <= 80)
                {
                    tmrThuNho.Stop();
                }
            }
        }

        //Điều khiển phóng to thanh bar
        private void tmrPhongTo_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width < 290)
            {
                pnlMenu.Width += 35;
                if (pnlMenu.Width >= 290)
                {
                    tmrPhongTo.Stop();
                }
            }
        }

        private void cmnusDangKyItemHoKhau_Click(object sender, EventArgs e)
        {
            childForm.Open(new FDangKyHoKhau());
            TatMenu(sender, e);
        }

        private void cmnusDangKyItemCCCD_Click(object sender, EventArgs e)
        {
            childForm.Open(new FDangKyCCCD());
            TatMenu(sender, e);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            cmnusTaiKhoan.Show(new Point(1500,142));
        }

        private void TaiKhoanItemDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            fDangNhap.Show();
            StackForm.ClearAll();
        }

        private void cmnusTaiKhoanItemThoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có thật sự muốn thoát", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                StackForm.ClearAll();
                Application.Exit();
            }
        }

        private void cmnusTaiKhoanItemCaNhan_Click(object sender, EventArgs e)
        {
            childForm.Open(new FTaiKhoan(account));
        }
        private void lblThongKe_Click(object sender, EventArgs e)
        {
            childForm.Open(new FThongKe());
            TatMenu(sender, e);
        }

        private void ptcHinhDaiDien_Click(object sender, EventArgs e)
        {
            cmnusTaiKhoan.Show(new Point(1500, 142));
        }

        private void ItemCongDanChuyenDi_Click(object sender, EventArgs e)
        {
            childForm.Open(new FKhaiTu());
            TatMenu(sender, e);
        }


        //Tạo đồng hồ
        private void tmrNgayHienTai_Tick(object sender, EventArgs e)
        {
            lblNgayHienTai.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        //Thay đổi hình nền
        private void btnHinhNen_Click(object sender, EventArgs e)
        {
            hinhAdmin.ThemHinhDaiDien(ofdHinhNen, ptcHinhNen);
            hinhAdmin.SaveHinhDaiDien("hinhnen", ofdHinhNen, ptcHinhNen);
        }

        private void cmnusDangKyItemTaiKhoanCongDan_Click(object sender, EventArgs e)
        {
            childForm.Open(new FDangKyTaiKhoan());
        }
    }
}
