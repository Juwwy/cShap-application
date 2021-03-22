using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            int[] asc = new int[5];
            for(; i <= 4; i++)
            {
                Console.Write("Enter a number");
                asc [i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(asc);
            foreach(int value in asc)
            {
                Console.Write(value + " ");
            }

        }
    }
}
