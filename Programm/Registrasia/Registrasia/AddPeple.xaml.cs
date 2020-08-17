using Registrasia.ClassFolder;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace Registrasia
{
    /// <summary>
    /// Логика взаимодействия для AddPeple.xaml
    /// </summary>
    public partial class AddPeple : Window
    {
        DBconnection dBconnection = new DBconnection();
        int ID { get; set; } = 0;
        public AddPeple()
        {
            InitializeComponent();
            information();
            Comboboxitem();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        string id = "";
        string name = "";
        private void dataGridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView dataRow2 = (DataRowView)dataGridView1.SelectedItem;
            if (dataRow2 != null)
            {
                id = dataRow2.Row.ItemArray[0].ToString();
                name = dataRow2.Row.ItemArray[1].ToString();

            }
        }
        string id_1 = "";
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DataRowView dataRow = (DataRowView)dataGridView1.SelectedItem;
            if (dataRow != null)
            {
                id_1 = dataRow.Row.ItemArray[0].ToString();
                MessageWindow message_Window = new MessageWindow();
                if (id_1 != "")
                {
                    message_Window.Id = id_1;
                    message_Window.TableBasa = "users";
                    message_Window.del_ += () => information();
                    message_Window.ShowDialog();
                }
            }
        }
        public void information()
        {
            dBconnection.eventDysplay += delegate (DataTable db)
            {
                dataGridView1.DataContext = db;
            };
            dBconnection.SoursData("SELECT users.id,user_name,user_login,user_password,categories.category_name AS category FROM users,categories WHERE users.user_category_id=categories.id");
        }
        void Comboboxitem()
        {
            dBconnection.eventDysplay2 += delegate (string[] db)
            {
                Profess.ItemsSource = db;
            };
            dBconnection.Display("SELECT category_name FROM categories;");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            dBconnection.Registr("INSERT INTO users(user_name,user_login,user_password,user_category_id) VALUES ('"+Fio.Text+ "','" + Login.Text + "','" + Pass.Text + "','"+ID.ToString()+"');");
            Fio.Text = "";
            Profess.Text = "";
            Login.Text = "";
            Pass.Text = "";
            information();
        }

        private void Profess_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ID=dBconnection.DisplayReturn1("SELECT id FROM categories where category_name='"+Profess.SelectedValue+"';");
        }
    }
}
