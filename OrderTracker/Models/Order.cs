using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string OrderDate { get; set; }
    public Order(string orderDate)
    {
      OrderDate = orderDate;
    }
  }
}