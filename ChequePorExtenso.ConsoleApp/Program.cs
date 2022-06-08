using System;

namespace ChequePorExtenso.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Conversor conversor = new();

            var input = Console.ReadLine();

            Console.WriteLine(conversor.ConverterNumero(input));
        }
    }
}
