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
    public partial class Raw_material : Form
    {
        public Raw_material()
        {
            InitializeComponent();
        }

        private void raw_materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raw_materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PPO3_2_versionDataSet);

        }

        private void Raw_material_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Units". При необходимости она может быть перемещена или удалена.
            this.unitsTableAdapter.Fill(this._PPO3_2_versionDataSet.Units);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Raw_material". При необходимости она может быть перемещена или удалена.
            this.raw_materialTableAdapter.Fill(this._PPO3_2_versionDataSet.Raw_material);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully deleted data", "Delete Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
