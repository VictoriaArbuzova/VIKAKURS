﻿using System;
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

namespace КУРСАЧВИКИ
{
    /// <summary>
    /// Логика взаимодействия для Avtorise.xaml
    /// </summary>
    public partial class Avtorise : Window
    {
        public Avtorise()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
