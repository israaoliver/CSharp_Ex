using System;
using System.Collections.Generic;

namespace Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteAlunos = 10;
            int limiteSalas = 10;
            
            int[] alunos = new int[10];
            int[] salas = new int[10];

            int alunosCadastrados;
            int salasCadastradas;

            int option;

            do
            {
                Console.Clear();
                System.Console.WriteLine("Escola de Informatica SENAIzinho");
                System.Console.WriteLine();

                System.Console.WriteLine("Digite uma opção:");
                System.Console.WriteLine("1 - Cadastrar Aluno");
                System.Console.WriteLine("2 - Cadastrar Sala");
                System.Console.WriteLine("3 - Alocar Aluno");
                System.Console.WriteLine("4 - Remover Aluno");
                System.Console.WriteLine("5 - Verificar Salas");
                System.Console.WriteLine("6 - Verificar Alunos");
                System.Console.WriteLine("0 - Sair");
                System.Console.WriteLine("Opção: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        // todo: Metodo de cadstro de Aluno
                        break;
                    case 2:
                     // todo: Metodo de cadastro da sala
                        break;
                    case 3:
                    // todo: Metodo da class Sala de alocar aluno
                        break;
                    case 4:
                    // todo: Metodo de Remover Aluno
                        break;
                    case 5:
                    // todo: Verificar sala 
                        break;
                    case 6:
                    // todo: Verificar Sala
                        break;
                    case 0:
                    System.Console.WriteLine("Falou Valeu!");
                        break;
                }                
            } while (option !=0);

        }
    
        public static void CadastrarAluno()
        {
            
        }
        public static void CadastrarSala()
        {

        }

        public static void AlocarAluno()
        {

        }

        public static void  RemoverAluno()
        {

        }
        public static void VerificarSalas()
        {
            
        }

    }

}
