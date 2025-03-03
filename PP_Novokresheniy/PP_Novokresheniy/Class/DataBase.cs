using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Novokresheniy.Class
{
    class DataBase
    {
        static public string connStr = "Data Source=109.233.236.26;Initial Catalog = PIVZVOD_NVKRSHN28TP; Persist Security Info=True;User ID = stud;Password=123456789";

        public static SqlConnection con = new SqlConnection(connStr);
        public static DataTable Query(string sql)
        {
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, connStr);
                da.Fill(table);
                return table;
            }
            catch (Exception ex)
            {

                return table;
            }
        }
        static public bool ExecuteSqlCommand(string sql, DataTable toFill)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr);
                adapter.Fill(toFill);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обращения к БД!\nПроверьте вводимые данные.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public static void open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }
        public static void close()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}

    

