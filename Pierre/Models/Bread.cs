using System;

namespace Pierre.Models
{
  public class Bread
  {
    public int Quantity { get; }
    public int TotalCost { get; }
    public double SaleCost { get; }

    public Bread(int quantity)
    {
      Quantity = quantity;
      TotalCost = quantity * 5;
      SaleCost = Math.Round(quantity * (3.33));
    }
  }

  public class Pastry
  {
    public int Quantity { get; }
    public int TotalCost { get; }

    public Pastry(int quantity)
    {
      Quantity = quantity;
      TotalCost = quantity * 2;
    }
  }
}