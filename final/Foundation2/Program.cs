using System;
using Foundation2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        List<Order> orderList =  new List<Order>();
        orderList.Add(new Order());
        orderList[0].CreateDemoCustomer(0);
        orderList[0].CreateDemoProducts(0); 
        Console.WriteLine();
        Console.WriteLine("Order 1");
        Console.WriteLine($"Shipping Label:\n{orderList[0].GetShippingLabel()}");
        Console.WriteLine($"Total Order Cost: ${orderList[0].GetTotalCost()}");
        Console.WriteLine($"Packing Label:\n{orderList[0].GetPackingLabel()}");      
        orderList.Add(new Order());
        orderList[1].CreateDemoCustomer(1);
        orderList[1].CreateDemoProducts(1);
        Console.WriteLine();
        Console.WriteLine("Order 2");
        Console.WriteLine($"Shipping Label:\n{orderList[1].GetShippingLabel()}");
        Console.WriteLine($"Total Order Cost: ${orderList[1].GetTotalCost()}");
        Console.WriteLine($"Packing Label:\n{orderList[1].GetPackingLabel()}");
        Console.WriteLine();
    }
}