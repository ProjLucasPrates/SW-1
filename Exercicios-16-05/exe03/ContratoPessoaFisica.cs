namespace exe03;
class ContratoPessoaFisica:Contrato{
    public override double CalculoPrestacao(){
    if (Idade <= 30)
    {
        return ((base.CalculoPrestacao()/Pz)+1);
    }
    else if (Idade <= 40) 
    {
        return ((base.CalculoPrestacao()/Pz)+2);
    }
    else if (Idade <= 50) 
    {
        return ((base.CalculoPrestacao()/Pz)+3);
    }
    else 
    {
        return ((base.CalculoPrestacao()/Pz)+4);
    }
}
  
}