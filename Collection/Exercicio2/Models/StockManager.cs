public class StockManager{
    public List<Product> Products = new List<Product>();

    // Adicionar produto
    public void AddProduct(string name, double price){
        Products.Add(new Product(name, price));
    }

    // Remover produto
    public bool RemoveProduct(string name){
        foreach(Product product in Products){
            if(product.Name.Equals(name)){
                Products.Remove(product);
                return true;
            }
        }
        return false;
    }

    // Pesquisar produto
    public string SearchProduct(string name){ 
        foreach(Product product in Products){
            if(product.Name.Equals(name))
                return product.ToString();
        }
        return "Product not found!";
    }

    // Listar todos os produtos
    public void ListAllProducts(){ 
        foreach(Product product in Products){
            Console.WriteLine(product);
        }
    }
}
