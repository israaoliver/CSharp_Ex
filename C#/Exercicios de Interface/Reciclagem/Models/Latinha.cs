using System;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class  Latinha : JogandoNoLixo, IMetal
    { 

        public bool reciclarMetal()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Jogado na lixeira de Metais amarela.  "); 
            System.Console.WriteLine("Latinha sendo Reciclado...             ");
            return true;
        }
    }

    
}