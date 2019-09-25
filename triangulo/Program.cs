using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l;

            Console.WriteLine("Qual a altura do seu triândulo?");
            int alt = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos triândulo?");
            int qtde = int.Parse(Console.ReadLine());

            for(l = 0; l < qtde; l++){


            for(i = 0; i < alt; i++)
            {
                for (j = 1; j == alt; j++){
                 Console.Write(""); 
                }
                for (k = 1; k == i; k++){
                    Console.Write("*");
                }
                Console.WriteLine("");       
            }
            Console.WriteLine(); 
            }
        }
    }
}
