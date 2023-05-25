namespace exe03;
class ContratoPessoaJuridica:Contrato{
    public override double CalculoPrestacao(){
    return ((base.CalculoPrestacao()/Pz)+3);
   }
}