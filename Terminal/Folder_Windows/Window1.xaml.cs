using System;
using System.Windows;
using Terminal.Folder_Class;

namespace Terminal.Folder_Windows
{

    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private dbConnect dbCon=new dbConnect();

        public Window1()
        {
            InitializeComponent();
        }

        DateTime thisDay = DateTime.Today;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Nevropotolog_Click(object sender, RoutedEventArgs e)
        {
            Nevropotolog.IsEnabled = false;
            Zaderjka();
            string numberOchered = dbCon.RegistrOchered("В");
            For_print for_Print = new For_print("Нервопотолог", numberOchered,
                thisDay.ToString("dd.MM.yyyy") + "_" + "В_" + numberOchered);
            
            for_Print.Check_Print();
            Nevropotolog.IsEnabled = true;
        }

        private void Kardiolog_Click(object sender, RoutedEventArgs e)
        {
            Kardiolog.IsEnabled = false;
            Zaderjka();
            string numberOchered = dbCon.RegistrOchered("Р");
            For_print for_Print = new For_print("Кардиолог", numberOchered,
                thisDay.ToString("dd.MM.yyyy") + "_" + "Р_" + numberOchered);
           
            for_Print.Check_Print();
            Kardiolog.IsEnabled = true;
        }

        private void Oftalmolog_Click(object sender, RoutedEventArgs e)
        {
            Oftalmolog.IsEnabled = false;
            Zaderjka();
            string numberOchered = dbCon.RegistrOchered("Ф");
            For_print for_Print = new For_print("Офтальмолог", numberOchered,
                thisDay.ToString("dd.MM.yyyy") + "_" + "Ф_" + numberOchered);
            for_Print.Check_Print(); 
            Oftalmolog.IsEnabled = true;
        }

        private void Gepatolog_Click(object sender, RoutedEventArgs e)
        {
            Gepatolog.IsEnabled = false;
            Zaderjka();
            string numberOchered = dbCon.RegistrOchered("Э");
            For_print for_Print = new For_print("Гепатолог", numberOchered,
                thisDay.ToString("dd.MM.yyyy") + "_" + "Э_" + numberOchered);
           for_Print.Check_Print();
            Gepatolog.IsEnabled = true;
        }

        private void Nefrolog_Click(object sender, RoutedEventArgs e)
        {
            Nefrolog.IsEnabled = false;
            Zaderjka();
            string numberOchered = dbCon.RegistrOchered("Ф");
            For_print for_Print = new For_print("Нефролог", numberOchered,
                thisDay.ToString("dd.MM.yyyy") + "_" + "Ф_" + numberOchered);
            for_Print.Check_Print();
            Nefrolog.IsEnabled = true;
        }

        private void Gemotolog_Click(object sender, RoutedEventArgs e)
        {
            Gemotolog.IsEnabled = false;
            Zaderjka();
            string numberOchered = dbCon.RegistrOchered("М");
            For_print for_Print = new For_print("Гемотог", numberOchered,
            thisDay.ToString("dd.MM.yyyy") + "_" + "М_" + numberOchered);
            for_Print.Check_Print();
            Gemotolog.IsEnabled = true;
        }

        private void Pediatr_Click(object sender, RoutedEventArgs e)
        {
            Pediatr.IsEnabled = false;
            Zaderjka();
            string numberOchered = dbCon.RegistrOchered("П");
            For_print for_Print = new For_print("Педиатр", numberOchered,
            thisDay.ToString("dd.MM.yyyy") + "_" + "П_" + numberOchered);
            for_Print.Check_Print();
            Pediatr.IsEnabled = true;
        }

        private void Endokrinolog_Click(object sender, RoutedEventArgs e)
        {
            Endokrinolog.IsEnabled = false;
            Zaderjka();
            string numberOchered = dbCon.RegistrOchered("Д");
            For_print for_Print = new For_print("Эндокринолог", numberOchered,
            thisDay.ToString("dd.MM.yyyy") + "_" + "Д_" + numberOchered);
            for_Print.Check_Print();
            Endokrinolog.IsEnabled = true;
        }

        private void Allergolog_Click(object sender, RoutedEventArgs e)
        {
            Allergolog.IsEnabled = false;
            Zaderjka();
            string numberOchered = dbCon.RegistrOchered("А");
            For_print for_Print = new For_print("Аллерголог", numberOchered,
            thisDay.ToString("dd.MM.yyyy") + "_" + "А_" + numberOchered);
            for_Print.Check_Print();
            Allergolog.IsEnabled = true;
        }

        private void Lor_Click(object sender, RoutedEventArgs e)
        {
            Lor.IsEnabled = false;
            Zaderjka();
            string numberOchered = dbCon.RegistrOchered("Л");
            For_print for_Print = new For_print("Лор", numberOchered,
            thisDay.ToString("dd.MM.yyyy") + "_" + "Л_" + numberOchered);
            for_Print.Check_Print();
            Lor.IsEnabled = true;
        }

        private void Stomotolog_Click(object sender, RoutedEventArgs e)
        {
            Stomotolog.IsEnabled = false;
            Zaderjka();
            string numberOchered = dbCon.RegistrOchered("С");
            For_print for_Print = new For_print("Стоматолог", numberOchered,
            thisDay.ToString("dd.MM.yyyy") + "_" + "С_" + numberOchered);
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
