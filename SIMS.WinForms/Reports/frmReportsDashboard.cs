using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SIMS.WinForms.Reports
{
    public partial class frmReportsDashboard : Form
    {
        public frmReportsDashboard()
        {
            InitializeComponent();
        }

        private void frmReportsDashboard_Load(object sender, EventArgs e)
        {
            LoadDailySalesChart();
            LoadTopSellingProductsChart();
        }

        private void LoadDailySalesChart()
        {
            chartSales.Series["DailySales"].ChartType = SeriesChartType.Line;
            chartSales.Series["DailySales"].BorderWidth = 3;

            var dailySalesData = GetDummyDailySalesData();

            foreach (var item in dailySalesData)
            {
                chartSales.Series["DailySales"].Points.AddXY(item.Key, item.Value);
            }
        }

        private Dictionary<string, double> GetDummyDailySalesData()
        {
            var data = new Dictionary<string, double>();
            DateTime today = DateTime.Today;

            data.Add(today.AddDays(-6).ToString("dd MMM"), 12500);
            data.Add(today.AddDays(-5).ToString("dd MMM"), 15200);
            data.Add(today.AddDays(-4).ToString("dd MMM"), 14800);
            data.Add(today.AddDays(-3).ToString("dd MMM"), 17500);
            data.Add(today.AddDays(-2).ToString("dd MMM"), 16300);
            data.Add("Yesterday", 19100);
            data.Add("Today", 21500);

            return data;
        }

        private void LoadTopSellingProductsChart()
        {
            chartTopSelling.Series["Top5Products"].ChartType = SeriesChartType.Pie;
            chartTopSelling.Series["Top5Products"].IsValueShownAsLabel = true;

            var topSellingData = GetDummyTopSellingData();

            foreach (var item in topSellingData)
            {
                chartTopSelling.Series["Top5Products"].Points.AddXY(item.Key, item.Value);
            }
        }

        private Dictionary<string, double> GetDummyTopSellingData()
        {
            var data = new Dictionary<string, double>();
            data.Add("Soft Drinks", 75000);
            data.Add("Sweets", 62000);
            data.Add("Cheese & Dairy", 55000);
            data.Add("Vegetables", 48000);
            data.Add("Home Appliances", 41000);
            return data;
        }

    }
}
