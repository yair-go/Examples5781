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

namespace Lesson5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random(DateTime.Now.Millisecond);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pbHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello WPF");
        }

        private void pbBye_Click(object sender, RoutedEventArgs e)
        {

        }

        private void pbHello_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Button).Content = "Enter"; 
        }

        private void pbHello_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Button).Content = "Hello";
        }

        private void pbHello_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            int r = rand.Next(255);
            int g = rand.Next(255);
            int b = rand.Next(255);
            (sender as Button).Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b))); 
        }
    }
}
