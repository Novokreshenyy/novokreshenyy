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

namespace PP_Novokresheniy.Main
{
    public partial class Insert1 : Form
    {
        public Insert1()
        {
           
            InitializeComponent();
        }

        private void LoadGridSelectInsert()
        {
            string sqlText = "Select * from Zakazi";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlText, Class.DataBase.connStr);
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            dgvSelect.DataSource = table;
            dgvSelect.Columns[0].HeaderText = "Номер";
            dgvSelect.Columns[1].HeaderText = "Количество";
            dgvSelect.Columns[2].HeaderText = "Дата заказа";
            dgvSelect.Columns[3].HeaderText = "Номер потребителя";
            dgvSelect.Columns[4].HeaderText = "Номер напитка";
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Добавить запись?\n"
               + "Количество: " + tbKolichestvo.Text.ToString() + "\n"
               + "Дата заказа: " + dtpData.Text.ToString() + "\n"
               + "Номер потребителя: " + tbPotrebitel.Text.ToString() + "\n"
               + "Номер напитка: " + tbNapitok.Text.ToString(),
               "Сообщение",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                string sqlText = "INSERT INTO Zakazi (Kolich, Data_zakaza, FK_Potrebitel, FK_Napitki) VALUES"
                    + "('" + tbKolichestvo.Text.ToString() + "',"
                    + "'" + dtpData.Value.ToShortDateString() + "',"
                    + "'" + tbPotrebitel.Text.ToString() + "',"
                    + "'" + tbNapitok.Text.ToString() + "')";


                using (SqlConnection con = new SqlConnection(Class.DataBase.connStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlText, con);
                    int kol = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Записей добавлено: " + kol.ToString(),
                        "Cообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadGridSelectInsert();
            }
        }

        private void Insert1_Load(object sender, EventArgs e)
        {
            LoadGridSelectInsert();
        }


        // Событие для двойного щелчка по ячейке DataGridView
        private void dgvSelect_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что щелчок произошел по строке с данными
            if (e.RowIndex >= 0)
            {
                // Получаем выбранную строку
                DataGridViewRow row = dgvSelect.Rows[e.RowIndex];

                // Заполняем текстовые поля значениями из выбранной строки
                tbKolichestvo.Text = row.Cells["Kolich"].Value.ToString();
                dtpData.Value = Convert.ToDateTime(row.Cells["Data_zakaza"].Value);
                tbPotrebitel.Text = row.Cells["FK_Potrebitel"].Value.ToString();
                tbNapitok.Text = row.Cells["FK_Napitki"].Value.ToString();
            }
        }

        // Обработчик для кнопки, выполняющий обновление записи
        private void button1_Click(object sender, EventArgs e)
        {
            // Подтверждаем действие пользователя
            DialogResult result = MessageBox.Show("Вы уверены, что хотите обновить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string sql = @"UPDATE Zakazi 
                       SET Kolich = @Kolich,
                           Data_zakaza = @Data_zakaza,
                           FK_Potrebitel = @FK_Potrebitel,
                           FK_Napitki = @FK_Napitki
                       WHERE Kod_Z = @Kod_Z";

                using (SqlConnection conn = new SqlConnection(Class.DataBase.connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Подготовка параметров для запроса
                        cmd.Parameters.AddWithValue("@Kolich", tbKolichestvo.Text);
                        cmd.Parameters.AddWithValue("@Data_zakaza", dtpData.Value);
                        cmd.Parameters.AddWithValue("@FK_Potrebitel", tbPotrebitel.Text);
                        cmd.Parameters.AddWithValue("@FK_Napitki", tbNapitok.Text);

                        // Используем Kod_Z из выбранной строки
                        cmd.Parameters.AddWithValue("@Kod_Z", dgvSelect.CurrentRow.Cells["Kod_Z"].Value);

                        // Выполняем запрос и показываем результат
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Записей обновлено: " + rowsAffected, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LoadGridSelectInsert();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvSelect.CurrentRow != null && dgvSelect.CurrentRow.Cells[0] != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить эти записи?", "Удаление записей", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        DataBase.Query(@"DELETE FROM [dbo].[Zakazi] where Kod_Z = " + dgvSelect.CurrentRow.Cells[0].Value);
                        MessageBox.Show("Запись удалена");
                        foreach (DataGridViewRow item in this.dgvSelect.SelectedRows)
                        {
                            dgvSelect.Rows.RemoveAt(item.Index);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбрана запись для удаления");
            }
        }
    }
  }

 
    


