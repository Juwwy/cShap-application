using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter your first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("What arithmetic do you intend\n1. Addition\n2. Substraction\n3. Multiplication\n4. Increment\n5. Decrement");
            string operatorSign = Console.ReadLine();

            int arithmetic = 0;

            switch(operatorSign)
            {
                case  "1":
                arithmetic = number1 + number2 ;
                break;
                case  "2":
                arithmetic = number1 - number2;
                break;
                case  "3":
                arithmetic = number1 * number2;
                break;
                case  "4":
                arithmetic = (number1 + number2) + 1;
                break;
                case  "5":
                arithmetic = (number1 + number2) -1;
                break;
                default:
                Console.Write("Invalid input");
                break;

                 
            }
              Console.Write($"Your answer is {arithmetic}");

            

        }
        
    }
}
