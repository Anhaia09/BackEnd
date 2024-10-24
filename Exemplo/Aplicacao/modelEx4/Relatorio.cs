class Relatorio : Imprimivel{

    private string Nome;
    public Relatorio(string nome){
       Nome = nome;
    }

    public void Imprimir(){
        Console.WriteLine("imprimindo Relatório: " + Nome);
    }
}