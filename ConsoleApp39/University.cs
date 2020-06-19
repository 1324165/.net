using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class University
    {
        public List<Faculty> faculties= new List<Faculty>();

        public void AddFaculty(string nameF)
        {
            Faculty newFaculty = new Faculty(nameF);
            faculties.Add(newFaculty);
        }

        public void RemoveFaculty(string nameF)
        {
            foreach (Faculty item in faculties)
            {
                if (item.showfaculName() == nameF)
                {
                    faculties.Remove(item);
                    break;
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("\nСписок факультетов:");
            foreach (Faculty item in faculties)
            {
                Console.WriteLine(item.showfaculName());
            }
        }

    }
}
