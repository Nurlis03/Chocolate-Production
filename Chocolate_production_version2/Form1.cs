using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolate_production_version2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void budgetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.budgetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PPO3_2_versionDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Budget". При необходимости она может быть перемещена или удалена.
            this.budgetTableAdapter.Fill(this._PPO3_2_versionDataSet.Budget);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Budget budget = new Budget();
            budget.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Finished_products finished_products = new Finished_products();
            finished_products.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ingredients ingredients = new Ingredients();
            ingredients.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Positions positions = new Positions();
            positions.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Production production = new Production();
            production.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Purchase_of_raw_materials purchase_of_raw_materials = new Purchase_of_raw_materials();
            purchase_of_raw_materials.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Raw_material raw_material = new Raw_material();
            raw_material.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Sale_of_products sale_of_products = new Sale_of_products();
            sale_of_products.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Units units = new Units();
            units.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Salary_issuance salary = new Salary_issuance();
            salary.Show();
        }
    }
}
