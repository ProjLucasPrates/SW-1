namespace agregacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com Agregação!");

        //instanciando os objetos de cada classe
        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();

        //instanciando um nome parar um cliente
        cli.Nome = "Lucas Prates";

        //Adicionando número e validadde do Cartão de Crédito
        cdc.Numero = "123456678";
        cdc.DataValidade = "05/2030";

        //Associando o cliente ao atributo de agregação ao Cartão de Crédito
        cdc.Cliente = cli;  

        //visualizando as informações
        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cliente é: " + cdc.Numero);
        Console.WriteLine("A data de validadde é: " + cdc.DataValidade);
        Console.WriteLine("O nome da cliente  AGREGADO é: " + cdc.Cliente.Nome);

    }
}
