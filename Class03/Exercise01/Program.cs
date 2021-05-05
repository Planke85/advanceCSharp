using System;
using System.Collections.Generic;
using Models;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher(1, "Pera", "Pera", "12345", "PHP");
            Teacher teacher2 = new Teacher(2, "Risto", "Risto", "12345", "C#");

            Student student1 = new Student(3, "Aleksandar", "alex", "alex123", new List<int> { 3, 5, 4, 5, 5, 4, 3 });
            Student student2 = new Student(4, "Ivan", "ivan", "ivan123", new List<int> { 5, 5, 5, 5, 4, 4, 2 });

            Console.WriteLine(teacher1.GetUserInfo());
            Console.WriteLine(teacher2.GetUserInfo());
            Console.WriteLine(student1.GetUserInfo());
            Console.WriteLine(student2.GetUserInfo());
        }
    }
}
