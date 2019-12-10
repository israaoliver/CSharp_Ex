using System;

namespace Byte_Bank_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cadastro do Cliente

                
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
            #endregion
            
            #region Cadastro Conta
                
            
            Console.Clear();
            System.Console.WriteLine("ByteBank - Cadastro de Conta");
            System.Console.Write("Entre com a Agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.Write("Entre com a conta: ");
            int conta = int.Parse(Console.ReadLine());
            
            ContaCorrente contaCorrente1 = new ContaCorrente(cliente1,agencia,conta);
            double saldo;
            bool depositou = true;
            do
            {
                System.Console.Write("Entre com o saldo: ");
                saldo = double.Parse(Console.ReadLine());
                depositou = contaCorrente1.Deposito(saldo);
                if (!depositou){

                    System.Console.WriteLine("Valor do saldo deve ser positivo!");
                }
                
            } while (!depositou);

            System.Console.WriteLine("Saldo Atualizado!");
            System.Console.WriteLine();
            #endregion

            Cliente cliente2 = new Cliente("Cesar","123.123.123-12","1@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(cliente2,123,321);

            #region Depósito
            Cliente usuario = contaCorrente1.Titular;
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"Bem Vindo - {usuario}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Titular}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.Write("Digite o valor do Depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente1.Deposito(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            #endregion

            #region Saque.
            System.Console.WriteLine("ByteBank - Saque");
            System.Console.WriteLine($"Bem Vindo - {usuario}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Titular}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.Write("Digite o valor do Saque: ");
            valor = double.Parse(Console.ReadLine());
            contaCorrente1.Saque(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
                
            #endregion

            
            #region Transferência.
            System.Console.WriteLine("ByteBank - Transferência");
            System.Console.WriteLine($"Bem Vindo - {usuario}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Titular}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.Write("Digite o valor da Transferência: ");
            valor = double.Parse(Console.ReadLine());
            if(contaCorrente1.Tranferencia(contaCorrente2,valor)){
                System.Console.WriteLine("Transferência Efetuada.");
                
            } else{
                System.Console.WriteLine("Não foi possivel Realizar a essa ação.");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
                
            #endregion


        }
    }
}
