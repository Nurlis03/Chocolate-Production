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
    public partial class Report_production_form : Form
    {
        public Report_production_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.PPO3_2_versionConnectionString);
            SqlCommand cmd = new SqlCommand($"SELECT Finished_products.Name AS Product, dbo.Production.Amount, dbo.Production.Date_of_manufacture, dbo.Employee.Full_name AS Employee\r\nFROM dbo.Production INNER JOIN\r\n     Finished_products ON dbo.Production.Product = Finished_products.ID INNER JOIN\r\n     Employee ON dbo.Production.Employee = Employee.ID\r\nWHERE Date_of_manufacture BETWEEN '{start.Value}' AND '{end.Value}';", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource sourse = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = "Production_report.rdlc";
            reportViewer1.LocalReport.DataSources.Add(sourse);
            reportViewer1.RefreshReport();
            cn.Close();
        }

        private void Report_production_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Production". При необходимости она может быть перемещена или удалена.
            this.productionTableAdapter.Fill(this._PPO3_2_versionDataSet.Production);

        }
    }
}
