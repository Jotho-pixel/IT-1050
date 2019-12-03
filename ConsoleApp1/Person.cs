
namespace ConsoleApp1
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public static double SumOfAllAges;

        
        public void PersonInfo()
        {
            System.Console.WriteLine("First Name?");
            FirstName = System.Console.ReadLine();
            System.Console.WriteLine("Last Name?");
            LastName = System.Console.ReadLine();
            System.Console.WriteLine("Age?");
            Age = int.Parse(System.Console.ReadLine());
            SumOfAllAges += this.Age;

            
        }

        public void SpouseInfo()
        {
            Spouse = new Person();
            System.Console.WriteLine("Spouse Name?");
            Spouse.FirstName = System.Console.ReadLine();
            Spouse.LastName = LastName;
            System.Console.WriteLine("Spouse Age?");
            Spouse.Age = int.Parse(System.Console.ReadLine());
            SumOfAllAges += Spouse.Age;
            
        }
        private string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine("Name: " + this.GetFullName());
            System.Console.WriteLine("Age: " + this.Age);
            System.Console.WriteLine("Spouse Name: " + Spouse.GetFullName());
            System.Console.WriteLine("Spouse Age: " + Spouse.Age);
            

        }
    }
}
