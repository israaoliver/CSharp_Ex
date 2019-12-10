using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{

    class Violao : InstrumentoMusical, IMelodia, IHarmonia, IPercussao
    {
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocar Solo o  Violão");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocar Acordes Violão");
            return true;
        }

        public bool ManterRitmo()
        {
            System.Console.WriteLine("Manter Ritmo do Violão");
            return true;
        }

        
    }
    
}