using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace Registrasia.ClassFolder
{
    class DBconnection
    {
        public MySqlConnection connection = new MySqlConnection("datasource=Localhost; port=3306;Initial Catalog='medlinedb';username=root;password=123456;CharSet=utf8;");
        public delegate void DisplaySourse(DataTable db);
        public event DisplaySourse eventDysplay; 
        public delegate void DisplaySourse2(string[] a);
        public event DisplaySourse2 eventDysplay2;
        public void RemoveData(string table, string id)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM " + table + " WHERE id = '" + id + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void SoursData(string s)
        {
            try
            {
            connection.Open();            
            MySqlCommand cmd = new MySqlCommand(s,connection);
            cmd.ExecuteNonQuery();
            DataTable dta1 = new DataTable();
            MySqlDataAdapter dataadap = new MySqlDataAdapter(cmd);
            dataadap.Fill(dta1);
            eventDysplay(dta1);
            connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
        public void Display(string s)
        {     
            connection.Open();
            string[] a = new string[100];
            int i = 0;     
            string sql = s;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                a[i] = reader[0].ToString();
                i++;
            }
            connection.Close();
            eventDysplay2(a);
        }
        public int DisplayReturn1(string s)
        {
            connection.Open();
            string sql = s;
            int value = 0;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                value = Convert.ToInt32(reader[0].ToString());

            }
            connection.Close();
            return value;
        }
    }
}
