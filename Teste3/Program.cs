using System;

namespace Teste3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Escreva o dia do seu nascimento com dois dígitos");
            Console.WriteLine();

            string[] Dia = Console.ReadLine().Split();
            int a = int.Parse(Dia[0]);
            int b = int.Parse(Dia[1]);

            Console.WriteLine("Escreva o mês do seu nascimento com dois dígitos");
            Console.WriteLine();

            string[] Mes = Console.ReadLine().Split();
            int c = int.Parse(Mes[0]);
            int d = int.Parse(Mes[1]);

            
            Console.WriteLine("Escreva o ano do seu aniversário com quatro dígitos");
            Console.WriteLine();

            string[] Ano = Console.ReadLine().Split();
            
            int e = int.Parse(Ano[0]);
            int f = int.Parse(Ano[1]);
            int g = int.Parse(Ano[2]);
            int h = int.Parse(Ano[3]);

            





            Console.WriteLine("Hello World!");
        }
    }
}
