using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee1=> Enter hourly rate:");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Employee1=> Enter hour worked:");
            int hourWorked = int.Parse(Console.ReadLine());

            Console.WriteLine("Pay for Employee1 is $ " + hourlyRate * hourWorked);

             Console.WriteLine("Employee2=> Enter hourly rate:");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Employee2=> Enter hour worked:");
            int hourWorked2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Pay for Employee1 is $ " + hourlyRate2 * hourWorked2);

             Console.WriteLine("Employee3=> Enter hourly rate:");
            double hourlyRate3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Employee3=> Enter hour worked:");
            int hourWorked3 = int.Parse(Console.ReadLine());

            Console.Write("Pay for Employee1 is $ " + hourlyRate3 * hourWorked3);
        }
    }
}
