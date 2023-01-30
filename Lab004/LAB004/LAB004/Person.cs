using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB004
{
    internal class Person
    {
        private string name;
        private int age;
        private int Year;


        public Person(string name, int year)
        {
            this.name = name;
            this.Year = year;
            this.age = 2565 - year;
        }

        public int getAge()
        {
            return this.age;
        }

        public string getName()
        {
            return this.name;
        }
    }
}
