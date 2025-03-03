using Microsoft.Office.Interop.Excel;
using PP_Novokresheniy.Class;
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
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace PP_Novokresheniy.Main
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private void btnSelect1_Click(object sender, EventArgs e)
        {
            Select1 select1 = new Select1();
            select1.Show();
        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            string sqlText = "SELECT Potrebitel.Vladelec_Magazina, Potrebitel.Magazin, COUNT(Zakazi.Kolich) AS Kolich_zakazov FROM Potrebitel "
                + "LEFT JOIN Zakazi ON Potrebitel.Kod_P = Zakazi.FK_Potrebitel "
                + "GROUP BY Potrebitel.Vladelec_Magazina, Potrebitel.Magazin, Zakazi.Kolich";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlText, Class.DataBase.connStr);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            dgvSelect.DataSource = table;

            dgvSelect.Columns[0].HeaderText = "Владелец магазина";
            dgvSelect.Columns[1].HeaderText = "Магазин";
            dgvSelect.Columns[2].HeaderText = "Количество заказов";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert1 insert1 = new Insert1();
            insert1.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workBook = excelApp.Workbooks.Add();
            Excel.Worksheet workSheet = workBook.Sheets[1];

            workSheet.Cells[1, 2] = "«ЗАКРЫТОЕ АКЦИОНЕРНОЕ ОБЩЕСТВО» Волчихинский пивоваренный завод";
            workSheet.Columns[7].ColumnWidth = 22;
            workSheet.Cells.Font.Size = 16;
            workSheet.Name = "Отчёт";
            workSheet.Cells[2, 4] = "Заказы";

            Excel.Range rng1 = workSheet.Range[workSheet.Cells[2, 4], workSheet.Cells[2, 4]];
            rng1.Cells.Font.Name = "Times New Roman";
            rng1.Cells.Font.Size = 26;
            rng1.Font.Bold = true;
            rng1.Cells.Font.Color = ColorTranslator.ToOle(Color.Black);

            workSheet.Cells[4, 1] = "Магазин";
            workSheet.Columns[1].ColumnWidth = 22;
            workSheet.Cells[4, 2] = "Владелец магазина";
            workSheet.Columns[2].ColumnWidth = 22;
            workSheet.Cells[4, 4] = "Название напитка";
            workSheet.Columns[4].ColumnWidth = 22;
            workSheet.Cells[4, 5] = "Количество";
            workSheet.Columns[5].ColumnWidth = 22;
            workSheet.Cells[4, 6] = "Дата заказа".ToString();
            workSheet.Columns[6].ColumnWidth = 22;

            Excel.Range rng2 = workSheet.Range[workSheet.Cells[4, 1], workSheet.Cells[4, 6]];
            rng2.Font.Bold = true;

            string SqlText = "select Potrebitel.Magazin as [Магазин], Potrebitel.Vladelec_Magazina as [Владелец магазина], Napitki.Nazvanie as [Название напитка], Zakazi.Kolich as [Количество], Zakazi.Data_zakaza as [Дата заказа] from Zakazi "
                + " join Potrebitel on Zakazi.FK_Potrebitel = Kod_P"
                + " join Napitki on Zakazi.FK_Napitki = Napitki.Kod_N";

            SqlDataAdapter adapter = new SqlDataAdapter(SqlText, Class.DataBase.connStr);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);

            int i = 5;
            foreach (DataRow row in table.Rows)
            {
                workSheet.Cells[i, 1] = row["Магазин"];
                workSheet.Cells[i, 2] = row["Владелец магазина"];
                workSheet.Cells[i, 4] = row["Название напитка"];
                workSheet.Cells[i, 5] = row["Количество"];
                workSheet.Cells[i, 6] = row["Дата заказа"];
                i++;
            }

            Excel.Range rng3 = workSheet.Range[workSheet.Cells[4, 1], workSheet.Cells[i - 1, 6]];
            rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            rng3.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            rng3.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            rng3.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            int otstup = 15;
            // Добавляем строки для "Утвердил", "Составил" и даты
            workSheet.Cells[otstup, 1] = "Утвердил: ___________________ (ФИО и подпись)";
            workSheet.Cells[otstup + 1, 1] = "Составил: ___________________ (ФИО и подпись)";
            workSheet.Cells[otstup + 2, 1] = "Дата: " + DateTime.Now.ToString("dd.MM.yyyy");

            excelApp.Visible = true;
            excelApp.UserControl = true;
        }


        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlText = "Select * from Sklad";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlText, Class.DataBase.connStr);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            dgvSelect.DataSource = table;
            dgvSelect.Columns[0].HeaderText = "Номер напитка";
            dgvSelect.Columns[1].HeaderText = "Название напитка";
            dgvSelect.Columns[2].HeaderText = "Количество";
            dgvSelect.Columns[3].HeaderText = "Дата производства";
            dgvSelect.Columns[4].HeaderText = "Срок годности";
            dgvSelect.Columns[5].HeaderText = "Цена";
        }

        private void dgvSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Добавить потребителя?\n"
               + "Владелец магазина: " + textBox1.Text + "\n"
               + "Магазин: " + textBox2.Text + "\n",

               "Сообщение",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.OK)
            {
                string sqlText = "INSERT INTO Potrebitel (Vladelec_magazina, Magazin) VALUES (@VladelecMagazina, @Magazin)";

                using (SqlConnection con = new SqlConnection(Class.DataBase.connStr))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlText, con))
                    {
                        // Использование параметров для предотвращения SQL-инъекций
                        cmd.Parameters.AddWithValue("@VladelecMagazina", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Magazin", textBox2.Text);

                        int kol = cmd.ExecuteNonQuery();

                        MessageBox.Show("Записей добавлено: " + kol.ToString(),
                            "Сообщение",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Class.DataBase.connStr))
            {
                conn.Open();

                // Создаем команду SQL с запросом и привязываем параметры
                SqlCommand cmd = new SqlCommand("INSERT INTO Sklad (Nazv_Napitka, Koliches, Data_Proizvods, Srok_Godnosti, Cena) VALUES (@Nazv_Napitka, @Koliches, @Data_Proizvods, @Srok_Godnosti, @Cena)", conn);

                // Добавляем параметры
                cmd.Parameters.AddWithValue("@Nazv_Napitka", textBox8.Text);
                cmd.Parameters.AddWithValue("@Koliches", textBox3.Text);
                cmd.Parameters.AddWithValue("@Data_Proizvods", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Srok_Godnosti", dtpData.Value);
                cmd.Parameters.AddWithValue("@Cena", textBox9.Text);

                // Подтверждение перед выполнением запроса
                DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Выполняем запрос на добавление записи
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись добавлена успешно.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}










