namespace exe02;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();

        cf.Tipo = "Pessoa Física";
        cf.Idade = 50;
        cf.Cpf = 12345678910;

        cj.Tipo = "Pessoa Jurídica";
        cj.Cnpj = 19876543210;
        cj.Inscricao = 13579246810;

        //Contrato Pessoa Fisíca
        Console.WriteLine("Tipo de contrato: " + cf.Tipo);
        Console.WriteLine("Pessoa Física tem: " + cf.Idade + "anos");
        Console.WriteLine("Seu Cpf: " + cf.Cpf);

        //Contrato Pessoa Juridica
        Console.WriteLine("Tipo de contrato: " + cj.Tipo);
        Console.WriteLine("Seu Cnpj: " + cj.Cnpj);
        Console.WriteLine("Inscrição estadual: " +cj.Inscricao);
    }
} 