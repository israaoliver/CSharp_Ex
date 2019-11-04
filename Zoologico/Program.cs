using System.Collections.Generic;
using System;
using System.Linq;
using ZooLogico.Interfaces;
using ZooLogico.Models.Animais;


namespace ZooLogico
{
    class Program
    {
        static void Main (string[] args)
        {
            bool finalizar = false;
            int codigo = 0;
            do
            {
                Console.Clear();
                codigo = ListarAnimais();
                
            } while (!finalizar);
        }

        public static int ListarAnimais()
        {
            string linha = "==================================";
            bool escolheu = false;
            int codigo;
            int index = 1;
            do
            {
                
            System.Console.WriteLine(linha);
            System.Console.WriteLine("", 5 + "Zoologico");
            System.Console.WriteLine("Digite o código do animal para adicionalo em um ambiente: ");
            System.Console.WriteLine(linha);

            foreach (var nomes in AnimaisDicionario.animais.Values)

            {
                System.Console.WriteLine($"{"", 5} + (index) + {nomes.GetType().Name}");
                index++;
            }
            System.Console.WriteLine(linha);
            System.Console.WriteLine("Para sair aperte 0 ");
            System.Console.WriteLine(linha);

            


            } while (!escolheu);
        }
    }
    
}