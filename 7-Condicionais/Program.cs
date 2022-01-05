using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoao = 16;
            bool acompanhado = true;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João é de maior");
            }
            else
            {
                if (acompanhado)
                {
                    Console.WriteLine("João é de menor mas está acompanhado");
                }
                else
                {
                    Console.WriteLine("João é de menor");
                }
            }
            Console.ReadLine();
        }
    }
}
