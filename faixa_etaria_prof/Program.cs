using System;

namespace faixa_etaria_prof
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int ano;
            
            do{

            Console.WriteLine("Qual o ano do seu nacimento:" );
            ano = int.Parse(Console.ReadLine());
            if((ano > 2021) || (ano < 0)){
                Console.WriteLine("Data invalida!!" );                
            }
            } while((ano > 2021) || (ano < 0));

            idade = 2019 - ano  ;

            if(idade < 3){
                Console.WriteLine("Você é um Recém-Nacido");      
            } else if((idade >=12) && (idade <=11)){
                Console.WriteLine("Você é Criança");
            } else if((idade >=12) && (idade <=19)){
                Console.WriteLine("Você é Adolecente");
            } else if((idade >=20) && (idade <=65)){
                Console.WriteLine("Você é Adulto");
            } else if(idade > 65){
                Console.WriteLine("Você é idoso");
            }
        }
    }
}
