using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocar solo Guitarra");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocar Acordes Guitarra");
            return true;
            
        }
    }
    
}