using System;
using System.Collections.Generic;
using System.Text;

namespace Section3
{

    public class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string Name, Instructor Teacher)
        {
            this.Name = Name;
            this.Teacher = Teacher;
            this.Grade = 0;

        }

        public int SetGrade(int Grade)
        {
            return this.Grade = Grade;

        }

        public void Print()
        {
            System.Console.WriteLine("Name: " + this.Name);
            System.Console.WriteLine("Grade: " + this.Grade);
            System.Console.WriteLine(this.Teacher.GiveInfo());
            System.Console.WriteLine();
        }

    }
}
