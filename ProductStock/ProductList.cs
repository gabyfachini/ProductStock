using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductStock
{
    // Manages a collection of stock items
    internal class ProductList
    {
        private List<Stock> stocks = new List<Stock>(); // Internal list of all registered products

        // Adds a new product to the stock list
        public void AddProduct(Stock stock)
        {
            stocks.Add(stock);
            stock.AddProducts();
            Console.WriteLine("Product registered successfully!");
        }

        // Displays all products with their index (1-based for user friendliness)
        public void ListProducts()
        {
            if (!stocks.Any())
            {
                Console.WriteLine("No products registered!");
                return;
            }

            Console.WriteLine("\n========== PRODUCT LIST ==========");
            for (int i = 0; i < stocks.Count; i++)
            {
                Console.WriteLine($"\n[{i + 1}]");
                Console.WriteLine(stocks[i]);
                Console.WriteLine("----------------------------------");
            }

            // Show total stock value across all products
            decimal total = stocks.OfType<Store>().Sum(s => s.TotalValue);
            Console.WriteLine($"\nTotal inventory value: R${total:F2}");
            Console.WriteLine("==================================");
        }

        // Replaces the stock quantity of a product at the given 1-based index
        public void UpdateStock(int index, int quantity)
        {
            // Convert from 1-based (user input) to 0-based (list index)
            int realIndex = index - 1;

            if (realIndex < 0 || realIndex >= stocks.Count)
            {
                Console.WriteLine("Invalid index! Please enter a number shown in the product list.");
                return;
            }

            stocks[realIndex].UpdateStock(quantity);
            Console.WriteLine($"Stock for '{stocks[realIndex].Product}' updated to {quantity} unit(s).");
        }

        // Adds more units to the stock of a product at the given 1-based index
        public void AddToStock(int index, int amount)
        {
            int realIndex = index - 1;

            if (realIndex < 0 || realIndex >= stocks.Count)
            {
                Console.WriteLine("Invalid index! Please enter a number shown in the product list.");
                return;
            }

            stocks[realIndex].AddToStock(amount);
            Console.WriteLine($"{amount} unit(s) added to '{stocks[realIndex].Product}'. New stock: {stocks[realIndex].Quantity}.");
        }

        // Removes a product from the list at the given 1-based index
        public void RemoveProduct(int index)
        {
            int realIndex = index - 1;

            if (realIndex < 0 || realIndex >= stocks.Count)
            {
                Console.WriteLine("Invalid index! Please enter a number shown in the product list.");
                return;
            }

            string removedName = stocks[realIndex].Product;
            stocks.RemoveAt(realIndex);
            Console.WriteLine($"Product '{removedName}' removed successfully.");
        }

        // Returns the number of registered products
        public int Count => stocks.Count;
    }
}