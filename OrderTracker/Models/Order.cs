using System.Collections.Generic;

//Consider setting order name to the same as ID.
namespace OrderTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string OrderDate { get; set; }
    public int Flour { get; set; }
    public int Butter { get; set; }
    public int Price { get; set; }
    public int Id { get; }
        
    public Order(string orderDate)
    {
      OrderDate = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}