using System;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;

            Console.WriteLine("Valor inicial: R$ " + valorInvestido);

            for (int x = 1; x <= 12; x++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("No " + x + "° mês: R$ " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
