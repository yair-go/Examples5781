﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Person : IComparable, INotifyPropertyChanged
    {
        #region Fields
        private string name;
        private DateTime birthday;
        private int id;

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

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

        public string Name
        {
            get => name;
            set
            {
                name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        public DateTime Birthday 
        { 
            get => birthday;
            set
            {
                birthday = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Birthday"));
                }
            }
        }
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
