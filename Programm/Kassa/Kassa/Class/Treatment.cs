using System;
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
        static string[] hranilishe_stroki = {"0", "0", "0" ,"0"};
        int id_int = 0;
        public string dalee()
        {
            try
            {
                string id = data.DisplayReturn("SELECT MIN(id) FROM queue_cashier WHERE user_id IS NULL");
                id_int = Convert.ToInt32(id.ToString());
                string[] basa_stroka = data.DisplayReturns("SELECT * FROM queue_cashier WHERE id=" + id_int + "");
                data.Registr("UPDATE queue_cashier SET user_id = "+1+" WHERE id="+ id_int + ""); //user_id     для логин пароля кассы, замените *1* на нужную
                hranilishe_stroki[0] = basa_stroka[0];
                hranilishe_stroki[1] = basa_stroka[1];
                hranilishe_stroki[2] = basa_stroka[2];
                hranilishe_stroki[3] = basa_stroka[3];
                pozvat();

                return basa_stroka[1];
            }
            catch 
            { 
                return "пусто"; 
            }

        }
        public void delete_table()
        {
            try
            {
                if (hranilishe_stroki[2] == "4") //условие для лаб
                {
                    data.Registr("insert into queue_lab1(queue_number, category_id) values(" + hranilishe_stroki[1] + ", " + hranilishe_stroki[2] + ")");
                }

                else if (hranilishe_stroki[2] == "5") //условие для лаб
                {
                    data.Registr("insert into queue_lab2(queue_number, category_id) values(" + hranilishe_stroki[1] + ", " + hranilishe_stroki[2] + ")");
                }

                else if (hranilishe_stroki[2] == "3") {/*ну типа касса*/}  //условие для кассы

                else
                {
                    data.Registr("insert into queue_users(queue_number, category_id) values(" + hranilishe_stroki[1] + ", " + hranilishe_stroki[2] + ")"); //врачи
                }
                data.Registr("DELETE FROM queue_cashier WHERE id = " + id_int + "");
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
                data.Registr("insert into queue_talker(queue_number, category_id) values(" + hranilishe_stroki[1] + ", " + hranilishe_stroki[2] + ")");
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
                data.Registr("DELETE FROM queue_cashier WHERE id = " + id_int + "");
            }
            catch
            {
                //если очереди нет и кассир от скуки нажимает кнопки
            }
        }     
    }
}
