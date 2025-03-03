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
    public partial class Select1 : Form
    {
        public Select1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sqlText = "SELECT Potrebitel.Vladelec_Magazina, Potrebitel.Magazin, Zakazi.Kolich, Zakazi.Data_zakaza FROM Potrebitel "
               + " JOIN Zakazi ON Potrebitel.Kod_P = Zakazi.FK_Potrebitel "
               + " WHERE Zakazi.Data_zakaza = '" + dateTimePicker2.Text.ToString() + "' ";
        

            SqlDataAdapter adapter = new SqlDataAdapter(sqlText, Class.DataBase.connStr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvSelect.DataSource = table;

            dgvSelect.Columns[0].HeaderText = "Владелец Магазина";
            dgvSelect.Columns[1].HeaderText = "Магазин";
            dgvSelect.Columns[2].HeaderText = "Количество";
            dgvSelect.Columns[3].HeaderText = "Дата заказа";
        }

        private void Select1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlText = "select Potrebitel.Vladelec_Magazina as [Владелец Магазина], Potrebitel.Magazin as [Магазин], Napitki.Nazvanie as [Название напитка], Zakazi.Kolich as [Количество], Zakazi.Data_zakaza as [Дата заказа] from Zakazi "
                + " join Potrebitel on Zakazi.FK_Potrebitel = Kod_P"
                + " join Napitki on Zakazi.FK_Napitki = Napitki.Kod_N";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlText, Class.DataBase.connStr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvSelect.DataSource = table;

            dgvSelect.Columns[0].HeaderText = "Владелец Магазина";
            dgvSelect.Columns[1].HeaderText = "Магазин";
            dgvSelect.Columns[2].HeaderText = "Название напитка";
        }

        private void tbData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
