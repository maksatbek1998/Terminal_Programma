using Glavnyi_Monitor.All_Clasess;
using System;
using System.Data;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Glavnyi_Monitor
{
    /// <summary>
    /// Логика взаимодействия для Proba2.xaml
    /// </summary>
    public partial class Proba2 : Window
    {
        dbConnect dbCon;
        public Proba2()
        {
            dbCon = new dbConnect();
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Time1;
            timer.Start();
            btn_Click();
            int t = 0, t2=0, t3=0, t4=0, t5=0, t6=0, t7=0, t8=0, t9=0, t10=0, t11=0;
            string[] a = new string[5];
            string[] a1 = new string[5];
            string[] a2 = new string[5];
            string[] a3 = new string[5];
            string[] a4 = new string[5];
            string[] a5 = new string[5];
            string[] a6 = new string[5];
            string[] a7 = new string[5];
            string[] a8 = new string[5];
            string[] a9 = new string[5];
            string[] a10 = new string[5];
             
            dbCon.del += i => {

                a[1] = ""; a[2] = ""; a[3] = "";
                a1[1] = ""; a1[2] = ""; a1[3] = "";
                a2[1] = ""; a2[2] = ""; a2[3] = "";
                a3[1] = ""; a3[2] = ""; a3[3] = "";
                a4[1] = ""; a4[2] = ""; a4[3] = "";
                a5[1] = ""; a5[2] = ""; a5[3] = "";
                a6[1] = ""; a6[2] = ""; a6[3] = "";
                a7[1] = ""; a7[2] = ""; a7[3] = "";
                a8[1] = ""; a8[2] = ""; a8[3] = "";
                a9[1] = ""; a9[2] = ""; a9[3] = "";
                a10[1] = ""; a10[2] = ""; a10[3] = "";

                for (int j = 0; j < i.Rows.Count; j++)
                {
                    
                    if (i.Rows[j][1].ToString() == "В") {
                        t++;
                        a[t]="В"+ i.Rows[j][0].ToString();
                    }
                    if (i.Rows[j][1].ToString() == "Р")
                    {   t2++;
                        a1[t2] = "Р" + i.Rows[j][0].ToString();
                    }
                    if (i.Rows[j][1].ToString() == "О")
                    {
                        t3++;
                        a2[t3] = "О" + i.Rows[j][0].ToString();
                    }

                    if (i.Rows[j][1].ToString() == "Е")
                    {
                        t4++;
                        a3[t4] = "Е" + i.Rows[j][0].ToString();
                    }
                    if (i.Rows[j][1].ToString() == "Ф")
                    {
                        t5++;
                        a4[t5] = "Ф" + i.Rows[j][0].ToString();
                    }
                    if (i.Rows[j][1].ToString() == "М")
                    {
                        t6++;
                        a5[t6] = "М" + i.Rows[j][0].ToString();
                    }

                    if (i.Rows[j][1].ToString() == "П")
                    {
                        t7++;
                        a6[t7] = "П" + i.Rows[j][0].ToString();
                    }
                    if (i.Rows[j][1].ToString() == "Д")
                    {
                        t8++;
                        a7[t8] = "Д" + i.Rows[j][0].ToString();
                    }
                    if (i.Rows[j][1].ToString() == "А")
                    {
                        t9++;
                        a8[t9] = "А" + i.Rows[j][0].ToString();
                    }
                    if (i.Rows[j][1].ToString() == "Л")
                    {
                        t10++;
                        a9[t10] = "Л" + i.Rows[j][0].ToString();
                    }
                    if (i.Rows[j][1].ToString() == "С")
                    {
                        t11++;
                        a9[t11] = "С" + i.Rows[j][0].ToString();
                    }
                }
             

                t = 0; t2=0; t3=0; t4=0; t5=0; t6=0; t7=0; t8=0; t9=0; t10=0; t11=0;
                V1.Text = a[1]; V2.Text = a[2]; V3.Text = a[3];
                R1.Text = a1[1]; R2.Text = a1[2]; R3.Text = a1[3];
                O1.Text = a2[1]; O2.Text = a2[2]; O3.Text = a2[3];
                E1.Text = a3[1]; E2.Text = a3[2]; E3.Text = a3[3];
                F1.Text = a4[1]; F2.Text = a4[2]; F3.Text = a4[3];
                M1.Text = a5[1]; M2.Text = a5[2]; M3.Text = a5[3];
                P1.Text = a6[1]; P2.Text = a6[2]; P3.Text = a6[3];
                D1.Text = a7[1]; D2.Text = a7[2]; D3.Text = a7[3];
                A1.Text = a8[1]; A2.Text = a8[2]; A3.Text = a8[3];
                L1.Text = a9[1]; L2.Text = a9[2]; L3.Text = a9[3];
                C1.Text = a10[1]; C2.Text = a10[2]; C3.Text = a10[3];
               
            };
            dbCon.RegistrOchered();
        }
        
        public void Time1(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Date.Text = dateTime.ToLongDateString();
            var dateTime1 = DateTime.Now.TimeOfDay;
            var time1 = new TimeSpan(00, 00, 0);
            var time2 = new TimeSpan(10, 00, 0);
            if (time1 > dateTime1 && time2 > dateTime1)
            {
                Time.Text = "0" + dateTime.ToShortTimeString();
            }
            else
            {
                Time.Text = dateTime.ToShortTimeString();
            }
        }
       
        private void btn_Click()
        {
            Storyboard sb = this.FindResource("Kalomka_Animation") as Storyboard;
            sb.Begin();
            Storyboard sb1 = this.FindResource("TextBloc_Animated") as Storyboard;
            sb1.Begin();
        }
    }
}
