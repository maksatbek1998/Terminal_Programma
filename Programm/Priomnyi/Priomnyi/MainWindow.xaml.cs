using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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

namespace Priomnyi
{ 
    public partial class MainWindow : Window
    {SQLiteConnection connection = new SQLiteConnection("Data Source=D:\\basa\\asd.db;Version=3;New=False;Compress=True;");
        ConnectingToBase connect = new ConnectingToBase();
        public MainWindow()
        {
            InitializeComponent();
        }

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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tbG.Text =Convert.ToString(DisplayReturn("select dot from nums where id = ( SELECT MIN(id) FROM nums )"));
            Registr("delete from nums where id = ( SELECT MIN(id) FROM nums )");
        }
        
        public void Registr(string s)
        {
            connection.Open();
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public int DisplayReturn(string s)
        {
            int x = 0;
            connection.Open();
            string sql = s, value = "";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                value = reader[0].ToString();

            }
            try
            {
                 x = Convert.ToInt32(value);
            }
            catch 
            { 
                MessageBox.Show("нету никого в очереди"); 
            }
            connection.Close();
            return x;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (tbG.Text != "0" && tbG.Text != "") 
            {
                MessageBox.Show(tbG.Text);
            }
        }
    }
}
