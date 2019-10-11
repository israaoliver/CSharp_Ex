using System;

namespace Byte_Bank_Correct
{
    public class Cliente
    {
        private string _Nome  ;
        private string _Cpf   ;
        private string _Email ;
        private string _Senha;

        public string Senha{
            
            get {return _Senha;}
        }

        public string Cpf
        {
            get {return _Cpf;}
            set { _Cpf = value;}
        }
        public string Nome
        {
            get {return _Nome;}
            set { _Nome = value;}
        }
        public string Email
        {
            get {return _Email;}
            
        }
        
        public Cliente(string Nome, string Cpf, string Email)
        {
            this._Nome = Nome;
            this.Cpf = Cpf;
            this._Email = Email;
        }

        
        // todo: verificação sa senha 
        public bool TrocaSenha(string senha)
        {
            if((senha.Length > 6) && (senha.Length < 16)){
                this._Senha = senha;
                return true;
            } else{
                return false;
            }
        }

    }
}