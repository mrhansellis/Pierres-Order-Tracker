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
  }
}