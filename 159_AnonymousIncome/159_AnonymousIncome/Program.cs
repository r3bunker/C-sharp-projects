using System;


namespace _159_AnonymousIncome
{
    class Program
    {
        static void Main()
        {
            // Titlescreen
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // Person1
            Console.WriteLine("\nPerson 1: ");
            Console.WriteLine("What is the hourly rate for 'Person1'?");
            int Person1_hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours per week does 'Person1' work?");
            int Person1_hoursWorked = Convert.ToInt32(Console.ReadLine());

            // Person2
            Console.WriteLine("\nPerson 2: ");
            Console.WriteLine("What is the hourly rate for 'Person2'?");
            int Person2_hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours per week does 'Person2' work?");
            int Person2_hoursWorked = Convert.ToInt32(Console.ReadLine());

            // Person1 Salary
            int Person1_salary = Person1_hourly * Person1_hoursWorked * 52;
            Console.WriteLine("\nPerson1 Salary: ");
            Console.WriteLine(Person1_salary);
            Console.ReadLine();

            // Person2 Salary
            int Person2_salary = Person2_hourly * Person2_hoursWorked * 52;
            Console.WriteLine("\nPerson2 Salary: ");
            Console.WriteLine(Person2_salary);
            Console.ReadLine();

            // Salary Comparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool Person1_makesMore = Person1_salary > Person2_salary;
            Console.WriteLine(Person1_makesMore);
            Console.ReadLine();
            


        }
    }
}
