using System.Collections.Generic;
using System;
using NumerosPar.Enuns;

namespace NumerosPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string linha = "============================================";
            int codigo = 1;

            do
            {

            do
            {
                Console.Clear();
                System.Console.WriteLine(linha);
                System.Console.WriteLine("Coloque um numero: ");
                System.Console.WriteLine(linha);
                valor = int.Parse(Console.ReadLine());

            } while (valor < 0);    

            if(valor % 2==0)
            {
                System.Console.WriteLine($"O numéro {valor} é par.");
            } else
            {
                System.Console.WriteLine($"O numéro {valor} é impar.");
            }



            Menu(codigo);
            



            } while (codigo == 0);

        }

        public static int Menu(int codigo)
        {
            string[] itensMenu = Enum.GetNames(typeof(EnumOpcao));
            string linha = "============================================";
            int opcaoColocada = 0;


            System.Console.WriteLine(linha);
            System.Console.WriteLine("Deseja colocar um novo numero?");
            System.Console.WriteLine(linha);

            for (int i = 0; i < itensMenu.Length; i++)
            {
                string titulo = Tratar(itensMenu[i]);
                if(opcaoColocada == i)
                {
                    DestacarOpcao(itensMenu[opcaoColocada].Replace("-",">").Replace(i.ToString(), titulo));
                }
                else
                {
                    System.Console.WriteLine(itensMenu[i].Replace(i.ToString(),titulo));
                }
            }

            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:

                opcaoColocada = opcaoColocada == 0 ? opcaoColocada : --opcaoColocada;
                break;
                case ConsoleKey.DownArrow:
                opcaoColocada = opcaoColocada == itensMenu.Length - 1 ? opcaoColocada : ++opcaoColocada;
                break;
                case ConsoleKey.Enter:
                codigo = opcaoColocada;
                break;
            }
            return codigo;
            

        }

        public static void DestacarOpcao(string opcao)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(opcao);
            Console.ResetColor();
        }

        public static string Tratar(string titulo)
        {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        
        }
    }
}
