using System;

namespace McBonalds_cadastro
{
    public class  Cliente {

        //Propridades
        public string Nome; //Nome do cliente
        public string Endereco; //Endereço
        public string Telefone; // Telefone do cliente
        public string Senha; // Senha de acesso do cliente ao sistema 
        public string Email; // Email do cliente e nome de usuário do sistema
        public DateTime DataNacimento; // Data de nacimento do cliente 

        //Construtores 
        public Cliente(string Nome, string Telefone, string Email){
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }
        



    }

} 