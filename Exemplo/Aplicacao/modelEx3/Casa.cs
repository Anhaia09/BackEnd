using System.ComponentModel;

class Casa
{
    // Composição - uma casa é composta por vários cômodos.
    private List<Comodo> comodos = new List<Comodo>();

    //adicionar comodo
    public void AdicionarComodo(Comodo comodo){
        comodos.Add(comodo);
    }

    //mostrar comodo
    public void MostrarComodos(){
        if(comodos.Any()){
            foreach (Comodo comodo in comodos){
                Console.WriteLine(comodo.Nome);
                }
        }else{
            

        }
    }
}
