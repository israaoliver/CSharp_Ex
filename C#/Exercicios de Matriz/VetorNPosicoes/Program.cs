using System;

namespace VetorNPosicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Digite a quantidade de numeros requeridos.");
            int n = int.Parse(Console.ReadLine());
                        
            int[] numeros = new int [n];


            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Digite o {i + 1}º:");
                numeros[i] = int.Parse(Console.ReadLine());                
            }
            for (int j = 0; j < n; j++)
            {
                System.Console.WriteLine($"O {j + 1}º Numéro é  " + numeros[j]);
            }
        }
    }
}
