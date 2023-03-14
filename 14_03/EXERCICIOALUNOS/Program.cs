namespace EXERCICIOALUNOS;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();
        aluno1.nome = "Lucas Prates";
        aluno1.nota1 = 4;
        aluno1.nota2 = 5;

        aluno1.mensagem();
    }
}
