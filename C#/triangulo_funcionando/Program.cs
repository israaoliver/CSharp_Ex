using System;

namespace testeX
{
    class Program
    {
        static void Main(string[] args)
        {
            int ntri,nh,n = 0 ;

            string asterisco;

            asterisco = "*";
            
            do{

            Console.WriteLine("Qual a altura do triângulo: ");
            nh = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos triângulo você quer emprimir: ");
            ntri = int.Parse(Console.ReadLine());

            if((ntri < 0) || (nh < 0)){
                Console.WriteLine("Digite um numéro positivo ");

            }

            } while((ntri < 0) || (nh < 0));

            while(ntri != 0){

                for(n = nh; n != 0; n--){
                    Console.WriteLine(asterisco);
                    asterisco = (asterisco + "*");
                }
                ntri--;
                asterisco = ("*");
                Console.WriteLine("");
            }
        }
    }
}
