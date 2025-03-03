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
    public partial class Avto : Form
    {
        public Avto()

        {
            InitializeComponent();
            btnLogin.Click += (a, s) => avto();
        }
        public void avto()

        {
            System.Data.DataTable tb = new System.Data.DataTable();

            string query = $@"SELECT Name,Password            
                      FROM [avto] WHERE (Name = N'{tbUsername.Text}') AND (Password = N'{tbPassword.Text}')";


            using (SqlConnection connection = new SqlConnection(Class.DataBase.connStr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(tb);
                }
            }
            if (tb.Rows.Count > 0)
            {
                new mainForm().Show();
                this.Hide();
    }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Avto_Load(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

