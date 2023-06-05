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
    public partial class Finished_products : Form
    {
        public Finished_products()
        {
            InitializeComponent();
        }

        private void finished_productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.finished_productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PPO3_2_versionDataSet);

        }

        private void Finished_products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Units". При необходимости она может быть перемещена или удалена.
            this.unitsTableAdapter.Fill(this._PPO3_2_versionDataSet.Units);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Ingredients". При необходимости она может быть перемещена или удалена.
            this.ingredientsTableAdapter.Fill(this._PPO3_2_versionDataSet.Ingredients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Finished_products". При необходимости она может быть перемещена или удалена.
            this.finished_productsTableAdapter.Fill(this._PPO3_2_versionDataSet.Finished_products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Units". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Finished_products". При необходимости она может быть перемещена или удалена.
            this.finished_productsTableAdapter.Fill(this._PPO3_2_versionDataSet.Finished_products);

        }

        private void finished_productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.finished_productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PPO3_2_versionDataSet);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully deleted data", "Delete Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
