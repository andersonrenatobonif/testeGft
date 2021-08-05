using System;
using Teste2.src.Entities;

namespace Teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Seja Bem vindo!");
            Console.WriteLine();
            

            Hospedagem Nova = new Hospedagem(100, "Fulano", 30);

            Console.WriteLine(Nova);
        
        }
    }
}
