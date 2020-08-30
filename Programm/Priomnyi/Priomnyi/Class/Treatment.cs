using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Priomnyi.Class
{
    class Treatment
    {
        Data data=new Data();

        static string[] hranilishe_stroki = { "0", "0", "0", "0", "0", "0" };
        int id_int = 0;

        public string dalee()
        {
            string id = data.DisplayReturn("SELECT MIN(id) FROM queue_reception q WHERE (user_id IS NULL" +
                " OR q.user_id='"+ClassStatic.Id+"') AND DATE(q.created_at)=CURDATE()");
            if (id != "")
            {               
                id_int = Convert.ToInt32(id);
            }
            else { 
                return "пусто"; 
            }
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
                }        
            };
            data.SoursData("SELECT q.id,q.queue_number,c.category_suffix,c.id,q.category_id, q.lang FROM queue_reception q JOIN categories c " +
                "ON q.category_id = c.id " +
                "WHERE q.id = " + id_int + " AND DATE(q.created_at) = CURDATE()");
            data.Registr("UPDATE queue_reception q SET user_id = " + ClassStatic.Id + " WHERE id=" + id_int + " AND DATE(q.created_at)=CURDATE()");
            pozvat();
            return hranilishe_stroki[2] + hranilishe_stroki[1];
        }
        public void s_nap()
        {
            if (hranilishe_stroki[2] == "ЛА") //условие для лаб
            {
                data.Registr("insert into queue_lab1(queue_number, category_id,with_direction,lang) values('" + hranilishe_stroki[1] + "', '" + hranilishe_stroki[4] + "','" + 0 + "','"+ hranilishe_stroki[5] + "')");
            }

            else if (hranilishe_stroki[2] == "ЛБ") //условие для лаб
            {
                data.Registr("insert into queue_lab2(queue_number, category_id,with_direction,lang) values('" + hranilishe_stroki[1] + "', '" + hranilishe_stroki[4] + "','" + 0 + "','"+ hranilishe_stroki[5] + "')");
            }
            else
            {
                data.Registr("insert into queue_users(queue_number, category_id, with_direction,lang) values('" + hranilishe_stroki[1] + "', '" + hranilishe_stroki[4] + "','" + 1 + "','"+ hranilishe_stroki[5] + "')");
            }
        }
        public void bez_nap()
        {
            
                data.Registr("insert into queue_cashier(queue_number, category_id, with_direction,lang) values('" + hranilishe_stroki[1] + "', '" + hranilishe_stroki[4] + "','" + 0 + "','"+ hranilishe_stroki[5] + "')");
            
        }

        public void pozvat()
        {
            string Catid = data.DisplayReturn("SELECT c.id FROM  categories c WHERE c.category_suffix='Регистр'");
            data.Registr("insert into queue_talker(queue_number, category_id,caller_id,lang) values('" + hranilishe_stroki[1] + "', '" + hranilishe_stroki[3] + "','"+ Catid + "','"+ hranilishe_stroki[5] + "')");
            
        }
        public void delete_ocheredi()
        {
            
                data.Registr("DELETE FROM queue_reception WHERE id = " + id_int + "");
            
        }
       

    }
}
