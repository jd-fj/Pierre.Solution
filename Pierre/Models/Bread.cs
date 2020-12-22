using System;
using System.Collections.Generic;

namespace Pierre.Models
{
  public class Bread
  {
    public string BreadKind { get; set; }
    public int Quantity { get; }
    public int TotalCost { get; }
    public double SaleCost { get; }
    public int Price { get; set; }
    private static List<Bread> _breadOrder = new List<Bread> {};

    public Bread(string breadKind, int quantity)
    {
      BreadKind = breadKind;
      Quantity = quantity;
      TotalCost = quantity * 5;
      SaleCost = Math.Round(quantity * (3.33));
      _breadOrder.Add(this);
      Price = 0;
    }

    public static List<Bread> GetAll()
    {
      return _breadOrder;
    }

    public static void ClearAll()
    {
      _breadOrder.Clear();
    }
    
    public int GetSaleCost()
    {
      if (Quantity <= 2)
      {
        int cost = (Quantity * 5);
        return cost;
      }
      else
      {
        int cost = (((Quantity / 3) * 10) + ((Quantity % 3) * 5));
        return cost;
      }
    }
  }
}
// if they are buying more than one bread, then they'll activate the discount

// (totalItems/3)*2+ totalItems%3

// the quotient of dividing the number of dvds by three is the exact number of times they have activated the "buy one get one free" deal.

// % is not quotient, it is modulus