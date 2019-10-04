namespace Byte_Bank_Correct
{
    public class ContaCorrente
    {

        public string Titular  {get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        public double Saldo {get;set;}


        public ContaCorrente(string Titular, int Agencia, int Numero)
        {
            this.Titular = Titular;
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Saldo = 0.0;
        }

        public double Deposito(double valor){
            return this.Saldo += valor;
        }

        public bool Saque(double valor){
            if(this.Saldo >= valor){
                this.Saldo -= valor;
                return true;
            } else{
                return false;
            }
        } 

        public bool Tranferencia(ContaCorrente contaDestino, double valor){
            if(this.Saque(valor)){
                contaDestino.Deposito(valor);
                return true;
            } else{
                return false;
            }
        } 

    }
}