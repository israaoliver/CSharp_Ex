﻿using System;

namespace nota_funcional_com_switch_case
{
  class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("Entre com a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 +nota4) / 4;

            Console.WriteLine("Sua media é " + media);
        
        switch (media)
        {
            Console.WriteLine("Você Passou!");
            Console.WriteLine("Parabéns sua nota esta a cima da media");
            break;

            case :
            Console.WriteLine("Você Reprovou!!");
            Console.WriteLine("Se esforce mais na proxima vez.");
            break;

        }


        }
    }
}
