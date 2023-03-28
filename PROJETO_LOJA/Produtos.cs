namespace PROJETO_LOJA;
class Produtos
{
    public Produtos(){
        this.Nome = "Lucas";
        this.Preco = 50;
    }

    public Produtos(string nome){
        this.Nome = nome;
        this.Preco = 10;
    }
    public Produtos(string nome, int desconto){
        this.Nome = nome;
        this.Preco = 10 -(10*desconto/100) ;   
    }
    private string? Nome {get;set;}
    private double Preco {get;set;}

    public void AlternaNome(string nome){
        this.Nome = nome;
    }
    public void AlternaPreco(double preco){
        this.Preco = preco;
    }
    public void MostraDados(){
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Preço: " + this.Preco);
    }
}
