using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolate_production_version2
{
    public partial class Report_sale_of_products : Form
    {
        public Report_sale_of_products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.PPO3_2_versionConnectionString);
            SqlCommand cmd = new SqlCommand($"SELECT Finished_products.Name AS Product, dbo.Sale_of_products.Amount, dbo.Sale_of_products.Cost_Amount, dbo.Sale_of_products.Date_of_sale, Employee.Full_name AS Employee\r\nFROM dbo.Sale_of_products INNER JOIN\r\n     Finished_products ON dbo.Sale_of_products.Product = Finished_products.ID INNER JOIN\r\n     Employee ON dbo.Sale_of_products.Employee = Employee.ID\r\nWHERE Date_of_sale BETWEEN '{start.Value}' AND '{end.Value}';", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource sourse = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = "Sale_product_report.rdlc";
            reportViewer1.LocalReport.DataSources.Add(sourse);
            reportViewer1.RefreshReport();
            cn.Close();
        }
    }
}
