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
using System.Windows.Threading;

namespace Terminal.Folder_Windows
{
    /// <summary>
    /// Логика взаимодействия для Sleep_Window.xaml
    /// </summary>
    public partial class Sleep_Window : Window
    {
        public Sleep_Window()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += Time;
            timer.Start();
        }
        public void Time(object sender,EventArgs e)
        {
            this.Hide();
        }
    }
}
