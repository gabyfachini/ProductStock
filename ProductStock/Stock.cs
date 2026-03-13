using System;
using System.Collections.Generic;

namespace ProductStock
{
    // Abstract base class representing a generic stock item
    public abstract class Stock
    {
        public Stock(string product, string supplier, string category, int quantity, decimal price)
        {
            Product = product;
            Supplier = supplier;
            Category = category;
            Quantity = quantity;
            Price = price;
        }

        public string Product { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; } // Unit price of the product

        // Abstract methods to be implemented by derived classes
        public abstract void AddProducts();
        public abstract void UpdateStock(int amount);
        public abstract void AddToStock(int amount); // Adds more units to existing stock
    }

    // Concrete implementation of Stock representing a store product
    public class Store : Stock
    {
        public Store(string product, string supplier, string category, int quantity, decimal price)
            : base(product, supplier, category, quantity, price)
        {
        }

        // Confirms product was added to stock
        public override void AddProducts()
        {
            Console.WriteLine($"Product '{Product}' added to stock.");
        }

        // Replaces current stock quantity with a new value
        public override void UpdateStock(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Quantity cannot be negative.");
                return;
            }
            Quantity = amount;
        }

        // Increments the current stock quantity
        public override void AddToStock(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount to add must be greater than zero.");
                return;
            }
            Quantity += amount;
        }

        // Returns the total stock value for this product
        public decimal TotalValue => Quantity * Price;

        public override string ToString()
        {
            return $"  Product  : {Product}\n" +
                   $"  Supplier : {Supplier}\n" +
                   $"  Category : {Category}\n" +
                   $"  Stock    : {Quantity} unit(s)\n" +
                   $"  Price    : R${Price:F2}\n" +
                   $"  Total    : R${TotalValue:F2}";
        }
    }
}