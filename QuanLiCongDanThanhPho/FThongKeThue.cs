
using QuanLiCongDanThanhPho.Models;
using System;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongKeThue : Form
    {
        private ThueDAO thueDAO;

        public FThongKeThue()
        {
            InitializeComponent();
            thueDAO = new ThueDAO();
            StackForm.Add(this);
        }

        private string DinhDangTienTe(string s)
        {
            string result = s;
            for (int i = result.Length-3; i > 0; i -= 3)
            {
                result = result.Insert(i, ".");
            }
            return result +" VND";
        }

        private void FThongKeThue_Load(object sender, EventArgs e)
        {
            TaoBieuDoThue();
            int[] thues = thueDAO.LayThongKeThue();
            int soNguoiTreHan = thueDAO.LaySoNguoiTreHan();
            lblTongTienThue.Text += " " + DinhDangTienTe(thues[2].ToString());
            lblTongThueCanDong.Text += " " + DinhDangTienTe(thues[1].ToString());
            lblTongThueDaDong.Text += " " + DinhDangTienTe(thues[0].ToString());
            lblTrungBinhThue.Text += " " + DinhDangTienTe(((int)(thues[2] / thues[3])).ToString());
            lblSoNguoiTreHan.Text += " " + soNguoiTreHan.ToString();
        }

        private void TaoBieuDoThue()
        {
            TaoChartThue();
            int[] thues = thueDAO.LayThongKeThue();

            // Set the chart type to Pie
            chartThue.Series.Add("Data");
            chartThue.Series["Data"].ChartType = SeriesChartType.Pie;

            // Bind the chart data to the DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Tình trạng", typeof(string));
            dt.Columns.Add("Số tiền", typeof(int));

            dt.Rows.Add("Đã đóng", thues[0]);
            dt.Rows.Add("Còn thiếu", thues[1]);
            chartThue.DataSource = dt;
            chartThue.Series["Data"].XValueMember = "Tình trạng";
            chartThue.Series["Data"].YValueMembers = "Số tiền";
                
            // Set the chart properties
            chartThue.ChartAreas.Add(new ChartArea());
            chartThue.Legends.Add(new Legend());
            chartThue.Legends[0].Enabled = true;

            // Format the data labels to show percentages
            chartThue.Series["Data"].Label = "#PERCENT";
            chartThue.Series["Data"].LegendText = "#VALX";

            Controls.Add(chartThue);
        }

        private void TaoChartThue()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            chartThue = new Chart();

            chartArea1.Name = "ChartArea1";
            chartThue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartThue.Legends.Add(legend1);
            chartThue.Location = new Point(700, 12);
            chartThue.Name = "chartGioiTinh";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";

            chartThue.Series.Add(series1);
            chartThue.Size = new Size(800, 650);
            chartThue.TabIndex = 0;
            chartThue.Text = "chartGioiTinh";
        }
    }
}
