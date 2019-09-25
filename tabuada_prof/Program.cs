using System;

namespace tabuada_prof
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 1; i <=10; i++){
               for(int j = 1; j <= 10; j++){
                   Console.Write($"{i,-1} x {j,-2}= {i * j,-3}    "); 
               }
               Console.WriteLine();
           }
        }
    }
}
