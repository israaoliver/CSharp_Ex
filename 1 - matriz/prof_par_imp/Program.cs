using System;

namespace prof_par_imp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetores = new int [6];
            int pares = 0;
            int impar = 0;

            for(int cont = 0; cont < 6; cont++){

                Console.Write($"Digite o {cont + 1} número:  ");
                vetores[cont] = int.Parse(Console.ReadLine());
            }

            foreach(int num in vetores){
                if(num % 2 ==0){

                    pares ++;

                } else{
                    impar ++;

                }
            }

            Console.WriteLine($"{pares} são pares || {impar} são impares");
        }
    }
}
