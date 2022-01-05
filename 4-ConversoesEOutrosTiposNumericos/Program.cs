using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioDouble = 1500.85;
            Console.WriteLine("O salário no tipo double é " + salarioDouble);

            int salarioInt = (int)salarioDouble;
            Console.WriteLine("O salário no tipo int é " + salarioInt);

            //Variéveis do tipo inteiro só recebem valores que vão de -2^31 até 2^31
            //para guardar um valor inteiro que seja maior que 32 bits, é necessário
            //usar outro tipo de variável, o tipo long. E também podemos usar o tipo
            //short para valores pequenos, de até 16 bits.
            
            //Resumindo:
            //long = 64 bits
            //int = 32 bits
            //short = 16 bits

            long idadeDoUniverso = 13000000000;
            short qtdDeProdutos = 150;
        }
    }
}
