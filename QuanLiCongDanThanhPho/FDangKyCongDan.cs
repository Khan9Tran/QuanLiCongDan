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
    public partial class FDangKyCongDan : Form
    {
        CongDanDAO cdDao = new CongDanDAO();
        public FDangKyCongDan()
        {
            InitializeComponent();
        }
        public void ThemCongDan()
        {
            KhaiSinh kS = new KhaiSinh();
            CongDan cD = new CongDan();
            TamTruTamVang tTTV = new TamTruTamVang();
            HonNhan hN = new HonNhan();

        }
    }
}
