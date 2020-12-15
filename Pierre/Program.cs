using System;
using Pierre.Models;
using System.Collections.Generic;

namespace Pierre
{
  class Program
  {
    public static string[] breadMenu = { "Pita", "French" };
    public static string[] pastryMenu = { "Biscuits", "Croissants" };

    public static void Main()
    {
      Console.WriteLine("Would you like to order some of our fine Breads? ['Y' for yes, 'N' to check out the pastries]");
      string breadYesOrNo = Console.ReadLine().ToLower();
      if (breadYesOrNo == "y")
      {
        OrderBread();
      }
      else
      {
        OrderPastry();
      }
    }

    public static void OrderBread()
    {
      Console.WriteLine("--------Bread Menu:--------");
      foreach (string loaf in breadMenu)
      {
      Console.WriteLine("Pierre's: " + loaf + " bread");
      }
      Console.WriteLine();
      Console.WriteLine("What type of bread do you want?");
      string breadSelection = Console.ReadLine();
      Console.WriteLine("Va bene! Pierre's " + breadSelection + " bread is the finest");
      Console.WriteLine("How many of these sweet baby " + breadSelection + " loaves do you want?");
      int breadQuant = int.Parse(Console.ReadLine());
      Bread breadOrder = new Bread(breadSelection, breadQuant);
      Console.WriteLine("You ordered " + breadOrder.Quantity + " of the " + breadOrder.BreadKind + " loaves");
      // potentially loop back to top of OrderBread() here?
      Console.WriteLine("Total Bread Cost: " + breadOrder.TotalCost);
      Console.WriteLine("Sale Price: " + breadOrder.SaleCost);
      Console.WriteLine("Total Savings: " + (breadOrder.TotalCost - breadOrder.SaleCost));
      Console.WriteLine("Bread order recieved! Press ['enter'] to continue to our Pastry menu");
      Console.ReadLine();
      OrderPastry();
    }

    public static void OrderPastry()
    {
      Console.WriteLine("Would you like to order a pastry? ['Y' for yes, 'N' to checkout]");
      string pastryYesOrNo = Console.ReadLine().ToLower();
      if (pastryYesOrNo == "n")
      {
        CheckOut(); 
      }
      if (pastryYesOrNo == "y")
      {
      Console.WriteLine("--------:Pastry Menu:--------");
      foreach (string pastry in pastryMenu)
      {
        Console.WriteLine("Pierre's: " + pastry + " pastry");
      }
      Console.WriteLine();
      Console.WriteLine("What type of pastry do you want?");
      string pastrySelection = Console.ReadLine();
      Console.WriteLine("How many of these little " + pastrySelection + " do you want?");
      int pastryQuant = int.Parse(Console.ReadLine());
      Pastry newPastryOrder = new Pastry(pastrySelection, pastryQuant);
      // potentially add loop to go back to OrderPastry for more?
      Console.WriteLine("Total Pastry Cost: " + newPastryOrder.TotalCost);
      Console.WriteLine("Sale Price: " + newPastryOrder.SaleCost);
      Console.WriteLine("Total Savings: " + (newPastryOrder.TotalCost - newPastryOrder.SaleCost));
      }
      CheckOut();
    }

    public static void CheckOut()
    {
      // Console.WriteLine("Would you like to order more? ['Y' for yes, 'N' for no]");
      // string goodBye = Console.ReadLine().ToLower();
      
      // if (goodBye == "y")
      // {
      //   Main();
      // }
      // else if (goodBye == "n")
      // {
        double breadTotal = 0;
        List<Bread> breadBasket = Bread.GetAll();
        foreach (Bread loaf in breadBasket)
        {
          breadTotal =+ loaf.SaleCost;
          Console.WriteLine("write this once");
        }
        // Console.WriteLine("Your Bread Total is: $" + breadTotal);
      // }
      // else
      // {
      //   Console.WriteLine("Easter Egg");
      // }

    }
  }
}