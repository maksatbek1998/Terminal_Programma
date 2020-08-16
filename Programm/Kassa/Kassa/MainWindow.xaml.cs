using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kassa.Class;

namespace Kassa
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Data t = new Data();
        Treatment check = new Treatment();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var desctop = System.Windows.SystemParameters.WorkArea;
            this.Left = desctop.Right - this.Width;
            this.Top = desctop.Bottom - this.Height;
        }
        bool btn = true;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (btn == true) 
            { 
                Label.Text = check.dalee(); 
                btn_1.Content = "Завершить"; 
                btn = false; }
            else 
            {
                check.delete_table();
                Label.Text = ""; 
                btn_1.Content = "Далее";
                btn = true; 
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            check.pozvat();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            check.delete_ocheredi();
        }
    }
}
