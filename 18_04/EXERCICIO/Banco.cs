namespace EXERCICIO;
class Banco{

    public double Valor;

    public double obterjuros(){
        double juros = ((Valor * 0.06)*12) + Valor;
        return juros;
    }

    public double Mensal(){
        double Mes = ((Valor * 0.06) + Valor /12);
        return Mes;
    }
}

