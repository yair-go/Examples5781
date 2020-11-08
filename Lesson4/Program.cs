using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson2;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            foreach (Student student in students)
            {
                //    student.Name = Console.ReadLine();
                Console.WriteLine(student);

            }
            //int num;
            //if (getInt(out num))
            //{ }
            //int num2;
            //Int32.TryParse(Console.ReadLine(),out num2);

//DateTime.Now.ToStringProperty();
        //    students.ToStringProperty();
           // students.StudentList.ToStringProperty();
            try
            {
                try
                {
                    throw new NullReferenceException();
                }
                catch (NullReferenceException e)
                {
                    throw new BusStationNotExistException("Bus Station Not Exist", e);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

        private static bool getInt(out int num)
        {
            try
            {
                num = Int32.Parse(Console.ReadLine());
                return true;
            }
            catch (Exception e)
            {
                num = -1;
                return false;
            }
        }
    }
}
