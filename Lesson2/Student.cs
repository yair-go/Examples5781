using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Student : Person
    {
        public Student(string name = "", int year = 1970, int month = 1, int day = 1, int id = 1) : base(name, year, month, day, id)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
