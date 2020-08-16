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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Glavnyi_Monitor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn_Click();
   
        }
        private void btn_Click()
        {
            Storyboard sb = this.FindResource("Kalomka_Animation") as Storyboard;
            sb.Begin();
            Storyboard sb1 = this.FindResource("TextBloc_Animated") as Storyboard;
            sb1.Begin();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
              c1.To = -Win.ActualHeight*2.6;
            f1.Height = Win.ActualHeight * 2.6;
            f2.Height = Win.ActualHeight * 2.6;
        }
    }
}
