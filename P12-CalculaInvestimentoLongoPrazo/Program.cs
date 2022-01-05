using System;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            Console.WriteLine("Valor inicial: R$ " + valorInvestido + "\n");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("\nANO - " + i + "\n");

                for (int j = 1; j <= 12; j++)
                {
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine("No " + j + "° mês: R$ " + valorInvestido);
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("\nNo fim do investimento você terá R$" + valorInvestido);
            Console.ReadLine();
        }
    }
}
