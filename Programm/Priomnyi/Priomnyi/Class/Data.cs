using System.Data;
using MySql.Data.MySqlClient;

namespace Priomnyi.Class
{
    class Data
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='medlinedb';username=root;password=;CharSet=utf8;");
        public delegate void SendData(DataTable data);
        public event SendData del;
        public delegate void SendPassword(string pass);
        public event SendPassword sendP;

        public void SoursData(string s)
        {

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            DataTable dta1 = new DataTable();
            MySqlDataAdapter dataadap = new MySqlDataAdapter(cmd);
            dataadap.Fill(dta1);
            del(dta1);
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
            string sql = s;
            string value = "";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                value = reader[0].ToString();
            }
            connection.Close();
            return value;
        }
        public string[] DisplayReturns(string s)
        {
            connection.Open();
            string sql = s;
            string[] value = new string[4];
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                value[0] = reader[0].ToString();
                value[1] = reader[1].ToString();
                value[2] = reader[2].ToString();
                //value[3] = reader[3].ToString();
            }
            connection.Close();
            return value;
        }
        
        public bool login(string log, string pass)
        {
            try
            {
                connection.Open();
                string sql = "SELECT * FROM users WHERE user_login='" + log + "' and user_password='" + pass + "'";
                string[] value = new string[5];
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    value[2] = reader[2].ToString();
                    value[3] = reader[3].ToString();
                    value[4] = reader[4].ToString();
                }
                connection.Close();
                
                if (value[3].Length > 0) {
                    sendP(value[2]);
                    return true;
                }
                else { 
                    return false;
                }
        }
            catch { return false; }
        }
    }
}
