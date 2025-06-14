using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStock
{
    public abstract class Stock
    {
        public Stock(string product,string supplier,string category,int quantity)
        {
            Product = product;
            Supplier = supplier;
            Category = category;
            Quantity = quantity;
        }
        public string Product { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public abstract void AddProducts();
        public abstract void UpdateStock(int amount);
        /*
        public void RemoveQuantity(int amount)
        {
            if (Quantity > 0)
            {
                Quantity -= amount;
            }
            else
            {
                Console.WriteLine("Stock is empty!");
            }
        }
        */
    }
    public class Store : Stock
    {
        public Store(string product, string supplier, string category, int quantity)
            : base(product, supplier, category, quantity) // Calls the constructor of the base class
        {
        }

        public override void AddProducts()
        {
            Console.WriteLine($"Product {Product} added to stock.");
        }

        public override void UpdateStock(int amount)
        {
            Quantity = amount;
        }

        public override string ToString()
        {
            return $"Product: {Product} from Supplier {Supplier} and Category {Category} with {Quantity} quantity(ies).";
        }
    }
     /*
    public class AddStock : Stock
    {
        public AddStock(int quantity) : base(quantity) 
        {

        }

        public override string ToString()
        {
            return $"{Quantity} unit(s) added to {Product} in Category {Category}.";
        }
    }
    */
}
