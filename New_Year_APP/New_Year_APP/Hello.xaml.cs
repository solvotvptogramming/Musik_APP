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

namespace New_Year_APP
{
    /// <summary>
    /// Логика взаимодействия для Hello.xaml
    /// </summary>
    public partial class Hello : Page
    {
        private MediaPlayer media1;
        private MediaPlayer mediaPlayer1;
        public Hello()
        {
            InitializeComponent();
            media1 = new MediaPlayer();
            mediaPlayer1 = new MediaPlayer();
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\New_Year_APP\New_Year_APP\bin\Debug\prj_13861024_dfc2f857b7475eac72560212c114170a_1657525217.mp3", UriKind.Absolute));
            mediaPlayer1.Play();
        }
    }
}
