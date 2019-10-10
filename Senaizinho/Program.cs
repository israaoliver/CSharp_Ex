using System;
namespace Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
        int limiteAlunos = 10;   
        int limiteSalas = 10;
        Aluno[] alunos = new Aluno[100];
        Sala[] salas    = new Sala[10];
        int alunosCadastrados = 0;
        int salasCadastradas = 0;
        // bool querSair;         
            
        }

        public void CadastrarAluno(Aluno[] alunos, int totalAluno, int alunosCadastrado)
        {
            if(totalAluno < alunosCadastrado)
            {
                System.Console.WriteLine("Cadastro de Alunos");
                System.Console.WriteLine();
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Data de Nacimento: ");
                DateTime dtNacimento = DateTime.Parse(Console.ReadLine());

                Aluno novoAluno = new Aluno();
                novoAluno.Nome = nome;
                novoAluno.DataNacimento = dtNacimento;

                int index = 0;
                foreach (Aluno aluno in alunos)
                {
                    if(alunos == null)
                    {
                        alunos[index] = novoAluno;
                        break;
                    }
                    index++;
                }
                alunosCadastrado++;
                
            }
        }
        public void CadastrarSala(){}
        public void AlocarAluno(){}
        public void RemoverAluno(){}
        public void VerificarSalas(){}
        public void VerificarAlunos(){}
        
    


    }

}
