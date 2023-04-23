using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] cmds = input.Split(' ');
                Student student = new Student();
                student.firstName = cmds[0];
                student.lastName = cmds[1];
                student.age = Convert.ToInt32(cmds[2]);
                student.homeTown = cmds[3];
                
                students.Add(student);
            }
            
            string city = Console.ReadLine();
            foreach (var student in students)
            {
                if (student.homeTown == city)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }
            
        }
    }

    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string homeTown { get; set; }
        
    }
}