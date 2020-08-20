using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Glavnyi_Monitor.All_Clasess
{
    class dbConnect
    {


        public MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='medlinedb';username=root;password=123456;CharSet=utf8;");

        public delegate void DisplaySourse(DataTable db);
        public event DisplaySourse eventDysplay;
        public event DisplaySourse del;
        
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

       
        public  void RegistrOchered()
        {
           DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2.5);
            timer.Tick += delegate (object sender, EventArgs e) {
                eventDysplay += db =>
                {
                    del(db);
                };
                SoursData("SELECT q.queue_number,c.category_suffix FROM queue_users q JOIN categories c ON q.category_id=c.id " +
                    "AND q.user_id IS NOT NULL AND DATE(q.created_at) = CURDATE() " +
                    "ORDER BY queue_number");
                
            };
            timer.Start();
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
