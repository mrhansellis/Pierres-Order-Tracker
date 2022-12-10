using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_ReturnsOrderName_String()
    {
      //Arrange
      string name = "test name";
      Order newOrder = new Order(name);
      //Act
      string result = newOrder.OrderDate;
      //Assert
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void OrderConstructor_SetsOrderName_String()
    {
      //Arrange
      string name = "test name";
      Order newOrder = new Order(name);
      //Act
      string updatedName = "new test name";
      newOrder.OrderDate = updatedName;
      string result = newOrder.OrderDate;
      //Assert
      Assert.AreEqual(updatedName, result);
    }
    [TestMethod]
    public void SetProperty_SetPropertyOfBread_Int()
    {
      //Arrange
      string date = "12/01/2022";
      Order newOrder = new Order(date);
      //Act
      int breadAmount = 5;
      newOrder.Bread = breadAmount;
      int result = newOrder.Bread;
      //Assert
      Assert.AreEqual(breadAmount, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      {
      //Arrange
      string order01 = "12/01/2022";
      string order02 = "12/02/2022";
      Order newOrder1 = new Order(order01);
      Order newOrder2 = new Order(order02);
      //Act
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      Console.WriteLine(result);
      //Assert
      CollectionAssert.AreEqual(newList, result);
      }
    }
    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      {
      //Arrange
      string name = "12/01/2022";
      Order newOrder = new Order(name);
      //Act
      int result = newOrder.Id;
      //Assert
      Assert.AreEqual(1, result);
      }
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string name01 = "Hans";
      string name02 = "Paul";
      Order newOrder1 = new Order(name01);
      Order newOrder2 = new Order(name02);
      //Act
      Order result = Order.Find(2);
      //Assert
      Assert.AreEqual(newOrder2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor()
    {
      //Arrange
      string date = "12/01/2022";
      Order newOrder = new Order(date);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "Hans";
      Vendor newVendor = new Vendor(vendorName);
      newVendor.AddOrder(newOrder);
      //Act
      List<Order> result = newVendor.Orders;
      //Arrange
      CollectionAssert.AreEqual(newList, result);

    }
  }
}