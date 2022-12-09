using System.Collections.Generic;

//Consider setting order name to the same as ID.
namespace OrderTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string OrderDate { get; set; }
    public int Bread { get; set; }
    public int Pastry { get; set; }
    public int Price { get; set; }
        
    public Order(string orderDate)
    {
      OrderDate = orderDate;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}