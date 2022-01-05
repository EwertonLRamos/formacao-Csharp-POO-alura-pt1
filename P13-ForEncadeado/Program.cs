using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                    if (i == j)
                        break;
                }
                Console.WriteLine();
            }

            //Outra forma de fazer
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
