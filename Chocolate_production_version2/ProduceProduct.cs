using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Chocolate_production_version2.Properties;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace Chocolate_production_version2
{
    public partial class ProduceProduct : Form
    {
        public ProduceProduct()
        {
            InitializeComponent();
        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.sP_DATE_ProductionTableAdapter.Fill(this._PPO3_2_versionDataSet.SP_DATE_Production, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(startToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(endToolStripTextBox.Text, typeof(System.DateTime))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void ProduceProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this._PPO3_2_versionDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Finished_products". При необходимости она может быть перемещена или удалена.
            this.finished_productsTableAdapter.Fill(this._PPO3_2_versionDataSet.Finished_products);

        }

        SqlConnection cn = new SqlConnection(Properties.Settings.Default.PPO3_2_versionConnectionString);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double amount_of_produce_products = (double)numericUpDown1.Value;
                int id_product = int.Parse(finished_productsComboBox.SelectedValue.ToString());
                cn.Open();

                // We find how much raw materials are needed for the production of the selected products
                string sqlExpression = $"SELECT Amount * @amount_of_produce_products AS need_amount FROM Ingredients " +
                                       "WHERE Product = @id_product " +
                                       "ORDER BY Ingredients.Raw_material;";
                SqlCommand command = new SqlCommand(sqlExpression, cn);
                command.Parameters.AddWithValue("@amount_of_produce_products", amount_of_produce_products);
                command.Parameters.AddWithValue("@id_product", id_product);
                SqlDataReader reader = command.ExecuteReader();
                command.Parameters.Clear();

                List<double> need_raw_materials = new List<double>(); // required amount of raw materials
                if (reader.HasRows) // if product has raw materials, than saved into list
                {
                    while (reader.Read())
                    {
                        need_raw_materials.Add((double)reader.GetValue(0));
                    }
                }
                else
                {
                    // if product hasn't any raw materials for production
                    MessageBox.Show("The product has no raw materials!!!!",
                    "Production", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    return;
                }
                reader.Close();

                // find how many amount of raw materials in table Raw_material for produce products
                sqlExpression = "SELECT Raw_material.ID, Raw_material.Amount FROM Raw_material " +
                                "WHERE Raw_material.ID in (SELECT Ingredients.Raw_material FROM Ingredients WHERE Ingredients.Product = @id_product);";
                command.CommandText = sqlExpression;
                command.Parameters.AddWithValue("@id_product", id_product);
                reader = command.ExecuteReader();
                command.Parameters.Clear();

                List<double> amount_raw_materials = new List<double>(); // quantity of raw materials
                List<int> id_raw_materials = new List<int>();
                while (reader.Read())
                {
                    id_raw_materials.Add((int)reader.GetValue(0));
                    amount_raw_materials.Add((double)reader.GetValue(1));
                }
                reader.Close();

                for(int i = 0; i < need_raw_materials.Count; i++)
                {
                    if (need_raw_materials[i] > amount_raw_materials[i])
                    {
                        cn.Close();
                        MessageBox.Show("There are not enough raw materials for the production of this product!!!",
                        "Production", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                sqlExpression = "SELECT Raw_material.Cost FROM Raw_material " +
                                "WHERE Raw_material.ID in (SELECT Ingredients.Raw_material FROM Ingredients WHERE Ingredients.Product = @id_product);";
                command.CommandText = sqlExpression;
                command.Parameters.AddWithValue("@id_product", id_product);
                reader = command.ExecuteReader();
                command.Parameters.Clear();

                List<double> average_cost = new List<double>(); // the price of one raw material
                while (reader.Read())
                {
                    average_cost.Add((double)reader.GetValue(0));
                }
                double total_cost_amount = 0;
                for (int i = 0; i < need_raw_materials.Count; i++)
                {
                    total_cost_amount += need_raw_materials[i] * average_cost[i];
                }

                reader.Close();

                sqlExpression = "UPDATE Finished_products " + //Algoritm 5, 6
                                "SET Amount = Amount + @amount, " +
                                "Cost_amount = Cost_amount + @total_cost_amount WHERE ID = @id_product;";
                command.Parameters.AddWithValue("@amount", amount_of_produce_products);
                command.Parameters.AddWithValue("@total_cost_amount", total_cost_amount);
                command.Parameters.AddWithValue("@id_product", id_product);
                command.CommandText = sqlExpression;
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                List<double> quantity_of_raw_materials_left = new List<double>(); // 7 Algoritm
                for (int i = 0; i < need_raw_materials.Count; i++)
                {
                    quantity_of_raw_materials_left.Add(amount_raw_materials[i] - need_raw_materials[i]);
                }


                for (int i = 0; i < need_raw_materials.Count; i++)
                {
                    sqlExpression = "UPDATE Raw_material " +
                                    "SET Amount = @quantity_of_raw_materials_left " +
                                    "WHERE ID = @id_raw_materials";
                    command.CommandText = sqlExpression;
                    command.Parameters.AddWithValue("@quantity_of_raw_materials_left", quantity_of_raw_materials_left[i]);
                    command.Parameters.AddWithValue("@id_raw_materials", id_raw_materials[i]);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }

                for (int i = 0; i < need_raw_materials.Count; i++) // 8 Algoritm
                {
                    sqlExpression = "UPDATE Raw_material " +
                                   "SET Cost_amount = @quantity_of_raw_materials_left * @average_cost " +
                                   "WHERE ID = @id_raw_materials";
                    command.CommandText = sqlExpression;
                    command.Parameters.AddWithValue("@quantity_of_raw_materials_left", quantity_of_raw_materials_left[i]);
                    command.Parameters.AddWithValue("@average_cost", average_cost[i]);
                    command.Parameters.AddWithValue("@id_raw_materials", id_raw_materials[i]);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }


                sqlExpression = "INSERT INTO Production(Product, Amount, Date_of_manufacture, Employee)" +
                                "VALUES(@id_product, @amount_of_produce_products, @date, @employee);";

                command.CommandText = sqlExpression;
                command.Parameters.AddWithValue("@id_product", id_product);
                command.Parameters.AddWithValue("@amount_of_produce_products", amount_of_produce_products);
                command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@employee", getEmployeesComboBox.SelectedValue);
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                MessageBox.Show("The product has been successfully produced!!!",
                        "Production", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Production", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }

            cn.Close();
        }
    }
}
