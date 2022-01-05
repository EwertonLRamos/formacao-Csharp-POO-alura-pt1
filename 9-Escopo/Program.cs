using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoao = 18;
            bool acompanhado = !true;
            string msgAdicional;

            if (acompanhado)
                msgAdicional = "está acompanhado";
            else
                msgAdicional = "está sozinho";

            if (idadeJoao >= 18 && acompanhado)
            {
                Console.Write("João é de maior e ");
                Console.WriteLine(msgAdicional);
            }
            else if (idadeJoao < 18 && acompanhado)
            {
                Console.Write("João é de menor mas ");
                Console.WriteLine(msgAdicional);
            }
            else if (idadeJoao >= 18 && !acompanhado)
            {
                Console.Write("João é de maior mas ");
                Console.WriteLine(msgAdicional);
            }
            else
            {
                Console.Write("João é de menor e ");
                Console.WriteLine(msgAdicional);
            }

            Console.ReadLine();
        }
    }
}
