using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PRODUCT ORDERS SUMMARY: \n\n");
        Console.WriteLine("Order 1\n---------------------------------");
        Order order1 = new("Blake Cooper","235 W Street","Rexburg","ID","USA");
        order1.AddProduct("Eggs", 3231, 4.00, 2);
        order1.AddProduct("Milk",493243,1.99,1);

        Console.WriteLine("Total Price: "+"\n"+order1.TotalCost()+"\n---------------------------------");
        Console.WriteLine("Shipping Label: "+order1.ShippingLabel());
        Console.WriteLine("Packing Label: "+order1.PackingLabel()+"\n---------------------------------");

        Console.WriteLine("\n\nOrder 2\n---------------------------------");
        Order order2 = new("Jean Paul","Av. Gustave Eiffel","Paris","N/A","France");
        order2.AddProduct("Iphone 8s", 10294, 500.00, 1);
        order2.AddProduct("Apple Charging Cable", 12032,6.99,1);
        order2.AddProduct("Outlet Adaptor USA-EU", 293842, 4.99,1);

        Console.WriteLine("Total Price: "+"\n"+order2.TotalCost()+"\n---------------------------------");
        Console.WriteLine("Shipping Label: "+order2.ShippingLabel());
        Console.WriteLine("Packing Label: "+order2.PackingLabel()+"\n---------------------------------");
   
    }
}