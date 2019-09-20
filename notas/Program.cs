using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, num4, media;
            

            Console.Write("Digite a nota do 1ºBimestre: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do 2ºBimestre: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do 3ºBimestre: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do 4ºBimestre: ");
            num4 = int.Parse(Console.ReadLine());

            media = (num1 + num2 + num3 + num4) / 4;

            Console.Write("Media Geral: " + media);

            if (media >=7)
            {
                Console.WriteLine(" Passou");
            } else 
            {
                Console.WriteLine(" Reprovado");
            }

        }
    }
}