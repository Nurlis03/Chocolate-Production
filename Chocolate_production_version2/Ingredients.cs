using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Chocolate_production_version2
{
    public partial class Ingredients : Form
    {
        public Ingredients()
        {
            InitializeComponent();
        }

        public bool FullCheck()
        {
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Product cannot be empty!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nameComboBox.Text.Length == 0)
            {
                MessageBox.Show("Raw material cannot be empty!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double result = 0;
            if (double.TryParse(textBox1.Text,out result))
            {
                if (Convert.ToDouble(textBox1.Text) > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Amount textbox cannot contain negative numbers and zero!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("In amount textbox value is wrong format!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                return false;
            }
        }

        public void CheckButton()
        {
            bool EnabledButton = false;
            for (int i = 0; i < ingredientsDataGridView.RowCount; i++)
            {
                if (ingredientsDataGridView[0, i].Value.ToString() == nameComboBox.Text)
                {
                    EnabledButton = true;
                    button2.Enabled = false;
                }
            }
            if (!EnabledButton)
            {
                button2.Enabled = true;
            }
        }
        private void ingredientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PPO3_2_versionDataSet);

        }
        private void Ingredients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet1.Raw_material". При необходимости она может быть перемещена или удалена.
            this.raw_materialTableAdapter.Fill(this._PPO3_2_versionDataSet1.Raw_material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_PPO3_2_versionDataSet.Finished_products". При необходимости она может быть перемещена или удалена.
            this.finished_productsTableAdapter.Fill(this._PPO3_2_versionDataSet.Finished_products);
            this.ingredientsTableAdapter.Fill(this._PPO3_2_versionDataSet.Ingredients);

            comboBox1.SelectedItem = null;
            nameComboBox.SelectedItem= null;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var select = $"SELECT Raw_material.Name AS Raw_material, Ingredients.Amount " +
                $"FROM Ingredients INNER JOIN Raw_material on Ingredients.Raw_material=Raw_material.ID " +
                $"WHERE Ingredients.Product in (SELECT Finished_products.ID FROM Finished_products " +
                $"WHERE Finished_products.Name = '{comboBox1.Text}');";

            var c = Properties.Settings.Default.PPO3_2_versionConnectionString;

            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            ingredientsDataGridView.DataSource = ds.Tables[0];
            CheckButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FullCheck())
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.PPO3_2_versionConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Ingredients(Product, Raw_material, Amount) VALUES(@Product,@Raw_material,@Amount)", con);
                cmd.Parameters.AddWithValue("@Product", Convert.ToInt64(comboBox1.SelectedValue));
                cmd.Parameters.AddWithValue("@Raw_material", Convert.ToInt64(nameComboBox.SelectedValue));
                cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(textBox1.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                comboBox1_SelectionChangeCommitted(sender, e);
                MessageBox.Show("Added data Succesfully!!!");
            }
        }

        private void nameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FullCheck())
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.PPO3_2_versionConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Ingredients set Product=@Product, Raw_material=@Raw_material, Amount=@Amount where Product=@Product AND Raw_material=@Raw_material", con);
                cmd.Parameters.AddWithValue("@Product", Convert.ToInt64(comboBox1.SelectedValue));
                cmd.Parameters.AddWithValue("@Raw_material", Convert.ToInt64(nameComboBox.SelectedValue));
                cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(textBox1.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                comboBox1_SelectionChangeCommitted(sender, e);
                MessageBox.Show("Successfully Updated!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.PPO3_2_versionConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Ingredients where Product=@Product AND Raw_material=@Raw_material", con);
            cmd.Parameters.AddWithValue("@Product", Convert.ToInt64(comboBox1.SelectedValue));
            cmd.Parameters.AddWithValue("@Raw_material", Convert.ToInt64(nameComboBox.SelectedValue));
            cmd.ExecuteNonQuery();
            con.Close();
            comboBox1_SelectionChangeCommitted(sender, e);
            MessageBox.Show("Successfully Deleted!!!");
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
