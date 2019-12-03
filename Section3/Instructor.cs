using System;
using System.Collections.Generic;
using System.Text;

namespace Section3
{
    public class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string FirstName, string LastName, string CourseName)
        {
            this.Name = FirstName + " " + LastName;
            this.CourseName = CourseName;
        }

        public int SetStudentGrade(Student Name, int Grade)
        {

            return Name.SetGrade(Grade);

        }

        public string GiveInfo()
        {
            return "Teacher: " + Name;

        }
        public void Print()
        {
            System.Console.WriteLine("Teacher: " + this.Name);
            System.Console.WriteLine("Course: " + this.CourseName);
            System.Console.WriteLine();
        }
    }
}
