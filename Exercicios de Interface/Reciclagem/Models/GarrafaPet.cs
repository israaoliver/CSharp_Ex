using System;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class  GarrafaPet : JogandoNoLixo, IPlastico
    { 

        public bool reciclarPlastico()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Jogado na lixeira de Plastico vermelha");            
            System.Console.WriteLine("GarrafaPet sendo Reciclado...         ");
            return true;
        }
    }

    
}