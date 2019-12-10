using System;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class  GuardaChuva : JogandoNoLixo, IIndefinido
    { 

        public bool reciclarIndefinido()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Jogado na lixeira indefinida vermelha.");            
            System.Console.WriteLine("Guarda-Chuva sendo Reciclado...        ");
            return true;
        }
    }

    
}