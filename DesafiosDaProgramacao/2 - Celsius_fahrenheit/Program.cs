using System;

namespace Celsius_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            System.Console.WriteLine("Escreva o valor de Celcius: ");
            int valor =  int.Parse(Console.ReadLine());

            int F = (valor * 9/5) + 32;

            System.Console.WriteLine($"A temperatura em Fahrenheit é: {F}Fº");
        }
    }
}
