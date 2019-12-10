using System;

namespace nota_funcional
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("Entre com a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 +nota4) / 4;

            Console.WriteLine("Sua media é " + media);

            if (media >=8)
            {
            Console.WriteLine("Você Passou!");
            Console.WriteLine("Parabéns sua nota esta a cima da media");
            } else if(media == 7){
                Console.WriteLine("Você Passou!");
                Console.WriteLine("Você esta na media");
            } else if(media ==6 ){
                Console.WriteLine("Você Reprovou!!");
                Console.WriteLine("Se esforce mais na proxima vez.");
            } else if(media < 5){
                Console.WriteLine("Você Passou longe.");
                Console.WriteLine("Parabens vc é um animal!!");
            }
            

        }
    }
}
