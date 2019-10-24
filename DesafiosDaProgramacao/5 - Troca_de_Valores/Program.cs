using System;

namespace Troca_de_Valores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.Write("Digite o Valor de A:");
            int A = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("Digite o Valor de B:");
            int B = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"O A é {A}");
            System.Console.WriteLine($"O B é {B}");
            Continue();

            TrocandoNumber(A,B);


        }
        public static void TrocandoNumber(int A, int B)
        {
            int C = A;
            int D = B;
            B = C;
            A = D;

            System.Console.WriteLine($"Agora A é {A}");
            System.Console.WriteLine($"É B é {B}");
            Continue();


        }
        public static void Continue()
        {
            System.Console.WriteLine("Aperte <Enter> para continuar");
            Console.ReadLine();
            
        }
    }
}
