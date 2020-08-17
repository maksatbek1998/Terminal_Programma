using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Glavnyi_Monitor
{
    /// <summary>
    /// Логика взаимодействия для Proba2.xaml
    /// </summary>
    public partial class Proba2 : Window
    {
        public Proba2()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Time1;
            timer.Start();
            btn_Click();
        }
        public void Time1(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Date.Text = dateTime.ToLongDateString();
            Time.Text = dateTime.ToShortTimeString();
        }
        private void btn_Click()
        {
            Storyboard sb = this.FindResource("Kalomka_Animation") as Storyboard;
            sb.Begin();
            Storyboard sb1 = this.FindResource("TextBloc_Animated") as Storyboard;
            sb1.Begin();
        }
    }
}
