using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio;
using System.Windows;
using Glavnyi_Monitor.All_Clasess;
using System.Threading;

namespace звук.Class
{
    
    public static class Sound
    {
       
        private static NAudio.Wave.BlockAlignReductionStream stream = null;
        private static NAudio.Wave.DirectSoundOut output = null;
       public static string Name="";
        public static string Number="";
        static int muz_id = 0;
        static int check_int = 1;
        static int dlinnie_slova = 1;
        static string[] data_muz = { "", "","", "", "", "", "", "" };
        static string que_num = "";
        public static string Muzic()
        {         
            if (data_muz[1] != "") 
            {
                muz_id++;
            }

            if (muz_id == 0 ) 
            {               
                Data data = new Data();
                data_muz= data.DisplayReturn("SELECT q.id, q.queue_number, " +
                    "c.category_suffix, " +
                    "c.category_name, " +
                    "(SELECT v.category_suffix FROM categories v WHERE q.caller_id = v.id) AS caller, " +
                    " (SELECT v.category_name FROM categories v WHERE q.caller_id =v.id) AS regst, " +
                    " q.lang " +
                    "FROM queue_talker q " +
                    "JOIN categories c ON q.category_id = c.id " +
                    "ORDER BY id LIMIT 1");
                que_num = data_muz[1];
                if (data_muz[1] != "") 
                {
                    muz_id++;                   
                }
            }
            
            if (data_muz[6] == "KG")
            {

                #region KG

                if (muz_id == 1)
                {
                    Soundd(@"kg\" + data_muz[2]);



                    Number = data_muz[2] + data_muz[1];
                    if (data_muz[4] == "Регистр")
                    {
                        Name = data_muz[5];
                    }
                    if (data_muz[4] == "К")
                    {
                        Name = data_muz[5];
                    }
                    if (data_muz[4] == "")
                    {
                        Name = data_muz[3];
                    }
                    return data_muz[1];
                }
                if (muz_id == 2)
                {
                    if (int.Parse(que_num) > 999 && que_num[que_num.Length - 4] != '0')
                    {

                        output = null;
                        Soundd(@"kg\" + que_num[que_num.Length - 4] + "000");
                        return data_muz[1];
                    }
                    else { muz_id++; }
                }
                if (muz_id == 3)
                {
                    if (int.Parse(que_num) > 99 && que_num[que_num.Length - 3] != '0')
                    {
                        output = null;
                        Soundd(@"kg\" + que_num[que_num.Length - 3] + "00");
                        return data_muz[1];
                    }
                    else { muz_id++; }
                }
                if (muz_id == 4)
                {
                    if (int.Parse(que_num) > 9 && que_num[que_num.Length - 2] != '0')
                    {
                        Soundd(@"kg\" + que_num[que_num.Length - 2].ToString() + que_num[que_num.Length - 1].ToString());
                        return data_muz[1];
                    }
                    else if (que_num[que_num.Length - 1] == '0')
                    {
                        return data_muz[1];
                    }
                    else
                    {
                        Soundd(@"kg\" + que_num[que_num.Length - 1].ToString());
                        return data_muz[0];
                    }
                }
                if (muz_id == 6)
                {
                    if (data_muz[4] == "Регистр")
                    {
                        Soundd(@"kg\" + data_muz[4] + data_muz[4]);
                    }
                    if (data_muz[4] == "К")
                    {
                        Soundd(@"kg\" + data_muz[4] + data_muz[4]);
                    }
                    if (data_muz[4] == "")
                    {
                        Soundd(@"kg\" + data_muz[2] + data_muz[2]);
                    }

                }
                if (muz_id == 7)
                {
                    if (dlinnie_slova == 3)
                    {
                        dlinnie_slova = 1;
                        muz_id = 7;
                        return data_muz[0];
                    }
                    if (data_muz[2] == "Е")
                    {
                        muz_id = 6;
                        dlinnie_slova++;
                    }
                    if (data_muz[2] == "ЛА" || data_muz[2] == "ЛБ")
                    {
                        if (dlinnie_slova == 2)
                        {
                            dlinnie_slova = 1;
                            muz_id = 7;
                            return data_muz[0];
                        }
                        muz_id = 6;
                        dlinnie_slova++;
                    }
                }
                if (muz_id == 8)
                {
                    Soundd(@"kg\" + "кел");
                }
                if (muz_id == 9)
                {
                    if (check_int == 2)
                    {
                        check_int = 0;
                        output = null;
                        string retur = data_muz[1];
                        data_muz[1] = "";
                        muz_id = 0;
                        Data data = new Data();
                        data.Registr("DELETE FROM queue_talker WHERE id = " + data_muz[0] + "");
                    }
                    else { muz_id = 0; }
                    check_int++;
                }
                #endregion KG
            }
            if (data_muz[6] == "RU")
            {
                Thread.Sleep(150);

                #region RU
                if (muz_id == 1)
                {
                    Soundd(@"ru\" + data_muz[2]);


                    Number = data_muz[2] + data_muz[1];
                    if (data_muz[4] == "Регистр")
                    {
                        Name = data_muz[5];
                    }
                    if (data_muz[4] == "К")
                    {
                        Name = data_muz[5];
                    }
                    if (data_muz[4] == "")
                    {
                        Name = data_muz[3];
                    }
                    return data_muz[1];
                }
                if (muz_id == 2)
                {
                    if (int.Parse(que_num) > 999 && que_num[que_num.Length - 4] != '0')
                    {

                        output = null;
                        Soundd(@"ru\" + que_num[que_num.Length - 4] + "000");
                        return data_muz[1];
                    }
                    else { muz_id++; }
                }
                if (muz_id == 3)
                {
                    if (int.Parse(que_num) > 99 && que_num[que_num.Length - 3] != '0')
                    {
                        output = null;
                        Soundd(@"ru\" + que_num[que_num.Length - 3] + "00");
                        return data_muz[1];
                    }
                    else { muz_id++; }
                }
                if (muz_id == 4)
                {
                    if (int.Parse(que_num) > 9 && que_num[que_num.Length - 2] != '0')
                    {
                        Soundd(@"ru\" + que_num[que_num.Length - 2].ToString() + que_num[que_num.Length - 1].ToString());
                        return data_muz[1];
                    }
                    else if (que_num[que_num.Length - 1] == '0')
                    {
                        return data_muz[1];
                    }
                    else
                    {
                        Soundd(@"ru\" + que_num[que_num.Length - 1].ToString());
                        return data_muz[0];
                    }
                }
                if (muz_id == 6)
                {
                    if (data_muz[4] == "Регистр")
                    {
                        Soundd(@"ru\" + data_muz[4] + data_muz[4]);
                        muz_id = 8;
                    }
                    if (data_muz[4] == "К")
                    {
                        Soundd(@"ru\" + data_muz[4] + data_muz[4]);
                        muz_id = 8;
                    }
                    if (data_muz[4] == "")
                    {
                        Soundd(@"ru\" + "пройдите в отдел");
                    }

                }
                if (muz_id == 7)
                {
                    Soundd(@"ru\" + data_muz[2] + data_muz[2]);

                }
                if (muz_id == 8)
                {
                    if (dlinnie_slova == 3)
                    {
                        dlinnie_slova = 1;
                        muz_id = 8;
                        return data_muz[0];
                    }
                    if (data_muz[2] == "Е")
                    {
                        muz_id = 7;
                        dlinnie_slova++;
                    }
                    if (data_muz[2] == "ЛА" || data_muz[2] == "ЛБ")
                    {
                        if (dlinnie_slova == 2)
                        {
                            dlinnie_slova = 1;
                            muz_id = 8;
                            return data_muz[0];
                        }
                        muz_id = 7;
                        dlinnie_slova++;
                    }
                }

                if (muz_id == 9)
                {
                    if (check_int == 2)
                    {
                        check_int = 0;
                        output = null;
                        string retur = data_muz[1];
                        data_muz[1] = "";
                        muz_id = 0;
                        Data data = new Data();
                        data.Registr("DELETE FROM queue_talker WHERE id = " + data_muz[0] + "");
                    }
                    else { muz_id = 0; }
                    check_int++;
                }
                return data_muz[1];
                #endregion RU
            }
            return data_muz[1]; 
        }
        public static string Muzic_ru()
        {
            if (data_muz[1] != "")
            {
                muz_id++;
            }

            if (muz_id == 0)
            {
                Data data = new Data();
                data_muz = data.DisplayReturn("SELECT q.id, q.queue_number, " +
                    "c.category_suffix, " +
                    "c.category_name, " +
                    "(SELECT v.category_suffix FROM categories v WHERE q.caller_id = v.id) AS caller, " +
                    " (SELECT v.category_name FROM categories v WHERE q.caller_id =v.id) AS regst " +
                    "FROM queue_talker q " +
                    "JOIN categories c ON q.category_id = c.id " +
                    "ORDER BY id LIMIT 1");
                que_num = data_muz[1];
                if (data_muz[1] != "")
                {
                    muz_id++;
                }
            }
            if (muz_id == 1)
            {
                Soundd(@"ru\"+data_muz[2]);


                Number = data_muz[2] + data_muz[1];
                if (data_muz[4] == "Регистр")
                {
                    Name = data_muz[5];
                }
                if (data_muz[4] == "К")
                {
                    Name = data_muz[5];
                }
                if (data_muz[4] == "")
                {
                    Name = data_muz[3];
                }
                return data_muz[1];
            }
            if (muz_id == 2)
            {
                if (int.Parse(que_num) > 999 && que_num[que_num.Length - 4] != '0')
                {

                    output = null;
                    Soundd(@"ru\" + que_num[que_num.Length - 4] + "000");
                    return data_muz[1];
                }
                else { muz_id++; }
            }
            if (muz_id == 3)
            {
                if (int.Parse(que_num) > 99 && que_num[que_num.Length - 3] != '0')
                {
                    output = null;
                    Soundd(@"ru\" + que_num[que_num.Length - 3] + "00");
                    return data_muz[1];
                }
                else { muz_id++; }
            }
            if (muz_id == 4)
            {
                if (int.Parse(que_num) > 9 && que_num[que_num.Length - 2] != '0')
                {
                    Soundd(@"ru\" + que_num[que_num.Length - 2].ToString() + que_num[que_num.Length - 1].ToString());
                    return data_muz[1];
                }
                else if (que_num[que_num.Length - 1] == '0')
                {
                    return data_muz[1];
                }
                else
                {
                    Soundd(@"ru\" + que_num[que_num.Length - 1].ToString());
                    return data_muz[0];
                }
            }
            if (muz_id == 6)
            {
                if (data_muz[4] == "Регистр")
                {
                    Soundd(@"ru\" + data_muz[4] + data_muz[4]);
                    muz_id = 8;
                }
                if (data_muz[4] == "К")
                {
                    Soundd(@"ru\" + data_muz[4] + data_muz[4]);
                    muz_id = 8;
                }
                if (data_muz[4] == "")
                {
                    Soundd(@"ru\" + "пройдите в отдел");
                }

            }
            if (muz_id == 7)
            {
                Soundd(@"ru\" + data_muz[2] + data_muz[2]);

            }
            if (muz_id == 8)
            {
                if (dlinnie_slova == 3)
                {
                    dlinnie_slova = 1;
                    muz_id = 8;
                    return data_muz[0];
                }
                if (data_muz[2] == "Е")
                {
                    muz_id = 7;
                    dlinnie_slova++;
                }
                if (data_muz[2] == "ЛА" || data_muz[2] == "ЛБ")
                {
                    if (dlinnie_slova == 2)
                    {
                        dlinnie_slova = 1;
                        muz_id = 8;
                        return data_muz[0];
                    }
                    muz_id = 7;
                    dlinnie_slova++;
                }
            }

            if (muz_id == 9)
            {
                if (check_int == 2)
                {
                    check_int = 0;
                    output = null;
                    string retur = data_muz[1];
                    data_muz[1] = "";
                    muz_id = 0;
                    Data data = new Data();
                    data.Registr("DELETE FROM queue_talker WHERE id = " + data_muz[0] + "");
                }
                else { muz_id = 0; }
                check_int++;
            }
            return data_muz[1];
        
    }
        private static void Soundd(string naz)
        {
            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(@"C:\medical\sound\" + naz+ ".mp3"));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();
        }
      
    }
}
