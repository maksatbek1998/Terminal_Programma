﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Terminal.Folder_Class;
using Terminal.Folder_Windows;

namespace Terminal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /*Program*/
    public partial class MainWindow :Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Saat();
            
           
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Time;
            timer.Start();
            Time_Strart();
           

        }
        dbConnect dbCon;
        int CouuntTimer = 0;
        DateTime thisDay = DateTime.Today;
        ConnectWindow connectWindow;
        void Time(object sender, EventArgs e)
        {
            Saat();
            CouuntTimer++;
            if (CouuntTimer >= 360)
            {
                dbCon = new dbConnect();
                dbCon.ResetConnect();
                CouuntTimer = 0;
            }


        }
        private void Saat()
        {

            DateTime dateTime = DateTime.Now;
            var dateTime1 = DateTime.Now.TimeOfDay;
            Data.Text = dateTime.ToLongDateString();
            var time1 = new TimeSpan(00, 00, 0);
            var time2 = new TimeSpan(10, 00, 0);
            if (time1 > dateTime1 && time2 > dateTime1)
            {
                Hours.Text = "0" + dateTime.ToShortTimeString();
            }
            else
            {
                Hours.Text = dateTime.ToShortTimeString();
            }
        }
        int Metka_Id = 0;
        void Time_Metka(object sender, EventArgs e)
        {
            if (Metka_Id==0)
            {
                Metka.Text = "";
                Metka_Id = 1;
            }
            else
            {
                Metka.Text = ":";
                Metka_Id = 0;
            }
        }
        void Time_Strart()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += Time_Metka;
            timer.Start();
        }
        //дота
        //ыпльлжджфьдфиьджфи
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            kassa.IsEnabled = false;
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(kassa.Content.ToString(), "К" + x,
                y.ToString("dd.MM.yyyy") + "_" + "К_" + x+"_"+StaticClass.Flag);
                for_Print.Check_Print();
                
            };
            dbCon.RegistrOchered("К");
            kassa.IsEnabled = true;
        }
      
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();

            Lab_A.IsEnabled = false;
            
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Lab_A.Content.ToString(), "ЛА" + x,
                 y.ToString("dd.MM.yyyy") + "_" + "ЛА_" + x+"_"+StaticClass.Flag);
                for_Print.Check_Print();
                
            };
            dbCon.RegistrOchered("ЛА");
            
            Lab_A.IsEnabled = true;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            Lab_B.IsEnabled = false;
            Zaderjka();
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Lab_B.Content.ToString(), "ЛБ" + x,
                y.ToString("dd.MM.yyyy") + "_" + "ЛБ_" + x+"_"+StaticClass.Flag);
                for_Print.Check_Print();
                
            };
            dbCon.RegistrOchered("ЛБ");
            Lab_B.IsEnabled = true;
        }
        public  void Zaderjka()
        {
            Sleep_Window sleep_Window = new Sleep_Window();
            sleep_Window.ShowDialog();
        }

    }
}
