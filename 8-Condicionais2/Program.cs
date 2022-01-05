using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoao = 16;
            int qtdDePessoas = 2;
            bool acompanhado = qtdDePessoas >= 2;

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("João é de maior ou é de menor e está acompanhado");
            }
            else
            {
                Console.WriteLine("João é de menor");
            }

            Console.ReadLine();
        }
    }
}
