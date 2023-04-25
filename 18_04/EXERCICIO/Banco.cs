namespace EXERCICIO;
class Banco
{   

    public int Numero {get; set;}
    private double Saldo { get;  set;}
    public double Limite {get; private set;}

    public void AjustarLimite(double valor){
        this.Limite = valor;
    }
    public void Depositar( double valor){
        this.Saldo += valor;
    }
    public void Sacar(double valor){
        if (this.Saldo + this.Limite <= valor){
            Console.WriteLine("O valor do seu saque é maior do que possue!");
        }else{
             this.Saldo -= valor;
        }
    }
    public double MostrarSaldo(){
        return this.Saldo + this.Limite;
    }

    public double parcela {get; set;}
    public double valor {get; set;}

    public string emprestimo(int parcelas, double dinheiro){
        this.parcela = parcelas;
        this.valor = dinheiro;
        
        double div = dinheiro/parcelas;
        double mult = dinheiro * 0.06;
        double soma = mult + div;
        double total = soma *parcelas;

        string resultado = "O valor da parcela sem juros é: "+ div +", parcela com juros: "+ mult + ", juros com prestações: "+ soma +", valor total a pagar é de: "+total;
        return resultado;
        
     
    }
    public void imprimi(string texto){
        Console.WriteLine(texto);
    }
}

