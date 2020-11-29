using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
using Lesson2;

namespace Lesson7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<Student> students = new BindingList<Student>();
        Student student;
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                students.Add(new Student("Moshe"));
            }
            studentListView.DataContext = students;
        }

        private void pbAddStudent_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).IsEnabled = false;
            student = new Student("Yossi");
            student.CreateStudentWorker.RunWorkerCompleted += CreateStudentWorker_RunWorkerCompleted;
        }

        private void CreateStudentWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StudentWindow studentWindow = new StudentWindow(student);
            studentWindow.Closed += StudentWindow_Closed;
            studentWindow.Show();
        }

        private void StudentWindow_Closed(object sender, EventArgs e)
        {
            pbAddStudent.IsEnabled = true;
            students.Add(student);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource studentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            studentViewSource.Source = students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BackgroundWorker createStudent = new BackgroundWorker();
            (sender as Button).IsEnabled = false;
            createStudent.DoWork += CreateStudent_DoWork;
            createStudent.RunWorkerCompleted += CreateStudent_RunWorkerCompleted;
            createStudent.RunWorkerAsync();
        }

        private void CreateStudent_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Student Created Succesfully");
            pbWorker.IsEnabled = true;
        }

        private void CreateStudent_DoWork(object sender, DoWorkEventArgs e)
        {
            students.Add(new Student("Yossi"));
            Thread.Sleep(10000); 

        }

        private void pbBindingStudent_Click(object sender, RoutedEventArgs e)
        {
            new BindingStudentWindow(new Student("Avram")).Show();
        }

        private void pbOneStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = ((sender as Button).DataContext as Student);
        }
    }
}
