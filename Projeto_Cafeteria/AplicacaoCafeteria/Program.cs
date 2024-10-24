using System;

public class Program{

    public static void Main(string[] args){
        Item item = new Item("Pão de queijo", 5.90m);
        Console.WriteLine(item);

        Item bebida = new Cafe("Capuccino",4,"Grande","Expresso");
        Console.WriteLine(bebida);

        Item sobremesa = new Sobremesa("Bolo",6,"Ninho");

    }
}