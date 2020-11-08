using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Person : IComparable
    {
        #region Fields
        private string name;
        private DateTime birthday;
        private int id;

        #endregion

        #region Ctors
        public Person(string name = "", int year = 1970, int month = 1, int day = 1, int id = 1)
        {
            this.Name = name;
            this.Birthday = new DateTime(year,month,day);
            this.id = id;
        }
        #endregion

        #region Properties

        public int Age
        {
            get { return DateTime.Now.Year - Birthday.Year; }
        }

        public string Name { get => name; set => name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public int Id { get => id;  }

        public int CompareTo(object obj)
        {
            return Age.CompareTo((obj as Person).Age);
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{Name} you are {Age} years old";
        }
        #endregion
    }
}
