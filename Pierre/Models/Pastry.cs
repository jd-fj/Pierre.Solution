using System;

namespace Pierre.Models
{
  public class Pastry
  {
    public string PastryKind { get; }
    public int Quantity { get; }
    public int TotalCost { get; }
    public double SaleCost { get; }

    public Pastry(string pastryKind, int quantity)
    {
      PastryKind = pastryKind;
      Quantity = quantity;
      TotalCost = quantity * 2;
      SaleCost = Math.Round(quantity * (1.66));
    }
  }
}