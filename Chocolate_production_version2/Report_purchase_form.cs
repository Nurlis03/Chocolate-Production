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
    public partial class Report_purchase_form : Form
    {
        public Report_purchase_form()
        {
            InitializeComponent();
        }

        private void Report_form_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.PPO3_2_versionConnectionString);
            SqlCommand cmd = new SqlCommand($"SELECT Raw_material.Name AS Raw_material, Purchase_of_raw_materials.Amount, Purchase_of_raw_materials.Cost_amount, Purchase_of_raw_materials.Purchase_date, Employee.Full_name AS Employee\r\nFROM dbo.Purchase_of_raw_materials INNER JOIN\r\n     Raw_material ON dbo.Purchase_of_raw_materials.Raw_material = Raw_material.ID INNER JOIN\r\n     Employee ON dbo.Purchase_of_raw_materials.Employee = Employee.ID\r\nWHERE Purchase_date BETWEEN '{start.Value}' AND '{end.Value}';", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource sourse = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = "Product_purchase_report.rdlc";
            reportViewer1.LocalReport.DataSources.Add(sourse);
            reportViewer1.RefreshReport();
            cn.Close();
        }

        private void end_ValueChanged(object sender, EventArgs e)
        {

        }

        private void start_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
