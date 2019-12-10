using System;

namespace par_imapr
{
    class Program
    {
        static void Main(string[] args)
        {
            int pares = 0;
            int impares = 0;
            int[] numeros = new int [6];
            
        

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Digite um numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                
                if ((numeros[i] % 2) == 0)
                {
                pares += 1;
                }
                else
                {
                    impares += 1;
                }
            }
            Console.WriteLine($"Números pares: {pares} || Números ímpares: {impares}");







        }
    }
}
