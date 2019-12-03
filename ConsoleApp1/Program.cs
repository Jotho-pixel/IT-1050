using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            P1.PersonInfo();
            P1.SpouseInfo();
            Person P2 = new Person();
            P2.PersonInfo();
            P2.SpouseInfo();

            P1.PrintNameAndAge();
            P2.PrintNameAndAge();
            System.Console.WriteLine("Adverage Age:" + Person.SumOfAllAges / 4);

            System.Console.ReadKey();
        }
        
    }
}
