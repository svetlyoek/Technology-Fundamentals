using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{

    public class Startup
    {


        public static void Main()
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                List<string> text = Console.ReadLine().Split().ToList();
                if (text[0] == "end")
                {
                    break;
                }

                string firstName = text[0];
                string lastName = text[1];
                int age = int.Parse(text[2]);
                string city = text[3];

                if (IsStudentExisting(students, firstName, lastName))
                {

                    Student student = GetStudent(students, firstName, lastName, age);
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = city,

                    };
                    students.Add(student);
                }

            }
            string myCity = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == myCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");

                }


            }
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName, int age)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                    existingStudent.Age = age;
                }
            }
            return existingStudent;
        }
    }
}

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}
                
            
        
    



        
    


