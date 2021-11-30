using System;

namespace StaffFiles
{
    class Register
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The name and salary is: {name} {salary}");
        }
    }
}