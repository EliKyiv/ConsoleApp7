// See https://aka.ms/new-console-template for more information
using MyProgram;
using System;

Teacher teacher = new Teacher();
teacher.Name = "John";
teacher.Lastname = "Wick";
teacher.Age = 40;
teacher.City = "New Mexico";
teacher.Position = "Tenured";

teacher.StudentList.Add("Porky Pig");
teacher.StudentList.Add("Bugs Bunny");
teacher.StudentList.Add("Daffy Duck");

teacher.DescribeYourself();
Console.WriteLine($"Position = {teacher.Position}");
Console.WriteLine("Students:");
teacher.StudentList.ForEach(Console.WriteLine);

namespace MyProgram
{

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }

        public virtual void DescribeYourself()
        {
            System.Console.WriteLine($"Age = {Age}");
            System.Console.WriteLine($"Name = {Name}");
            System.Console.WriteLine($"Lastname = {Lastname}");
            System.Console.WriteLine($"City = {City}");
        }

    }

    public class Student : Person
    {
        public string Year { get; set; }
        public List<string> CourseList = new List<string>();
        public override void DescribeYourself()
        {
            base.DescribeYourself();
            System.Console.WriteLine($"Year = {Year}");
        }
    }

    public class Teacher : Person
    {
        public string Position { get; set; }
        public List<string> StudentList = new List<string>();
        public List<string> CourseList = new List<string>();
    }

    public class Course
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public int Duration { get; set; }
        public int StudentsQty { get; set; }
        public List<string> StudentList = new List<string>();
        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Teacher);
            Console.WriteLine(Duration);
            Console.WriteLine(StudentsQty);
        }

        public Course()
        {
            Name = string.Empty;
            Teacher = string.Empty;
            Duration = 0;
            StudentsQty = 0;
        }

        public Course(string name, string teacher, int duration, int studentsQty)
        {
            Name = name;
            Teacher = teacher;
            Duration = duration;
            StudentsQty = studentsQty;
        }

    }
}

