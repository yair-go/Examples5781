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

namespace Lesson5_Tal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pbHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello WPF", "Wow");
        }

        private void pbHello_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Button).Content = "Enter";
        }

        private void pbHello_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Button).Content = "Hello";
        }
    }
}
