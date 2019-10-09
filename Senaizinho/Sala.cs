using System;
namespace Senaizinho
{
    public class Sala
    {
        public int capacidadeAtual{get;set;} 
        public int capacidadeTotal{get;set;} 
        public int numeroSala{get;set;}
        public string[] Alunos {get;set;}



        public Sala(int capacidadeAtual, int capacidadeTotal)
        {
            this.capacidadeAtual = capacidadeAtual;
            this.capacidadeTotal = capacidadeTotal;
        }

        public bool AlocarAluno(string alocar)
        {
            if(){

            }
        }
        
        public bool RemoverAluno(string remover)
        {}

        public bool MostrarAlunos(string mostrar)
        {}

    }
}