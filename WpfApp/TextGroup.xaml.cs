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
    /// Interaction logic for TextGroup.xaml
    /// </summary>
    public partial class TextGroup : Page
    {
        public TextGroup()
        {
            InitializeComponent();
        }

        private void Random_Num(object sender, RoutedEventArgs e)
        {
            Random slumpGenerator = new Random();

            int rndmNum = slumpGenerator.Next(0, 1000);

            TextBox.Text += rndmNum.ToString();
        }
    }
}
