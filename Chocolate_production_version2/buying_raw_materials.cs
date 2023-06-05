using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Chocolate_production_version2
{
    public partial class buying__raw_materials : Form
    {
        public buying__raw_materials()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        private void buying__raw_materials_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Purchase_of_raw_materials". При необходимости она может быть перемещена или удалена.
            this.purchase_of_raw_materialsTableAdapter.Fill(this._PPO3_2_versionDataSet.Purchase_of_raw_materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this._PPO3_2_versionDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Raw_material". При необходимости она может быть перемещена или удалена.
            this.raw_materialTableAdapter.Fill(this._PPO3_2_versionDataSet.Raw_material);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.PPO3_2_versionConnectionString);
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cn.Open();

                string sqlExpression = "SELECT SUM(Budget_amount) " +
                                       "FROM Budget;";
                SqlCommand command = new SqlCommand(sqlExpression, cn);
                double budget_amount = Convert.ToDouble(command.ExecuteScalar());
                double amount_of_purchased_raw_materials = Convert.ToDouble(textBox1.Text);
                double cost_amount_of_purchased_raw_materials = Convert.ToDouble(textBox2.Text);

                // Checking what the budget will be enough for the purchase of raw materials
                if (budget_amount - cost_amount_of_purchased_raw_materials < 0)
                {
                    // Budget is not enough
                    MessageBox.Show("There is not enough budget " +
                        "for the purchase of this raw material!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Budget is enough
                    // REDUCE budget
                    sqlExpression = "UPDATE Budget " +
                                    $"SET Budget_amount = Budget_amount - @cost_amount_of_purchased_raw_materials;";
                    command.CommandText = sqlExpression;
                    command.Parameters.Add("@cost_amount_of_purchased_raw_materials", SqlDbType.Decimal).Value = cost_amount_of_purchased_raw_materials;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    // INSERT data into table Purchase_of_raw_materials
                    sqlExpression = "INSERT INTO Purchase_of_raw_materials(Raw_material, Amount, Cost_amount, Purchase_date, Employee) " +
                                    "VALUES(@Raw_material, @Amount, @Cost_amount, @Purchase_date, @Employee);";

                    command.CommandText = sqlExpression;
                    command.Parameters.Add("@Raw_material", SqlDbType.Int).Value = (int)comboBox1.SelectedValue;
                    command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount_of_purchased_raw_materials;
                    command.Parameters.Add("@Cost_amount", SqlDbType.Decimal).Value = cost_amount_of_purchased_raw_materials;
                    command.Parameters.Add("@Purchase_date", SqlDbType.Date).Value = dateTimePicker1.Value;
                    command.Parameters.Add("@Employee", SqlDbType.Int).Value = (int)comboBox2.SelectedValue;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    // UPDATE raw material field "Amount"
                    sqlExpression = "UPDATE Raw_material " +
                                   $"SET Raw_material.Amount = Raw_material.Amount + @amount_of_purchased_raw_materials " +
                                   $"WHERE Raw_material.ID = {(int)comboBox1.SelectedValue};";
                    command.CommandText = sqlExpression;
                    command.Parameters.Add("@amount_of_purchased_raw_materials", SqlDbType.Decimal).Value = amount_of_purchased_raw_materials;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    // UPDATE raw material field "Cost amount"
                    sqlExpression = "UPDATE Raw_material " +
                                    $"SET Raw_material.Cost_amount = Raw_material.Cost_amount + @cost_amount_of_purchased_raw_materials " +
                                    $"WHERE Raw_material.ID = {(int)comboBox1.SelectedValue};";

                    command.CommandText = sqlExpression;
                    command.Parameters.Add("@cost_amount_of_purchased_raw_materials", SqlDbType.Decimal).Value = cost_amount_of_purchased_raw_materials;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    MessageBox.Show("The purchase of raw materials was successful!",
                        "Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                        "Purchase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }
            cn.Close();
        }
    }
}
