using System;

namespace tabuado_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A tabuda do cinco é: ");

            for(int i=1; i <= 10; i++){

                Console.WriteLine($"{i} x 1=  " + (1 * i));
                Console.WriteLine($"{i} x 2=  " + (2 * i));
                Console.WriteLine($"{i} x 3 = " + (3 * i));
                Console.WriteLine($"{i} x 4 = " + (4 * i));
                Console.WriteLine($"{i} x 5 = " + (5 * i));
                Console.WriteLine($"{i} x 6 = " + (6 * i));
                Console.WriteLine($"{i} x 7 = " + (7 * i));
                Console.WriteLine($"{i} x 8 = " + (8 * i));
                Console.WriteLine($"{i} x 9 = " + (9 * i));
                Console.WriteLine($"{i} x 10= " + (10 * i));



            }

        
        }
    }
}
