using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;
            int contMes = 1;

            Console.WriteLine("Valor inicial: R$ " + valorInvestido);

            while (contMes <= 12) 
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("No " + contMes +"° mês: R$ " + valorInvestido);
                contMes++;
            }
            
            Console.ReadLine();
        }
    }
}
