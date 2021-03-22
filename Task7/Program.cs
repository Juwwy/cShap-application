using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hourly rate:");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter hour worked:");
            int hourWorked = int.Parse(Console.ReadLine());

            Console.Write("Pay for Employee1 is $ " + hourlyRate * hourWorked);
        }
    }
}
