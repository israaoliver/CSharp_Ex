using System;
using System.Collections.Generic;
using EscolaDeRock.Models;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock
{
    enum FormacaoEnum : int
    {
        TRIO = 3,
        QUARTETO
    };

    enum InstrumentosEnum : int
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLÃO
    };

    enum CategoriaEnum : int
    {
        HARMONIA,
        PERCUSSÃO,
        MELODIA
    };  
    class Program
    {
        static void Main(string[] args)
        {
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                "    - 0                         ",
                "    - 1                     "
            };
            

            int opcaoFormacaoSelecionada = 0;
            string menuBar = "=========================================================";
            bool querSair = true;

            do
            {
                #region Area do menu
                bool formacaoEscolhida = false;
                do
                {
                    
                    Console.Clear();
                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    System.Console.WriteLine("                   Seja Bem-vindo!                  ");
                    System.Console.WriteLine("                   Escolha uma formação:            ");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                    for(int i = 0; i < opcoesFormacao.Count; i++)
                    {
                        string titulo = itensMenuPrincipal[i];
                        if(opcaoFormacaoSelecionada == i){

                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine(opcoesFormacao[opcaoFormacaoSelecionada].Replace("-",">").Replace(i.ToString(),titulo));
                            Console.ResetColor();
                        } else {
                            Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
                        }
                    }

                    var key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.W:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                        break;

                        case ConsoleKey.S:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count -1? opcaoFormacaoSelecionada : ++opcaoFormacaoSelecionada;
                        break;
                        case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                        break;
                        
                        
                    }
                        
                    
                } while (!formacaoEscolhida);
                #endregion

                #region Adiciona os instrumentos a foemação escolhida.
                bool bandaCompleta = false;
                int vagas = 0;


                switch(opcaoFormacaoSelecionada)
                {
                    #region 
                    case 0:
                    vagas = 2;
                    do
                    {
                        ExibirMenuDeInstrumentos();

                        System.Console.WriteLine($"Digite código do instrumento de Harmonia: ");
                        int codigo = int.Parse(Console.ReadLine());
                        var instrumento = Deposito.Instrumentos[codigo];

                        Type interfaceEncontrada = instrumento.GetType().GetInterface("IHarmonia");

                        if (interfaceEncontrada != null)
                        {
                            vagas--;
                            ColocarNaBanda((IHarmonia)instrumento);
                        }
                        else
                        {
                            System.Console.WriteLine("O instrumento selecionado não é de Harmonia.");
                            continue;
                        }

                        System.Console.WriteLine($"Digite código do instrumento de Percussão:  ");
                        codigo = int.Parse(Console.ReadLine());
                        instrumento = Deposito.Instrumentos[codigo];

                        interfaceEncontrada = instrumento.GetType().GetInterface("IPercussao");

                        if (interfaceEncontrada != null)
                        {
                            vagas--;
                            ColocarNaBanda((IPercussao)instrumento);
                        }
                        else
                        {
                            System.Console.WriteLine("O instrumento selecionado não é de Percussão.");
                        }
                            continue;




                        
                    } while (!bandaCompleta);

                    break;
                    #endregion
                }

                #endregion                
            }while(!querSair);

        }

        public static void ExibirMenuDeInstrumentos()
        {}

        public static bool ColocarNaBanda(IHarmonia harmonia)
        {
            harmonia.TocarAcordes();
            System.Console.WriteLine(harmonia.GetType().BaseType + "foi incluido");
            return true;
        }

        public static bool ColocarNaBanda(IPercussao percussao)
        {
            percussao.ManterRitmo();
            System.Console.WriteLine(percussao.GetType().BaseType + "foi incluido");
            return true;
        }
    }
}
