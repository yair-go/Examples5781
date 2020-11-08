using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Student : Person, IComparable
    {
        private int average;
        static Random rand = new Random();
        public Student(string name = "", int year = 1970, int month = 1, int day = 1, int id = 1) : base(name, year, month, day, id)
        {
            Average = rand.Next(60, 100);
        }

        public int Average { get => average; set => average = value; }

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
