using System;

namespace font_nelas
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;

            Console.WriteLine("Digite alguma porra");
            i = int.Parse(Console.ReadLine());

            while(i < 100000){
                i +=1000;
                Console.WriteLine(i);
                
            }

        }
    }
}
