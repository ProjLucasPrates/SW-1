namespace EXERCICIO;
class Program
{
    static void Main(string[] args){
        
        Banco b = new Banco();

        Console.Write("Digite o valor do seu emprestimo: ");
        b.Valor = double.Parse(Console.ReadLine());

        Console.WriteLine("Seu emprestimo é de: " + b.Valor);
        Console.WriteLine("Seu juros do emprestimo é de: " + b.obterjuros());
        Console.WriteLine("Seu juros mensais iram ser de: " + b.Mensal() + " por mês");
    }
}
