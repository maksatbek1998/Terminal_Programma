using System.Windows;
using Kassa.Class;
namespace Kassa
{
    /// <summary>
    /// Логика взаимодействия для ParolWindow.xaml
    /// </summary>
    public partial class ParolWindow : Window
    {
        public ParolWindow()
        {
            InitializeComponent();
        }
        Data data = new Data();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (data.login(log_text.Text, pass_text.Password) == true)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                log_text.Text = "";
                pass_text.Password = "";
                MessageBox.Show("Не верный логин или пароль");
            }
        }
    }
}
