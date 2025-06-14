using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStock
{
    internal class ProductList
    {
        private List<Stock> stocks = new List<Stock>(); // Stores multiple values of the same type
        public void AddProduct(Stock stock)
        {
            stocks.Add(stock);
            Console.WriteLine("Product added successfully!");
        }
        public void ListProducts()
        {
            if (!stocks.Any())
            {
                Console.WriteLine("No stock registered!");
                return;
            }
            for (int i = 0; i < stocks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {stocks[i]}");
            }

    }
        public void UpdateStock(int index, int quantity)
        {
            if (index < 0 || index >= stocks.Count)
            {
                Console.WriteLine("Invalid index!");
                return;
            }
            stocks[index].UpdateStock(quantity);
            Console.WriteLine("Stock updated successfully!");
        }
        {
            if (index >= 0 && index < stocks.Count)
            {
                stocks[index].UpdateStock(quantity);
                Console.WriteLine("Stock updated successfully!");
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }

    }
}
