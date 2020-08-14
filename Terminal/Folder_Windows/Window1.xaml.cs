using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Terminal.Folder_Windows
{
    
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Nevropotolog_Click(object sender, RoutedEventArgs e)
        {
            Nevropotolog.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Нервопотолог", "27", "qwer");
            for_Print.Check_Print();
            Nevropotolog.IsEnabled = true;
        }

        private void Kardiolog_Click(object sender, RoutedEventArgs e)
        {
            Kardiolog.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Кардиолог", "27", "qwer");
            for_Print.Check_Print();
            Kardiolog.IsEnabled = true;
        }

        private void Oftalmolog_Click(object sender, RoutedEventArgs e)
        {
            Oftalmolog.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Офтальмолог", "27", "qwer");
            for_Print.Check_Print(); 
            Oftalmolog.IsEnabled = true;
        }

        private void Gepatolog_Click(object sender, RoutedEventArgs e)
        {
            Gepatolog.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Гепатолог,Гастроэнтролог", "27", "qwer");
            for_Print.Check_Print();
            Gepatolog.IsEnabled = true;
        }

        private void Nefrolog_Click(object sender, RoutedEventArgs e)
        {
            Nefrolog.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Нефролог", "27", "qwer");
            for_Print.Check_Print();
            Nefrolog.IsEnabled = true;
        }

        private void Gemotolog_Click(object sender, RoutedEventArgs e)
        {
            Gemotolog.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Гемотог", "27", "qwer");
            for_Print.Check_Print();
            Gemotolog.IsEnabled = true;
        }

        private void Pediatr_Click(object sender, RoutedEventArgs e)
        {
            Pediatr.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Педиатр", "27", "qwer");
            for_Print.Check_Print();
            Pediatr.IsEnabled = true;
        }

        private void Endokrinolog_Click(object sender, RoutedEventArgs e)
        {
            Endokrinolog.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Эндокринолог", "27", "qwer");
            for_Print.Check_Print();
            Endokrinolog.IsEnabled = true;
        }

        private void Allergolog_Click(object sender, RoutedEventArgs e)
        {
            Allergolog.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Аллерголог", "27", "qwer");
            for_Print.Check_Print();
            Allergolog.IsEnabled = true;
        }

        private void Lor_Click(object sender, RoutedEventArgs e)
        {
            Lor.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Лор", "27", "qwer");
            for_Print.Check_Print();
            Lor.IsEnabled = true;
        }

        private void Stomotolog_Click(object sender, RoutedEventArgs e)
        {
            Stomotolog.IsEnabled = false;
            Zaderjka();
            For_print for_Print = new For_print("Стоматолог", "27", "qwer");
            for_Print.Check_Print();
            Stomotolog.IsEnabled = true;
        }
        public void Zaderjka()
        {
            Sleep_Window sleep_Window = new Sleep_Window();
            sleep_Window.ShowDialog();
        }
    }
}
