using System;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class  Salgadinhos : JogandoNoLixo, IPlastico
    { 

        public bool reciclarPlastico()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Jogado na lixeira de Plastico vermelha"); 
            System.Console.WriteLine("Salgadinho sendo Reciclado...         ");
            return true;
        }
    }

    
}