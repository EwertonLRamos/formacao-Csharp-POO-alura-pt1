using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1 = 32;
            int idade2 = idade1;
            Console.WriteLine(idade1);
            Console.WriteLine(idade2);

            idade1 = 25;
            Console.WriteLine(idade1);
            Console.WriteLine(idade2);

            Console.ReadLine();
        }
    }
}
