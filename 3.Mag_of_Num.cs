using System;

namespace Assignment_c_
{
    internal class _3
    {
        public static int GetMagnitude(int num)
        {
            int magnitude = 0;

            while (num > 0)
            {
                magnitude++;
                num = num / 10;
            }
            return magnitude;
        }
        public static void Main()
        {
            Console.Write("\n Name  - Rupchandra Manhare");
            Console.Write("\n Class - M.Sc.(IT) II Sem");
            Console.Write("\n Date  - 25/March/25\n");

            int num = 34521;
            int mag = 0;

            mag = GetMagnitude(num);

            Console.WriteLine($"\n Magnitude of {num} is : " + mag);

            Console.ReadLine();
        }
    }
}
