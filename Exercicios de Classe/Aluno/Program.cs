using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Deus Gamer", "435.456.768-98");
            Aluno aluno2 = new Aluno("Ser Gamer","876.234.546-00","Prog1");

             Console.WriteLine("Nome: " + aluno1.Nome);
             Console.WriteLine("CPF: " + aluno1.Cpf);    
             Console.WriteLine("Curso: " + aluno1.Curso);  
             
             Console.WriteLine("Nome: " + aluno2.Nome);
             Console.WriteLine("CPF: " + aluno2.Cpf);
             Console.WriteLine("Curso: " + aluno2.Curso);

             Console.Write("Entre com a Nome:  ");
             string Nome = Console.ReadLine();
             Console.Write("Entre com a Cpf:  ");
             string Cpf = Console.ReadLine();
             Console.Write("Entre com a Curso:  ");
             string Curso = Console.ReadLine();
             Console.Write("Entre com a nota:  ");
             int nota = int.Parse(Console.ReadLine());
             Console.Write("Entre com a bimestre:  ");
             int bimestre = int.Parse(Console.ReadLine());
             Aluno aluno3 = new Aluno(Nome,Cpf,Curso);
             aluno3.setNotas(bimestre,notas);

             Console.WriteLine("Nome: " + aluno3.Nome);
             Console.WriteLine("CPF: " + aluno3.Cpf);
             Console.WriteLine("Curso: " + aluno3.Curso);
             Console.WriteLine("Notas: ");
             foreach(int n in aluno3.getNotas()){
                 Console.Write(n + " ");
             }

             Console.WriteLine("");


        }
    }
}
