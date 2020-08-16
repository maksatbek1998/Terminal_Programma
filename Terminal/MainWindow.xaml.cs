using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using Terminal.Folder_Windows;

namespace Terminal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /*Program*/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Time;
            timer.Start();
            Time_Strart();
        }
        void Time(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Data.Text = dateTime.ToLongDateString();
            Hours.Text = dateTime.ToShortTimeString();
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            kassa.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Касса", "27", "20.10.2020_27");
            for_Print.Check_Print();
            kassa.IsEnabled = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Lab_A.IsEnabled = false;  
            Zaderjka();
            For_print for_Print = new For_print("Лаборатория(А)", "27", "qwer");
            for_Print.Check_Print();
            Lab_A.IsEnabled = true;         
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Lab_B.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Лаборатория(Б)", "27", "qwer");
            for_Print.Check_Print();
            Lab_B.IsEnabled = true;
        }
        public void Zaderjka()
        {
            Sleep_Window sleep_Window = new Sleep_Window();
            sleep_Window.ShowDialog();
        }

    }
}
