using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_c_
{
    internal class _18
    {
        static void Main(string[] args)
        {
            Console.Write("\n Name  - Rupchandra Manhare");
            Console.Write("\n Class - M.Sc.(IT) II Sem");
            Console.Write("\n Date  - 25/March/25\n");

            int i, j,N = 6;
            int Fibo(int n)
            {
                if(n==0)
                {
                    return 0;
                }else if(n==1)
                {
                    return 1;
                }
                else
                {
                    return Fibo(n - 1) + Fibo(n - 2);
                }
            }

            for (i = 1; i <= N; i++)
            {

                for (j = 1; j <= i; j++)
                {
                    Console.Write(" "+Fibo(j));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
