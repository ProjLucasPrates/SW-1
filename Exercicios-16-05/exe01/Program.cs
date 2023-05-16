namespace exe01;
class Program
{
    static void Main(string[] args)
    {
        Homem h = new Homem();
        Gato g = new Gato();
        Cao c = new Cao();

        Console.WriteLine("O homem " + h.Fala());
        Console.WriteLine("O gato " + g.Fala());
        Console.WriteLine("O cao " + c.Fala());
    }
}
