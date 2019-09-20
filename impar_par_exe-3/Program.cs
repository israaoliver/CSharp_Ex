using System;

namespace impar_par_exe_3
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Os numeros impares de 0 a 100 são: ");
            
            for(int i=1; i < 100; i+=2){
            Console.WriteLine(i);
            }
            
        }   
    }
}
