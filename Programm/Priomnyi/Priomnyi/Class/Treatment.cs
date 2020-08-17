using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priomnyi.Class
{
    class Treatment
    {
        Data data;
        
        static string[] hranilishe_stroki = { "0", "0", "0" };
        int id_int = 0;
        
        public string dalee()
        {
            try
            {
                hranilishe_stroki[1] = "";
                data = new Data();
                data.del += db => {
                    hranilishe_stroki[0] = db.Rows[0][0].ToString();
                    hranilishe_stroki[1] = db.Rows[0][1].ToString();
                    hranilishe_stroki[2] = db.Rows[0][2].ToString();
                };
                data.SoursData("SELECT * FROM queue_reception WHERE id = " + id_int + "");
                string id = data.DisplayReturn("SELECT MIN(id) FROM queue_reception WHERE user_id IS NULL");
                id_int = Convert.ToInt32(id.ToString());
                data.sendP += db1 =>
                {
                    data.Registr("UPDATE queue_reception SET user_id = " + db1 + " WHERE id=" + id_int + "");
                };
                //bool b= data.login();
                

                pozvat();
                
                return hranilishe_stroki[1];
            }
            catch
            {
                return "пусто";
            }

        }
        public void s_nap()
        {
            try
            {
                data.Registr("insert into queue_users(queue_number, category_id, with_direction) values(" + hranilishe_stroki[1] + ", " + hranilishe_stroki[2] + ","+1+ ")");
            }
            catch
            {
                //если очереди нет и кассир от скуки нажимает кнопки
            }
        }
        public void bez_nap()
        {
            try
            {
                data.Registr("insert into queue_cashier(queue_number, category_id, with_direction) values(" + hranilishe_stroki[1] + ", " + hranilishe_stroki[2] + "," + 0 + ")");
            }
            catch
            {
                //если очереди нет и кассир от скуки нажимает кнопки
            }
        }

        public void pozvat()
        {
            try
            {
                data.Registr("insert into queue_talker(queue_number, category_id) values(" + hranilishe_stroki[1] + ", " + 13 + ")");
            }
            catch
            {
                //если очереди нет и кассир от скуки нажимает кнопки
            }
        }
        public void delete_ocheredi()
        {
            try
            {
                data.Registr("DELETE FROM queue_reception WHERE id = " + id_int + "");
            }
            catch
            {
                //если очереди нет и кассир от скуки нажимает кнопки
            }
        }
        
    }
}
