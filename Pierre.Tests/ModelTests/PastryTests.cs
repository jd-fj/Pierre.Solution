// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Pierre.Models;
// using System;
// using System.Collections.Generic;

// namespace Pierre.Tests
// {
//   [TestClass]
//   public class PastryTests : IDisposable
//   {
//     public void Dispose()
//     {
//       Pastry.ClearAll();
//     }

//     [TestMethod]
//     public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
//     {
//       Pastry newPastryOrder = new Pastry("biscuit", 2);
//       Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
//     }
//     [TestMethod]
//     public void
//     GetQuantity_ReturnsQuantityOfPastry_Int()
//     {
//       int quantity = 2;
//       Pastry newPastryOrder = new Pastry("biscuit", quantity);
//       int result = newPastryOrder.Quantity;
//       Assert.AreEqual(quantity, result);
//     }
//     [TestMethod]
//     public void 
//     GetPastryCost_ReturnsCostOfPastryOrder_Int()
//     {
//       int quantity = 2;
//       int expectedTotal = 4;
//       Pastry newPastryOrder = new Pastry("biscuit", quantity);
//       int pastryQuantity = newPastryOrder.Quantity;
//       int pastryCost = newPastryOrder.TotalCost;
//       Assert.AreEqual(pastryCost, expectedTotal);
//     }
//     [TestMethod]
//     public void 
//     GetPastrySaleCost_ReturnsSaleCostOfPastryOrder_Int()
//     {
//       int quantity = 3;
//       int expectedTotal = 5;
//       Pastry newPastryOrder = new Pastry("biscuit", quantity);
//       double pastrySaleCost = newPastryOrder.SaleCost;
//       Assert.AreEqual(pastrySaleCost, expectedTotal);
//     }
//     [TestMethod]
//     public void
//     GetPastryType_ReturnsTypeOfPastry_Str()
//     {
//       Pastry newPastry = new Pastry("biscuit", 2);
//       string pastryType = newPastry.PastryKind;
//       Assert.AreEqual(pastryType, "biscuit");
//     }
//     [TestMethod]
//     public void
//     SetPastryType_SetsTypeOfPastry_Str()
//     {
//       Pastry newPastry = new Pastry("biscuit", 2);
//       newPastry.PastryKind = "croissant";
//       string pastryType = newPastry.PastryKind;
//       Assert.AreEqual(pastryType, "croissant");
//     }
//     [TestMethod]
//     public void
//     GetAll_ReturnsEmptyPastryList_EmptyPastryList()
//     {
//       List<Pastry> newPastryList = new List<Pastry> { };
//       List<Pastry> result = Pastry.GetAll();
//       CollectionAssert.AreEqual(newPastryList, result);
//     }
//     [TestMethod]
//     public void
//     GetAll_ReturnsPastryList_PastryList()
//     {
//       string pastryType1 = "biscuit";
//       string pastryType2 = "croissant";
//       Pastry pastry1 = new Pastry(pastryType1, 2);
//       Pastry pastry2 = new Pastry(pastryType2, 2);
//       List<Pastry> newPastryList = new List<Pastry> { pastry1, pastry2 };
//       List<Pastry> result = Pastry.GetAll();
//       List<Pastry> falsePastryList = new List<Pastry> { pastry1, };
//       CollectionAssert.AreEqual(newPastryList, result);
//     }
//   }
// }