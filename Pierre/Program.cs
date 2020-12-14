using System;
using Pierre.Models;
using System.Collections.Generic;

class Program
{
  public static string[] breadMenu = { "Pita", "French" };
  public static string[] pastryMenu = { "Biscuits", "Croissants" };
  
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
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
    Console.WriteLine("Please select from our following bread items:");
    Console.WriteLine("--------Bread Menu:--------");
    foreach (string loaf in breadMenu)
    {
    Console.WriteLine("Pierre's: " + loaf + " bread");
    }
    Console.WriteLine("----------------");
    Console.WriteLine("What type of bread do you want? ");
    string breadSelection = Console.ReadLine();
    Console.WriteLine("Va bene! Pierre's " + breadSelection + " bread is the finest");
    Console.WriteLine("How many of these sweet baby " + breadSelection + " loaves do you want?");
    int breadQuant = int.Parse(Console.ReadLine());
    Bread breadOrder = new Bread(breadSelection, breadQuant);
    Console.WriteLine("you ordered " + breadOrder.Quantity + " of the " + breadOrder.BreadKind);
    Console.WriteLine("Total Bread Cost: " + breadOrder.TotalCost);
    Console.WriteLine("Sale Price: " + breadOrder.SaleCost);
    Console.WriteLine("Total Savings: " + (breadOrder.TotalCost - breadOrder.SaleCost));
    Console.WriteLine("Bread order recieved! Press ['enter'] to continue to our Pastry menu");
    Console.ReadLine();
    OrderPastry();
  }

  public static void OrderPastry()
  {
    Console.WriteLine("What type of pastry would you like? [enter 'N' to checkout]" );
    string pastryYesOrNo = Console.ReadLine().ToLower();
    if (pastryYesOrNo == "n")
    {
      // checkout 
    }
    else
    {
    Console.WriteLine("--------Pastry Menu--------");
    foreach (string pastry in pastryMenu)
    {
      Console.WriteLine("Pierre's: " + pastry + " pastry");
    }
    Console.WriteLine("----------------");
    string pastrySelection = Console.ReadLine();
    Console.WriteLine("How many of these little " + pastrySelection + " do you want?");
    int pastryQuant = int.Parse(Console.ReadLine());
    Pastry newPastryOrder = new Pastry(pastrySelection, pastryQuant);
    Console.WriteLine("Total Pastry Cost: " + newPastryOrder.TotalCost);
    Console.WriteLine("Sale Price: " + newPastryOrder.SaleCost);
    Console.WriteLine("Total Savings: " + (newPastryOrder.TotalCost - newPastryOrder.SaleCost));
    Console.WriteLine("All sales are USD");
    }
    CheckOut();
  }

  public static void CheckOut()
  {
    Console.WriteLine("Your Grand Total is : "  );
    Console.WriteLine(" Thank You! Please come again.");
    Console.WriteLine("----------------");
    Console.WriteLine("----------------");
    Console.WriteLine("----------------");
    Console.WriteLine("----------------");
    Console.WriteLine("----------------");
    Console.WriteLine("Would you like to order more? ['Y' for yes, 'N' for no]");
    string goodBye = Console.ReadLine().ToLower();
    if (goodBye == "y")
    {
      Main();
    }
    else if (goodBye == "n")
    {

    }
    else
    {
      Console.WriteLine("Easter Egg");
    }

  }


} 

// I want the console to do things in this order:
// 1. Start screen lists breads and pastries
// 2. Ask what type and quantity of bread
// 3. Ask what type and quantity of pastry
// 4. Ask if they need to add anything else (if so run through main again)
// 5. Once the answer is "no" to needing anything else...
// 6. Print the grand total and what they ordered