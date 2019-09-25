using System;

namespace areas
{
    class Program
    {
        static void Main(string[] args)
        {   
            double alt, bas, bas2, lado, raio, dia, dia2, area;
            string escolha;

            do{


            Console.WriteLine("Escolha  a area geometrica para calcular:");
            Console.WriteLine("Escreva 1 para quadrado.");
            Console.WriteLine("Escreva 2 para Triângulo.");
            Console.WriteLine("Escreva 3 para Circulo.");
            Console.WriteLine("Escreva 4 para Trapézio.");
            Console.WriteLine("Escreva 5 para Retângulo.");
            Console.WriteLine("Escreva 6 para Losango.");
            Console.WriteLine("Escreva 0 para Encerrar.");
            escolha = Console.ReadLine();

            switch (escolha)
                {
                    case "1":

                    Console.WriteLine("Escreva o valor do lado do quadrado:");
                    lado = double.Parse(Console.ReadLine());
                    area = lado * lado;
                    Console.WriteLine($"A area do seu quadrado é A = {lado}² = " + area );
                    break;
                    
                    case "2":
                    Console.WriteLine("Escreva a altura do triângulo:");
                    alt = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escreva a base do triângulo:");
                    bas = double.Parse(Console.ReadLine());
                    area = (bas * alt) / 2;
                    Console.WriteLine($"A area do seu Triângulo é A = ({bas} x {alt}) / 2 = " + area );

                    break;
                    case "3":
                    Console.WriteLine("Escreva o Raio do circulo:");
                    raio = double.Parse(Console.ReadLine());
                    area = 3.14 * (raio * raio);
                    Console.WriteLine($"A area do seu Triângulo é A = pi x {raio}²) = " + area );
                    break;

                    case "4":
                    Console.WriteLine("Escreva a Base maior do Trapézio:");
                    bas = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escreva a Base menor do Trapézio:");
                    bas2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escreva a altura do Trapézio:");
                    alt = double.Parse(Console.ReadLine());
                    area = ((bas + bas2)* alt) / 2;
                    Console.WriteLine($"A area do seu Trapézio é A = ({bas} + {bas2}) x {alt} / 2 = " + area );
                    break;

                    case "5":
                    Console.WriteLine("Escreva a Base do Retângulo:");
                    bas = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escreva a altura do Retângulo:");
                    alt = double.Parse(Console.ReadLine());
                    area = bas * alt;
                    Console.WriteLine($"A area do seu Trapézio é A = {bas} x {alt} = " + area);
                    break;

                    
                    case "6":
                    Console.WriteLine("Escreva a Diagonal maior");
                    dia = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escreva a Diagonal menor");
                    dia2 = double.Parse(Console.ReadLine());
                    area = (dia * dia2) / 2;
                    Console.WriteLine($"A area do seu Trapézio é A = ({dia} x {dia2}) / 2 = " + area);
                    break;

                    case "0":
                    Console.WriteLine("Obrigado!!! Volte sempre!!");
                    break;

                    default:
                    Console.WriteLine("Coloque uma das opções pedidas!!");
                    break;

                

                }


            
            } while(escolha != "0");

        }
    }
}
