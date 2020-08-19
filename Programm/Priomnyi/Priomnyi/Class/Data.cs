using System.Data;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace Priomnyi.Class
{
    class Data
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='medlinedb';username=root;password=;CharSet=utf8;");
        public delegate void SendData(DataTable data);
        public event SendData del;      

        public void SoursData(string s)
        {
            connection.Close();
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
        /*public string[] DisplayReturns(string s)
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
        }*/
        
        public bool login(string log, string pass)
        {
              connection.Open();
               
            string sql = "SELECT * FROM users WHERE user_login='" + log + "' and user_password='" + ComputeSha256Hash(pass) + "'";
            string[] value = new string[6];
            del += db =>
            {
                if (db.Rows.Count >0) { 
                value[1] = db.Rows[0][0].ToString();
                value[2] = db.Rows[0][1].ToString();
                value[3] = db.Rows[0][2].ToString();
                value[4] = db.Rows[0][3].ToString();
                value[5] = db.Rows[0][4].ToString();
                }

            };
            SoursData(sql);
            if (value[1]!=null&&value[2]=="13") {
                ClassStatic.Id =  value[1];
                ClassStatic.Name = value[3];
                return true;
            }
            else
             return false;
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }



    }
}
