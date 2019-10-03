using System;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("ByteBank - Cadastro de Clientes");
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente cliente1 = new Cliente(nome,cpf,email);
            
            bool trocouSenha = false;
            do{
                System.Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(senha);
                if (trocouSenha){
                    System.Console.WriteLine("Senha alterada com sucesso!");
                } else{
                    System.Console.WriteLine("Senha Invalida!!");
                }
            }while(!trocouSenha);

            Console.Clear();
            System.Console.WriteLine("ByteBank - Cadastro de Conta-Corrent");
            System.Console.Write("Titular: ");
            string titular = Console.ReadLine();
            System.Console.Write("Agência: ");
            int agencia = Int32.Parse(Console.ReadLine());
            System.Console.Write("Numero do Cartão: ");
            int numero = Int32.Parse(Console.ReadLine());

            double saldo = 0;            
            do{
                

                System.Console.Write("Qual o Saldo da Conta: ");
                saldo = double.Parse(Console.ReadLine());

                if(saldo >=0)
                {
                    System.Console.WriteLine("Conta Salva com sucesso");
                } else {
                    System.Console.WriteLine("Valor Invalido!");
                }

            }while(saldo < 0);

            
            


        }
    }
}
