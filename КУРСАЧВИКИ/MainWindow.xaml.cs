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

namespace КУРСАЧВИКИ
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAvtorise_Click(object sender, RoutedEventArgs e)
        {
            Avtorise avtorise = new Avtorise();
            avtorise.Show();
            Close();
        }

        private void ButtonRegistr_Click(object sender, RoutedEventArgs e)
        {
            Registr registr = new Registr();
            registr.Show();
            Close ();

        }
    }
}
