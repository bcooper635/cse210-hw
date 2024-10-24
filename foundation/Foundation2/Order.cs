using Microsoft.VisualBasic;

public class Order
{
    public List<Product> Products;
    public Customer Customer;
    string _name;
    public Order(string name, string street,string city, string state,string country)
    {
        Products = new List<Product>();
        Customer = new(name, street, city,state,country);
        _name = name;
    }
    public double TotalCost()
    {
        double _total = 0;
        foreach(var product in Products)
        {
            _total = _total+product.TotalCost();
        }
        
        if (Customer.USACheck())
        return _total+5;
        else
        return _total+35;
    }

    public string PackingLabel()
    {
        string packinglabel = "";
        foreach(var product in Products)
        {
            packinglabel = packinglabel+product.PackingLabel();
        }
        return packinglabel;
    }

    public string ShippingLabel()
    {
        return "\n"+_name+Customer.RetrieveAddress();
    }

    public void AddProduct(string name, int id, double price, int quantity)
    {
        Product Product1 = new(name,id,price,quantity);
        Products.Add(Product1);
    }

    



}