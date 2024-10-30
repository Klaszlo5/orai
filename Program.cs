using App;


internal class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        Product product1 = new Product("Laptop", 1200, true);
        Product product2 = new Product("Okostelefon", 800, false);
        inventory.AddProduct(product1);
        inventory.AddProduct(product2);

        inventory.ListProducts();

        Console.WriteLine(inventory.FindProduct("Laptop"));

        inventory.RemoveProduct("Okostelefon");

        inventory.SaveToFile("products.json");
        inventory.LoadFromFile("products.json");
    }
}