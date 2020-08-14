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
    public partial class MainWindow : Window
    {
        int Chet = 0;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            kassa.IsEnabled = false;
            For_print for_Print = new For_print("Касса","27", "qwer");
            for_Print.Check_Print();          
            Thread.Sleep(600);
            kassa.IsEnabled = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Lab_A.IsEnabled = false;
            For_print for_Print = new For_print("Лаборатория(А)", "27", "qwer");
            for_Print.Check_Print();
            Thread.Sleep(600);
            Lab_A.IsEnabled = true;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Lab_B.IsEnabled = false;
            For_print for_Print = new For_print("Лаборатория(Б)", "27", "qwer");
            for_Print.Check_Print();
            Thread.Sleep(600);
            Lab_B.IsEnabled = true;
        }
    }
}
