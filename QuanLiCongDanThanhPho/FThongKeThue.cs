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
    public partial class FThongKeThue : Form
    {
        ThueDAO thueDAO = new ThueDAO();
        public FThongKeThue()
        {
            InitializeComponent();
            StackForm.Add(this);
        }

        private void FThongKeThue_Load(object sender, EventArgs e)
        {
            double[] thues = thueDAO.LayTongTienTatCa();
            lblTongTienThue.Text += " " + thues[2].ToString();
            lblTongThueCanDong.Text += " " + thues[1].ToString();
            lblTongThueDaDong.Text += " " + thues[0].ToString();
           
        }
    }
}
