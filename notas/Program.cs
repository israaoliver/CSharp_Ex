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

            Console.Write("Digite a nota do 1ºBimestre: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do 2ºBimestre: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do 3ºBimestre: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do 4ºBimestre: ");
            num4 = int.Parse(Console.ReadLine());

            Console.Write("Media Geral");
            Console.Write($" = {(num1 + num2 + num3 + num4) / 4}");

        }
    }
}