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

        static string[] hranilishe_stroki = { "0", "0", "0", "0" };
        int id_int = 0;

        public string dalee()
        {
            //AND DATE(q.created_at)=CURDATE()
            string id = (data.DisplayReturn("SELECT MIN(queue_number) FROM queue_users q WHERE category_id = "+ClassStatic.Cat_Id+ " AND user_id IS NULL AND DATE(q.created_at)=CURDATE()")).ToString();
            if (id != "")
            {
                id_int = Convert.ToInt32(id.ToString());
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
                    hranilishe_stroki[3] = db.Rows[0][4].ToString();
                }
            };
            data.SoursData("SELECT * FROM queue_users q WHERE queue_number = " + id_int + " AND category_id = " + ClassStatic.Cat_Id + " AND DATE(q.created_at)=CURDATE()");
            data.Registr("UPDATE queue_users q SET user_id = " + ClassStatic.Id + " WHERE queue_number=" + id_int + " AND category_id = " + ClassStatic.Cat_Id + " AND DATE(q.created_at)=CURDATE()");
            pozvat();
            return sufix(hranilishe_stroki[2])+hranilishe_stroki[1];
        }
        
        public void history()
        {

            data.Registr("insert into queue_history(queue_number, category_id, user_id, with_direction) values(" + hranilishe_stroki[1] + ", " + hranilishe_stroki[2] + ","+ ClassStatic.Id + ", " + hranilishe_stroki[3] + ")");

        }

        public void pozvat()
        {

            data.Registr("insert into queue_talker(queue_number, category_id) values(" + hranilishe_stroki[1] + ", " + ClassStatic.Cat_Id + ")");

        }
        public void delete_ocheredi()
        {

            data.Registr("DELETE FROM queue_users WHERE id = "+ hranilishe_stroki[0] + "");

        }
        public string sufix(string x)
        {
            switch (x)
            {
                case "1":
                    return "В";

                case "2":
                    return "Р";

                case "3":
                    return "О";

                case "4":
                    return "Е";

                case "5":
                    return "Ф";

                case "6":
                    return "М";

                case "7":
                    return "П";

                case "8":
                    return "Д";

                case "9":
                    return "А";

                case "10":
                    return "Л";

                case "11":
                    return "С";

                case "12":
                    return "К";

                case "13":
                    return "T";

                case "14":
                    return "ЛА";

                case "15":
                    return "ЛБ";

            }

            return "";
        }
    }
}
