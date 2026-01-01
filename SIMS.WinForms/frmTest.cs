using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Reports;
using Microsoft.Reporting.WinForms;

namespace SIMS.WinForms
{
    public partial class frmTest : Form
    {

        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer);

            // ملاحظة: تأكد من أن ملف repSales.rdlc موجود في مجلد المشروع أو مسار التشغيل
            reportViewer.LocalReport.ReportPath = "C:\\Users\\mozaf\\GitHub\\sales-and-inventory-management-system\\SIMS.WinForms\\Reports\\repSales.rdlc";

            // 2. تجهيز القائمة (هنا تكتب الكود الذي سألت عنه)
            List<clsSalesReport> basicFinancialSummary = new List<clsSalesReport>();
            //{
            //    new clsSalesReport
            //    {
            //        DateFrom = DateTime.Now,
            //        DateTo = DateTime.Now,
            //        TotalInvoicesCount = 150, 
            //        GrossSalesAmount = 25750.50m,
            //        TotalDiscounts = 450.00m,
            //        TotalTaxes = 3850.75m,
            //        NetSales = 25300.50m,
            //        TotalReturns = 120.25m,
            //        FinalNetRevenue = 29031.00m
            //    }
            //};

            // 3. إرسال البيانات للتقرير
            reportViewer.LocalReport.DataSources.Clear(); // مسح أي بيانات قديمة
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("BasicFinancialSummary", basicFinancialSummary));

            // 4. تحديث التقرير لعرضه
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.RefreshReport();
        }

    }
}
