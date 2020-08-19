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
using Priomnyi.Class;

namespace Priomnyi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            s_nap_btn.IsEnabled = false;
            bez_nap_btn.IsEnabled = false;
            delete_btn.IsEnabled = false;
            golos_btn.IsEnabled = false;
        }
        Treatment check = new Treatment();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var desctop = System.Windows.SystemParameters.WorkArea;
            this.Left = desctop.Right - this.Width;
            this.Top = desctop.Bottom - this.Height;
        }

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

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            
                Next.IsEnabled = false;
                s_nap_btn.IsEnabled = true;
                bez_nap_btn.IsEnabled = true;
                delete_btn.IsEnabled = true;
                golos_btn.IsEnabled = true;
                //Next.Content = "Заверщить";
                Label.Text= check.dalee();

        }
        private void golos_btn_Click(object sender, RoutedEventArgs e)
        {
            check.pozvat();
        }

        private void s_nap_btn_Click(object sender, RoutedEventArgs e)
        {
            Next.IsEnabled = true;
            s_nap_btn.IsEnabled = false;
            bez_nap_btn.IsEnabled = false;
            delete_btn.IsEnabled = false;
            golos_btn.IsEnabled = false;
            Label.Text = "";
            check.s_nap();
            check.delete_ocheredi();
        }

        private void bez_nap_btn_Click(object sender, RoutedEventArgs e)
        {
            Next.IsEnabled = true;
            s_nap_btn.IsEnabled = false;
            bez_nap_btn.IsEnabled = false;
            delete_btn.IsEnabled = false;
            golos_btn.IsEnabled = false;
            Label.Text = "";
            check.bez_nap();
            check.delete_ocheredi();
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("удалить очер?", "удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                Next.IsEnabled = true;
                s_nap_btn.IsEnabled = false;
                bez_nap_btn.IsEnabled = false;
                delete_btn.IsEnabled = false;
                golos_btn.IsEnabled = false;
                Label.Text = "";
                check.delete_ocheredi();
                
            }
            else
            {

            }
        }
    }
}
