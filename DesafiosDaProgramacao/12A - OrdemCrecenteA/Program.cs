using System;

namespace OrdemCrecente
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = "===========================";
            int num1,num2,num3;

            Console.Clear();
            System.Console.WriteLine(linha);
            System.Console.WriteLine("Digite três numeros: ");
            System.Console.WriteLine(linha);
            System.Console.Write("Digite o Primeiro:");
            num1 = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o Segundo:");
            num2 = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o Terceiro:");
            num3 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                if(num2 > num3)
                {
                    System.Console.WriteLine($"A ordem Crecente é {num3}, {num2}, {num1}");
                }else
                {
                    if(num1 > num3){
                        System.Console.WriteLine($"A ordem Crecente é {num2}, {num3}, {num1}");
                    }else
                        System.Console.WriteLine($"A ordem Crecente é {num2}, {num1}, {num3}");                    {
                        
                    }
                }
            } else if(num1 < num2)
            {
                if(num1 > num3)
                {
                    System.Console.WriteLine($"A ordem Crecente é {num3}, {num1}, {num2}");
                }else
                {
                    if(num2 > num3){
                        System.Console.WriteLine($"A ordem Crecente é {num1}, {num3}, {num2}");
                    }else
                    {
                        System.Console.WriteLine($"A ordem Crecente é {num1}, {num2}, {num3}");
                    }
                }
            } else if(num1 < num3)
            {
                if(num1 > num2)
                {
                    System.Console.WriteLine($"A ordem Crecente é {num2}, {num1}, {num3}");
                }else
                {
                    if(num3 > num2){
                        System.Console.WriteLine($"A ordem Crecente é {num1}, {num2}, {num3}");
                    }else
                    {
                        System.Console.WriteLine($"A ordem Crecente é {num1}, {num3}, {num2}");
                    }

                }
            }



        }
    }
}
