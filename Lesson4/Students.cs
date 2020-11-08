using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson2;

namespace Lesson4
{
    class Students : IEnumerable
    {
        private List<Student> students;

        public Students()
        {
            students = new List<Student>();
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                students.Add(new Student("Yossi", rand.Next(1980, 2000)));
            }
            
        }

        public List<Student> StudentList { get => students; set => students = value; }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }

       
    }
}
