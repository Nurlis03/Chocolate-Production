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
    public partial class Budget : Form
    {
        public Budget()
        {
            InitializeComponent();
        }

        private void budgetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.budgetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PPO3_2_versionDataSet);
        }

        private void Budget_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Budget". При необходимости она может быть перемещена или удалена.
            this.budgetTableAdapter.Fill(this._PPO3_2_versionDataSet.Budget);

        }
    }
}
