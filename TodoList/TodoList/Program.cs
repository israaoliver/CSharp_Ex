using System.Runtime.ConstrainedExecution;
using System;
using System.Collections.Generic;
using System.IO;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TodoItem> todoList = new List<TodoItem>();
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName;

            try{
                string[] todoFile = File.ReadAllLines(filePath);

                foreach (string line in todoFile)
                {
                    string[] itens =  line.Split(",");
                    string titulo = itens[0].Replace("\"","");
                    string nota = itens[1].Replace("\"","");

                    TodoItem todoItem = new TodoItem(titulo, nota);
                    todoList.Add(todoItem);
                }
            } catch (IOException ioe) {
                System.Console.WriteLine("Erro ao acessar arquivo");
                System.Console.WriteLine(ioe.Message);
            }

            int opcao = 0;

            do
            {
                Console.Clear();
                System.Console.WriteLine("TODO LIST");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine("Digite uma opção:");
                System.Console.WriteLine("1 - Adicione um item ");
                System.Console.WriteLine("2 - Remover Item ");
                System.Console.WriteLine("3 - Sair do Progama ");
                System.Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // todo: Método de adicionar itens a lista
                    break;

                    case 2:
                        // todo: Método de remover itens a lista
                    break;

                    case 3:
                        System.Console.WriteLine("GoodBye!");
                    break;
                    default:
                    System.Console.WriteLine("Opção inválida");
                    Console.Clear();
                    break;
                }
            } while (opcao != 3);
        }
        
        public static void ListaItens(List<TodoItem> todoList)
        {
            Console.Clear();
            int count = 1;
            System.Console.WriteLine("Todo List");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID{"",2} Titulo{"",12} Notas");
            foreach (TodoItem item in todoList)
            {
                System.Console.WriteLine($"{count, 3}: {item.Titulo, -15} - {item.Nota}");
                count++;
                
            }
        }
    }
}
