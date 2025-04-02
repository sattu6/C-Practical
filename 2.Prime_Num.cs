using System;

namespace Assignment_c_
{
    internal class _2
    {
        static void Main(string[] args)
        {
            Console.Write("\n Name  - Rupchandra Manhare");
            Console.Write("\n Class - M.Sc.(IT) II Sem");
            Console.Write("\n Date  - 25/March/25\n");

            int i,j,start,end;
            Console.Write("\n Enter Starting Num : ");
            start=int.Parse(Console.ReadLine());

            Console.Write("\n Enter End Num : ");
            end=int.Parse(Console.ReadLine());

            Console.Write($"\n Prime Num from {start} to {end} is : ");
            for (i=start;i<=end;i++)
            {
                for(j=2;j<i;j++)
                {
                    if(i%j==0)
                    break;
                }
               
                if (i == j)
                Console.Write(" "+i);
            }Console.ReadLine();
        } 
        
    } 
}
