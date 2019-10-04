using System;

namespace Byte_Bank_Correct
{
    public class Cliente
    {
        public string Nome  {get;set;}
        public string Cpf   {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        
        public Cliente(string Nome, string Cpf, string Email)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }

        
        // todo: verificação sa senha 
        public bool TrocaSenha(string senha)
        {
            if((senha.Length > 6) && (senha.Length < 16)){
                this.Senha = senha;
                return true;
            } else{
                return false;
            }
        }

    }
}