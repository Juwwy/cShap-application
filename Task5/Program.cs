using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
          int[] newArr = new int[5];

             
            for(int num = 0; num <= 4; num++)
            {
                Console.WriteLine("Enter a number");
                newArr[num] = int.Parse(Console.ReadLine());
            }

            int smallNum = newArr[0] ;

            for(int i = 0; i < newArr.Length; i++)
            {
                if(newArr[i] < smallNum)
                {
                    smallNum = newArr[i];
                }
            }

            Console.Write($"The smallest number among inputs is {smallNum}");
        }
    }
}
