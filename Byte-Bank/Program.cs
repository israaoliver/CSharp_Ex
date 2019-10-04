using System.Runtime.ConstrainedExecution;
using System;

namespace Byte_Bank
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
            System.Console.Write("Entre com o nome do titular: ");
            string titular = Console.ReadLine();
            
            ContaCorrente contaCorrente1 = new ContaCorrente(titular,agencia,conta);
            double saldo;
            do
            {
                System.Console.Write("Entre com o saldo: ");
                saldo = double.Parse(Console.ReadLine());
                if (saldo > 0){
                    contaCorrente1.Saldo = saldo;
                } else{
                    System.Console.WriteLine("Valor do saldo deve ser positivo!");
                }
                
            } while (saldo < 0);

            System.Console.WriteLine("Saldo Atualizado!");
            #endregion

            #region Minha conta corrente
                
            
             // !: Conta corrente que eu fiz:
            
            /* 
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

            */
            #endregion
        
        #region Deposito
            
        System.Console.WriteLine();

        System.Console.WriteLine("ByteBank - Deposito na conta correte.");
        double deposito;
        do
        {
            Console.Write("Valor a ser Depositado: ");
            deposito = double.Parse(Console.ReadLine());
            if (deposito > 0)
            {
                System.Console.WriteLine("Saldo Atualizado com sucesso");
                saldo = saldo + deposito;
                contaCorrente1.Saldo = saldo;
            } else {
                System.Console.WriteLine("Não é possivel depositar um valor negativo.");
            }
            
        } while (deposito < 0);
        System.Console.WriteLine($"Seu novo saldo é {saldo}R$ ");


        #endregion

        System.Console.WriteLine();

        System.Console.WriteLine("ByteBank - Saque conta corrente. ");
        
        bool SacouDinheiro = false;

        do
        {
            double saque;
            double saldoSaque;
            System.Console.Write("Valor a ser Sacado: ");
            saque = double.Parse(Console.ReadLine());
            saldo = saldoSaque = saldo - saque;
            SacouDinheiro = contaCorrente1.VerificarSaque(saldoSaque);


            if (SacouDinheiro){
                System.Console.WriteLine("Saque feito com sucesso.");
                System.Console.WriteLine($"Agora seu Saldo é {saldo}");
                
            } else {
                System.Console.WriteLine("Não foi possivel realizar essa ação.");
            }
            
        } while (!SacouDinheiro);

        }
    }
}
