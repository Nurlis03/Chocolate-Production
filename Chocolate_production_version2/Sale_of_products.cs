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
    public partial class Sale_of_products : Form
    {
        public Sale_of_products()
        {
            InitializeComponent();
        }

        private void sale_of_productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sale_of_productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PPO3_2_versionDataSet);

        }
        SqlConnection cn;
        private void Sale_of_products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this._PPO3_2_versionDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Finished_products". При необходимости она может быть перемещена или удалена.
            this.finished_productsTableAdapter.Fill(this._PPO3_2_versionDataSet.Finished_products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Sale_of_products". При необходимости она может быть перемещена или удалена.
            this.sale_of_productsTableAdapter.Fill(this._PPO3_2_versionDataSet.Sale_of_products);
            cn = new SqlConnection(Properties.Settings.Default.PPO3_2_versionConnectionString);
            cn.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sale_product SaleForm = new Sale_product();
            SaleForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report_sale_of_products sal_product = new Report_sale_of_products();
            sal_product.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully deleted data", "Delete Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
