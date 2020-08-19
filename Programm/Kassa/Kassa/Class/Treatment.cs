﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kassa.Class;

namespace Kassa.Class
{
    class Treatment
    {
        Data data = new Data();
        static string[] hranilishe_stroki = {"0", "0", "0"};
        int id_int = 0;
        public string dalee()
        {
            string id = (data.DisplayReturn("SELECT MIN(id) FROM queue_cashier q WHERE user_id IS NULL AND DATE(q.created_at)=CURDATE()")).ToString();
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
                }
            };
            data.SoursData("SELECT * FROM queue_cashier q WHERE id = " + id_int + " AND DATE(q.created_at)=CURDATE()");
            data.Registr("UPDATE queue_cashier q SET user_id = " + ClassStatic.Id + " WHERE id=" + id_int + " AND DATE(q.created_at)=CURDATE()");
            pozvat();
            return sufix(hranilishe_stroki[2])+hranilishe_stroki[1];

        }
        public void delete_table()
        {
            
                //if (hranilishe_stroki[2] == "14") //условие для лаб
                //{
                //    data.Registr("insert into queue_lab1(queue_number, category_id,with_direction) values(" + hranilishe_stroki[1] + ", " + hranilishe_stroki[2] + "," + 0 + ")");
                //}

                //else if (hranilishe_stroki[2] == "15") //условие для лаб
                //{
                //    data.Registr("insert into queue_lab2(queue_number, category_id,with_direction) values(" + hranilishe_stroki[1] + ", " + hranilishe_stroki[2] + "," + 0 + ")");
                //}

                if (hranilishe_stroki[2] == "12") {/*ну типа касса*/}  //условие для кассы

                else
                {
                    data.Registr("insert into queue_users(queue_number, category_id,with_direction) values(" + hranilishe_stroki[1] + ", " + hranilishe_stroki[2] + ","+0+")"); //врачи
                }
                data.Registr("DELETE FROM queue_cashier WHERE id = " + id_int + "");
            
        }


        public void pozvat()
        {
            
             data.Registr("insert into queue_talker(queue_number, category_id) values(" + hranilishe_stroki[1] + ", " +12 + ")"); //тут для голоса
            
        }
        public void delete_ocheredi()
        {
            
            data.Registr("DELETE FROM queue_cashier WHERE id = " + id_int + "");
            
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
                    return "Э";

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
