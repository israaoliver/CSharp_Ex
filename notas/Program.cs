using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;

            Console.WriteLine("Digite a nota do 1ºBimestre");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do 2ºBimestre");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do 3ºBimestre");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do 4ºBimestre");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine($" 1ºBimestre {num1}");
            Console.WriteLine($" 2ºBimestre {num2}");
            Console.WriteLine($" 3ºBimestre {num3}");
            Console.WriteLine($" 4ºBimestre {num4}");
            Console.WriteLine("Media Geral");
            Console.WriteLine($" = {(num1 + num2 + num3 + num4) / 4}");

        }
    }
}