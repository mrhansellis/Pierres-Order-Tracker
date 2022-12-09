using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string VendorName { get; set; }
    
    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _instances.Add(this);
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}