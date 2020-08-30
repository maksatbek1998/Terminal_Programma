using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Notifications_Window.Class
{
    class Data
    {
        //MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='medlinedb';username=root;password=123456;CharSet=utf8;");
        //public MySqlConnection connection = new MySqlConnection("datasource=192.168.0.26; port=3306;Initial Catalog='medlinedb';username=admin;password=server_terminal_2019#;CharSet=utf8;");
        public MySqlConnection connection = new MySqlConnection("datasource=10.10.10.123; port=3306;Initial Catalog='medlinedb';username=terminal;password=123456;CharSet=utf8;");

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
       
        public bool login(string log, string pass)
        {
            connection.Open();

            string sql = "SELECT u.id,c.id,u.user_name,u.user_login,u.user_password, c.category_suffix FROM users u JOIN " +
                "categories c ON u.user_category_id = c.id " +
                "WHERE u.user_login = '" + log + "' " +
                "AND u.user_password = '" + ComputeSha256Hash(pass) + "'";
            string[] value = new string[7];
            del += db =>
            {
                if (db.Rows.Count > 0)
                {
                    value[1] = db.Rows[0][0].ToString();
                    value[2] = db.Rows[0][1].ToString();
                    value[3] = db.Rows[0][2].ToString();
                    value[4] = db.Rows[0][3].ToString();
                    value[5] = db.Rows[0][4].ToString();
                    value[6] = db.Rows[0][5].ToString();
                }

            };
            SoursData(sql);
            if (value[1] != null && value[6] != "ЛБ" && value[6] != "ЛА")
            {
                ClassStatic.Id = value[1];
                ClassStatic.Cat_Id = value[2];
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
