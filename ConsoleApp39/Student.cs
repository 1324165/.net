using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Student
    {
        private string firstName { get; }
        private string lastName { get; }
        private string date { get; }

        public void Show()
        {
            Console.WriteLine("{0} {1}, {2}", firstName, lastName, date);
        }
        public string showName()
        {
            return (firstName+" "+lastName);
        }
        public string showDate()
        {
            return (date);
        }
        public Student(string fName, string lName, string d)
        {
            firstName = fName;
            lastName = lName;
            date = d;
        }

    }
}
