using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;

namespace Chocolate_production_version2
{
    public partial class Salary_issuance : Form
    {
        public Salary_issuance()
        {
            InitializeComponent();
        }

        private void AutoSizeTableColumms()
        {
            dataGridView1.Columns["Employee_ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Full_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Month"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Purchase_Count"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Production_Count"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Sale_Count"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Total_Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Bonus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Salary"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Total_Salary"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Has_The_Salary_Been_Issued"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void ShowBudget(SqlCommand command)
        {
            command.Parameters.Clear();

            // создаем команду для получения бюджета
            command.CommandText = "SELECT Budget_amount FROM Budget";
            // выполняем команду и получаем результат
            double budget = (double)command.ExecuteScalar();
            // устанавливаем значение бюджета в текстовом поле
            textBox3.Text = budget.ToString();
            textBox3.ForeColor = System.Drawing.Color.Red;
        }
        private int CheckForSalaryIssuance(SqlCommand command, int selectedYear, int selectedMonth)
        {
            command.Parameters.Clear();
            command.CommandText = "SELECT COUNT(*) " +
                                  "FROM Salary " +
                                  "WHERE Year = @year AND Month = @month AND Has_The_Salary_Been_Issued = 'issued'";

            command.Parameters.AddWithValue("@year", selectedYear);
            command.Parameters.AddWithValue("@month", selectedMonth);

            // Выполняем запрос и получаем количество сотрудников, у которых выплачена зарплата в выбранном месяце и году
            int count = (int)command.ExecuteScalar();

            if (count > 0)
            {
                // Если зарплата уже выплачена, блокируем groupBox1 и все его внутренние элементы, а также button2
                groupBox1.Enabled = false;
                button2.Enabled = false;
                groupBox2.Enabled = false;
                LoadDataGridView1(command);
                ShowBudget(command);
                return 0;
            }
            else
            {
                // Иначе разблокируем groupBox1 и все его внутренние элементы, а также button2
                groupBox1.Enabled = true;
                button2.Enabled = true;
                groupBox2.Enabled = true;
                return 1;
            }
        }
        private void LoadDataGridView1(SqlCommand command)
        {
            command.Parameters.Clear();
            // изменяем текст sql-запроса
            command.CommandText = "SELECT Employee.ID AS Employee_ID, Employee.Full_name, Year,\r\n    " +
                                  "CASE Month \r\n        " +
                                  "WHEN 1 THEN 'January'\r\n        " +
                                  "WHEN 2 THEN 'February'\r\n        " +
                                  "WHEN 3 THEN 'March'\r\n        " +
                                  "WHEN 4 THEN 'April'\r\n        " +
                                  "WHEN 5 THEN 'May'\r\n        " +
                                  "WHEN 6 THEN 'June'\r\n        " +
                                  "WHEN 7 THEN 'July'\r\n        " +
                                  "WHEN 8 THEN 'August'\r\n        " +
                                  "WHEN 9 THEN 'September'\r\n        " +
                                  "WHEN 10 THEN 'October'\r\n        " +
                                  "WHEN 11 THEN 'November'\r\n        " +
                                  "WHEN 12 THEN 'December'\r\n    " +
                                  "END AS Month, \r\n    " +
                                  "Purchase_Count, Production_Count, Sale_Count, Total_Amount, " +
                                  "Bonus, Salary.Salary, Total_Salary, Has_The_Salary_Been_Issued\r\n" +
                                  "FROM Salary\r\n" +
                                  "JOIN Employee on Employee_ID = Employee.ID\r\n" +
                                  "WHERE Year = @year AND Month = @month;\r\n";

            // добавление параметров к команде
            command.Parameters.AddWithValue("@year", (int)Year_comboBox.SelectedItem);
            command.Parameters.AddWithValue("@month", ((KeyValuePair<string, int>)Month_comboBox.SelectedItem).Value);

            // выполняем запрос и получаем результаты
            SqlDataReader reader = command.ExecuteReader();

            // создаем новую таблицу DataTable и загружаем в нее результаты запроса
            DataTable table = new DataTable();
            table.Load(reader);

            // отображаем результаты в DataGridView
            dataGridView1.DataSource = table;

            // автоматически изменяем размеры столбцов на основе содержимого ячеек
            AutoSizeTableColumms();
        }
        private void Salary_issuance_Load(object sender, EventArgs e)
        {
            // Определите начальный и конечный год, которые вы хотите добавить в ComboBox
            int startYear = 2000;
            int endYear = 2030;

            // Добавьте года в ComboBox
            for (int year = startYear; year <= endYear; year++)
            {
                Year_comboBox.Items.Add(year);
            }

            // Добавьте названия месяцев в ComboBox
            for (int month = 1; month <= 12; month++)
            {
                Month_comboBox.Items.Add(new KeyValuePair<string, int>(DateTimeFormatInfo.InvariantInfo.GetMonthName(month), month));
            }
            Month_comboBox.DisplayMember = "Key";
            Month_comboBox.ValueMember = "Value";
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void Month_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Year_comboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a year.");
                return;
            }

            // Строка подключения к БД
            string connectionString = Properties.Settings.Default.PPO3_2_versionConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            // открытие подключения
            connection.Open();

            // Получаем значение выбранных года и месяца из выпадающих списков
            int selectedYear = (int)Year_comboBox.SelectedItem;
            int selectedMonth = ((KeyValuePair<string, int>)Month_comboBox.SelectedItem).Value;

            // Создаем SQL-запрос для проверки выплаты зарплаты в выбранном месяце и году
            string query = "";
            SqlCommand cmd = new SqlCommand(query, connection);
            if (CheckForSalaryIssuance(cmd, selectedYear, selectedMonth) == 0) {
                connection.Close();
                return;
            }


            //SQL - запрос
            cmd.CommandText = @"INSERT INTO Salary (Employee_ID, Year, Month, Purchase_Count, Production_Count, Sale_Count, Total_Amount, Bonus, Salary, Total_Salary, Has_The_Salary_Been_Issued)
                                SELECT e.ID AS Employee_ID,
                                    @year AS Year,
                                    @month AS Month,
                                    COALESCE(p.Purchase_Count, 0) AS Purchase_Count,
                                    COALESCE(pr.Production_Count, 0) AS Production_Count,
                                    COALESCE(s.Sale_Count, 0) AS Sale_Count,
                                    (COALESCE(p.Purchase_Count, 0) + COALESCE(pr.Production_Count, 0) + COALESCE(s.Sale_Count, 0)) AS Total_Amount,
                                    b.Bonus * (COALESCE(p.Purchase_Count, 0) + COALESCE(pr.Production_Count, 0) + COALESCE(s.Sale_Count, 0)) AS Bonus,
                                    e.Salary,
                                    (e.Salary * b.Bonus * (COALESCE(p.Purchase_Count, 0) + COALESCE(pr.Production_Count, 0) + COALESCE(s.Sale_Count, 0)) / 100) + e.Salary AS Total_Salary,
                                    'not issued' AS Has_The_Salary_Been_Issued
                                FROM Employee e
                                LEFT JOIN (
                                    SELECT Employee, COUNT(*) AS Purchase_Count
                                    FROM Purchase_of_raw_materials
                                    WHERE YEAR(Purchase_date) = @year AND MONTH(Purchase_date) = @month
                                    GROUP BY Employee
                                ) p ON e.ID = p.Employee
                                LEFT JOIN (
                                    SELECT Employee, COUNT(*) AS Production_Count
                                    FROM Production
                                    WHERE YEAR(Date_of_manufacture) = @year AND MONTH(Date_of_manufacture) = @month
                                    GROUP BY Employee
                                ) pr ON e.ID = pr.Employee
                                LEFT JOIN (
                                    SELECT Employee, COUNT(*) AS Sale_Count
                                    FROM Sale_of_products
                                    WHERE YEAR(Date_of_sale) = @year AND MONTH(Date_of_sale) = @month
                                    GROUP BY Employee
                                ) s ON e.ID = s.Employee
                                CROSS JOIN Budget b;";
            try
            {
                // выполнение команды
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601) // unique constraint violation
                {
                    // handle duplicate combination error here
                }
                else
                {
                    // handle other errors here
                }
            }
            finally
            {
                cmd.CommandText = "UPDATE Salary\r\n" +
                                  "SET Bonus = (SELECT Bonus FROM Budget) * Total_Amount,\r\n\t" +
                                  "Total_Salary = ((SELECT Bonus FROM Budget) * Total_Amount) * Salary / 100 + Salary\r\n" +
                                  "WHERE Year = @year AND Month = @month AND Has_The_Salary_Been_Issued = 'not issued'";

                cmd.ExecuteNonQuery();

                // Запрос на получение общей суммы зарплат
                cmd.CommandText = "SELECT SUM(Total_Salary) AS TotalSalarySum " +
                                  "FROM Salary " +
                                  "WHERE Year = @year AND Month = @month";

                SqlDataReader readerTotalSalary = cmd.ExecuteReader();
                readerTotalSalary.Read();
                double totalSalarySum = readerTotalSalary.GetDouble(0);
                textBox2.Text = totalSalarySum.ToString();
                readerTotalSalary.Close();
                LoadDataGridView1(cmd);
                ShowBudget(cmd);
                connection.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string totalSalary = dataGridView1.CurrentRow.Cells["Total_Salary"].Value.ToString();
                textBox1.Text = totalSalary;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal totalSalary) && Convert.ToDouble(textBox1.Text) >= 0)
            {
                // Получаем значение ID выбранного сотрудника из dataGridView1
                int emp_id = (int)dataGridView1.CurrentRow.Cells["Employee_ID"].Value;
                double salary = Convert.ToDouble(textBox1.Text);

                // Строка подключения к БД
                string connectionString = Properties.Settings.Default.PPO3_2_versionConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                // Создаем подготовленный запрос с параметрами
                string sql = "UPDATE Salary SET Total_Salary = @Total_Salary " +
                                "WHERE Employee_ID = @emp_id AND Year = @year AND Month = @month";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    // Добавляем параметры
                    cmd.Parameters.AddWithValue("@Total_Salary", salary);
                    cmd.Parameters.AddWithValue("@emp_id", emp_id);
                    cmd.Parameters.AddWithValue("@year", (int)Year_comboBox.SelectedItem);
                    cmd.Parameters.AddWithValue("@month", ((KeyValuePair<string, int>)Month_comboBox.SelectedItem).Value);

                    // Выполняем запрос
                    cmd.ExecuteNonQuery();

                    // Запрос на получение общей суммы зарплат
                    cmd.CommandText = "SELECT SUM(Total_Salary) AS TotalSalarySum " +
                                      "FROM Salary " +
                                      "WHERE Year = @year AND Month = @month";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@year", (int)Year_comboBox.SelectedItem);
                    cmd.Parameters.AddWithValue("@month", ((KeyValuePair<string, int>)Month_comboBox.SelectedItem).Value);

                    SqlDataReader readerTotalSalary = cmd.ExecuteReader();
                    readerTotalSalary.Read();
                    double totalSalarySum = readerTotalSalary.GetDouble(0);
                    textBox2.Text = totalSalarySum.ToString();
                    readerTotalSalary.Close();
                    LoadDataGridView1(cmd);
                }
                MessageBox.Show($"Обновление сотрудника с ID: {emp_id} с общей зарплатой: {salary}");
                connection.Close();
            }
            else
            {
                MessageBox.Show("Введенное значение некорректно.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Строка подключения к БД
            string connectionString = Properties.Settings.Default.PPO3_2_versionConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Получаем значение выбранных года и месяца из выпадающих списков
            int selectedYear = (int)Year_comboBox.SelectedItem;
            int selectedMonth = ((KeyValuePair<string, int>)Month_comboBox.SelectedItem).Value;

            // Запрос на получение общей суммы зарплат
            SqlCommand commandTotalSalary = new SqlCommand("SELECT SUM(Total_Salary) AS TotalSalarySum " +
                                                           "FROM Salary " +
                                                           "WHERE Year = @year AND Month = @month", connection);

            commandTotalSalary.Parameters.AddWithValue("@year", selectedYear);
            commandTotalSalary.Parameters.AddWithValue("@month", selectedMonth);
            SqlDataReader readerTotalSalary = commandTotalSalary.ExecuteReader();
            readerTotalSalary.Read();
            double totalSalarySum = readerTotalSalary.GetDouble(0);
            readerTotalSalary.Close();

            // Запрос на получение бюджета
            SqlCommand commandBudget = new SqlCommand("SELECT Budget_amount FROM Budget;", connection);
            SqlDataReader readerBudget = commandBudget.ExecuteReader();
            readerBudget.Read();
            double budgetAmount = readerBudget.GetDouble(0);
            readerBudget.Close();


            // Сравнение общей суммы зарплат с бюджетом
            if (totalSalarySum <= budgetAmount)
            {
                // Выплата зарплаты
                SqlCommand commandIssueSalary = new SqlCommand("UPDATE Salary " +
                                                               "SET Has_The_Salary_Been_Issued = 'issued' " +
                                                               "WHERE Year = @year AND Month = @month;", connection);

                commandIssueSalary.Parameters.AddWithValue("@year", selectedYear);
                commandIssueSalary.Parameters.AddWithValue("@month", selectedMonth);
                commandIssueSalary.ExecuteNonQuery();

                // Уменьшаем бюджет
                SqlCommand commandUpdateBudget = new SqlCommand("UPDATE Budget " +
                                                                "SET Budget_amount = Budget_amount - @totalSalary", connection);
                commandUpdateBudget.Parameters.AddWithValue("@totalSalary", totalSalarySum);
                commandUpdateBudget.ExecuteNonQuery();

                // Вывод сообщения об успешной выплате зарплаты
                CheckForSalaryIssuance(commandUpdateBudget, selectedYear, selectedMonth);
                MessageBox.Show("Зарплата выплачена успешно!");
            }
            else
            {
                // Вывод сообщения о недостаточности бюджета
                MessageBox.Show("Бюджета недостаточно для выплаты зарплаты!");
            }
            // Закрытие соединения
            connection.Close();
        }
    }
}

