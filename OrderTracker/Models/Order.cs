using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string OrderDate { get; set; }
    public int Bread { get; set; }
    public int Pastry { get; set; }
    public int Price { get; set; }
    
    
    public Order(string orderDate)
    {
      OrderDate = orderDate;
    }
  }
}