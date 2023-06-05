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
using Chocolate_production_version2.Properties;

namespace Chocolate_production_version2
{
    public partial class Sale_product : Form
    {
        public Sale_product()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string id = finished_productsComboBox.SelectedValue.ToString();
            //string idEmpl = getEmployeesComboBox.SelectedValue.ToString();
            //var Settings = new Settings();
            //try
            //{
            //    SqlConnection connection = new SqlConnection { ConnectionString = Settings.PPO3_2_versionConnectionString };
            //    SqlCommand command = connection.CreateCommand();
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.CommandText = "CheckToEnoughProducts";
            //    command.Parameters.AddWithValue("@SellOfIDProduct", int.Parse(id));
            //    command.Parameters.AddWithValue("@NumberOfProductsSold", Convert.ToInt64(numericUpDown1.Value));
            //    var returnParam = command.Parameters.AddWithValue("@return_value", SqlDbType.Int);
            //    returnParam.Direction = ParameterDirection.ReturnValue;
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    var result = returnParam.Value;
            //    if (result.Equals(-1))
            //    {
            //        MessageBox.Show("Нельзя продать больше, чем имеется");
            //        return;
            //    }
            //    else
            //    {
            //        SqlCommand cmd1 = new SqlCommand("SellProduct", connection);
            //        cmd1.CommandType = CommandType.StoredProcedure;
            //        cmd1.Parameters.Add("@SellOfIDProduct", SqlDbType.Int).Value = int.Parse(id);
            //        cmd1.Parameters.Add("@NumberOfProductsSold", SqlDbType.Int).Value = Convert.ToInt64(numericUpDown1.Value);
            //        cmd1.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = int.Parse(idEmpl);
            //        cmd1.ExecuteNonQuery();
            //        MessageBox.Show("Продукт успешно продан!", "Information");
            //    }
            //    //else if (result.Equals(-2))
            //    //{
            //    //    MessageBox.Show("Цена продажи меньше себестоимости. Вы не выйдите в плюс.");
            //    //    return;
            //    //}
            //    connection.Close();
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


            string id = finished_productsComboBox.SelectedValue.ToString();     // id of sale product
            string idEmpl = getEmployeesComboBox.SelectedValue.ToString();      // id of employee
            double amount_of_sale_products = Convert.ToDouble(numericUpDown1.Value);    // amount of sale products

            var Settings = new Settings();
            SqlConnection connection = new SqlConnection { ConnectionString = Settings.PPO3_2_versionConnectionString };
            connection.Open();
            try
            {
                // get amount of product
                string sqlExpression = "SELECT Amount FROM Finished_products " +
                                       $"WHERE ID={id};";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                double amount_product_in_finished_products = (double)command.ExecuteScalar();   // amount of product in finished products

                if (amount_of_sale_products > amount_product_in_finished_products)
                {
                    MessageBox.Show("Нельзя продать больше, чем имеется");
                    connection.Close();
                    return;
                }
                else
                {
                    // get percentage 
                    sqlExpression = "SELECT TOP 1 Budget.[Percentage] FROM Budget;";
                    command.CommandText = sqlExpression;
                    double percent = Convert.ToDouble(command.ExecuteScalar());

                    // select cost of product
                    sqlExpression = "SELECT (Sebes * (@percent / 100) + Sebes) * @amount_of_sale_products " +
                                    "FROM Finished_products " +
                                    $"WHERE Finished_products.ID = {id};";
                    command.CommandText = sqlExpression;
                    command.Parameters.AddWithValue("@amount_of_sale_products", amount_of_sale_products);
                    command.Parameters.AddWithValue("@percent", percent);
                    double cost_of_product = Convert.ToDouble(command.ExecuteScalar());
                    command.Parameters.Clear();


                    // UPDATE Budget
                    sqlExpression = "UPDATE Budget " +
                                    $"SET Budget_amount = Budget_amount + @cost_of_product;";
                    command.CommandText = sqlExpression;
                    command.Parameters.AddWithValue("@cost_of_product", cost_of_product);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    // INSERT in to table sale of products
                    sqlExpression = "INSERT INTO Sale_of_products\r\n" +
                                    "VALUES(@id, @amount_of_sale_products, @cost_amount_sale_prodcts, GETDATE(), @idEmpl);";
                    command.CommandText = sqlExpression;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@amount_of_sale_products", amount_of_sale_products);
                    command.Parameters.AddWithValue("@cost_amount_sale_prodcts", cost_of_product);
                    command.Parameters.AddWithValue("@idEmpl", idEmpl);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();


                    // Update cost_amount of finished products
                    sqlExpression = "UPDATE Finished_products " +
                                   $"SET Cost_amount = Cost_amount - (SELECT Sebes FROM Finished_products WHERE ID={id}) * @amount_of_sale_products " +
                                   $"WHERE ID = {id};";
                    command.CommandText = sqlExpression;
                    command.Parameters.AddWithValue("@amount_of_sale_products", amount_of_sale_products);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    // Update amount of finished products
                    sqlExpression = "UPDATE Finished_products " +   
                                           $"SET Amount = Amount - @amount_of_sale_products " +
                                           $"WHERE ID={id};";
                    command.CommandText= sqlExpression;
                    command.Parameters.AddWithValue("@amount_of_sale_products", amount_of_sale_products);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    if (amount_of_sale_products == amount_product_in_finished_products)
                    {
                        sqlExpression = "UPDATE Finished_products " +
                                        "SET Cost_amount = 0 " +
                                        $"WHERE ID={id}";
                        command.CommandText = sqlExpression;
                        command.ExecuteNonQuery();
                    }

                   
                    MessageBox.Show("Продукт успешно продан!", "Information");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            connection.Close();
        }
            private void SaleProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Finished_products". При необходимости она может быть перемещена или удалена.
            this.finished_productsTableAdapter.Fill(this._PPO3_2_versionDataSet.Finished_products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this._PPO3_2_versionDataSet.Employee);

        }
    }
}
