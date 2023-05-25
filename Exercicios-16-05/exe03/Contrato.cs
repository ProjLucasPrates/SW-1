namespace exe03;
class Contrato{
    public int Idade {get;set;}

    public long Pf {get;set;}

    public int Inscricao {get;set;}

    public long Pj {get;set;}

    public string? Tipo {get;set;}

    public int Pz {get;set;}

    public virtual double CalculoPrestacao(){
        return 1000;
    }

}