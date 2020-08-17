using Registrasia.ClassFolder;
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

namespace Registrasia
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DBconnection dBconnection = new DBconnection();
        int ID = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ID = dBconnection.DisplayReturn1("SELECT * FROM users WHERE user_login='"+Log.Text.ToString()+"' and user_password='"+Pass.Password.ToString()+"';");
            if (ID!=0)
            {
             AddPeple addPeple = new AddPeple();
             addPeple.Show();
             this.Hide();
            }
            else
            {
                MessParol messParol = new MessParol();
                messParol.Show();
            }
     
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
