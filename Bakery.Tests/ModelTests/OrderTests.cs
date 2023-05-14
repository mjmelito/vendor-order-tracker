using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
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
        Order newOrder = new Order("test Order");
        Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
     public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
  {
    //Arrange
    string description = "Walk the dog.";
    Order newOrder = new Order(description);

    //Act
    int result = newOrder.Id;

    //Assert
    Assert.AreEqual(1, result);
  }
  }
}