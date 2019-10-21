using System.Collections.Generic;

namespace Reciclagem.Models
{
    public class Lixo
    {
        public static Dictionary<int , JogandoNoLixo> Embalagens = new Dictionary<int, JogandoNoLixo>()
        {
            { 0, new Garrafa() },
            { 1, new GarrafaPet() },
            { 2, new GuardaChuva() },
            { 3, new Latinha() },
            { 4, new Papelao() },
            { 5, new PoteManteiga() },
            { 6, new Salgadinhos() },
            { 7, new Sobras() }
        };
        
    }
    
}