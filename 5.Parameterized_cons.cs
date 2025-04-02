using System;

namespace Assignment_c_
{
    internal class _5
    {
        public class xyz
        {
            int age;
            string name;

            public xyz(int x, string character)
            {
                Console.Write("\n Parameterized Constructor Called!.\n");
                age = x;
                name = character;

                Console.Write($"\n My name is {name} and age {age}.");           
            }
            static void Main(string[] args)
            {
                Console.Write("\n Name  - Rupchandra Manhare");
                Console.Write("\n Class - M.Sc.(IT) II Sem");
                Console.Write("\n Date  - 25/March/25\n");

                xyz obj = new xyz(22, "Rupchandra Manhare");

                Console.ReadLine();
            }
        }
    }
}
