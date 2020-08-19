using Notifications_Window.Class;
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

namespace Notifications_Window
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            zvonok.IsEnabled = false;
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
            userText.Text = ClassStatic.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        Treatment check = new Treatment();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        bool btn = true;
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (btn == true)
            {
                Label.Text = check.dalee();
                if (Label.Text != "пусто")
                {
                    zvonok.IsEnabled = true;
                    Next.Content = "Завершить";
                    btn = false;   // bool для поведения кнопки }
                }
            }
            else
            {
                zvonok.IsEnabled = false;
                check.history();
                check.delete_ocheredi();
                Label.Text = "";
                Next.Content = "Далее";
                btn = true;   // bool для поведения кнопки
            }
        }

        private void zvonok_Click(object sender, RoutedEventArgs e)
        {
            if(btn == true)
            {
                check.pozvat();
            }
        }
    }
}
