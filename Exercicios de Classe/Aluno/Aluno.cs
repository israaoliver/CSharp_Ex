using System;

namespace Aluno
{
    public class Aluno{
        //Propriedades
        public string Nome{get;set;}
        public string Curso{get;set;}
        public string Cpf{get;set;}
        public int[] Notas; 


        //contrutor
        public Aluno(string Nome, string Cpf){
            this.Nome = Nome;
            this.Cpf = Cpf;
            Notas = new int [4];
        }

        public Aluno(string Nome, string Cpf, String Curso){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Curso = Curso;
            Notas = new int [4];
        }

        //Metodo de acesso
        public int[] getNotas(){return notas;}

        public void setNotas(int bi, int nota){
            int i = bi -1;
            if ((i < 0) || (i > 3)){
                //Condição de Erro
                throw new ArgumentOutOfRangeException($"{nameof(Notas)} must be between 1 and 4.");
            } else if (nota < 0 || nota > 10){
                //Condição de Erro;
                throw new ArgumentOutOfRangeException($"{nameof(Notas)} must be  between 0 and 10.");
            } else {
                this.Notas[indice] = nota;

            }
        }
    }
}