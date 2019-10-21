using System;
using System.Collections.Generic;
using Reciclagem.Models;
using Reciclagem.Interface;

namespace Reciclagem
{
    enum CategoriaEnum : int // todo: tipos de lixo a serem reciclados
    {
        INDEFINIDO,
        METAL,
        ORGANICO,
        PAPEL,
        PLASTICO,
        VIDRO
    };

    enum Lixosenum : int // todo: Lixos a serem selecionados
    {

        GARRAFA      ,
        GARRAFAPET   ,
        GUARDACHUVA  ,
        LATINHA      ,
        PAPELAO      ,
        POTEMANTEIGA ,
        SALGADINHO   ,
        SOBRAS
    };

    class Program
    {
        static void Main(string[] args)
        {
            bool finalizou = false; // todo: elo de repetição principal
            string[] menuTiposLixo = Enum.GetNames(typeof(CategoriaEnum)); // todo: Tipos de lixo listados
            string[] lixosParaReciclar = Enum.GetNames(typeof(Lixosenum)); // todo: Lixos listados

            var opcoesLixo = new List<string>()
            {
                "   - 0                          ",
                "   - 1                          ",
                "   - 2                          ",
                "   - 3                          ",
                "   - 4                          ",
                "   - 5                          ",
                "   - 6                          ",
                "   - 7                          "
            }; //todo: tamanhos dos nomes dos lixos

            int opcaoLixoSelecionado = 0; //todo: onde começa selecionado

            string linha = "============================================";

            do
            {

                #region Menu de lixo
                bool lixoEscolhido = false; // todo: elo de repeção do menu para escolher o lixo 
                do
                {
                    
                Console.Clear();
                
                System.Console.WriteLine(linha);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("    Eae fala o lixo que vc vai reciclar     ");
                System.Console.WriteLine("     Escolha o lixo:                        ");
                Console.ResetColor();
                System.Console.WriteLine(linha);

                for(int i = 0; i < opcoesLixo.Count; i++)
                {
                    string lixos = TratarTituloMenu(lixosParaReciclar[i]);
                    if ( opcaoLixoSelecionado == i)
                    {
                        DestacarOpcao(opcoesLixo[opcaoLixoSelecionado].Replace("-",">").Replace(i.ToString(), lixos));
                    }
                    else
                    {
                        System.Console.WriteLine(opcoesLixo[i].Replace(i.ToString(), lixos));
                    }
                }

                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                    opcaoLixoSelecionado = opcaoLixoSelecionado == 0 ? opcaoLixoSelecionado : --opcaoLixoSelecionado;
                    break;
                    case ConsoleKey.DownArrow:
                    opcaoLixoSelecionado = opcaoLixoSelecionado == opcoesLixo.Count - 1 ? opcaoLixoSelecionado : ++opcaoLixoSelecionado;
                    break;
                    case ConsoleKey.Enter:
                    lixoEscolhido = true;
                    break;
                }
        
                    
                } while (!lixoEscolhido);
                #endregion

                switch (opcaoLixoSelecionado)
                {
                    case 0:
                    var lixo = Lixo.Embalagens[0];
                    ColocarNoLixo((IVidro)lixo);

                    break;
                    case 1:
                    lixo = Lixo.Embalagens[1];
                    ColocarNoLixo((IPlastico)lixo);
                    break;
                    case 2:
                    lixo = Lixo.Embalagens[2];
                    ColocarNoLixo((IIndefinido)lixo);
                    break;
                    case 3:
                    lixo = Lixo.Embalagens[3];
                    ColocarNoLixo((IMetal)lixo);
                    break;
                    case 4:
                    lixo = Lixo.Embalagens[4];
                    ColocarNoLixo((IPapel)lixo);
                    break;
                    case 5:
                    lixo = Lixo.Embalagens[5];
                    ColocarNoLixo((IPlastico)lixo);
                    break;
                    case 6:
                    lixo = Lixo.Embalagens[6];
                    ColocarNoLixo((IPlastico)lixo);
                    break;
                    case 7:
                    lixo = Lixo.Embalagens[7];
                    ColocarNoLixo((IOrganico)lixo);
                    break;
                    
                }
                System.Console.WriteLine("Lixo foi reciclado!");
                Console.ReadLine();
                Console.ResetColor();
                
            } while (!finalizou);


                
        }

        public static void ColocarNoLixo(IVidro lixo)
        {
            lixo.reciclarVidro();
            System.Console.WriteLine("Indo Reciclar");
        }

        public static void ColocarNoLixo(IPlastico lixo)
        {
            lixo.reciclarPlastico();
            System.Console.WriteLine("Indo Reciclar");
        }

        public static void ColocarNoLixo(IIndefinido lixo)
        {
            lixo.reciclarIndefinido();
            System.Console.WriteLine("Indo Reciclar");
        }
        public static void ColocarNoLixo(IMetal lixo)
        {
            lixo.reciclarMetal();
            System.Console.WriteLine("Indo Reciclar");
        }
        public static void ColocarNoLixo(IOrganico lixo)
        {
            lixo.reciclarOrganico();
            System.Console.WriteLine("Indo Reciclar");
        }
        public static void ColocarNoLixo(IPapel lixo)
        {
            lixo.reciclarPapel();
            System.Console.WriteLine("Indo Reciclar");
        }

        public static string TratarTituloMenu(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }

        public static void DestacarOpcao(string opcao)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(opcao);
            Console.ResetColor();
        }

        

    }
}
