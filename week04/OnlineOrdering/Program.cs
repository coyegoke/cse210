using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Method to create addresses (USA and Non USA)
        Address usaAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address nonUsaAddress = new Address("Road 12", "House 28, O.A.U, Ife", "Osun State", "Nigeria");

        // Method to create customers (USA and Non USA)
        Customer usaCustomer = new Customer("Joseph Miller", usaAddress);
        Customer nonUsaCustomer = new Customer("Oyegoke Cornelius", nonUsaAddress);

        // Method to create the products
        Product product1 = new Product("Laptop", 100, 1200.0, 1);
        Product product2 = new Product("Wireless-Mouse", 111, 500.0, 1);
        Product product3 = new Product("External Bluetooth", 200, 800.0, 1);
        Product product4 = new Product("Laptop Charger", 222, 3000.0, 1);
        Product product5 = new Product("Notepad", 300, 500.0, 2);

        // Method to create the orders
        Order order1 = new Order(usaCustomer, new List<Product> { product1, product2, });
        Order order2 = new Order(nonUsaCustomer, new List<Product> { product3, product4, product5 });

        // Method to display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}