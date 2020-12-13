using System;
using System.Collections.Generic;

namespace Pierre.Models
{
  public class Pastry
  {
    public string PastryKind { get; set; }
    public int Quantity { get; }
    public int TotalCost { get; }
    public double SaleCost { get; }
    private static List<Pastry> _pastryOrder = new List<Pastry> {};


    public Pastry(string pastryKind, int quantity)
    {
      PastryKind = pastryKind;
      Quantity = quantity;
      TotalCost = quantity * 2;
      SaleCost = Math.Round(quantity * (1.66));
      _pastryOrder.Add(this);
    }

    public static List<Pastry> GetAll()
    {
      return _pastryOrder;
    }

    public static void ClearAll()
    {
      _pastryOrder.Clear();
    }
  }
}