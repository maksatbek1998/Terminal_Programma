using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Notifications_Window.Class
{
    class Treatment
    {
        Data data = new Data();

        static string[] hranilishe_stroki = { "0", "0", "0", "0", "0", "0", "0" };
        int id_int = 0;
        static string table = "";
        public string dalee()
        {
            if (ClassStatic.Cat_Id=="ЛА") { 
                table = "queue_lab1"; }
            else if (ClassStatic.Cat_Id == "ЛБ") { 
                table = "queue_lab2"; }
            else { table = "queue_users"; }
            //AND DATE(q.created_at)=CURDATE()
            string id = data.DisplayReturn("SELECT MIN(q.id) FROM " + table + " q WHERE category_id = " + ClassStatic.Cat_Id+ " AND" +
                " (user_id IS NULL OR q.user_id='" + ClassStatic.Id + "') AND  DATE(q.created_at)=CURDATE()");
              if (id != "")
            {
                id_int = Convert.ToInt32(id);
            }
            else { return "пусто"; }
            data = new Data();
            data.del += db =>
            {
                if (db.Rows.Count > 0)
                {
                    hranilishe_stroki[0] = db.Rows[0][0].ToString();
                    hranilishe_stroki[1] = db.Rows[0][1].ToString();
                    hranilishe_stroki[2] = db.Rows[0][2].ToString();
                    hranilishe_stroki[3] = db.Rows[0][3].ToString();
                    hranilishe_stroki[4] = db.Rows[0][4].ToString();
                    hranilishe_stroki[5] = db.Rows[0][5].ToString();
                    hranilishe_stroki[6] = db.Rows[0][6].ToString();
                    
                }
            };
            
            data.SoursData("SELECT q.id,q.queue_number,c.category_suffix,c.id,q.category_id,q.with_direction, q.lang" +
                " FROM " + table + " q JOIN categories c " +
                "ON q.category_id = c.id  WHERE q.id = " + id_int + "  AND DATE(q.created_at)=CURDATE()");
            
            data.Registr("UPDATE "+ table + " q SET user_id = " + ClassStatic.Id + " WHERE queue_number=" + id_int + " AND category_id = " + ClassStatic.Cat_Id + " AND DATE(q.created_at)=CURDATE()");
            pozvat();
            return hranilishe_stroki[2]+hranilishe_stroki[1];
        }
        
        public void history()
        {
            data.Registr("insert into queue_history(queue_number, category_id, user_id, with_direction) " +
                "values('" + hranilishe_stroki[1] + "',' " + hranilishe_stroki[4] + "','"+ ClassStatic.Id + "',' " + hranilishe_stroki[5] + "')");
          }

        public void pozvat()
        {

            data.Registr("insert into queue_talker(queue_number, category_id,lang) " +
                "values('" + hranilishe_stroki[1] + "',' " + ClassStatic.Cat_Id + "','"+ hranilishe_stroki[6] + "')");

        }
        public void delete_ocheredi()
        {

            data.Registr("DELETE FROM " + table + " WHERE id = " + hranilishe_stroki[0] + "");

        }
        
    }
}
