using System;

namespace Pierre.Models
{
  public class Pastry
  {
    public int Quantity { get; }
    public int TotalCost { get; }
    public double SaleCost { get; }

    public Pastry(int quantity)
    {
      Quantity = quantity;
      TotalCost = quantity * 2;
      SaleCost = Math.Round(quantity * (1.66));
    }
  }
}