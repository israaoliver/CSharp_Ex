using System;

namespace Base_Altura
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite as Medidas do Rêtangulo.");
            System.Console.WriteLine();
            System.Console.Write("Digite Base: ");
            int b = int.Parse(Console.ReadLine());            
            System.Console.Write("Digite Altura: ");
            int alt = int.Parse(Console.ReadLine());

            int Perimetro = 2*(b + alt);
            int Area = b*alt;
            double diagonal =  Math.Sqrt(b*b + alt*alt);

            System.Console.WriteLine($"O Perimetro é : {Perimetro} ");
            System.Console.WriteLine($"A Aréa é : {Area} ");
            System.Console.WriteLine($"A Diagonal é : {diagonal}");
        }
    }
}
