using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;


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
        Assert.AreEqual(breadSaleCost, expectedTotal);
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
  }
}