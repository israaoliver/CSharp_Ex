using System.Collections.Generic;

using System.Linq;
using System;


namespace Gravidade
{
    enum PlanetaEnum : int
    {
        MERCURIO,
        VÊNUS,
        MARTE,
        JUPITER,
        SATURNO,
        URANO
    };
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuPlanetas = Enum.GetNames(typeof(PlanetaEnum));
            string linha = "============================";
            int peso;

            var opcoesPlaneta = new List<string>()
            {
                "    - 0                      ",
                "    - 1                      ",
                "    - 2                      ",
                "    - 3                      ",
                "    - 4                      ",
                "    - 5                      "
            };

            int opcoesPlanetaSelecionado = 0;
            
            string finalizou ;

            do
            {
                
            Console.Clear();
            System.Console.WriteLine(linha);
            System.Console.WriteLine("Bem Vindo!!");
            System.Console.WriteLine("Digite o seu Peso?");
            System.Console.WriteLine(linha);
            peso = int.Parse(Console.ReadLine());

            bool escolheu = false;
            do
            {

            Console.Clear();
            
            System.Console.WriteLine(linha);
            System.Console.WriteLine("Escolha o Planeta para ver o seu peso lá:");
            System.Console.WriteLine(linha);

            for(int i = 0; i < opcoesPlaneta.Count; i++)
            {
                string planetas = Tratar(menuPlanetas[i]);
                if(opcoesPlanetaSelecionado == i)
                {
                    Destacar(opcoesPlaneta[opcoesPlanetaSelecionado].Replace("-",">").Replace(i.ToString(), planetas));
                }
                else
                {
                    System.Console.WriteLine(opcoesPlaneta[i].Replace(i.ToString(), planetas));
                }
            }

            var key =  Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                opcoesPlanetaSelecionado = opcoesPlanetaSelecionado == 0 ? opcoesPlanetaSelecionado : --opcoesPlanetaSelecionado;
                    break;
                case ConsoleKey.DownArrow:
                opcoesPlanetaSelecionado = opcoesPlanetaSelecionado == opcoesPlaneta.Count -1 ? opcoesPlanetaSelecionado : ++opcoesPlanetaSelecionado;
                    break;
                case ConsoleKey.Enter:
                escolheu = true;
                    break;
                
                
            }


            } while (!escolheu);

            double g ;

            switch (opcoesPlanetaSelecionado)
            {
                case 0:
                
                g = peso * 0.37;
                System.Console.WriteLine($"Em Mercurio seu peso vai ser {g}");

                break;
                case 1:

                g = peso * 0.88;
                System.Console.WriteLine($"Em Vênus seu peso vai ser {g}");
                break;
                case 2:
                g = (peso/10)
                 * 3.8;
                System.Console.WriteLine($"Em Marte seu peso vai ser {g}");
                break;
                case 3:
                g = peso * 2.64;
                System.Console.WriteLine($"Em Júpiter seu peso vai ser {g}");
                break;
                case 4:
                g = peso * 1.15;
                System.Console.WriteLine($"Em Saturno seu peso vai ser {g}");
                break;
                case 5:
                g = peso * 1.17;
                System.Console.WriteLine($"Em Uranos seu peso vai ser {g}");
                break;
            }

            System.Console.WriteLine("Colocar um novo valor?");
            System.Console.WriteLine("S para sim ou N para não");
            finalizou = Console.ReadLine();
            


            } while (!(finalizou == "N"));

        }
        public static string Tratar(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }

        public static void Destacar(string opcao)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(opcao);
            Console.ResetColor();
        }

    }
}
