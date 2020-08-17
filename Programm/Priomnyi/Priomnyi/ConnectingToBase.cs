using System.Data;
using MySql.Data.MySqlClient;

namespace Priomnyi
{
    class ConnectingToBase
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='u_system';username=STROI;password=123456;CharSet=utf8;");

        public void SoursData(string s)
        {

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            //DataTable dta1 = new DataTable();
            //MySqlDataAdapter dataadap = new MySqlDataAdapter(cmd);
            //dataadap.Fill(dta1);
            //dataGridView1.ItemsSource = dta1.DefaultView; 
            connection.Close();
        }
        public void Registr(string s)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public string DisplayReturn(string s)
        {
            connection.Open();
            string sql = s, value = "";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                value = reader[0].ToString();

            }
            connection.Close();
            return value;
        }


    }
}
