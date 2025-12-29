using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Reports;

namespace SIMS.WinForms.Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            clsDailySummary dailySummary = new clsDailySummary();

            lblTodaySales.Text = dailySummary.TodaySales.ToString("0.##") + " ج.س";
            lblTodayTotalSalesReturn.Text = dailySummary.TodaySalesReturn.ToString("0.##") + " ج.س";
            lblTodayNetSales.Text = dailySummary.TodayNetSales.ToString("0.##") + " ج.س";
            lblTodaySalesInvoices.Text = dailySummary.TodaySalesInvoiceCount.ToString();

            lblTodayPurchases.Text = dailySummary.TodayPurchases.ToString("0.##") + " ج.س";
            lblTodayPurchasesReturn.Text = dailySummary.TodayPurchasesReturn.ToString("0.##") + " ج.س";
            lblTodayNetPurchases.Text = dailySummary.TodayNetPurchases.ToString("0.##") + " ج.س";
            lblTodayPurchasesInvoices.Text = dailySummary.TodayPurchasesInvoiceCount.ToString();

            lblTodayTotalProfits.Text = dailySummary.TodayProfit.ToString("0.##") + " ج.س";
            lblTodayProfitRate.Text = dailySummary.TodayProfitRate.ToString("0.##") + "%";
        }
    }
}
