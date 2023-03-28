namespace PROJETO_PESSOA;
class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("godofredo", 15);
        //p1.AlteraNome("Lucas");
        //p1.AlteraSobreNome("Prates");
        //p1.AlteraIdade(15);
        p1.MostraDados();
    }
}
