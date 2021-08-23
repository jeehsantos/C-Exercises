using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = 0;
            HashSet<Student> listA = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            students = int.Parse(Console.ReadLine());
            for (int i = 0; i < students; i++)
            {
                int studentId = int.Parse(Console.ReadLine());
                listA.Add(new Student(studentId));
            }
            Console.Write("How many students for course B? ");
            students = int.Parse(Console.ReadLine());
            for (int i = 0; i < students; i++)
            {
                int studentId = int.Parse(Console.ReadLine());
                listA.Add(new Student(studentId));
            }
            Console.Write("How many students for course C? ");
            students = int.Parse(Console.ReadLine());
            for (int i = 0; i < students; i++)
            {
                int studentId = int.Parse(Console.ReadLine());
                listA.Add(new Student(studentId));
            }

            Console.WriteLine("Total students: " + listA.Count());
        }
    }
}
