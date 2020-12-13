using System;

namespace Pierre.Models
{
  public class Bread
  {
    public string BreadKind { get; set; }
    public int Quantity { get; }
    public int TotalCost { get; }
    public double SaleCost { get; }

    public Bread(string breadKind, int quantity)
    {
      BreadKind = breadKind;
      Quantity = quantity;
      TotalCost = quantity * 5;
      SaleCost = Math.Round(quantity * (3.33));
    }
  }
}