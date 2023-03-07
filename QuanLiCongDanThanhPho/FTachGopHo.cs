using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCongDanThanhPho.Models;
namespace QuanLiCongDanThanhPho
{
    public partial class FTachGopHo : Form
    {
        private CongDanDAO cDDAO;
        public FTachGopHo()
        {
            InitializeComponent();
            cDDAO = new CongDanDAO();
        }

        private bool isTach = false;
        private CongDan cD;
        private void btnTach_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            try 
            { 

                int index = gvHoTach.CurrentCell.RowIndex;
                if (index >= 0)
                {
                    cD = new CongDan();
                    cD.CCCD = gvHoTach.Rows[index].Cells[0].Value.ToString();
                }
                isTach = true;
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
        private void btnTaoHoMoi_Click(object sender, EventArgs e)
        { 
            if (KiemTraThongTin())
                if (isTach == true)
                {
                    if (gvHoGop.Rows.Count != 1)
                    {
                        MessageBox.Show("Hộ đã tồn tại");
                    }
                    else if (cD.MaHoKhau == txtMaHoGop.Text)
                    {
                        MessageBox.Show("Đây là một hộ duy nhất!");
                    }
                    else
                    {
                        HoKhauDAO hKDAO = new HoKhauDAO();
                        HoKhau hK = new HoKhau(txtMaHoGop.Text, "u,u,u,u", cD.CCCD);
                        hKDAO.ThemHoKhau(hK);
                        cDDAO.NhapHoKhau(cD);
                        ThemVaoHo();
                    }
                    isTach = false;
                }
        }
        public void ThemVaoHo()
        {
            cD.MaHoKhau = txtMaHoGop.Text;
            cDDAO.NhapHoKhau(cD);
            LoadHoTach();
            LoadHoGop();
        }
        private void btnGopHo_Click(object sender, EventArgs e)
        {   
            if (KiemTraThongTin())
                if (isTach == true)
                {
                    if (gvHoGop.Rows.Count <= 1)
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
            LoadHoTach();
        }

        private void btnMaHoGop_Click(object sender, EventArgs e)
        {
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
