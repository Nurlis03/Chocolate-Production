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
    public partial class SaleProduct : Form
    {
        public SaleProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = finished_productsComboBox.SelectedValue.ToString();
            string idEmpl = getEmployeesComboBox.SelectedValue.ToString();
            var Settings = new Settings();
            try
            {
                SqlConnection connection = new SqlConnection { ConnectionString = Settings.PPO3_2_versionConnectionString };
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "CheckToEnoughProducts";   
                command.Parameters.AddWithValue("@SellOfIDProduct", int.Parse(id));
                command.Parameters.AddWithValue("@NumberOfProductsSold", Convert.ToInt64(numericUpDown1.Value));
                var returnParam = command.Parameters.AddWithValue("@return_value", SqlDbType.Int);
                returnParam.Direction = ParameterDirection.ReturnValue;
                connection.Open();
                command.ExecuteNonQuery();
                var result = returnParam.Value;
                if (result.Equals(-1))
                {
                    MessageBox.Show("Нельзя продать больше, чем имеется");
                    return;
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("SellProduct", connection);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@SellOfIDProduct", SqlDbType.Int).Value = int.Parse(id);
                    cmd1.Parameters.Add("@NumberOfProductsSold", SqlDbType.Int).Value = Convert.ToInt64(numericUpDown1.Value);
                    cmd1.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = int.Parse(idEmpl);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Продукт успешно продан!", "Information");
                }
                //else if (result.Equals(-2))
                //{
                //    MessageBox.Show("Цена продажи меньше себестоимости. Вы не выйдите в плюс.");
                //    return;
                //}
                connection.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
