using Registrasia.ClassFolder;
using System.Windows;

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
