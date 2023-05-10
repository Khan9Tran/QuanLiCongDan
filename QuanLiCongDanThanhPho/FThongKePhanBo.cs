
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLiCongDanThanhPho
{
    public partial class FThongKePhanBo : Form
    {
        private CongDanDAO cdDAO;
        private TamTruTamVangDAO tttvDAO;
        private HoKhauDAO hkDAO;

        public FThongKePhanBo()
        {
            InitializeComponent();
            cdDAO = new CongDanDAO();
            tttvDAO = new TamTruTamVangDAO();
            hkDAO = new HoKhauDAO();
            StackForm.Add(this);
        }

        private void FThongKePhanBo_Load(object sender, EventArgs e)
        {
            TaoDoThiPhanBo();
            //gvDanhSachQuan.DataSource = cdDAO.LayDanhSachDiaChi();
            lblSoNguoiTamTru.Text += " " + tttvDAO.LaySoLuongTamTru().ToString();
            lblSoNguoiTamVang.Text += " " + tttvDAO.LaySoLuongTamVang().ToString();
            lblSoNguoiQuaHanTT.Text += " " + tttvDAO.LaySoLuongQuaHanTamTru().ToString();
            lblSoNguoiQuaHanTV.Text += " " + tttvDAO.LaySoLuongQuaHanTamVang().ToString();
            gvHoNhieuNguoiNhat.DataSource = hkDAO.TimHoNhieuNguoiNhat();
            lblSoNguoiTrungBinhMotQuan.Text += " " + cdDAO.LaySoNguoiTrungBinhCuaMotQuan().ToString();
        }

        private void TaoDoThiPhanBo()
        {
            TaoChartPhanBo();
            chartPhanBo.Series.Add("Data");
            chartPhanBo.Series["Data"].ChartType = SeriesChartType.Column;
            chartPhanBo.Series["Data"].Color = Color.SkyBlue;

            DataTable dt = cdDAO.LayDanhSachDiaChi();
            //Sắp xếp
            dt.DefaultView.Sort = "Số lượng người DESC";
            dt = dt.DefaultView.ToTable();

            var dt10 = dt.AsEnumerable().Take(10);
            chartPhanBo.DataSource = dt10;
            chartPhanBo.Series["Data"].XValueMember = "Quận";
            chartPhanBo.Series["Data"].YValueMembers = "Số lượng người";


            chartPhanBo.ChartAreas.Add("ChartArea");
            chartPhanBo.ChartAreas["ChartArea"].AxisX.LabelStyle.Angle = -90;
            chartPhanBo.ChartAreas["ChartArea"].BackColor = Color.Transparent;
            
            // Set the column width
            chartPhanBo.Series["Data"].CustomProperties = "PixelPointWidth=30";

            chartPhanBo.Legends.Clear();
            Controls.Add(chartPhanBo);
        }

        private void TaoChartPhanBo()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            chartPhanBo = new Chart();

            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 90F;
            chartArea1.Position.Width = 93F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chartPhanBo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartPhanBo.Legends.Add(legend1);
            chartPhanBo.Location = new Point(12, 215);
            chartPhanBo.Name = "chartNgheNghiep";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            chartPhanBo.Series.Add(series1);
            chartPhanBo.Size = new (1000, 440);
            chartPhanBo.TabIndex = 0;
            chartPhanBo.Text = "chart1";
        }
    }
}
