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
        Student[] students;
        public MainWindow()
        {
            Random rand = new Random();
            students = new Student[10];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student("Yossi", rand.Next(1980, 2000));
            }

            InitializeComponent();
        }

        private void pb_Console_Click(object sender, RoutedEventArgs e)
        {
            tb_Console.Text = "";
            Person p = new Person("Moshe");
            p.Birthday = new DateTime(1980, 1, 1);

            students.Clone();
            students.First()
            
            Array.Sort(students);

            foreach (Student st in students)
            {
                tb_Console.Text += $"Hello {st}\n";
            }
           

        }
    }
}
