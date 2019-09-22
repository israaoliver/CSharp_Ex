using System;

namespace Impar_par
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0;

            Console.WriteLine("Digite um numero inteiro: ");
            num = int.Parse(Console.ReadLine());


            if (num % 2==0){
                Console.WriteLine($"O numéro {num} é Par");
            } else{
                Console.WriteLine($"O numéro {num} é impar");
            }




        }
    }
}
