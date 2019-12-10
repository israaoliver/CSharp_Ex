using System;

namespace MultiploDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = "===========================";
            
            System.Console.WriteLine(linha);
            System.Console.Write("      Digite um Numero: ");
            int num = int.Parse(Console.ReadLine());
            System.Console.WriteLine(linha);

            if(num % 3 == 0){
                
                System.Console.WriteLine($"O numero {num} é multiplo de 3.");

            }
            else
            {
                System.Console.WriteLine($"O numero {num} não é multiplo de 3.");
            }
        }
    }
}
