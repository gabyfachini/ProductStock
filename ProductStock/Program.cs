using Stock;
using System.Security.AccessControl;

ProductList products = new ProductList();
while (true)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Register products");
    Console.WriteLine("2. Register more stock");
    Console.WriteLine("3. View products and stock");
    Console.WriteLine("4. Exit");
    string option = Console.ReadLine();

    switch (option)
    {
        case "1": //Add product information
            Console.WriteLine("Product name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Supplier: ");
            string supplier = Console.ReadLine();
            Console.WriteLine("Category: ");
            string category = Console.ReadLine();
            Console.WriteLine("Current stock: ");
            int quantity = int.Parse(Console.ReadLine());
            products.AddProduct(new Store(name, supplier, category, quantity));
            Console.ReadKey();
            Console.Clear();
            break;
        case "2":
            Console.WriteLine("Enter the desired index: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a new stock quantity: ");
            int code = int.Parse(Console.ReadLine());
            products.UpdateStock(index, code);
            Console.ReadKey();
            Console.Clear();
            break;
        case "3":
            products.ListProducts();
            Console.ReadKey();
            Console.Clear();
            break;
        case "4":
            Console.WriteLine("Exiting program  ...");
            return;

    }
}