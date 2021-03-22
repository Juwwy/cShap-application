using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Userdata();
        }

        static void Userdata()
        {
            Console.Write("Enter a name:");
            string userName = Console.ReadLine();

             Console.Write("Enter a age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your name is {userName} and Age is {age}");
        }
    }
}
