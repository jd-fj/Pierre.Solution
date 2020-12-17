using System;
using System.Collections.Generic;

namespace Pierre.Models
{
  public class Bread : Animal
  {
    public string BreadKind { get; set; }
    public int Quantity { get; }
    public int TotalCost { get; }
    public double SaleCost { get; }
    private static List<Bread> _breadOrder = new List<Bread> {};

    public Bread(string breadKind, int quantity)
    {
      BreadKind = breadKind;
      Quantity = quantity;
      TotalCost = quantity * 5;
      SaleCost = Math.Round(quantity * (3.33));
      _breadOrder.Add(this);
    }

    public static List<Bread> GetAll()
    {
      return _breadOrder;
    }

    public static void ClearAll()
    {
      _breadOrder.Clear();
    }

  }
}