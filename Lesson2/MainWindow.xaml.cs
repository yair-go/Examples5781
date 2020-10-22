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

namespace Lesson2
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

        private void pb_Console_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person("Moshe");
            p.Birthday = new DateTime(1980, 1, 1);

            //tb_Console.Text = $"Hello {p.Name} You are {p.Age} years old" ;
            tb_Console.Text = $"Hello {p}";
        }
    }
}
