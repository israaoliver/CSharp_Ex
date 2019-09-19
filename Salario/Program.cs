using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal;
        

            Console.WriteLine("Quanto você ganhou no ultimo mês");
            sal = double.Parse(Console.ReadLine());

            if(sal < 500)
            {
                
                Console.WriteLine("Você ganhou um aumento de 30%!!");
                Console.WriteLine("Teve um aumento de : " + (sal * 0.3));
                Console.WriteLine("Agora seu salario é: " + (sal * 1.3));  
            } else{
                Console.WriteLine("Seu salario esta ok");
            }          

        }
    }
}
