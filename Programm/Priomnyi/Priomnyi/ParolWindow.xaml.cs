﻿using Priomnyi.Class;
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

namespace Priomnyi
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
            if (data.login(log_text.Text,pass_text.Password)==true) 
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
