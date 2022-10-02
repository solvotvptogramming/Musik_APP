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

namespace Grid_Base
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Users db;

        public MainWindow()
        {
            var db = new vlad_uEntities();
            InitializeComponent();
            db = new vlad_uEntities(); // инициализируем бд, при отрисовки страницы
            dataView.ItemsSource = db.Users.ToList();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            var db = new vlad_uEntities();
            db.SaveChanges();
        }

        private void addItemButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void removeItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saveButton_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
