using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
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
  }
}