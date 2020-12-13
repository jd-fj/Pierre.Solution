using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System;
using System.Collections.Generic;

namespace Pierre.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {

    public void Dispose()
    {
      Bread.ClearAll();
    }

      [TestMethod]
      public void BreadConstructor_CreatesInstanceOfBread_Bread()
      {
        Bread newBreadOrder = new Bread("pita", 2);
        Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
      }
      [TestMethod]
      public void
      GetQuantity_ReturnsQuantityOfBread_Int()
      {
        int quantity = 2;
        Bread newBreadOrder = new Bread("pita", quantity);
        int result = newBreadOrder.Quantity;
        Assert.AreEqual(quantity, result);
      }
      [TestMethod]
      public void
      GetBreadCost_ReturnsCostOfBreadOrder_Int()
      {
        int quantity = 2;
        int expectedTotal = 10;
        Bread newBreadOrder = new Bread("pita", quantity);
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
        Bread newBreadOrder = new Bread("pita", quantity);
        double breadSaleCost = newBreadOrder.SaleCost;
        Assert.AreEqual(breadSaleCost, expectedTotal);
      }
      [TestMethod]
      public void
      GetBreadType_ReturnsTypeOfBread_Str()
      {
        Bread newBreadOrder = new Bread("pita", 2);
        string breadType = newBreadOrder.BreadKind;
        Assert.AreEqual(breadType, "pita");
      }
      [TestMethod]
      public void
      SetBreadType_SetsTypeOfBread_Str()
      {
        Bread newBreadOrder = new Bread("french", 2);
        newBreadOrder.BreadKind = "pita";
        string breadType = newBreadOrder.BreadKind;
        Assert.AreEqual(breadType, "pita");
      }
      [TestMethod]
      public void
      GetAll_ReturnsEmptyList_EmptyBreadList()
      {
        List<Bread> newBreadOrder = new List<Bread> { };
        List<Bread> result = Bread.GetAll();
        CollectionAssert.AreEqual(newBreadOrder, result);
      }
      [TestMethod]
      public void
      GetAll_ReturnsBread_BreadList()
      {
        string breadKind = "french";
        string breadKind2 = "pita";
        Bread loaf1 = new Bread(breadKind, 2);
        Bread loaf2 = new Bread(breadKind2, 3);
        List<Bread> newBreadList = new List<Bread> { loaf1, loaf2 };
        List<Bread> result = Bread.GetAll();
        CollectionAssert.AreEqual(newBreadList, result);
      }
    }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastryOrder = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }
    [TestMethod]
    public void
    GetQuantity_ReturnsQuantityOfPastry_Int()
    {
      int quantity = 2;
      Pastry newPastryOrder = new Pastry(quantity);
      int result = newPastryOrder.Quantity;
      Assert.AreEqual(quantity, result);
    }
    [TestMethod]
    public void 
    GetPastryCost_ReturnsCostOfPastryOrder_Int()
    {
      int quantity = 2;
      int expectedTotal = 4;
      Pastry newPastryOrder = new Pastry(quantity);
      int pastryQuantity = newPastryOrder.Quantity;
      int pastryCost = newPastryOrder.TotalCost;
      Assert.AreEqual(pastryCost, expectedTotal);
    }
    [TestMethod]
    public void 
    GetPastrySaleCost_ReturnsSaleCostOfPastryOrder_Int()
    {
      int quantity = 3;
      int expectedTotal = 5;
      Pastry newPastryOrder = new Pastry(quantity);
      double pastrySaleCost = newPastryOrder.SaleCost;
      Assert.AreEqual(pastrySaleCost, expectedTotal);
    }
  }
}