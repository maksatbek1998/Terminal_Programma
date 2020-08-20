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
        private dbConnect dbCon;

        public Window1()
        {
            InitializeComponent();
        }

        DateTime thisDay = DateTime.Today;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Nevropotolog_Click(object sender, RoutedEventArgs e)
        {
            Nevropotolog.IsEnabled = false;
            Zaderjka();
            dbCon = new dbConnect();
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print("Нервопотолог", "В" + x,
                    y.ToString("dd.MM.yyyy") + "_" + "В_" + x);

                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("В");
            Nevropotolog.IsEnabled = true;
        }

        private void Kardiolog_Click(object sender, RoutedEventArgs e)
        {
            Kardiolog.IsEnabled = false;
            Zaderjka();
            dbCon = new dbConnect();
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print("Кардиолог", "Р" + x,
                y.ToString("dd.MM.yyyy") + "_" + "Р_" + x);

                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("Р");
            Kardiolog.IsEnabled = true;
        }

        private void Oftalmolog_Click(object sender, RoutedEventArgs e)
        {
            Oftalmolog.IsEnabled = false;
            Zaderjka();
            dbCon = new dbConnect();
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print("Офтальмолог", "О" + x,
                y.ToString("dd.MM.yyyy") + "_" + "О_" + x);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("О");
            Oftalmolog.IsEnabled = true;
        }

        private void Gepatolog_Click(object sender, RoutedEventArgs e)
        {
            Gepatolog.IsEnabled = false;
            Zaderjka();
            dbCon = new dbConnect();
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print("Гепатолог", "Е" + x,
                y.ToString("dd.MM.yyyy") + "_" + "Е_" + x);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("Е");
            Gepatolog.IsEnabled = true;
        }

        private void Nefrolog_Click(object sender, RoutedEventArgs e)
        {
            Nefrolog.IsEnabled = false;
            Zaderjka();
            dbCon = new dbConnect();
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print("Нефролог", "Ф" + x,
                y.ToString("dd.MM.yyyy") + "_" + "Ф_" + x);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("Ф");
            Nefrolog.IsEnabled = true;
        }

        private void Gemotolog_Click(object sender, RoutedEventArgs e)
        {
            Gemotolog.IsEnabled = false;
            Zaderjka();
            dbCon = new dbConnect();
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print("Гемотог", "М" + x,
            y.ToString("dd.MM.yyyy") + "_" + "М_" + x);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("М");
            Gemotolog.IsEnabled = true;
        }

        private void Pediatr_Click(object sender, RoutedEventArgs e)
        {
            Pediatr.IsEnabled = false;
            Zaderjka();
            dbCon = new dbConnect();
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print("Педиатр", "П" + x,
            y.ToString("dd.MM.yyyy") + "_" + "П_" + x);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("П");
            Pediatr.IsEnabled = true;
        }

        private void Endokrinolog_Click(object sender, RoutedEventArgs e)
        {
            Endokrinolog.IsEnabled = false;
            Zaderjka();
            dbCon = new dbConnect();
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print("Эндокринолог", "Д" + x,
            y.ToString("dd.MM.yyyy") + "_" + "Д_" + x);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("Д");
            Endokrinolog.IsEnabled = true;
        }

        private void Allergolog_Click(object sender, RoutedEventArgs e)
        {
            Allergolog.IsEnabled = false;
            Zaderjka();
            dbCon = new dbConnect();
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print("Аллерголог", "А" + x,
            y.ToString("dd.MM.yyyy") + "_" + "А_" + x);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("А");
            Allergolog.IsEnabled = true;
        }

        private void Lor_Click(object sender, RoutedEventArgs e)
        {
            Lor.IsEnabled = false;
            Zaderjka();
            dbCon = new dbConnect();
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print("Лор", "Л" + x,
            y.ToString("dd.MM.yyyy") + "_" + "Л_" + x);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("Л");
            Lor.IsEnabled = true;
        }

        private void Stomotolog_Click(object sender, RoutedEventArgs e)
        {
            Stomotolog.IsEnabled = false;
            Zaderjka();
            dbCon = new dbConnect();
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print("Стоматолог", "С" + x,
            y.ToString("dd.MM.yyyy") + "_" + "С_" + x);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("С");
            Stomotolog.IsEnabled = true;
        }
        public void Zaderjka()
        {
            Sleep_Window sleep_Window = new Sleep_Window();
            sleep_Window.ShowDialog();
        }
    }
}
