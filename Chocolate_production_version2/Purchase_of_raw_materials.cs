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
using MessageBox = System.Windows.Forms.MessageBox;

namespace Chocolate_production_version2
{
    public partial class Purchase_of_raw_materials : Form
    {
        public Purchase_of_raw_materials()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        private void purchase_of_raw_materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchase_of_raw_materialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PPO3_2_versionDataSet);
        }

        private void Purchase_of_raw_materials_Load(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this._PPO3_2_versionDataSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this._PPO3_2_versionDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Raw_material". При необходимости она может быть перемещена или удалена.
            this.raw_materialTableAdapter.Fill(this._PPO3_2_versionDataSet.Raw_material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Purchase_of_raw_materials". При необходимости она может быть перемещена или удалена.
            this.purchase_of_raw_materialsTableAdapter.Fill(this._PPO3_2_versionDataSet.Purchase_of_raw_materials);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buying__raw_materials buy = new buying__raw_materials();
            buy.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report_purchase_form report = new Report_purchase_form();
            report.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully deleted data", "Delete Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
