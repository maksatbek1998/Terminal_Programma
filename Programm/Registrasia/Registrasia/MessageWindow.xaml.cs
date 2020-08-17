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
using System.Windows.Shapes;

namespace Registrasia
{
    /// <summary>
    /// Логика взаимодействия для MessageWindow.xaml
    /// </summary>
    public partial class MessageWindow : Window
    {
        public delegate void MessageDel();
        public event MessageDel del_;
        DBconnection dbCon = new DBconnection();
        public string Id { get; set; }
        public string TableBasa { get; set; }
        public MessageWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Id != "" && TableBasa != "")
                dbCon.RemoveData(TableBasa, Id);
            del_();
            this.Close();
        }
    }
}
