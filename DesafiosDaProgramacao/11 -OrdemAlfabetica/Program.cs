using System;

namespace OrdemAlfabetica
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = "=============================";
            string wordA, wordB;

            Console.Clear();
            
            System.Console.WriteLine(linha);
            System.Console.WriteLine("Digite uma palavra: ");
            System.Console.WriteLine(linha);
            wordA = Console.ReadLine();
            System.Console.WriteLine(linha);
            System.Console.WriteLine("Digite outra palavra: ");
            System.Console.WriteLine(linha);            
            wordB =  Console.ReadLine();
            System.Console.WriteLine(linha);

            int comparador = string.Compare(wordA,wordB);

            if(comparador < 0)
            {
                System.Console.WriteLine("A ordem das palavras é " + wordA + " vem antes de " + wordB );

            }else
            {
                System.Console.WriteLine("A ordem das palavras é " + wordB + " vem antes de " + wordA );
                
            }
            

        }
    }
}
