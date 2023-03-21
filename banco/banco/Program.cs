namespace banco;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Banco dos Melhores!");
        Conta c = new Conta();
        // c.Saldo = 1500;
        c.Depositar(1500);
        //c.Limite = 500;
        c.AjustaLimite(500);

        c.Sacar(5000);

        //Console.WriteLine("Seu saldo é de: " + c.Saldo +" E seu limite é de:" + c.Limite) ;
        Console.WriteLine("Seu saldo é de: " + c.MostrarSaldo());
    }
}
