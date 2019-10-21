using System;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class  GuardaChuva : JogandoNoLixo, IIndefinido
    { 

        public bool reciclarIndefinido()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Jogado na lixeira de Plastico vermelha");            
            System.Console.WriteLine("Lixo de Plástico dendo Reciclado");
            return true;
        }
    }

    
}