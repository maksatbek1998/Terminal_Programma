using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Terminal.Folder_Class
{
    class dbConnect
    {


        //public MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='medlinedb';username=root;password=123456;CharSet=utf8;");
        //public MySqlConnection connection = new MySqlConnection("datasource=192.168.0.26; port=3306;Initial Catalog='medlinedb';username=admin;password=server_terminal_2019#;CharSet=utf8;");
        public MySqlConnection connection = new MySqlConnection("datasource=10.10.10.123; port=3306;Initial Catalog='medlinedb';username=terminal;password=123456;CharSet=utf8;");

        public delegate void DisplaySourse(DataTable db);
        public delegate void SendData(string x, DateTime y);
        public delegate void ConnectDelegate();
        public event DisplaySourse eventDysplay;
        public event SendData sendData;
        public event ConnectDelegate ConnectDel;

        public void ResetConnect()
        {
            try { 
            connection.Open();
            connection.Close();
            }
            catch { }

        }

         public void ConnectDB()
        {
            if (connection.State == ConnectionState.Closed)
            {
                try
                {

                    connection.Open();
                    
                }
                catch
                {
                    ConnectDel();
                }

            }
            

        }

        public void SoursData(string s)
        {
            try
            {
                ConnectDB();
                //connection.Open();
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
            catch { }
        }
        public void Registr(string s)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch { }

        }
        
        public void RegistrOchered(string suf)
        {
            try
            {
                string categoryID = "";
                string lastnumber = "";
                string ocheretID = "";
                string curDate = "";
                string curDate2;
                categoryID = DisplayReturn("SELECT id FROM categories c WHERE c.category_suffix = '" + suf + "'");
                /*eventDysplay += data =>
                {
                    ocheretID = data.Rows[0][0].ToString();
                    lastnumber = data.Rows[0][1].ToString();
                };*/
                ocheretID = DisplayReturn("SELECT q.id FROM queue_last_numbering q " +
                    "WHERE DATE(q.created_at) = CURDATE() AND " +
                    "q.category_id ='" + categoryID + "' ");

                if (ocheretID == "")
                {
                    Registr("INSERT INTO queue_last_numbering(category_id,last_number)" +
                        "values('" + categoryID + "','1') ");
                    curDate2 = DisplayReturn("SELECT q.updated_at FROM queue_last_numbering q WHERE q.category_id='" + categoryID + "' AND DATE(q.created_at) = CURDATE()");
                    lastnumber = "1";
                    sendData(lastnumber, Convert.ToDateTime(curDate2));

                }
                else
                {
                    Registr("UPDATE queue_last_numbering " +
                        "SET last_number=(last_number+1) WHERE id = '" + ocheretID + "'");
                    eventDysplay += db =>
                    {
                        lastnumber = db.Rows[0][0].ToString();
                        curDate = db.Rows[0][1].ToString();
                    };

                    SoursData("SELECT q.last_number,q.updated_at FROM queue_last_numbering q " +
                    "WHERE DATE(q.created_at) = CURDATE() AND " +
                    "q.category_id ='" + categoryID + "' ");
                    sendData(lastnumber, Convert.ToDateTime(curDate));

                }

                if (suf == "К")
                {

                    Registr("INSERT INTO queue_cashier(category_id,queue_number,lang)" +
                        "values('" + categoryID + "','" + lastnumber + "','" + StaticClass.Flag + "') ");
                }
                else
                {

                    Registr("INSERT INTO queue_reception(category_id,queue_number,lang)" +
                        "values('" + categoryID + "','" + lastnumber + "','"+StaticClass.Flag+"') ");
                }
            }
            catch { }
        }
        public string DisplayReturn(string s)
        {
            try {
                
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
            catch
            {
                return null;
            }
        }

    }
}
