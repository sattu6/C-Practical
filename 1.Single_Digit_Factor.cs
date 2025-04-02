using System;

namespace Assignment_c_
{
    internal class _1
    {
        static void Main(string[] args)
        {
            Console.Write("\n Name  - Rupchandra Manhare");
            Console.Write("\n Class - M.Sc.(IT) II Sem");
            Console.Write("\n Date  - 25/March/25\n");

            int i, result=0, value;
           
            Console.Write("\n Enter the value : ");
            value = int.Parse(Console.ReadLine());

            for (i = 2; i <= value; i++)
            {
                if (value % i == 0)
                {
                    result=i;
                    break;
                }
            }
            if (result == value)
            {
                Console.Write($"\n The smallest factor of {value} is : {result}");
                Console.Write($"\n Because this is prime num.");
            }
            else if (result >= 10)
            {
                Console.Write($" There is no single digit factor of {value}");
            }
            else
            {
                Console.Write($"\n The smallest single digit factor of {value} is (exept 1) : {result}");
            }

                Console.ReadLine();
        }

    }
}
