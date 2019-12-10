using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocar Solo Teclado");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocar Acordes do Teclado");
            return true;
            
        }
    }
    
}