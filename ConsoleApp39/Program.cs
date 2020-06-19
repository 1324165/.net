using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University();
            Console.WriteLine("************************************************************************");
            Console.WriteLine("Список команд:");
            Console.WriteLine("Add Faculty - добавить новый факультет");
            Console.WriteLine("Add Student - добавить нового студента");
            Console.WriteLine("Remove Faculty - удалить факультет");
            Console.WriteLine("Remove Student - удалить студента");
            Console.WriteLine("Show Faculty - показать все факультеты");
            Console.WriteLine("Show Student - показать всех студентов факультета");
            Console.WriteLine("Show All Student - показать всех студентов университета");
            Console.WriteLine("Search Student Name - поиск студента по имени");
            Console.WriteLine("Search Student Date - поиск студента по дате рождения");
            Console.WriteLine("Exit - прекратить работу");
            Console.WriteLine("************************************************************************");

            string comand = "";
            string str = "";
            while (comand != "exit")
            {
                comand = Console.ReadLine();
                comand = comand.ToLower();

                if (comand == "add faculty")
                {
                    Console.WriteLine("Введите название факультета:");
                    str = Console.ReadLine();
                    bool k = true;
                    foreach (Faculty item in university.faculties)
                    {
                        if (str == item.showfaculName())
                        {
                            Console.WriteLine("Такой факультет уже существует");
                            k = false;
                            break;
                        }
                    }
                    if (k)
                    {
                        university.AddFaculty(str);
                        Console.WriteLine("Факультет {0} добавлен", str);
                    }
                }

                if (comand == "add student")
                {
                    university.Show();
                    Console.WriteLine("Введите название факультета для добавления студента:");
                    str = Console.ReadLine();
                    foreach (Faculty item in university.faculties)
                    {
                        if (str == item.showfaculName())
                        {
                            Console.WriteLine("Введите имя студента:");
                            string lName = Console.ReadLine();
                            Console.WriteLine("Введите фамилию студента:");
                            string fName = Console.ReadLine();
                            Console.WriteLine("Введите дату рождения:");
                            string d = Console.ReadLine();
                            item.AddStudent(lName, fName, d);
                            Console.WriteLine("Студент {0} добавлен", lName + " " + fName);
                        }
                    }
                }

                if (comand == "remove faculty")
                {
                    university.Show();
                    Console.WriteLine("Введите название факульетета для удаления:");
                    str = Console.ReadLine();
                    university.RemoveFaculty(str);
                    Console.WriteLine("Факультет {0} удален", str);
                }

                if (comand == "remove student")
                {
                    university.Show();
                    Console.WriteLine("Введите название факультета с которого вы хотите удалить студента:");
                    str = Console.ReadLine();
                    foreach(Faculty item in university.faculties)
                    {
                        if (item.showfaculName() == str)
                        {
                            Console.WriteLine("\nСписок студентов:");
                            item.Show();
                            Console.WriteLine("Введите имя и фамилию студента которого хотите удалить");
                            string  str1 = Console.ReadLine();
                            item.RemoveStudent(str1);
                        }
                    }
                }

                if (comand == "show faculty")
                {
                    university.Show();
                }

                if (comand == "show student ")
                {
                    university.Show();
                    Console.WriteLine("Введите название диска для просмотра песен:");
                    str = Console.ReadLine();
                    foreach (Faculty item in university.faculties)
                    {
                        if (item.showfaculName() == str)
                        {
                            Console.WriteLine("\nСписок студентов:");
                            item.Show();
                        }
                    }
                }

                if (comand == "show all student")
                {
                    Console.WriteLine("\nСписок студентов:");
                    foreach (var item in university.faculties)
                    {
                            item.Show();   
                    }
                }

                if (comand == "search student name")
                {
                    Console.WriteLine("Введите имя и фамилию студента");
                    str = Console.ReadLine();
                    foreach (var item in university.faculties)
                    {
                        item.SearchStudentName(str);
                    }
                }

                if (comand == "search student date")
                {
                    Console.WriteLine("Введите дату рождения студента");
                    str = Console.ReadLine();
                    foreach (var item in university.faculties)
                    {
                        item.SearchStudentDate(str);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
