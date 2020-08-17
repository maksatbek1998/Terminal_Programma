using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Folder_Class
{
    class dbConnect
    {


        public MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='medlinedb';username=root;password=123456;CharSet=utf8;");
        
        public delegate void DisplaySourse(DataTable db);
        public event DisplaySourse eventDysplay;
        public delegate void SendData(string x,string y);
        public event SendData sendData;
       
        
        
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
            eventDysplay(dta1);
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
        
        public string RegistrOchered(string suf)
        {
            string categoryID = "";
            string lastnumber = "";
            string ocheretID = "";
             categoryID = DisplayReturn("SELECT id FROM categories c WHERE c.category_suffix = '"+suf+"'");
            /*eventDysplay += data =>
            {
                ocheretID = data.Rows[0][0].ToString();
                lastnumber = data.Rows[0][1].ToString();
            };*/
            ocheretID = DisplayReturn( "SELECT q.id FROM queue_last_numbering q " +
                "WHERE DATE(q.created_at) = CURDATE() AND " +
                "q.category_id ='"+ categoryID + "' ");
            
            if (ocheretID == "")
            {
                Registr("INSERT INTO queue_last_numbering(category_id,last_number)" +
                    "values('"+ categoryID + "','1') ");
                lastnumber = "1";

            }
            else
            {
                Registr("UPDATE queue_last_numbering " +
                    "SET last_number=(last_number+1) WHERE id = '" + ocheretID + "'");
                lastnumber = DisplayReturn( "SELECT q.last_number FROM queue_last_numbering q " +
                "WHERE DATE(q.created_at) = CURDATE() AND " +
                "q.category_id ='" + categoryID + "' ");
                
            }

            if (suf=="К")
            {
                
                Registr("INSERT INTO queue_cashier(category_id,queue_number)" +
                    "values('" + categoryID + "','"+ lastnumber + "') ");
            }
            else
            {
                Registr("INSERT INTO queue_reception(category_id,queue_number)" +
                    "values('" + categoryID + "','" + lastnumber + "') ");
            }
            return lastnumber;
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
