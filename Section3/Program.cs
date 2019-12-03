using System;

namespace Section3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor Instructor1 = new Instructor("John", "Myer", "English");
            Instructor Instructor2 = new Instructor("Mike", "Green", "Math");
            Student Student1 = new Student("Jane", Instructor1);
            Student Student2 = new Student("Joe", Instructor1);
            Student Student3 = new Student("Melissa", Instructor2);
            Student Student4 = new Student("Mike", Instructor2);

            Instructor1.SetStudentGrade(Student1, 95);
            Instructor1.SetStudentGrade(Student2, 85);
            Instructor2.SetStudentGrade(Student3, 90);
            Instructor2.SetStudentGrade(Student4, 92);

            Instructor1.Print();
            Instructor2.Print();
            Student1.Print();
            Student2.Print();
            Student3.Print();
            Student4.Print();
            System.Console.ReadKey();
        }
    }
}
