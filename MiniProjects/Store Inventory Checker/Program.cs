using System;

namespace InventoryChecker
{
    class Program
    {
        // Array to store product data (name, quantity, price)
        static (string name, int quantity, float price)[] products = {
             ("Ketchup", 2, 15),
             ("Cheese", 1, 18.50f),
             ("Bread", 3, 1),
             ("Juice", 4, 4)
        };

        static void Main(string[] args)
        {
            // Calculate total inventory value
            float totalInventoryValue = CalculateTotalValue(products);

            // Display inventory summary
            Console.WriteLine("--- Store Inventory Summary ---");
            Console.WriteLine($"Total Inventory Value: {totalInventoryValue} SAR");

            // Show products with low stock
            PrintLowStockProducts(products);

            // Get product name from user
            Console.Write("\nEnter product name to search: ");
            string searchName = Console.ReadLine().ToLower();

            // Search for the product
            bool found = false;
            foreach (var product in products)
            {
                if (product.name.ToLower() == searchName)
                {
                    Console.WriteLine("\nSearch Result:");
                    Console.WriteLine($"Product: {product.name}");
                    Console.WriteLine($"Quantity: {product.quantity}");
                    Console.WriteLine($"Price: {product.price}");
                    found = true;
                    break;
                }
            }

            // Show message if product not found
            if (!found)
            {
                Console.WriteLine("\nProduct not found!");
            }

            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("End of Report");
        }

        // Method to calculate total inventory value
        static float CalculateTotalValue((string name, int quantity, float price)[] products)
        {
            float total = 0;

            foreach (var product in products)
            {
                total += product.quantity * product.price;
            }
            return total;
        }

        // Method to print products with low stock (less than 5)
        static void PrintLowStockProducts((string name, int quantity, float price)[] products)
        {
            Console.WriteLine("Products with low stock (<5):");

            foreach (var product in products)
            {
                if (product.quantity < 5)
                {
                    Console.WriteLine($"- {product.name,-10} Qty: {product.quantity}");
                }
            }
        }
    }
}