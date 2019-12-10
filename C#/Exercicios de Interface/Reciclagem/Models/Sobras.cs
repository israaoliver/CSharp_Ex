using System;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class Sobras : JogandoNoLixo, IOrganico
    { 

        public bool reciclarOrganico()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Jogado na lixeira de Orgânicos marrom.           "); 
            System.Console.WriteLine("Lixo orgânico sendo mandado para a composteira...");
            return true;
        }
    }

    
}