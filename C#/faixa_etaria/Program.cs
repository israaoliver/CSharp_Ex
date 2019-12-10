using System;

namespace faixa_etaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int ano;

            Console.WriteLine("Qual o ano que vc naceu?");
            ano = int.Parse(Console.ReadLine());

            while((ano > 2019) || (ano < 1900 )){
                Console.WriteLine("Fala serio fdp???");
                Console.WriteLine("Escreve direto porra!");
                ano = int.Parse(Console.ReadLine());

            }

            idade = 2019 - ano  ;

            if(idade <=2){
                Console.WriteLine("Você é um Recém-Nacido");
                Console.WriteLine($"Com {idade} anos");
                
            } else if(idade <=11){
                Console.WriteLine("Você é Criança");
                Console.WriteLine($"Com {idade} anos");
            } else if(idade <=19){
                Console.WriteLine("Você é Adolecente");
                Console.WriteLine($"Com {idade} anos");
            } else if(idade <=65){
                Console.WriteLine("Você é Adulto");
                Console.WriteLine($"Com {idade} anos");
            } else if(idade > 65){
                Console.WriteLine("Você é idoso");
                Console.WriteLine($"Com {idade} anos");
            }
        }
    }
}
