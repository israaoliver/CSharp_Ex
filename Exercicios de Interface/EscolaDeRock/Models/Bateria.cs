using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Bateria : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mater Ritmo Bateria");
            return true;

        }
    }
    
}