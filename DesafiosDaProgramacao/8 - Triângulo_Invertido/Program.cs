using System;

namespace Triângulo_Invertido
{
    class Program
    {
        static void Main(string[] args)
        {
            int nh,n = 0 ;

            string asterisco ="*";

            
            do{

            Console.WriteLine("Qual a altura do triângulo: ");
            nh = int.Parse(Console.ReadLine());

            if(nh < 0){
                Console.WriteLine("Digite um numéro positivo ");

            }

            } while(nh < 0);

            while(nh != 0){

                for(int i = nh; i != 0; i--){
                    Console.Write(asterisco);
                }
                nh--;

                Console.WriteLine("");
            }
        }
    }
}
