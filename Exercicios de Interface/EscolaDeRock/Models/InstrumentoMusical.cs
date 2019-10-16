using System;
namespace EscolaDeRock.Models
{

    class InstrumentoMusical
    {
        string[] notas = { "D6" , "R6" , "Mi" , "Fá" , "Sol" , "Lá" , "Si"};

        public string TocarMusica()
        {

            int nota = new Random().Next(notas.Length - 1);
            return notas[nota];
        }
        
    }
    
}