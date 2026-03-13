using System;
using ProductStock; // Correct namespace matching Stock.cs and ProductList.cs

ProductList products = new ProductList();

// Main application loop
while (true)
{
    Console.WriteLine("\n========== STOCK MANAGER ==========");
    Console.WriteLine("1. Register product");
    Console.WriteLine("2. Add more stock to existing product");
    Console.WriteLine("3. Set stock quantity (overwrite)");
    Console.WriteLine("4. Remove product");
    Console.WriteLine("5. View all products");
    Console.WriteLine("6. Exit");
    Console.WriteLine("====================================");
    Console.Write("Choose an option: ");

    string option = Console.ReadLine()?.Trim();

    switch (option)
    {
        case "1": // Register a new product
            Console.Write("Product name: ");
            string name = Console.ReadLine();

            Console.Write("Supplier: ");
            string supplier = Console.ReadLine();

            Console.Write("Category: ");
            string category = Console.ReadLine();

            Console.Write("Current stock quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 0)
            {
                Console.WriteLine("Invalid quantity. Please enter a non-negative integer.");
                break;
            }

            Console.Write("Unit price (R$): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal price) || price < 0)
            {
                Console.WriteLine("Invalid price. Please enter a non-negative number.");
                break;
            }

            products.AddProduct(new Store(name, supplier, category, quantity, price));
            break;

        case "2": // Add more units to an existing product's stock
            if (products.Count == 0)
            {
                Console.WriteLine("No products registered yet.");
                break;
            }

            products.ListProducts();
            Console.Write("Enter the product index: ");
            if (!int.TryParse(Console.ReadLine(), out int addIndex))
            {
                Console.WriteLine("Invalid index.");
                break;
            }

            Console.Write("Enter the amount to add: ");
            if (!int.TryParse(Console.ReadLine(), out int addAmount) || addAmount <= 0)
            {
                Console.WriteLine("Amount must be a positive integer.");
                break;
            }

            products.AddToStock(addIndex, addAmount);
            break;

        case "3": // Overwrite stock quantity for a product
            if (products.Count == 0)
            {
                Console.WriteLine("No products registered yet.");
                break;
            }

            products.ListProducts();
            Console.Write("Enter the product index: ");
            if (!int.TryParse(Console.ReadLine(), out int updateIndex))
            {
                Console.WriteLine("Invalid index.");
                break;
            }

            Console.Write("Enter the new stock quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int newQty) || newQty < 0)
            {
                Console.WriteLine("Quantity must be a non-negative integer.");
                break;
            }

            products.UpdateStock(updateIndex, newQty);
            break;

        case "4": // Remove a product from the list
            if (products.Count == 0)
            {
                Console.WriteLine("No products registered yet.");
                break;
            }

            products.ListProducts();
            Console.Write("Enter the product index to remove: ");
            if (!int.TryParse(Console.ReadLine(), out int removeIndex))
            {
                Console.WriteLine("Invalid index.");
                break;
            }

            products.RemoveProduct(removeIndex);
            break;

        case "5": // Display all registered products
            products.ListProducts();
            break;

        case "6": // Exit the application
            Console.WriteLine("Exiting program... Goodbye!");
            return;

        default:
            Console.WriteLine("Invalid option. Please choose a number between 1 and 6.");
            break;
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
    Console.Clear();
}