using System;

//Atributos
public class Cafe: Bebida{
    public string Tipo { get; private set;}

//Construtor

public Cafe(string nome,decimal preco,string tamanho, string tipo): base(nome,preco,tamanho){

    Tipo = tipo;
    Preco = CalcularPreco();
}

//Metodos
    public override decimal CalcularPreco()
    {
        return Tamanho == "Grande" ? Preco*2 : Preco; ;
    }

    //ToString

    public override string ToString()
    {
        return $"Nome: {Nome}, Preco: {Preco:C}, Tamanho: {Tamanho}, Tipo: {Tipo}";
    }
}