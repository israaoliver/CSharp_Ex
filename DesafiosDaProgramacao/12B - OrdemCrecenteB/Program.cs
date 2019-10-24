using System.Linq;
using System;
using System.Collections.Generic;
namespace Desafio12
{
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int[] numeros = new int[3];
        for(int i = 0; i < 3; i++){
            System.Console.WriteLine($"Digite o {i+1}º numero: ");
            numeros[i]= int.Parse(Console.ReadLine());
        }
        var numeroslist = new List<int>();
        for(int i = 0; i < 3; i++){
            numeroslist.Add(numeros[i]);
        }
        System.Console.WriteLine();
        numeroslist.Sort();
        foreach(int item in numeroslist){
            System.Console.WriteLine(item);
        }
    }
}
}