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

namespace КУРСАЧВИКИ
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void ButonPhoto_Click(object sender, RoutedEventArgs e)
        {
            // Создать окно открыть файл
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // устанавливаем ограничения на открытие файла
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            Nullable<bool> result = dlg.ShowDialog();


            // если что-то выбрано то поменять фото
            if (result == true)
            {
                // открыть документ
                string filename = dlg.FileName;
                ImageUser.Source = new BitmapImage(new Uri(filename));
            }
        }

        private void editlogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editpass_Click(object sender, RoutedEventArgs e)
        {

        }

        private void admin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();   
            mainWindow.Show();  
            Close();
        }
    }
}
