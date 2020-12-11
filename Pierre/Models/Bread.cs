
namespace Pierre.Models
{
  public class Bread
  {
    public int Quantity { get; }
    public int TotalCost { get; }

    public Bread(int quantity)
    {
      Quantity = quantity;
      TotalCost = quantity * 5;
    }
  }
}