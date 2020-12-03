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
using Lesson2;

namespace Lesson7
{
    /// <summary>
    /// Interaction logic for BindingStudentWindow.xaml
    /// </summary>
    public partial class BindingStudentWindow : Window
    {
        Student student;

        public BindingStudentWindow(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                this.student = student;
            }
            else
            {
                this.student = new Student();
            }
            studentGrid.DataContext = this.student;
        }

        private void pbUpdateName_Click(object sender, RoutedEventArgs e)
        {
            this.student.Name = "Yisrael";
            this.student.Birthday = new DateTime(2000, 1, 1);
        }
    }
}
