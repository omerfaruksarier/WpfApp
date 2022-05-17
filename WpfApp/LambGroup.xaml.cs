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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for LambGroup.xaml
    /// </summary>
    public partial class LambGroup : Page
    {
        public LambGroup()
        {
            InitializeComponent();
        }

        private void Lamb_State(object sender, RoutedEventArgs e)
        {
            var lambState = LambImg.Source;

            var LambOff = "pack://application:,,,/off.png";
            var LambSrc = Convert.ToString(LambImg.Source);
            if (LambSrc == LambOff)
            {
            LambImg.Source = new BitmapImage(new Uri(@"/on.png", UriKind.Relative));

            }
            else
            {
                LambImg.Source = new BitmapImage(new Uri(@"/off.png", UriKind.Relative));
            }

        }
    }
}
