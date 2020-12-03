using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Student : Person, IComparable
    {
        private int average;
        static Random rand = new Random();
        private BackgroundWorker createStudentWorker;

        public Student(string name = "", int year = 1970, int month = 1, int day = 1, int id = 1) : base(name, year, month, day, id)
        {
            CreateStudentWorker = new BackgroundWorker();
            CreateStudentWorker.DoWork += CreateStudent_DoWork;
            createStudentWorker.RunWorkerAsync();
            average = rand.Next(60, 100);
        }

        private void CreateStudent_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);
            e.Result = this;
        }

        public int Average { get => average; set => average = value; }
        public BackgroundWorker CreateStudentWorker { get => createStudentWorker; set => createStudentWorker = value; }

        public override string ToString()
        {
            return base.ToString() + $" Average : {Average}";
        }

        public int CompareTo(object obj)
        {
            return Average.CompareTo((obj as Student).Average);
        }
    }
}
