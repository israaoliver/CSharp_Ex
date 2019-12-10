using System.Xml.Serialization;
using System;

namespace Kahoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = {
                {10, 15, 48},
                {56, 97, 77},
                {2, 100 , 33}
            };

            int soma = 0;
            
            foreach(var item in matriz)
            {
                soma += item;
            }

            System.Console.WriteLine(soma);
    }
}
}
