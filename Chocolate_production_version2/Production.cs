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
    public partial class Production : Form
    {
        public Production()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        private void productionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PPO3_2_versionDataSet);
        }

        private void Production_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this._PPO3_2_versionDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Finished_products". При необходимости она может быть перемещена или удалена.
            this.finished_productsTableAdapter.Fill(this._PPO3_2_versionDataSet.Finished_products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Production". При необходимости она может быть перемещена или удалена.
            this.productionTableAdapter.Fill(this._PPO3_2_versionDataSet.Production);
            cn = new SqlConnection(Properties.Settings.Default.PPO3_2_versionConnectionString);
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProduceProduct Produce_product = new ProduceProduct();
            Produce_product.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report_production_form form_production = new Report_production_form();
            form_production.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully deleted data", "Delete Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
