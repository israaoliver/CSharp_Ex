namespace Byte_Bank
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
        
        public bool VerificarSaque(double saldoSaque)
        {
            this.Saldo -= saldoSaque;
            if(saldoSaque > 0){
                return true;
                
        
            } else{
                return false;
            }
        }

    }
}