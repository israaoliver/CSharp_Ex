using System;

namespace LitragemDoCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            string menuBar = "=============================================================================";
            System.Console.WriteLine(menuBar);
            System.Console.WriteLine("                                  Bem vindo!!!");
            System.Console.WriteLine("Coloque as informação para descobrir quantos litros forma gastos na sua viagem.");
            System.Console.WriteLine(menuBar);
            System.Console.WriteLine();

            System.Console.Write("Quanto tempo durou sua viagem em horas: ");
            double time = double.Parse(Console.ReadLine());
            System.Console.Write("Qual foi a velocidade média do seu carro: ");
            double km = double.Parse(Console.ReadLine());

            double distancia = time * km;
            double gastos = distancia/12;
            
            System.Console.WriteLine($"A {km}km/h durante {time}horas,");
            System.Console.WriteLine($"Você percorreu {distancia}km é");
            System.Console.WriteLine($"seu carro gastou {gastos} litros");
        }
    }
}
