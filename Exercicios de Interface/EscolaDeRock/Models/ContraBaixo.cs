using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Contrabaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Manter o  Ritmo ContraBaixo");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocar Acordes do Contrabaixo");
            return true;
            
        }
    }
    
}