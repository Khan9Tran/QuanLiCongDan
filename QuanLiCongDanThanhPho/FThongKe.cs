﻿using System;
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
    public partial class FThongKe : Form
    {
        KhaiSinhDAO ksDAO = new KhaiSinhDAO();
        public Form currentChildForm;

        public FThongKe()
        {
            InitializeComponent();
        }
        private void cmbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLuaChon.SelectedItem == "Công dân")
                OpenChildForm(new FThongKeCongDan());
            else if (cmbLuaChon.SelectedItem == "Phân bố dân cư")
                OpenChildForm(new FThongKePhanBo());

        }
        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlHienThiThongKe.Controls.Add(childForm);
            pnlHienThiThongKe.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
