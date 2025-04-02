using System;

namespace Assignment_c_
{
    internal class _15
    {
        static void Main(string[] args)
        {
            Console.Write("\n Name  - Rupchandra Manhare");
            Console.Write("\n Class - M.Sc.(IT) II Sem");
            Console.Write("\n Date  - 25/March/25\n");

            int fact = 1;
            Console.Write("\n Enter the num : ");
            int num = int.Parse(Console.ReadLine());

            for(int i=1; i<=num;  i++)
            {
                fact = fact * i;
                Console.Write($" {i}!");
            }
            Console.Write($"\n Factorial of {num}! is : "+fact);
            Console.ReadKey();
        }
    }
}
