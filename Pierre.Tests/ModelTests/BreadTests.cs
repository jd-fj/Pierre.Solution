using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBreadOrder = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
    [TestMethod]
    public void
    GetQuantity_ReturnsQuantityOfBread_Int()
    {
      int quantity = 2;
      Bread newBreadOrder = new Bread(quantity);
      int result = newBreadOrder.Quantity;
      Assert.AreEqual(quantity, result);
    }
    [TestMethod]
      public void
      GetBreadCost_ReturnsCostOfBreadOrder_Int()
      {
        int quantity = 2;
        int expectedTotal = 10;
        Bread newBreadOrder = new Bread(quantity);
        int breadQuantity = newBreadOrder.Quantity;
        int breadCost = newBreadOrder.TotalCost;
        Assert.AreEqual(breadCost, expectedTotal);
      }
    [TestMethod]
      public void
      GetBreadSaleCost_ReturnsCostOfBreadOnSale_Int()
      {
        int quantity = 3;
        double expectedTotal = 10;
        Bread newBreadOrder = new Bread(quantity);
        double breadSaleCost = newBreadOrder.SaleCost;
        Console.WriteLine(breadSaleCost);
        Assert.AreEqual(breadSaleCost, expectedTotal);
      }
  }
}