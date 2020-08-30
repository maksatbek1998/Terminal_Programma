using System;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using Terminal.Folder_Class;

namespace Terminal.Folder_Windows
{

    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private dbConnect dbCon;
        private int i = 0;
        ConnectWindow connectWindow;
        public Window1()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (object sender, EventArgs e)=> {
                i++;
                if (i >= 25)
                {
                    this.Hide();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    timer.Stop();
                }
            };
            timer.Start();
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
            i = 0;
            Nevropotolog.IsEnabled = false;
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
           
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Nevropotolog.Content.ToString().Substring(3), "В" + x,
                    y.ToString("dd.MM.yyyy") + "_" + "В_" + x+"_"+StaticClass.Flag);

                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("В");
            Nevropotolog.IsEnabled = true;
        }

        private void Kardiolog_Click(object sender, RoutedEventArgs e)
        {

            i = 0;
            Kardiolog.IsEnabled = false;
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Kardiolog.Content.ToString().Substring(3), "Р" + x,
                y.ToString("dd.MM.yyyy") + "_" + "Р_" + x+"_"+StaticClass.Flag);

                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("Р");
            Kardiolog.IsEnabled = true;
        }

        private void Oftalmolog_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            Oftalmolog.IsEnabled = false;
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Oftalmolog.Content.ToString().Substring(3), "О" + x,
                y.ToString("dd.MM.yyyy") + "_" + "О_" + x+"_"+StaticClass.Flag);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("О");
            Oftalmolog.IsEnabled = true;
        }

        private void Gepatolog_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            Gepatolog.IsEnabled = false;
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Gepatolog.Content.ToString().Substring(3), "Е" + x,
                y.ToString("dd.MM.yyyy") + "_" + "Е_" + x+"_"+StaticClass.Flag);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("Е");
            Gepatolog.IsEnabled = true;
        }

        private void Nefrolog_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            Nefrolog.IsEnabled = false;
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Nefrolog.Content.ToString().Substring(3), "Ф" + x,
                y.ToString("dd.MM.yyyy") + "_" + "Ф_" + x+"_"+StaticClass.Flag);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("Ф");
            Nefrolog.IsEnabled = true;
        }

        private void Gemotolog_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            Gemotolog.IsEnabled = false;
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Gemotolog.Content.ToString().Substring(3), "М" + x,
            y.ToString("dd.MM.yyyy") + "_" + "М_" + x+"_"+StaticClass.Flag);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("М");
            Gemotolog.IsEnabled = true;
        }

        private void Pediatr_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            Pediatr.IsEnabled = false;
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Pediatr.Content.ToString().Substring(3), "П" + x,
            y.ToString("dd.MM.yyyy") + "_" + "П_" + x+"_"+StaticClass.Flag);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("П");
            Pediatr.IsEnabled = true;
        }

        private void Endokrinolog_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            Endokrinolog.IsEnabled = false;
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Endokrinolog.Content.ToString().Substring(3), "Д" + x,
            y.ToString("dd.MM.yyyy") + "_" + "Д_" + x+"_"+StaticClass.Flag);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("Д");
            Endokrinolog.IsEnabled = true;
        }


        private void Allergolog_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            Allergolog.IsEnabled = false;
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Allergolog.Content.ToString().Substring(3), "А" + x,
            y.ToString("dd.MM.yyyy") + "_" + "А_" + x+"_"+StaticClass.Flag);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("А");
            Allergolog.IsEnabled = true;
        }

        private void Lor_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            Lor.IsEnabled = false;
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Lor.Content.ToString().Substring(3), "Л" + x,
            y.ToString("dd.MM.yyyy") + "_" + "Л_" + x+"_"+StaticClass.Flag);
                for_Print.Check_Print();
            };
            dbCon.RegistrOchered("Л");
            Lor.IsEnabled = true;
        }

        private void Stomotolog_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            Stomotolog.IsEnabled = false;
            Thread myThread = new Thread(new ThreadStart(Zaderjka));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            dbCon = new dbConnect();
            dbCon.ConnectDel += () => {
                connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            };
            dbCon.sendData += (x, y) =>
            {
                For_print for_Print = new For_print(Lor.Content.ToString().Substring(3), "С" + x,
            y.ToString("dd.MM.yyyy") + "_" + "С_" + x+"_"+StaticClass.Flag);
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
