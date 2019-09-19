using System;

namespace Calculadora_funcional
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int calculo = 0;
            String oper;
            

           Console.WriteLine("Digite o 1º número:");
           num1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o 2º número:");
           num2 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o operador:");
           oper = Console.ReadLine();

           switch (oper)
           {
               case "+":
               
                calculo = num1 + num2;
                Console.WriteLine($"{num1}+{num2} = " + calculo);
               break;
               
               case "-":
               
                calculo = num1 - num2;
                Console.WriteLine($"{num1}-{num2} = " + calculo);
                 break;
               
               case "*":
               
                calculo = num1 * num2;
                Console.WriteLine($"{num1}*{num2} = " + calculo);
                break;
               
               case "/":
               
                   calculo = num1 / num2;
                   Console.WriteLine($"{num1}/{num2} = " + calculo);
                   break;
               
               case "%":
               
                   calculo = num1 % num2;
                   Console.WriteLine($"{num1}%{num2} = " + calculo);
                   break;
               
               default:
               
                   Console.WriteLine("Por Favor digite uma operação valida!!");
                   break;

                  
                   
           }


        }
    }
}
