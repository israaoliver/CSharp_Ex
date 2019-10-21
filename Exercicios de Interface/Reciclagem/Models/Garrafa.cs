using System;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class  Garrafa : JogandoNoLixo, IVidro
    { 

        public bool reciclarVidro()
        {
            Console.BackgroundColor = ConsoleColor.Green; // todo: cor de fundo do texto
            Console.ForegroundColor = ConsoleColor.Black; // todo: cor das letras
            System.Console.WriteLine("Jogado na lixeira de Vidro verde");
            System.Console.WriteLine("Lixo de Vidro sendo Reciclado");
            Console.ResetColor();
            return true;
        }
    }

    
}