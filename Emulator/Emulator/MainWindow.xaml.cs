using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
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
using System.Xml.Linq;

namespace Emulator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gimnazia1Entities db = new Gimnazia1Entities();
            db = new Gimnazia1Entities();
        }



        private void Start_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            string Event = "32";
            Events codeStruct = new Events();
            {
               Events codeStruct2 = new Events();
                codeStruct2 = new Events();

            }

        }   
    }
}
