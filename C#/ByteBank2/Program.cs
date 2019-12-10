using System;
using ByteBank2.Models;
namespace ByteBank2
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente contaCorrente1 = new ContaCorrente (1, 1, "Alexandre O Grande");
            ContaCorrente contaCorrente2 = new ContaCorrente (1, 1, "Katie Bouman");

            ContaEspecial contaEspecial1 = new ContaEspecial (1,2,"Julio Cezar");

            DepositarConta(contaCorrente1);
            DepositarConta(contaEspecial1);
            
            double limite = 1000;
            contaEspecial1.SetLimite(limite);
            

            SacarConta(contaCorrente1);
            SacarConta(contaCorrente2);
            

            #region Depósito

            #endregion
        }

        public static void DepositarConta(ContaBancaria contaBancaria)
        {
            Console.Clear();
            string usuario = contaBancaria.Titular;
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"Conta: {contaBancaria.GetType()}");
            System.Console.WriteLine($"Bem Vindo - {usuario}");
            System.Console.WriteLine($"Agencia {contaBancaria.Agencia} Conta: {contaBancaria.NumeroConta}");
            System.Console.WriteLine($"Saldo: {contaBancaria.Saldo}");
            System.Console.WriteLine();
            System.Console.Write("Digite o valor do Depósito: ");
            double valor = double.Parse(Console.ReadLine());
            if(contaBancaria.Deposito(valor)){
                System.Console.WriteLine("Deposito Realizado com Sucesso!");

            }else{
                System.Console.WriteLine("Não foi possivel realizar o Deposito");
                
            }

            System.Console.WriteLine();
            System.Console.WriteLine($"Saldo Atual: {contaBancaria.Saldo}");
            System.Console.WriteLine();
            Continue();


        }
        public static void SacarConta(ContaBancaria contaBancaria)
        {
            Console.Clear();
            string usuario = contaBancaria.Titular;
            System.Console.WriteLine("ByteBank - Saque");
            System.Console.WriteLine($"Conta: {contaBancaria.GetType()}");
            System.Console.WriteLine($"Bem Vindo - {usuario}");
            System.Console.WriteLine($"Agencia {contaBancaria.Agencia} Conta: {contaBancaria.Titular}");
            System.Console.WriteLine($"Saldo: {contaBancaria.Saldo}");
            System.Console.WriteLine();
            System.Console.Write("Digite o valor do Saque: ");
            double Valor = double.Parse(Console.ReadLine());
            contaBancaria.Saque(Valor);
            if(contaBancaria.Saque(Valor)){
                System.Console.WriteLine("Saque Realizado com Sucesso!");

            }else{
                System.Console.WriteLine("Não foi possivel realizar o Saque");
                
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Saldo Atual: {contaBancaria.Saldo}");
            System.Console.WriteLine();

            Continue();


            
        }
        public static void TrasferenciaEntreContas(ContaBancaria conta1, ContaBancaria conta2)
        {
            string usuario = conta1.Titular;
            System.Console.WriteLine("ByteBank - Transferência");
            System.Console.WriteLine($"Conta: {conta1.GetType()}");
            System.Console.WriteLine($"Bem Vindo - {usuario}");
            System.Console.WriteLine($"Agencia {conta1.Agencia} Conta: {conta1.Titular}");
            System.Console.WriteLine($"Saldo: {conta1.Saldo}");
            System.Console.WriteLine();
            System.Console.Write("Digite o valor da Transferência: ");
            double valor = double.Parse(Console.ReadLine());
            if(conta1.Transferencia(conta2,valor)){
                System.Console.WriteLine("Transferência Efetuada.");
                
            } else{
                System.Console.WriteLine("Não foi possivel Realizar a essa ação.");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Saldo Atual: {conta1.Saldo}");
            System.Console.WriteLine();

            Continue();
        }

        public static void Continue()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Enter Para continuar");
            Console.ReadLine();

        }

    }
}
