using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            char caractere = 'a';
            Console.WriteLine("O caractere é o: " + caractere);

            caractere = (char)61;
            Console.WriteLine("O caractere representado pelo número indicado é o: " + caractere);

            caractere = (char)(caractere + 1);
            Console.WriteLine("O caractere representado pelo número indicado é o: " + caractere);

            string titulo = "Texto da string ";
            titulo = titulo + 2021;
            Console.WriteLine(titulo);

            Console.ReadLine();
        }
    }
}
