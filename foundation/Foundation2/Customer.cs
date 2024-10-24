using System.Data;

public class Customer
{
    private string _name;
    public Address Address;

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        Address = new(street,city,state,country);
    }
    public bool USACheck()
    {
        return Address.USACheck();
    }
    public string RetrieveAddress()
    {
        return Address.ReturnAddress();
    }

}