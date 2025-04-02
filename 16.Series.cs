using System;

namespace Assignment_c_
{
    public class _16
    {
        public static void Main()
        {
            Console.Write("\n Name  - Rupchandra Manhare");
            Console.Write("\n Class - M.Sc.(IT) II Sem");
            Console.Write("\n Date  - 25/March/25\n");

            int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("\n Enter the nth term : ");
            numberOfElements = int.Parse(Console.ReadLine());
            Console.Write($"\n Your {numberOfElements} term Fibonacci series is : ");
            if (numberOfElements < 2)
            {
                Console.Write("\n Please Enter a number greater than two");
            }
            else
            {
        
                Console.Write(" "+firstNumber + " " + SecondNumber + " ");
               
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }
            Console.ReadKey();
        }
    }
}