namespace exe03;
class Program
{
    static void Main(string[] args)
    {
       Contrato c = new Contrato();
       ContratoPessoaJuridica pj = new ContratoPessoaJuridica();
       ContratoPessoaFisica pf = new ContratoPessoaFisica();


       pf.Tipo = "Pessoa Física";
       pf.Idade = 60;
       pf.Pf = 12345678910;

       pj.Tipo = "Pessoa Jurídica";
       pj.Pj= 01987654321;
       pj.Inscricao = 10754857;

       pf.Pz = 10;
       pj.Pz = 10;


        Console.WriteLine(" Tipo:" + pf.Tipo + " #idade: " +  pf.Idade  +  " #cpf " + pf.Pf + "//Valor do contrato: " + pf.CalculoPrestacao() + "//Prazo de pagamento: "+ pf.Pz + "//Valor das prestações: " + pf.CalculoPrestacao() );
        Console.WriteLine(" Tipo:" + pj.Tipo + " #inscrição: " +  pj.Inscricao  +  " #cnpj " + pj.Pj  + "//Valor do contrato: " + pj.CalculoPrestacao() + "//Prazo de pagamento: " + pj.Pz + "//Valor das prestações: " + pj.CalculoPrestacao());
    }
}
