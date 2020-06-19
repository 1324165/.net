using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Faculty
    {
        private string faculName { get; }
        private List<Student> students = new List<Student>();

        public void AddStudent(string fName, string lName, string d)
        {
            Student newStudent = new Student(fName, lName, d);
            students.Add(newStudent);
        }

        public string showfaculName()
        {
            return (faculName);
        }

        public void Show()
        {
            foreach (Student item in students)
            {
                item.Show();
            }
        }

        public void RemoveStudent(string name)
        {
            
            foreach (Student item in students)
            {
                if (item.showName() == name)
                {
                    students.Remove(item);
                    break;
                }

            }
            
        }

        public void SearchStudentName(string name)
        {
            foreach (Student item in students)
            {
                if(item.showName() == name)
                {
                    item.Show();
                }
            }
        }

        public void SearchStudentDate(string date)
        {
            foreach (Student item in students)
            {
                if (item.showDate() == date)
                {
                    item.Show();
                }
            }
        }

        public Faculty(string name)
        {
            faculName = name;
        }
    }
}
