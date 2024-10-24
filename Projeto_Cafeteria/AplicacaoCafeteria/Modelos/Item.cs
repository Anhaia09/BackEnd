using System; // using é a mesma coisa que import no java, estou importando a biblioteca System
                //namespace é equivalente ao package do Java
public class Item{
    // Atributos da classe sempre com letra Maiuscula , metodos e classes também
    public string Nome{ get; private set; }
    public decimal Preco{ get; protected set; } 

    // Construtor

    public Item(string nome, decimal preco){
        Nome = nome;
        Preco = preco;
    }

    // Metodos 

    public virtual decimal CalcularPreco(){
        return Preco;
    }

    // toString()
    public override string ToString()
    {
        return $"Item: {Nome}, Preço: {Preco:C}";
    }
}