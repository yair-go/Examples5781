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
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    { 
        public StudentWindow(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                studentGrid.DataContext = student;
            }
        }

      
    }
}
