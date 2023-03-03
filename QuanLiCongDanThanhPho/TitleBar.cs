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
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();
            DinhDang();
        }
        private void DinhDang()
        {
            btnClose.FlatStyle = FlatStyle.Flat;
            btnMinimize.FlatStyle = FlatStyle.Flat;

            btnClose.BackColor = Color.Transparent;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnClose.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnMinimize.FlatAppearance.MouseDownBackColor= Color.Transparent;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.BorderSize = 0;

            btnClose.Image = Image.FromFile(@".\Icons\White\24\Cross.png");
            btnMinimize.Image = Image.FromFile(@".\Icons\White\24\minus.png");
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ParentForm.ToString() == "FTrangChu")
                Application.Exit();
            else
                ParentForm.Close();
        }
    }
}
