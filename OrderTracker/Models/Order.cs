using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string OrderDate { get; }
    public Order(string orderDate)
    {
      OrderDate = orderDate;
    }
  }
}