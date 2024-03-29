namespace EXERCICIOALUNOS;

class Alunos
{

    public string nome="";

    public double nota1, nota2;

    //MEDIA -> retorna um double (por exemplo um número como 8.3)
    public double obterMedia(){
        double media = (nota1+nota2)/2;
        return media;
    }

    //SITUAÇÃO -> retorna uma string ("Aprovado" ou "Reprovado")
    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="Aprovado";
        }else{
            situacao="Reprovado";
        }
        return situacao;
    }

    //MENSAGEM -> não retorna nada. Só na tela os detalhes (nome, media e situação)
    public void mensagem (){
        double mediaCalculada = obterMedia();
        string resultadoSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome+" está "+resultadoSituacao+" com média: "+mediaCalculada);
    }
}