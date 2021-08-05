using System;

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número entre 1000 e 9999");
            Console.WriteLine();
            string[] valores = Console.ReadLine().Split();

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);
            int d = int.Parse(valores[3]);
            int contador;

            contador = 0;

            for(int i = 0; i <= 3; i++)
            {
                if (i % 2 == 0)
                {
                    contador += 1;
                }
            }

            Console.WriteLine(contador.ToString());
        }
    }
}
