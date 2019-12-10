using System;

namespace numero_igual_a_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do{

                Console.WriteLine("Digite o Número");
                num = int.Parse(Console.ReadLine());
                
                if((num % 2) !=0){
                    Console.WriteLine("O número é impar.");
                } else {
                    Console.WriteLine("O número é par.");
                }           
            } while (num!=0);
        }
    }
}
