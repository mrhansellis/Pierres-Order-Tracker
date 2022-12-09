using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorConstructor_ReturnsVendorName_String()
    {
      //Arrange
      string name = "test name";
      Vendor newVendor = new Vendor(name);
      //Act
      string result = newVendor.VendorName;
      //Assert
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void VendorClass_SetVendorName_String()
    {
      //Arrange
      string name = "test name";
      Vendor newVendor = new Vendor(name);
      //Act
      string updatedName = "new test name";
      newVendor.VendorName = updatedName;
      string result = newVendor.VendorName;
      //Assert
      Assert.AreEqual(updatedName, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string vendor01 = "Hans";
      string vendor02 = "Paul";
      Vendor newVendor1 = new Vendor(vendor01);
      Vendor newVendor2 = new Vendor(vendor02);
      //Act
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      Console.WriteLine(result);
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "hans";
      Vendor newVendor = new Vendor(name);
      //Act
      int result = newVendor.Id;
      //Assert
      Assert.AreEqual(1, result);
    }
  }
}