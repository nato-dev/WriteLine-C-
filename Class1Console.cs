using System;

namespace Aula1Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Condicao;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Como você está ?");
            Condicao = Console.ReadLine();
            Console.WriteLine("A Sua condição é: " + Condicao);

            Console.ReadKey();
        }
    }
}
