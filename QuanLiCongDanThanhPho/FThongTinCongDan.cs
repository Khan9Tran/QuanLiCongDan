using QuanLiCongDanThanhPho.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongTinCongDan : Form
    {
        private string maCCCD;
        CongDanDAO cdDAO = new CongDanDAO();
        KhaiSinhDAO ksDAO = new KhaiSinhDAO();
        ThueDAO thueDAO = new ThueDAO();
        HonNhanDAO hnDAO = new HonNhanDAO();
        HoKhauDAO hkDAO = new HoKhauDAO();
        TamTruTamVangDAO tttvDAO = new TamTruTamVangDAO();
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        
        public string MaCCCD
        {
            set { maCCCD = value; }
            get { return maCCCD; }
        }
 
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        public FThongTinCongDan()
        {
            InitializeComponent();
        }

        public FThongTinCongDan(string maCCCD)
        {
            MaCCCD = maCCCD;
            InitializeComponent();
            StackForm.Add(this);
        }

        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            FThongTinKhaiSinh tTKS = new FThongTinKhaiSinh(MaCCCD);
            tTKS.ShowDialog();
        }
        private void ReadOnly()
        {
            txtNgheNghiep.ReadOnly = true;
            txtNgheNghiep.BackColor = Color.Gainsboro;
            txtHoVaTen.ReadOnly = true;
            txtHoVaTen.BackColor = Color.Gainsboro;
            txtSDT.ReadOnly= true;
            txtSDT.BackColor = Color.Gainsboro;
            txtTonGiao.ReadOnly= true;
            txtTonGiao.BackColor = Color.Gainsboro;
            btnXacNhan.Enabled = false;
            txtDanToc.ReadOnly = true;
            txtDanToc.BackColor= Color.Gainsboro;
            txtQueQuan.ReadOnly = true;
            txtQueQuan.BackColor = Color.Gainsboro;
            txtQuocTich.ReadOnly = true;
            txtQuocTich.BackColor = Color.Gainsboro;
            txtDiaChi.ReadOnly = true;
            txtDiaChi.BackColor = Color.Gainsboro;
            txtGioiTinh.ReadOnly = true;
            txtGioiTinh.BackColor = Color.Gainsboro;
            txtGhiChu.ReadOnly = true;
            txtGhiChu.BackColor = Color.Gainsboro;
            dtmNgaySinh.Enabled = false;
        }
        private void UnReadOnLy()
        {
            txtNgheNghiep.ReadOnly = false;
            txtNgheNghiep.BackColor = Color.SteelBlue;
            txtHoVaTen.ReadOnly = false;
            txtHoVaTen.BackColor= Color.SteelBlue;  
            txtSDT.ReadOnly = false;
            txtSDT.BackColor= Color.SteelBlue;
            txtTonGiao.ReadOnly = false;
            txtTonGiao.BackColor= Color.SteelBlue;
            btnXacNhan.Enabled = true;
            txtDanToc.ReadOnly = false;
            txtDanToc.BackColor = Color.SteelBlue;
            txtQueQuan.ReadOnly = false;
            txtQueQuan.BackColor = Color.SteelBlue;
            txtQuocTich.ReadOnly= false;
            txtQuocTich.BackColor = Color.SteelBlue;
            txtDiaChi.ReadOnly = false;
            txtDiaChi.BackColor = Color.SteelBlue;
            txtGioiTinh.ReadOnly = false;
            txtGioiTinh.BackColor = Color.SteelBlue;
            txtGhiChu.ReadOnly = false;
            dtmNgaySinh.Enabled = true;
        }
        private void AutoReadOnly()
        {
            if (txtHoVaTen.ReadOnly == true)
            {
                UnReadOnLy();
            }
            else
            {
                ReadOnly();
            }
        }
        public void LayThongTinCongDan()
        {
            if (maCCCD != null)
            {
                CongDan cd = cdDAO.LayThongTin(MaCCCD);
                txtCCCD.Text = cd.CCCD;
                txtHoVaTen.Text = cd.Ten;
                txtMaHoKhau.Text = cd.MaHoKhau;
                txtSDT.Text = cd.SDT;
                txtTonGiao.Text = cd.TonGiao;
                txtNgheNghiep.Text = cd.NgheNghiep;
                //----------------//
                KhaiSinh ks = ksDAO.LayThongTin(MaCCCD);
                dtmNgaySinh.Value = ks.NgaySinh;
                if (ks.GioiTinh == "f")
                    txtGioiTinh.Text = "Nữ";
                else
                    txtGioiTinh.Text = "Nam";
                txtDanToc.Text = ks.DanToc;
                txtQuocTich.Text = ks.QuocTich;
                txtQueQuan.Text = ks.QueQuan.toString();
                //-----------------//
                Thue thue = thueDAO.LayThongTin(MaCCCD);
                txtMaThue.Text = thue.MaThue.ToString();
                //------------------//
                HonNhan hn = new HonNhan();
                hn = hnDAO.LayThongTin(MaCCCD);
                if (!hnDAO.KiemTraHonNhan(MaCCCD))
                    txtHonNhan.Text = "Chưa có hôn nhân";
                else
                    txtHonNhan.Text = hn.MaSo;
                //---------------------//
                HoKhau hk = new HoKhau();
                hk = hkDAO.LayThongTin(cd.MaHoKhau);
                txtDiaChi.Text = hk.DiaChi.toString();
                //---------------------//
                TamTruTamVang tttv = new TamTruTamVang();
                if (!tttvDAO.KiemTraTamTruTamVang(MaCCCD))
                    txtGhiChu.Text = "Không có ghi chú";
                else
                {
                    tttv = tttvDAO.LayThongTin(MaCCCD);
                    txtGhiChu.Text = tttv.TrangThai;
                }
            }
        }
        private void FThongTinCongDan_Load(object sender, EventArgs e)
        {
                LayThongTinCongDan();
        }

        private void FThongTinCongDan_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pnlThongTinCD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            CongDan cd = cdDAO.LayThongTin(maCCCD);
            FThongTinHoKhau tTHK = new FThongTinHoKhau(cd.MaHoKhau);
            tTHK.ShowDialog();
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            FThongTinThue tTThue = new FThongTinThue(MaCCCD);
            tTThue.ShowDialog();
        }
        private bool KiemTraThongTin()
        {
            if (!KiemTraDuLieuNhap.isTen(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại họ và tên");
                txtHoVaTen.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isGioiTinh(txtGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại giới tính");
                txtGioiTinh.Focus();
                return false;
            }
            if (txtNgheNghiep.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại nghề nghiệp");
                txtNgheNghiep.Focus();
                return false;
            }
            if (txtQuocTich.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại quốc tịch");
                txtQuocTich.Focus();
                return false;
            }
            if (txtDanToc.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại dân tộc");
                txtDanToc.Focus();
                return false;
            }
            if (txtTonGiao.Text == "")
            {
                MessageBox.Show("Tôn giáo không được để trống");
                txtTonGiao.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại địa chỉ");
                txtDiaChi.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isDiaChi(txtQueQuan.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại quê quán");
                txtQueQuan.Focus();
                return false;
            }
            if (!KiemTraDuLieuNhap.isSoDT(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại số điện thoại");
                txtSDT.Focus();
                return false;
            }      
            return true;
        }
        private void btnHonNhan_Click(object sender, EventArgs e)
        {
            FThongTinHonNhan tTHN = new FThongTinHonNhan(MaCCCD);
            tTHN.ShowDialog();
        }
        private void CapNhatKhaiSinh()
        {
            KhaiSinh khaiSinh = ksDAO.LayThongTin(MaCCCD);
            khaiSinh.HoTen = txtHoVaTen.Text;
            khaiSinh.QueQuan.DinhDang(txtQueQuan.Text);
            khaiSinh.NgaySinh = dtmNgaySinh.Value;
            khaiSinh.DanToc = txtDanToc.Text;
            khaiSinh.QuocTich = txtQuocTich.Text;
            khaiSinh.GioiTinh = txtGioiTinh.Text;
            khaiSinh.DinhDangGioiTinh();
            ksDAO.CapNhatKhaiSinh(khaiSinh);  
        }    
        private void CapNhatCongDan()
        {
            CongDan cd = cdDAO.LayThongTin(MaCCCD);
            cd.Ten = txtHoVaTen.Text;
            cd.SDT = txtSDT.Text;
            cd.NgheNghiep = txtNgheNghiep.Text;
            cd.TonGiao = txtTonGiao.Text;
            cdDAO.CapNhatCongDan(cd);

        }
        private void btnSua_Click(object sender, EventArgs e)
        {  
            AutoReadOnly();
        }
        private void CapNhatHonNhan()
        {
            if (txtHonNhan.Text != "Chưa có hôn nhân" && txtHonNhan.Text != "")
            {
                HonNhan hn = hnDAO.LayThongTin(MaCCCD);
                if (txtCCCD.Text == hn.CCCDChong)
                    hn.TenChong = txtHoVaTen.Text;  
                else
                    hn.TenVo = txtHoVaTen.Text;
                hnDAO.CapNhatHonNhan(hn);
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {  
            if (KiemTraThongTin())
            {
                CapNhatCongDan();
                CapNhatKhaiSinh();
                CapNhatHonNhan();
                LayThongTinCongDan();
                ReadOnly();
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LayThongTinCongDan();
            ReadOnly();
        }

    }
}
