using System;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class  Papelao : JogandoNoLixo, IPapel
    { 

        public bool reciclarPapel()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Jogado na lixeira de Papel Azul"); 
            System.Console.WriteLine("Lixo de Papel sendo Reciclado");
            return true;
        }
    }

    
}